using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int LeftBox;
            int RightBox;
            int answer;

            /*LeftBox = int.Parse(input1_textbox.Text);
            RightBox = int.Parse(input2_textbox.Text);
            answer = LeftBox + RightBox;
            answer_textbox.Text = answer.ToString();*/
            if (int.TryParse(input1_textbox.Text,out LeftBox) || int.TryParse(input2_textbox.Text, out RightBox))
            {
                LeftBox = int.Parse(input1_textbox.Text);
                RightBox = int.Parse(input2_textbox.Text);
                answer = LeftBox + RightBox;
                answer_textbox.Text = answer.ToString();
            }
            else
            {
                MessageBox.Show("値はINTのみ入力できます。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
