using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Shifrovalka
{
    public partial class Form1 : Form
    {
        string str;
        string res;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShifr_Click(object sender, EventArgs e)
        {

            if (txtTe.Text != "")
            {
                str = "";
                res ="";
                str = txtTe.Text;
                str = str.Trim();
                int dl = Convert.ToInt32(nudDlina.Value);
                int dlina = str.Length;
                int shifr = Convert.ToInt32(nudSdvig.Value);
                for (int x = 0; x < dlina; x++)
                {
                    char bukva = str[x];
                    int bukvaindx = bukva;
                    bukvaindx = bukvaindx + shifr;
                    char bukva2 = Convert.ToChar(bukvaindx);
                    res = res + bukva2.ToString();
                    shifr = shifr + Convert.ToInt32(nudShag.Value);
                    if (shifr >= dl)
                    {
                        shifr = Convert.ToInt32(nudSdvig.Value);
                    }
                }
                txtRes.Text = res;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTe.Text != "")
            {
                str = "";
                res = "";
                str = txtTe.Text;
                str = str.Trim();
                int dl = Convert.ToInt32(nudDlinaDe.Value);
                int dlina = str.Length;
                int shifr = Convert.ToInt32(nudSdvigDe.Value);
                for (int x = 0; x < dlina; x++)
                {
                    char bukva = str[x];
                    int bukvaindx = bukva;
                    bukvaindx = bukvaindx - shifr;
                    char bukva2 = Convert.ToChar(bukvaindx);
                    res = res + bukva2.ToString();
                    shifr = shifr + Convert.ToInt32(nudShagDe.Value);
                    if (shifr >= dl)
                    {
                        shifr = Convert.ToInt32(nudSdvigDe.Value);
                    }

                }
                txtRes.Text = res;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtRes.Text = "";
            txtTe.Text = "";
            nudShag.Value = 0;
            nudSdvigDe.Value = 0;
            nudSdvig.Value = 0;
            nudShagDe.Value = 0;
        }

        private void btnFF_Click(object sender, EventArgs e)
        {
            str = "";
            str = txtTe.Text.Trim();
            int dlina = str.Length;
            for (int x = 0; x < dlina; x++)
            {
                char bukva = str[x];
                int bukvaindx = bukva;
                switch (bukvaindx)
                {
                    case 97:
                        bukvaindx = 125;
                        char bukva2 = Convert.ToChar(bukvaindx);
                        res = res + bukva2.ToString();
                        break;
                    case 98:
                        bukvaindx = 99;
                        bukva2 = Convert.ToChar(bukvaindx);
                        res = res + bukva2.ToString() + "ф";
                        break;
                    case 99:
                        bukvaindx = 117;
                        bukva2 = Convert.ToChar(bukvaindx);
                        res = res + bukva2.ToString();
                        break;
                    case 100:
                        bukvaindx = 117;
                        bukva2 = Convert.ToChar(bukvaindx);
                        res = res + bukva2.ToString() + "в" + "ф";
                        break;
                    case 101:
                        bukvaindx = 99;
                        bukva2 = Convert.ToChar(bukvaindx);
                        res = res + bukva2.ToString() + "ф" + "в";
                        break;
                    case 102:
                        bukvaindx = 125;
                        bukva2 = Convert.ToChar(bukvaindx);
                        res = res + bukva2.ToString() + "Ы";
                        break;
                    case 103:
                        bukvaindx = 125;
                        bukva2 = Convert.ToChar(bukvaindx);
                        res = res + bukva2.ToString() + "а";
                        break;
                    case 104:
                        bukvaindx = 99;
                        bukva2 = Convert.ToChar(bukvaindx);
                        res = res + bukva2.ToString() + "а";
                        break;
                    case 105:
                        bukvaindx = 99;
                        bukva2 = Convert.ToChar(bukvaindx);
                        res = res + bukva2.ToString() + "ы";
                        break;
                    case 106:
                        bukvaindx = 97;
                        bukva2 = Convert.ToChar(bukvaindx);
                        res = res + bukva2.ToString() + "ыв";
                        break;
                    case 107:
                        bukvaindx = 125;
                        bukva2 = Convert.ToChar(bukvaindx);
                        res = res + bukva2.ToString() + "вва";
                        break;
                    case 108:
                        bukvaindx = 117;
                        bukva2 = Convert.ToChar(bukvaindx);
                        res = res + bukva2.ToString() + "ыв";
                        break;
                    case 109:
                        bukvaindx = 97;
                        bukva2 = Convert.ToChar(bukvaindx);
                        res = res + bukva2.ToString() + "ыф";
                        break;
                    case 110:
                        bukvaindx = 117;
                        bukva2 = Convert.ToChar(bukvaindx);
                        res = res + bukva2.ToString() + "ф";
                        break;
                }
                txtRes.Text = res;
            }


        }
    }
}
