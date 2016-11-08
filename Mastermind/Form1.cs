using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{
    public partial class Form1 : Form
    {
        private string solution1;
        private string solution2;
        private string solution3;
        private string solution4;

        public Form1()
        {
            InitializeComponent();

            Random random = new Random();
            solution1 = random.Next(1, 6).ToString();
            solution2 = random.Next(1, 6).ToString();
            solution3 = random.Next(1, 6).ToString();
            solution4 = random.Next(1, 6).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Checkbutton_Click(object sender, EventArgs e)
        {
            //Guessbox1
            if (Guessbox1.Text == solution1)
            {
                Guessbox1.BackColor = Color.LightGreen;
            }
            else if (Guessbox1.Text == solution2 || Guessbox1.Text == solution3 || Guessbox1.Text == solution4) 
            {
                Guessbox1.BackColor = Color.Yellow;
            }
            else
            {
                Guessbox1.BackColor = Color.LightGray;
            }

            //Guessbox2
            if (Guessbox2.Text == solution2)
            {
                Guessbox2.BackColor = Color.LightGreen;
            }
            else if (Guessbox2.Text == solution1 || Guessbox2.Text == solution3 || Guessbox2.Text == solution4)
            {
                Guessbox2.BackColor = Color.Yellow;
            }
            else
            {
                Guessbox2.BackColor = Color.LightGray;
            }

            //Guessbox3
            if (Guessbox3.Text == solution3)
            {
                Guessbox3.BackColor = Color.LightGreen;
            }
            else if (Guessbox3.Text == solution2 || Guessbox3.Text == solution1 || Guessbox3.Text == solution4)
            {
                Guessbox3.BackColor = Color.Yellow;
            }
            else
            {
                Guessbox3.BackColor = Color.LightGray;
            }

            //Guessbox4
            if (Guessbox4.Text == solution4)
            {
                Guessbox4.BackColor = Color.LightGreen;
            }
            else if (Guessbox4.Text == solution2 || Guessbox4.Text == solution3 || Guessbox4.Text == solution1)
            {
                Guessbox4.BackColor = Color.Yellow;
            }
            else
            {
                Guessbox4.BackColor = Color.LightGray;
            }
        }

        private void Guessbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guessbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guessbox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guessbox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
