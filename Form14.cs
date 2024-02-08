using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assingment1MCQGame_AnyaScheinman
{
    public partial class Form14 : Form
    {
        private Timer timer;
        private Label messageLabel;
        private PictureBox pictureBox; // Declare pictureBox as a class-level variable

        public Form14()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 2000; // Change this value to adjust the duration in milliseconds
            timer.Tick += Timer_Tick;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Check which button was clicked
            Button clickedButton = sender as Button;

            // Display a message based on the clicked button
            if (clickedButton == button1 || clickedButton == button5)
            {
                ShowCustomMessage("Correct!", Color.Green, Properties.Resources.asd1);
            }
            else
            {
                ShowCustomMessage("Incorrect!", Color.Red, null);
            }
        }

        private void ShowCustomMessage(string message, Color labelColor, Image image)
        {
            // Check if there is an existing label and picture box, and remove them if present
            if (messageLabel != null)
            {
                this.Controls.Remove(messageLabel);
                messageLabel.Dispose();
            }

            if (pictureBox != null)
            {
                this.Controls.Remove(pictureBox);
                pictureBox.Dispose();
            }

            // Create a label to display the message
            messageLabel = new Label();
            messageLabel.Text = message;
            messageLabel.Dock = DockStyle.Fill;
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            messageLabel.ForeColor = labelColor;
            messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // Add the label to the form
            this.Controls.Add(messageLabel);

            // Display image if provided
            if (image != null)
            {
                pictureBox = new PictureBox();
                pictureBox.Image = image;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = new Size(100, 100); // Adjust size as needed
                pictureBox.Location = new Point((this.Width - pictureBox.Width) / 2, 100); // Adjust location as needed
                this.Controls.Add(pictureBox);
            }

            // Start the timer
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            timer.Stop();

            // Remove the label and picture box from the form
            if (messageLabel != null)
            {
                this.Controls.Remove(messageLabel);
                messageLabel.Dispose();
            }

            if (pictureBox != null)
            {
                this.Controls.Remove(pictureBox);
                pictureBox.Dispose();
            }
        }
    }
}
