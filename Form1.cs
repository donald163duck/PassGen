using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Passwrd = "";
            string[] array =
            {
                "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
                "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H",
                "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
            };

            Random rnd = new Random();

            if (radioButton1.Checked == true)
            {
                for (int i = 0; i < 8; i++)
                {
                    Passwrd = Passwrd + array[rnd.Next(0, 61)];
                    textBox1.Text = Passwrd.ToString();
                }
            }

            if (radioButton2.Checked == true)
            {
                for (int i = 0; i < 10; i++)
                {
                    Passwrd = Passwrd + array[rnd.Next(0, 61)];
                    textBox1.Text = Passwrd.ToString();
                }
            }

            if (radioButton3.Checked == true)
            {
                for (int i = 0; i < 12; i++)
                {
                    Passwrd = Passwrd + array[rnd.Next(0, 61)];
                    textBox1.Text = Passwrd.ToString();
                }
            }

            if (radioButton4.Checked == true)
            {
                for (int i = 0; i < 32; i++)
                {
                    Passwrd = Passwrd + array[rnd.Next(0, 61)];
                    textBox1.Text = Passwrd.ToString();
                }
            }

        }
    }
}

