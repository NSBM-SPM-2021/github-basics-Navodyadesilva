using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void enabled_menu()
        {
            tsLogin.Text = "Logout";
            tsStudents.Enabled = true;
            tsCourses.Enabled = true;
            tsGrades.Enabled = true;
            tsSubject.Enabled = true;
            tsUsers.Enabled = true;
            tsFindstudent.Enabled = true;
            tsLogin.Image = Properties.Resources.unlock;
        }

        public void disabled_menu()
        {
            tsLogin.Text = "Login";
            tsStudents.Enabled = false;
            tsCourses.Enabled = false;
            tsGrades.Enabled = false;
            tsSubject.Enabled = false;
            tsUsers.Enabled = false;
            tsFindstudent.Enabled = false;
            label1.Visible = true;
            tsLogin.Image = Properties.Resources._lock;
        }


        private void closefrm()
        {
            foreach(Form frm in this.MdiChildren)
            {
                frm.Close();

            }
        }
        private void showfrm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            disabled_menu();
        }

        private void tsStudents_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            closefrm();
            showfrm(new frmStudent());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            closefrm();
            showfrm(new frmGrades());
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            closefrm();
            frmCourse course = new frmCourse();
            course.StartPosition = FormStartPosition.CenterScreen;
            course.Show();
            //showfrm(new frmCourse());
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            closefrm();
            showfrm(new frmSubjects());
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            closefrm();
            showfrm(new frmUsers());

        }

       

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            closefrm();
            showfrm(new frmFinstudents());
        }

        private void tsLogin_Click(object sender, EventArgs e)
        {
            if(tsLogin.Text == "Login")
            {
                closefrm();
                showfrm(new frmLogin(this));
            }
            else
            {
                disabled_menu();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
