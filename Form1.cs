using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public double Result1, Result2, Sum, Mul, Min, Div;
        Boolean OPMul, OPSum, OPMin, OPDiv;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_Res.Text = txt_Res.Text +"0";         
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_Res.Text = txt_Res.Text + "1";         

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_Res.Text = txt_Res.Text + "2";         

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_Res.Text = txt_Res.Text + "3";         

        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_Res.Text = txt_Res.Text + "4";         

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_Res.Text = txt_Res.Text + "5";         

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_Res.Text = txt_Res.Text + "6";         

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_Res.Text = txt_Res.Text + "7";         

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_Res.Text = txt_Res.Text + "8";         

        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_Res.Text = txt_Res.Text + "9";         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Res.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
             if (txt_Res.Text != "")
            {
                Result1 = double.Parse(txt_Res.Text);
                txt_Res.Text = "";
                OPMul = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_Res.Text != "")
            {
                Result1 = double.Parse(txt_Res.Text);
                txt_Res.Text ="";
                OPMin = true;
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (txt_Res.Text != "")
            {
                Result1 = double.Parse(txt_Res.Text);
                txt_Res.Text = "";
                OPSum = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
             if (txt_Res.Text != "")
            {
                Result1 = double.Parse(txt_Res.Text);
                txt_Res.Text = "";
                OPDiv = true;
            }
        }

        private void btn_equl_Click(object sender, EventArgs e)
        {
            if (txt_Res.Text != "")
            {
                Result2 = double.Parse(txt_Res.Text);
                if (OPSum == true)
                {
                    Sum = Result1 + Result2;
                    txt_Res.Text = Sum.ToString();
                    OPSum = false;
                }
                else if (OPMin == true)
                {
                    Min = Result1 - Result2;
                    txt_Res.Text = Min.ToString();
                    OPMin = false;
                }
                else if (OPMul == true)
                {
                    Mul = (Result1 * Result2);
                    txt_Res.Text = Mul.ToString();
                    OPMul = false;
                }
                else if (OPDiv == true)
                {
                    Div = Result1 / Result2;
                    txt_Res.Text = Div.ToString();
                    OPDiv = false;
                }
            }
        }
    }
}
