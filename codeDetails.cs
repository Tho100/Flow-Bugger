using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow_Bugger {
    public partial class codeDetails : Form {
        public codeDetails(String titleIss, String descIss, String bugsDetsIss) {
            InitializeComponent();
            label1.Text = titleIss;
            guna2TextBox1.Text = bugsDetsIss;
            guna2TextBox2.Text = descIss;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e) {

        }

        private void codeDetails_Load(object sender, EventArgs e) {
            var countLinesDesc = guna2TextBox2.Lines.Length;
            var countLinesBugs = guna2TextBox1.Lines.Length;
            if(countLinesDesc >= 11) {
                guna2TextBox2.ScrollBars = ScrollBars.Vertical;
            }
            if(countLinesBugs >= 18) {
                guna2TextBox1.ScrollBars = ScrollBars.Vertical;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
