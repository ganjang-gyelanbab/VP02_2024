using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_radio_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "국적 : ";
            if (rb_korea.Checked)
                result += "대한민국\n";
            else if (rd_china.Checked)
                result += "중국\n";
            else if (rb_japan.Checked)
                result += "일본\n";
            else if (rb_others.Checked)
                result += "그 외의 국가 \n";

            if (rb_male.Checked)
                result += "성별 : 남성 ";
            else if (rb_female.Checked)
                result += "성별 : 여성";

            MessageBox.Show(result, "결과");
        }
    }
}
