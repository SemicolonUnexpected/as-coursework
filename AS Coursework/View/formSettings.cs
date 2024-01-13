using AS_Coursework.Model.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_Coursework.View {
    public partial class formSettings : Form {
        User _user;
        public formSettings(User user) {
            InitializeComponent();

            _user = user;

            PopulateData();
        }

        private void PopulateData() {

        }

        private void customRectangle2_Click(object sender, EventArgs e) {

        }

        private void label8_Click(object sender, EventArgs e) {

        }
    }
}
