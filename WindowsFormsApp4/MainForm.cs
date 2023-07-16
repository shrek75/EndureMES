using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainForm_Load();
        }

        Form currentForm; //현재 실행중인 폼
        //form들
        Form1 form1; 
        Form2 form2;
        Form3 form3;


        private void MainForm_Load(object sender = null, EventArgs e = null)
        {
            // form을 인스턴스화하고 MainForm에 자식으로 추가
            form1 = new Form1();
            form1.MdiParent = this;
            form1.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form1);

            form2 = new Form2();
            form2.MdiParent = this;
            form2.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form2);

            form3 = new Form3();
            form3.MdiParent = this;
            form3.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form3);
        }
        private void HideForm(Form currentForm)
        {
            if(currentForm != null)
            {
                currentForm.Hide();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            HideForm(currentForm);
            currentForm = form1;
            form1.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            HideForm(currentForm);

            currentForm = form2;

            form2.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            HideForm(currentForm);

            currentForm = form3;

            form3.Show();
        }
    }
}
