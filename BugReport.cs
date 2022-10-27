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
using System.Diagnostics;
using System.Management;
using System.Dynamic;
using System.IO;
using System.Collections;
using System.Configuration;
using System.Net;
using System.Threading;

namespace Flow_Bugger {
    public partial class BugReport : Form {
        public static BugReport instance;
        public BugReport() {
            InitializeComponent();
            instance = this;

        }

        private void BugReport_Load(object sender, EventArgs e) {
            this.CenterToScreen();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e) {
            string[] lines = this.guna2TextBox2.Text.Split(new Char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries); int count = lines.Length;
            int totalLines = lines.Length;
            if (totalLines >= 16) {
                guna2TextBox2.ScrollBars = ScrollBars.Vertical;
            } else {
                guna2TextBox2.ScrollBars = ScrollBars.None;
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        int curr = 0;
        private void guna2Button2_Click(object sender, EventArgs e) {
            curr++;
            var form = Form1.instance;
            var flowlayout = form.flowLayoutPanel1;
            var lab1 = form.label1;
            var lab8 = form.label8;
            var but6 = form.guna2Button6;

            lab1.Visible = false;
            lab8.Visible = false;
            but6.Visible = false;

            int top = 275;
            int h_p = 100;
            var repPanel = new Guna2Panel() {
                Name = "Pan" + curr,
                Width = 260,
                Height = 222,
                BorderRadius = 8,
                FillColor = ColorTranslator.FromHtml("#121212"),
                BackColor = Color.Transparent,
                Location = new Point(600, top)
            };
            top += h_p;
            flowlayout.Controls.Add(repPanel);
            
            var getPanel = ((Guna2Panel)flowlayout.Controls["Pan" + curr]);
            var getTitle = guna2TextBox1.Text;

            Label titleLab = new Label();
            getPanel.Controls.Add(titleLab);
            titleLab.Name = "Ttl" + curr;
            titleLab.BackColor = ColorTranslator.FromHtml("#121212");
            titleLab.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            titleLab.ForeColor = Color.White;
            titleLab.Location = new Point(10,12);
            titleLab.Text = getTitle;
            titleLab.Width = 500;
            titleLab.Visible = true;
            titleLab.Enabled = true;


        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void guna2Button3_Click(object sender, EventArgs e) {

        }

        private void guna2Button4_Click(object sender, EventArgs e) {

        }

        private void guna2Button5_Click(object sender, EventArgs e) {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e) {

        }

        private void guna2Button8_Click(object sender, EventArgs e) {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e) {
        }

        private void guna2Button6_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void guna2Button13_Click(object sender, EventArgs e) {

        }
    }
}
