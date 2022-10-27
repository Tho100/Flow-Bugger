using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Flow_Bugger {
    public partial class remIsForm : Form {
        public static remIsForm instance;
        public remIsForm(int intPos, String titleLab) {
            InitializeComponent();
            instance = this;
            label1.Text = intPos.ToString();
            label2.Text = "Remove `" + titleLab + "` Issue?";
        }

        private void guna2Button8_Click(object sender, EventArgs e) {
            int toIntCurr = Convert.ToInt32(label1.Text);
            var getPanelPos = ((Guna2Panel)Form1.instance.flowLayoutPanel1.Controls["Pan" + toIntCurr]);
            getPanelPos.Dispose();
            this.Close();
        }

        private void remIsForm_Load(object sender, EventArgs e) {

        }

        private void guna2Button10_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
