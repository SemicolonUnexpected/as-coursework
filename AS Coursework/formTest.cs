using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_Coursework {
    public partial class formTest : Form {
        public formTest() {
            InitializeComponent();
        }

        private void customScrollBar1_Click(object sender, EventArgs e) {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e) {
            Debug.WriteLine("Scroll event");
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e) {
        }

        private void lblUsername_Click(object sender, EventArgs e) {
            // Debug.WriteLine(customScrollBar1.Value.ToString());
        }

        protected override void OnMouseMove(MouseEventArgs e) {
            base.OnMouseMove(e);

            lblUsername.Text = PointToClient(MousePosition).ToString();
        }

        private void customScrollBar1_ValueChanged(object sender, EventArgs e) {
        }

        private void customScrollBar1_Scroll(object sender, EventArgs e) {
        }

        private void customScrollBar2_Scroll(object sender, EventArgs e) {
            Debug.WriteLine("Scroll");

        }

        private void customScrollBar2_ValueChanged(object sender, EventArgs e) {
            Debug.WriteLine("Value chnaged event : " + customScrollBar2.Value);

        }
    }
}
