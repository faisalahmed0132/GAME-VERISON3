using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assingment1MCQGame_AnyaScheinman
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Check if the entered name is exactly "حماس"
            if (txtName.Text.Trim() == "حماس")
            {
                // Perform the desired action or show a message for the name "حماس"
                MessageBox.Show("Welcome حماس! Get ready for an exciting experience!", "Special Welcome");

                // Optionally, you can pass the name to the next form if needed
                Form20 f20 = new Form20();
                f20.Show();
                this.Hide();
            }
            else
            {
                // Show an error if the entered name is not "حماس"
                lblError.Text = "Invalid name. Please enter 'حماس'.";
                txtName.Text = String.Empty;
            }
        }





        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
