using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms.Design;

namespace AS_Coursework.Custom_Controls;
[Designer(typeof(ParentControlDesigner))]
public partial class CustomScrollBar : Control {

    #region Fields

    // Custom appearance fields
    private Brush _channelBrush = new SolidBrush(Color.White);
    private Brush _thumbBrush = new SolidBrush(Color.Gray);
    private Brush _borderBrush = new SolidBrush(Color.Black);
    private Rectangle _thumbRectangle;
    private Rectangle _channelRectangle;
    private Padding _channelPadding = new(0, 0, 0, 0);
    private int _borderWidth = 0;

    // Progress bar fields that are the same as the default windows scrollbar
    private int _value = 0;
    private int _maximum = 100;
    private int _minimum = 0;
    private int _mouseWheelSensitivity = 1;

    // Other fields
    private bool _isDragging = false;
    private int _grabY = 0;

    #endregion

    public CustomScrollBar() {
        DoubleBuffered = true;

        _thumbRectangle = new Rectangle(0, 0, 50, 50);
    }

    #region Properties

    [Category("_CustomScrollBar Appearance")]
    public Color ChannelColor {
        get => (_channelBrush as SolidBrush)!.Color;
        set {
            _channelBrush = new SolidBrush(value);
            Invalidate();
        }
    }

    [Browsable(false)]
    public Brush ChannelBrush {
        get => _channelBrush;
        set {
            _channelBrush = value;
            Invalidate();
        }
    }

    [Category("_CustomScrollBar Further Options")]
    public Padding ChannelPadding {
        get => _channelPadding;
        set {
            SetChannelRectangleToPadding(value);
            _channelPadding = value;
            Invalidate();
        }
    }

    private void SetChannelRectangleToPadding(Padding padding) {
        _channelRectangle.X = padding.Left;
        _channelRectangle.Y = padding.Top;
        _channelRectangle.Width = Width - padding.Horizontal;
        _channelRectangle.Height = Height - padding.Vertical;
    }

    [Category("_CustomScrollBar Appearance")]
    public Color ThumbColor {
        get => (_thumbBrush as SolidBrush)!.Color;
        set {
            _thumbBrush = new SolidBrush(value);
            Invalidate();
        }
    }

    [Browsable(false)]
    public Brush ThumbBrush {
        get => _thumbBrush;
        set {
            _thumbBrush = value;
            Invalidate();
        }
    }

    [Category("_CustomScrollBar Appearance")]
    public Size ThumbSize {
        get => _thumbRectangle.Size;
        set {
            _thumbRectangle.Size = value;
            Invalidate();
        }
    }

    [Category("_CustomScrollBar Appearance")]
    public int BorderWidth {
        get => _borderWidth;
        set {
            _borderWidth = value;
            Invalidate();
        }
    }

    [Category("_CustomScrollBar Appearance")]
    public Color BorderColor {
        get => (_borderBrush as SolidBrush)!.Color;
        set {
            _borderBrush = new SolidBrush(value);
            Invalidate();
        }
    }

    [Browsable(false)]
    public Brush BorderBrush {
        get => _borderBrush;
        set {
            _borderBrush = value;
            Invalidate();
        }
    }

    [Category("_CustomScrollBar Scroll")]
    public int Value {
        get => _value;
        set {
            value = Math.Clamp(value, Minimum, Maximum);
            _value = value;
            TrySetThumbHeight(value);
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    [Category("_CustomScrollBar Scroll")]
    public int Minimum {
        get => _minimum;
        set {
            if (DesignMode && Maximum <= value) return;
            else if (Maximum <= value) throw new ArgumentOutOfRangeException(nameof(value), "The minimum must be less than the maximum");

            _minimum = value;
            Invalidate();
        }
    }

    [Category("_CustomScrollBar Scroll")]
    public int Maximum {
        get => _maximum;
        set {
            if (DesignMode && Minimum >= value) return;
            else if (Minimum >= value) throw new ArgumentOutOfRangeException(nameof(value), "The maximum must be greater than the minimum");

            _maximum = value;
            Invalidate();
        }
    }

    [Category("_CustomScrollBar Scroll")]
    public int MouseWheelSensitivity {
        get => _mouseWheelSensitivity;
        set {
            // Ensure the mouse wheel sensitivity does not equal 0
            if (value == 0) return;
            _mouseWheelSensitivity = value;
        }
    }

    #endregion

    #region Events

    [Category("_CustomScrollBar")]
    public event EventHandler? Scroll;
    [Category("_CustomScrollBar")]
    public event EventHandler? ValueChanged;

    #endregion

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        // Resize the thumb rectangle to fit with the padding
        SetChannelRectangleToPadding(ChannelPadding);
        TrySetThumbHeight(Value);
    }

    protected override void OnPaint(PaintEventArgs e) {
        Graphics graphics = e.Graphics;

        // Draw the background
        graphics.FillRectangle(ChannelBrush, DisplayRectangle);

        // Draw the border
        using Pen borderPen = new(BorderColor, BorderWidth);
        graphics.DrawRectangle(borderPen, Rectangle.Inflate(DisplayRectangle, 1, 1));

        // Center the thumb
        _thumbRectangle.X = (Width - _thumbRectangle.Width) / 2;
        // Draw the thumb
        graphics.FillRectangle(ThumbBrush, _thumbRectangle);
    }

    protected override void OnMouseDown(MouseEventArgs e) {
        base.OnMouseDown(e);

        // Set the control to the dragging state if the mouse clicks in the channel
        Point mousePoint = e.Location;
        if (e.Button == MouseButtons.Left && _channelRectangle.Contains(mousePoint)) {
            // Set the grab point to the mouse Y position if it is on the thumb or the middle of the thumb if it is not
            _grabY = _thumbRectangle.Contains(mousePoint) ? mousePoint.Y - _thumbRectangle.Top : _thumbRectangle.Height / 2;
            Debug.WriteLine(_grabY);
            _isDragging = true;

            TrySetThumbHeight();
        }
    }

    protected override void OnMouseUp(MouseEventArgs e) {
        base.OnMouseUp(e);

        _isDragging = false;
    }

    protected override void OnMouseMove(MouseEventArgs e) {
        base.OnMouseMove(e);

        if (!_isDragging) return;

        TrySetThumbHeight();
    }

    protected override void OnMouseWheel(MouseEventArgs e) {
        base.OnMouseWheel(e);

        Value -= e.Delta * MouseWheelSensitivity;
        ValueChanged?.Invoke(this, EventArgs.Empty);
    }

    private void TrySetThumbHeight() {
        Scroll?.Invoke(this, EventArgs.Empty);

        // Scroll the thumb
        int thumbTop = _channelRectangle.Top;
        int thumbBottom = _channelRectangle.Bottom - _thumbRectangle.Height;

        int newPosition = Math.Clamp(PointToClient(MousePosition).Y - _grabY, thumbTop, thumbBottom);

        if (_thumbRectangle.Y != newPosition) {
            _thumbRectangle.Y = newPosition;
            Value = ThumbYToValue();
        }

        Refresh();
    }

    private void TrySetThumbHeight(int value) {
        int valueRange = Maximum - Minimum;
        float valueFraction = (float)(value - Minimum) / valueRange;

        int thumbRange = _channelRectangle.Height - _thumbRectangle.Height;
        int thumbChannelY = (int)(valueFraction * thumbRange);
        int thumbY = _channelRectangle.Y + thumbChannelY;

        _thumbRectangle.Y = thumbY;

        if (Value != value) {
            Value = ThumbYToValue();
        }

        Refresh();
    }

    private int ThumbYToValue() {
        int thumbRange = _channelRectangle.Height - _thumbRectangle.Height;
        int thumbChannelY = _thumbRectangle.Y - _channelRectangle.Y;
        float thumbFraction = (float)thumbChannelY / thumbRange;

        int valueRange = Maximum - Minimum;
        int value = Minimum + (int)(thumbFraction * valueRange);
        return value;
    }
}
