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

namespace Flow_Bugger {
    public partial class Form1 : Form {
        public static Form1 instance;
        public Form1() {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            instance = this;
        }

        private void Form1_Load(object sender, EventArgs e) {
            guna2Button2.ForeColor = ColorTranslator.FromHtml("#3498DB");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e) {

        }

        private void guna2Button6_Click(object sender, EventArgs e) {

        }

        private void guna2Button2_Click(object sender, EventArgs e) {
            guna2Button2.ForeColor = ColorTranslator.FromHtml("#3498DB");
            guna2Button1.ForeColor = Color.White;
        }

        private void guna2Button1_Click(object sender, EventArgs e) {
            guna2Button1.ForeColor = ColorTranslator.FromHtml("#3498DB");
            guna2Button2.ForeColor = Color.White;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void label8_Click(object sender, EventArgs e) {

        }

        private void guna2Button3_Click(object sender, EventArgs e) {
            try {
                //BugReport bReport = new BugReport();
                //bReport.Show();

                guna2Panel5.Visible = true;
                guna2TextBox1.Text = "";
                guna2TextBox2.Text = "";

                guna2Button6.Visible = false;
                label8.Visible = false;
                label1.Visible = false;

                pri1.Visible = false;
                pri2.Visible = false;
                pri3.Visible = false;
                pri4.Visible = false;

                sev1.Visible = false;
                sev2.Visible = false;
                sev3.Visible = false;
                sev4.Visible = false;
            }
            catch (Exception eq) {
                MessageBox.Show(eq.Message);
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e) {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e) {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e) {
            string[] lines = this.guna2TextBox2.Text.Split(new Char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries); int count = lines.Length;
            int totalLines = lines.Length;
            if (totalLines >= 11) {
                guna2TextBox2.ScrollBars = ScrollBars.Vertical;
            } else {
                guna2TextBox2.ScrollBars = ScrollBars.None;
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e) {
            guna2Panel5.Visible = false;
            if(flowLayoutPanel1.Controls.Count > 1) {
                guna2Button6.Visible = false;
                label8.Visible = false;
                label1.Visible = false;
            } else {
                guna2Button6.Visible = true;
                label8.Visible = true;
                label1.Visible = true;
            }
        }

        List<string> prioritySelected = new List<string>();
        List<string> severitySelected = new List<string>();
        String priButName;
        String sevButName;

        int curr = 0;
        int widthPan = 400;

        private void guna2Button8_Click(object sender, EventArgs e) {
            try {

                int lenSev = severitySelected.Count();
                int lenPri = prioritySelected.Count();

                if (lenSev > 0) {
                    if(lenPri > 0) {
                        guna2Panel5.Visible = false;
                        //if (guna2TextBox1.Text.Length >= 18) {
                        //    widthPan = ((260 + guna2TextBox1.Text.Length) * 2) - (guna2TextBox1.Text.Length + 95);
                        //}
                        curr++;
                        int top = 275;
                        int h_p = 100;
                        var repPanel = new Guna2Panel() {
                            Name = "Pan" + curr,
                            Width = widthPan,
                            Height = 210,
                            BorderRadius = 8,
                            FillColor = ColorTranslator.FromHtml("#121212"),
                            BackColor = Color.Transparent,
                            Location = new Point(600, top)
                        };
                        top += h_p;
                        flowLayoutPanel1.Controls.Add(repPanel);

                        var getPanel = ((Guna2Panel)flowLayoutPanel1.Controls["Pan" + curr]);
                        var getTitle = guna2TextBox1.Text;

                        Label titleLab = new Label();
                        getPanel.Controls.Add(titleLab);
                        titleLab.Name = "Ttl" + curr;
                        titleLab.BackColor = Color.Transparent;//ColorTranslator.FromHtml("#121212");
                        titleLab.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
                        titleLab.ForeColor = Color.White;
                        titleLab.Location = new Point(10, 10);
                        titleLab.Text = getTitle;
                        titleLab.MaximumSize = new Size(350,0);
                        titleLab.AutoSize = true;
                        titleLab.Visible = true;
                        titleLab.Enabled = true;

                        var checkTitleLength = (getTitle.Length >= 28 ? 56 : 35);
                        var setHeight = (checkTitleLength == 56 ? 81 : 120);

                        Label subLab = new Label();
                        getPanel.Controls.Add(subLab);
                        subLab.Name = "subLab" + curr;
                        subLab.Font = new Font("Segoe UI Semibold", 10, FontStyle.Regular);
                        subLab.ForeColor = Color.LightGray;
                        subLab.Location = new Point(12, checkTitleLength);//35
                        subLab.Text = guna2TextBox2.Text;
                        subLab.Width = widthPan - 13;
                        subLab.Height = setHeight;//120;
                        subLab.Visible = true;
                        subLab.Enabled = true;

                        subLab.Click += (sender_et,et) => {
                            codeDetails showDets = new codeDetails(titleLab.Text,subLab.Text,guna2TextBox3.Text);
                            showDets.Show();
                        };
                        
                        Label priBut = new Label();
                        getPanel.Controls.Add(priBut);
                        priBut.Name = "priBut" + curr;
                        priBut.ForeColor = ColorTranslator.FromHtml("#" + priButName);
                        priBut.Font = new Font("Segoe UI", 10);
                        priBut.Location = new Point(18, 180);
                        priBut.Text = prioritySelected.ElementAt(0);
                        priBut.Width = 60;
                        priBut.Visible = true;
                        priBut.Enabled = true;

                        Label sevBut = new Label();
                        getPanel.Controls.Add(sevBut);
                        sevBut.Name = "sevBut" + curr;
                        sevBut.ForeColor = ColorTranslator.FromHtml("#" + sevButName);
                        sevBut.Font = new Font("Segoe UI", 10);
                        sevBut.Location = new Point(82, 180);
                        sevBut.Text = severitySelected.ElementAt(0);
                        sevBut.Width = 60;
                        sevBut.Visible = true;
                        sevBut.Enabled = true;

                        Label dateBut = new Label();
                        getPanel.Controls.Add(dateBut);
                        dateBut.Name = "dateBut" + curr;
                        dateBut.ForeColor = Color.LightGray;
                        dateBut.Font = new Font("Segoe UI", 9);
                        dateBut.Location = new Point(145, 180);
                        dateBut.Text = guna2TextBox4.Text;
                        dateBut.Width = 102;
                        dateBut.Visible = true;
                        dateBut.Enabled = true;

                        Guna2Button procBut = new Guna2Button();
                        getPanel.Controls.Add(procBut);
                        procBut.Name = "procBut" + curr;
                        procBut.FillColor = ColorTranslator.FromHtml("#3498db");
                        procBut.ForeColor = ColorTranslator.FromHtml("#1746d1");
                        procBut.Font = new Font("Segoe UI Semibold", 9);
                        procBut.Location = new Point(252, 173);
                        procBut.Text = "In-Progress";
                        procBut.BorderRadius = 10;
                        procBut.BorderColor = ColorTranslator.FromHtml("#1730d1");
                        procBut.Width = 88;
                        procBut.Height = 25;
                        procBut.Visible = true;
                        procBut.Enabled = true;

                        procBut.Click += (object sender_pr, EventArgs e_pr) => {
                            if(procBut.Text == "In-Progress") {
                                procBut.Text = "Done";
                                procBut.FillColor = ColorTranslator.FromHtml("#38bf13");
                                procBut.ForeColor = ColorTranslator.FromHtml("#1d7505");
                            } else if(procBut.Text == "Done") {
                                procBut.Text = "In-Progress";
                                procBut.FillColor = ColorTranslator.FromHtml("#3498db");
                                procBut.ForeColor = ColorTranslator.FromHtml("#1746d1");
                            }
                        };

                        Guna2Button remBut = new Guna2Button();
                        getPanel.Controls.Add(remBut);
                        remBut.Name = "remBut" + curr;
                        remBut.FillColor = ColorTranslator.FromHtml("#b51d29");
                        remBut.Image = new Bitmap(Flow_Bugger.Properties.Resources.icons8_garbage_66);
                        remBut.ForeColor = ColorTranslator.FromHtml("#1746d1");
                        remBut.Font = new Font("Segoe UI Semibold", 9);
                        remBut.Location = new Point(350, 167);
                        remBut.BorderRadius = 5;
                        remBut.BorderColor = ColorTranslator.FromHtml("#1730d1");
                        remBut.Width = 41;
                        remBut.Height = 34;
                        remBut.Visible = true;
                        remBut.Enabled = true;
                        remBut.Anchor = AnchorStyles.Right;
                        remBut.Anchor = AnchorStyles.Bottom;

                        remBut.Click += (sender_rm, e_rm) => {                           
                            remIsForm showRemForm = new remIsForm(curr,titleLab.Text);
                            showRemForm.Show();
                        };
        
                        Label priLab = new Label();
                        getPanel.Controls.Add(priLab);
                        priLab.Name = "priLab" + curr;
                        priLab.ForeColor = Color.Gray;
                        priLab.Font = new Font("Segoe UI", 9);
                        priLab.Location = new Point(18, 160);
                        priLab.Text = "Priority";
                        priLab.Width = 52;
                        priLab.Visible = true;
                        priLab.Enabled = true;

                        Label sevLab = new Label();
                        getPanel.Controls.Add(sevLab);
                        sevLab.Name = "priLab" + curr;
                        sevLab.ForeColor = Color.Gray;
                        sevLab.Font = new Font("Segoe UI", 9);
                        sevLab.Location = new Point(82, 160);
                        sevLab.Text = "Severity";
                        sevLab.Width = 52;
                        sevLab.Visible = true;
                        sevLab.Enabled = true;

                        Label dateLab = new Label();
                        getPanel.Controls.Add(dateLab);
                        dateLab.Name = "dateLab" + curr;
                        dateLab.ForeColor = Color.Gray;
                        dateLab.Font = new Font("Segoe UI", 9);
                        dateLab.Location = new Point(145, 160);
                        dateLab.Text = (guna2TextBox4.Text != "" ? "Deadlines" : "");
                        dateLab.Width = 58;
                        dateLab.Visible = true;
                        dateLab.Enabled = true;

                        severitySelected.Clear();
                        prioritySelected.Clear();
                        guna2TextBox4.Clear();
                        guna2TextBox3.Clear();
                    }
                    else {
                        MessageBox.Show("Please select priority of your issue.", "Flow Debugger System",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
                else {
                    MessageBox.Show("Please select severity of your issue.", "Flow Debugger System",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                } 
            }
            catch (Exception eq) {
                MessageBox.Show(eq.Message);
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e) {
            pri1.Visible = true;
            prioritySelected.Add("Critical");

            priButName = (sender as Guna2Button).FillColor.Name;

            pri3.Visible = false;
            pri4.Visible = false;
            pri2.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e) {
            pri2.Visible = true;
            prioritySelected.Add("High");

            priButName = (sender as Guna2Button).FillColor.Name;

            pri3.Visible = false;
            pri4.Visible = false;
            pri1.Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e) {
            pri3.Visible = true;
            prioritySelected.Add("Medium");

            priButName = (sender as Guna2Button).FillColor.Name;

            pri4.Visible = false;
            pri2.Visible = false;
            pri1.Visible = false;
        }

        private void guna2Button9_Click(object sender, EventArgs e) {
            pri4.Visible = true;
            prioritySelected.Add("Low");

            priButName = (sender as Guna2Button).FillColor.Name;

            pri3.Visible = false;
            pri2.Visible = false;
            pri1.Visible = false;
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e) {

        }

        private void guna2Button12_Click(object sender, EventArgs e) {

        }

        private void guna2Button17_Click(object sender, EventArgs e) {

        }

        private void guna2Button16_Click(object sender, EventArgs e) {

        }

        private void guna2Button14_Click(object sender, EventArgs e) {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e) {

        }

        private void sev3_Click(object sender, EventArgs e) {

        }

        private void guna2Button18_Click(object sender, EventArgs e) {
            sev1.Visible = true;
            severitySelected.Add("Critical");

            sevButName = (sender as Guna2Button).FillColor.Name;

            sev3.Visible = false;
            sev2.Visible = false;
            sev4.Visible = false;
        }

        private void guna2Button15_Click(object sender, EventArgs e) {
            sev2.Visible = true;
            severitySelected.Add("Major");

            sevButName = (sender as Guna2Button).FillColor.Name;

            sev3.Visible = false;
            sev4.Visible = false;
            sev1.Visible = false;
        }

        private void guna2Button13_Click(object sender, EventArgs e) {
            sev3.Visible = true;
            severitySelected.Add("Minor");
            sevButName = (sender as Guna2Button).FillColor.Name;

            sev4.Visible = false;
            sev2.Visible = false;
            sev1.Visible = false;
        }

        private void guna2Button11_Click(object sender, EventArgs e) {
            sev4.Visible = true;
            severitySelected.Add("Low");
            sevButName = (sender as Guna2Button).FillColor.Name;

            sev3.Visible = false;
            sev2.Visible = false;
            sev1.Visible = false;
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e) {

        }

        private void label9_Click(object sender, EventArgs e) {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e) {

        }
    }
}
