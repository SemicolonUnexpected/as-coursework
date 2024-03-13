using AS_Coursework._Helpers;
using System.Diagnostics;

namespace AS_Coursework;

public partial class formSplash : Form {

    const int FRAME_DELAY = 1;
    public formSplash() {
        InitializeComponent();
        OnResize(EventArgs.Empty);
    }

    // Reformat the splash screen whenever it resizes
    protected override void OnResize(EventArgs e) {
        base.OnResize(e);
        pb.CenterX();
        lblQuizTitle.CenterX();
    }

    // Load for the time in milliseconds
    public async Task SimulateLoading(int duration = 5000) {
        // Create the stopwatch and start it
        Stopwatch stopwatch = Stopwatch.StartNew();
        stopwatch.Start();

        // Update the progress bar asynchronously to prevent the application freezing until the time has elapsed
        while (stopwatch.ElapsedMilliseconds < duration) {
            pb.Progress = (float)stopwatch.ElapsedMilliseconds / duration;
            await Task.Delay(FRAME_DELAY);
        }

        stopwatch.Stop();
    }
}
