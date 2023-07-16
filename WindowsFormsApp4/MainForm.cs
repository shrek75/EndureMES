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
        M01_Schedule form1; 
        M02_Monitoring form2;
        M03_FacilityManagement form3;
        M04_AnomalyDetection form4;
        M05_WorkOrder form5;

        #region < form을 인스턴스화하고 MainForm에 자식으로 추가후, Mainpanel에 위치시키기 >
        private void MainForm_Load(object sender = null, EventArgs e = null)
        {
            form1 = new M01_Schedule();
            form1.MdiParent = this;
            form1.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form1);

            form2 = new M02_Monitoring();
            form2.MdiParent = this;
            form2.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form2);

            form3 = new M03_FacilityManagement();
            form3.MdiParent = this;
            form3.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form3);

            form4 = new M04_AnomalyDetection();
            form4.MdiParent = this;
            form4.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form4);

            form5 = new M05_WorkOrder();
            form5.MdiParent = this;
            form5.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form5);
        }
        #endregion
        private void HideForm(Form currentForm)
        {
            if(currentForm != null)
            {
                currentForm.Hide();
            }
        }
        #region <메뉴버튼 클릭하면 화면 바뀌게>
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

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            HideForm(currentForm);

            currentForm = form4;

            form4.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            HideForm(currentForm);

            currentForm = form5;

            form5.Show();
        }

        #endregion
    }
}
