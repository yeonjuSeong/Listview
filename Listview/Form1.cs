using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Listview
{
    public partial class Form1 : Form
    {
        string strName;
        string strAge;
        string strWork;

        public Form1()
        {
            InitializeComponent();
        }
        private bool TextCheck()
        {
            if (this.txtName.Text == "")
            {
                MessageBox.Show("이름을 넣어주세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
                return false;
            }

            if (this.txtName.Text == "")
            {
                MessageBox.Show("나이를 넣어주세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
                return false;
            }
            if (this.txtName.Text == "")
            {
                MessageBox.Show("직업을 넣어주세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
                return false;
            }
            return true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(TextCheck())
            {
                this.strName = this.txtName.Text;
                this.strWork = Name = this.txtWork.Text;

                ListViewItem lvi = new ListViewItem(
                    new String[]
                    { this.strName,this.strAge, this.strWork}
                    );
                this.lvView.Items.Add(lvi);
                this.txtName.Text = "";
                this.txtAge.Text = "";
                this.txtWork.Text = "";
                this.txtName.Focus();
            }
        }


        private void LvView_Click(object sender, EventArgs e)
        {
            if (this.lvView.SelectedItems.Count == 0)
            {
                MessageBox.Show("항목을 선택하세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListViewItem lvi = this.lvView.SelectedItems[0];
                MessageBox.Show("이름 : " + lvi.SubItems[0].Text +
                   "\n나이 : " + lvi.SubItems[1].Text +
                   "\n직업 : " + lvi.SubItems[2].Text,
                   "알림",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }

        }
    }
}
