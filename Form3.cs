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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            // Open Form3
            Form7 f = new Form7();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                Form7 f = new Form7();
                f = new Form7();
                f.Show();

            }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        
            private void button3_Click(object sender, EventArgs e)
            {

                Form8 f = new Form8();
                f = new Form8();
                f.Show();

            }
        }
    }
    

