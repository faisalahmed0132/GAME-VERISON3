using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment1MCQGame_AnyaScheinman
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
            transparentButton.BackColor = Color.Transparent;

            // قم بربط حدث النقر بوظيفة للتعامل مع النقر على الزر
        }

        private void transparentButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Open Form8
            Form10 f = new Form10();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Open Form8
            Form19 f = new Form19();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Open Form8
            Form17 f = new Form17();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Open Form8
            Form18 f = new Form18();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Open Form8
            Form7 f = new Form7();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
