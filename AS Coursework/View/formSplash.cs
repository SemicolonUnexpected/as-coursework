using AS_Coursework._Helpers;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_Coursework {
    public partial class formSplash : Form {

        const int FRAME_DELAY = 1;
        public formSplash() {
            InitializeComponent();
            OnResize(EventArgs.Empty);
        }

        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            pb.CenterX();
            lblQuizTitle.CenterX();
        }

        public async Task SimulateLoading(int duration = 1000) {
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();

            while (stopwatch.ElapsedMilliseconds < duration) {
                pb.Progress = (float)stopwatch.ElapsedMilliseconds / duration;
                await Task.Delay(FRAME_DELAY);
            }

            stopwatch.Stop();
        }
    }
}
