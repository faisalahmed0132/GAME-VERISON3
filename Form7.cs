using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assingment1MCQGame_AnyaScheinman
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Close the current form
            this.Close();

            // Open Form3
            Form11 f = new Form11();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if the name is not empty or greater than 20 characters

            this.Close();

            // Open Form3
            Form6 f = new Form6();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

            // Open Form3
            Form2 f = new Form2();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

            // Open Form3
            Form14 f = new Form14();
            f.Show();
        }

        private void textBoxPlayerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

            // Open Form3
            Form15 f = new Form15();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();

            // Open Form3
            Form7 f = new Form7();
            f.Show();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
    }
}


