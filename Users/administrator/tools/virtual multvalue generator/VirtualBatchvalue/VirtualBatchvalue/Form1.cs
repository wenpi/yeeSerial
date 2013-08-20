using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualBatchvalue
{
    public partial class frmMain : Form
    {
        private DateTime curTime;
        private Random rnd;

        public frmMain()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            txtYear.Text = DateTime.Now.Year.ToString();
            txtMonth.Text = DateTime.Now.Month.ToString();
            txtDay.Text = DateTime.Now.Day.ToString();
            txtHour.Text = DateTime.Now.Hour.ToString();
            txtMinute.Text = DateTime.Now.Minute.ToString();
            txtSeconds.Text = DateTime.Now.Second.ToString();
            this.Refresh();

            rnd = new Random(DateTime.Now.Millisecond);

            label6.Text = "配合yeelink批量上传测试用的小工具，产生批量数值类型的数据";
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            lvValues.Items.Clear();
            curTime = new DateTime(
                Convert.ToInt16(txtYear.Text),
                Convert.ToInt16(txtMonth.Text),
                Convert.ToInt16(txtDay.Text),
                Convert.ToInt16(txtHour.Text),
                Convert.ToInt16(txtMinute.Text),
                Convert.ToInt16(txtSeconds.Text)
                );



            int qty = Convert.ToInt16(txtQTY.Text);
            for (int i = 0; i < qty; i++)
            {
                int ratio = 1;
                if (chkCountDown.Checked)
                    ratio = -1;
                curTime = curTime.AddSeconds(Convert.ToInt16(txtStep.Text)*ratio);
                ListViewItem itm = lvValues.Items.Add((i + 1).ToString());
                itm.SubItems.Add(curTime.ToString());

                if (chkDouble.Checked)
                {
                    Double value = rnd.NextDouble()* Convert.ToInt16(txtMaxValue.Text );
                    value  = Math.Round(value,2);
                   
                    itm.SubItems.Add(value.ToString());
                }
                else
                {
                    int value = rnd.Next(0, Convert.ToInt16(txtMaxValue.Text));
                    itm.SubItems.Add(value.ToString());
                }




            }
        }

        private void lvValues_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dlgFileSave.ShowDialog();
            if (dlgFileSave.FileName != "")
            {
                // System.IO.FileStream fs = (System.IO.FileStream) dlgFileSave.OpenFile();
                String fileName = dlgFileSave.FileName;
                System.IO.StreamWriter objWriter;
                objWriter = new System.IO.StreamWriter(fileName, false);
                for (int i = 0; i < lvValues.Items.Count; i++)
                {
                    objWriter.Write(lvValues.Items[i].SubItems[1].Text);
                    objWriter.Write(",");
                    objWriter.WriteLine(lvValues.Items[i].SubItems[2].Text);
                };
                objWriter.Close();

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chkCountDown_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void chkDouble_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaxValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQTY_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeconds_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMinute_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHour_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



    }
}
