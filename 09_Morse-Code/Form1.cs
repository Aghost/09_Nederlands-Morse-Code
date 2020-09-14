using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_Morse_Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBox.Text = MorseCode.ToMorse('a');
        }

        private void Btn_ToMorse_Click(object sender, EventArgs e)
        {
            string buffer = TextBox.Text;
            TextBox.Text = "";

            foreach (char chr in buffer)
            {
                Console.Write(chr);
                TextBox.Text += MorseCode.ToMorse(chr) + ' ';
            }
        }

        private void Btn_FromMorse_Click(object sender, EventArgs e)
        {
            string buffer = TextBox.Text;
            TextBox.Text = "";

            foreach (string str in buffer.Split(' '))
            {
                TextBox.Text += MorseCode.FromMorse(str);
            }
            Console.WriteLine(TextBox.Text);
        }

    }
}
