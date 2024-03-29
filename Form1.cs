﻿//Anya Scheinman
//ascheinman4585@conestogac.on.ca

//* Assignment 1-MCQ Game
//* Revision History
//Anya Scheinman, 2022.09.23: Created
//Anya Scheinman, 2022.09.25: Debugged
//Anya Scheinman, 2022.09.27: Added Comments
//Anya Scheinman, 2022.09.27: Finished project





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Assingment1MCQGame_AnyaScheinman
{
    public partial class Form1 : Form
    {

        //creating variables for quiz game.
        int correctAnswer;
        int questionNumber = 1;
        int points;
        private int counter = 60;
        string hint;
        //int totalQuestions;
        

        Random randomNumber = new Random();

        public Form1(string name)
        {
            InitializeComponent();

            //making sure the label for player and points says "Player" and "Points" before the name and points.

            AskQuestion(randomNum());
            lblPlayerName.Text = "Player Name: " + name;
            lblPoints.Text = "Points: " + points.ToString();

            //creating the timer and adding an event handeler to the timer tick. 
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            //setting the interval amount
            timer1.Interval = 1000;
            timer1.Start();
        }
        //making a new random and random list
        Random random = new Random();
        static List<int> listRandom = new List<int>();

        //creating a method for the random questions
        
        private void Form1_Load(object sender, EventArgs e)
        {


            //making the 50:50 button round
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(1, 1, btnFiftyFifty.Width - 4, btnFiftyFifty.Height - 4);
            btnFiftyFifty.Region = new Region(p);

            //making the hint button round
            GraphicsPath p2 = new GraphicsPath();
            p2.AddEllipse(1, 1, btnHint.Width - 4, btnHint.Height - 4);
            btnHint.Region = new Region(p2);
        }

        //creating a method to check the answers when they are clicked
        private void checkAnswer(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);



            //checking if the button tag i created matches the correct answer.
            if (buttonTag == correctAnswer)
            {

                MessageBox.Show("Congratulations!!!");
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btnNext.Enabled = true;
                //showing which question the player is on.
                switch (questionNumber)
                {
                    case 1:
                        points = points + 100;
                        break;
                    case 2:
                        points = points + 1000;
                        break;
                    case 3:
                        points = points + 10000;
                        break;
                    case 4:
                        points = points + 100000;
                        break;
                    case 5:
                        points = points + 1000000;
                        break;
                    case 6:
                        points = points + 10000000;
                        break;
                    case 7:
                        points = points + 100000000;
                        break;
                }


            }
            else
            {
                //this is to show if the user selects a wrong question the correct one is highlighted
                foreach (var button in this.Controls.OfType<Button>())
                {
                    if (button.Tag != null && int.Parse(button.Tag.ToString()) == correctAnswer)
                    {
                        button.BackColor = Color.Green;
                    }

                }

                MessageBox.Show("Inncorect Answer");
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btnNext.Enabled = true;


            }
            //once quiz is over asked if user wants to play again, if so restart the form login.
            lblPoints.Text = "Points: " + points.ToString();
            //if (questionNumber > 7)
            //{
            //    DialogResult dialogResult = MessageBox.Show("Quiz Ended! Do you want to play again?", "Quiz Over", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {

            //    }
            //    //if the user does not want to play again it closes the form.
            //    else if (dialogResult == DialogResult.No)
            //    {
            //        Close();
            //    }

            //}

        }



        private void AskQuestion(int questionNum)
        {
            btnNext.Enabled = false;
            //creating a switch case for each question and the currect answer, as well as the hints.
            switch (questionNum)
            {

                case 1:
                    lblQuestion.Text = "ما هي عاصمة فلسطين؟";

                    btn1.Text = "رام الله";
                    btn2.Text = "القدس";
                    btn3.Text = "غزة";
                    btn4.Text = "نابلس";
                    correctAnswer = 2;

                    hint = "هي مكان المسجد الأقصى";

                    break;

                case 2:
                    lblQuestion.Text = "ما هي اللغة التي يتحدث بها الناس في فلسطين؟";
                    btn1.Text = "الإنجليزية";
                    btn2.Text = "الفرنسية";
                    btn3.Text = "العربية";
                    btn4.Text = "الإسبانية";

                    correctAnswer = 3;

                    hint = "هي اللغة العربية";

                    break;

                case 3:
                    lblQuestion.Text = "ما هو الشهر الذي يحتفل فيه الناس في فلسطين بعيد الفطر؟";

                    btn1.Text = "ديسمبر";
                    btn2.Text = "مارس";
                    btn3.Text = "يونيو";
                    btn4.Text = "رمضان";

                    correctAnswer = 4;

                    hint = "يأتي بعد شهر صيام";

                    break;

                case 4:
                    lblQuestion.Text = "ما هي المأكولات الشهيرة في فلسطين؟";

                    btn1.Text = "السوشي";
                    btn2.Text = "الكيش";
                    btn3.Text = "المقلوبة";
                    btn4.Text = "البرجر";

                    correctAnswer = 3;

                    hint = "طبق تقليدي شهير";

                    break;

                case 5:
                    lblQuestion.Text = "ما هي الألوان التي تظهر في علم فلسطين؟";

                    btn1.Text = "الأحمر والأخضر والأبيض";
                    btn2.Text = "الأزرق والأصفر والأحمر";
                    btn3.Text = "الأبيض والأسود والبرتقالي";
                    btn4.Text = "الأخضر والأصفر والأحمر";

                    correctAnswer = 1;

                    hint = "ثلاثة ألوان متقاربة";

                    break;

                case 6:
                    lblQuestion.Text = "ما هو نهر الأردن الذي يمر عبر أراضي فلسطين؟";

                    btn1.Text = "الياردن العظيم";
                    btn2.Text = "النيل";
                    btn3.Text = "نهر الملوك";
                    btn4.Text = "نهر الأردن";

                    correctAnswer = 4;

                    hint = "يفصل بين المملكة الأردنية وفلسطين";

                    break;

                case 7:
                    lblQuestion.Text = "ما هو اسم المدينة القديمة التي تقع في القدس؟";

                    btn1.Text = "جبل النار";
                    btn2.Text = "القدس القديمة";
                    btn3.Text = "نابلس";
                    btn4.Text = "غزة";

                    correctAnswer = 2;

                    hint = "تحتوي على العديد من المعالم الدينية";

                    break;
            }
        }



        private void btnNext_Click(object sender, EventArgs e)
        {

            //on the next button click it reserts the 1 minute timer.
            counter = 60;
            counter--;
            lblTimer.Text = "00:" + counter.ToString();
            AskQuestion(randomNum());

            //enabling the question buttons. 
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;

            questionNumber++;


            //Random number = new Random();

            
            //AskQuestion(questionNumber);
            //calling my colourLabel method
            //making sure the buttons colour is set to the correct colour
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.Tag != null)
                {
                    button.BackColor = Color.FromArgb(153, 180, 209);
                }


            }

            //once quiz is over asked if user wants to play again, if so restart the form login.
            if (questionNumber > 7)
            {
                DialogResult dialogResult = MessageBox.Show("Quiz Ended! Do you want to play again?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    listRandom = new List<int>();
                    Form2 goback = new Form2();
                    goback.Show();
                    this.Hide();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Close();
                }
            }

        }
        //creating a method to handle all the colour changes.
        

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            counter--;
            lblTimer.Text = "00:" + counter.ToString();

            //if the timer gets to zero stop the timer and tell the user they ran out of time.
            if (counter == 0)
            {
                timer1.Stop();
                lblTimer.Text = counter.ToString();

                {
                    //ask the user if they wish to play again, if not form closes
                    DialogResult dialogResult = MessageBox.Show("You ran out of time! Do you want to play again?", "Some Title", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        listRandom = new List<int>();
                        Form2 goback = new Form2();
                        goback.Show();
                        this.Hide();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Close();
                    }

                    //disabaling the buttons
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;

                }
            }
        }
        private void lblTimer_Click(object sender, EventArgs e)
        {


        }

        private void btnFiftyFifty_Click(object sender, EventArgs e)
        {
        
            disableButton();

            //after the button has been pushed disable it. 
            btnFiftyFifty.Enabled = false;
            //change the colour to gray once the button is pressed
            btnFiftyFifty.BackColor = Color.Gray;
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            //when hint is pressed show a pop up box
            MessageBox.Show(hint);

            btnHint.Enabled = false;
            btnHint.BackColor = Color.Gray;
        }


        public void disableButton()
        {
            //creating a method for th fifty fity button. making sure that only two buttons become disabled 
            int disableButtonCnt = 0;
            foreach (var button in this.Controls.OfType<Button>())
            {
                //creating the logic that if the button tag does not match the correct answer change the colour to gray
                if (button.Tag != null && button.Tag.ToString() != correctAnswer.ToString())
                {

                    button.Enabled = false;
                    button.BackColor = Color.Gray;
                    disableButtonCnt++;
                }
                if (disableButtonCnt > 1)
                {
                    break;
                }
            }
        }
        //creating  method that asks the questions in random order.
        private int randomNum()
        {
            //if my list is 7 it returns 7
            if (listRandom.Count == 7)
            {
                return 7;
            }
            //the numbers are from 1-8
            int number = random.Next(1, 8);
            //while it contrains the numbers it checks if its in the list and been used
            while (listRandom.Contains(number))
            {
                number = random.Next(1, 8);
            }

            listRandom.Add(number);

            return number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            // Open Form3
            Form7 f = new Form7();
            f.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
