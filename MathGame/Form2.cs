using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int result = 0;
        int secondStart = 4;
        int secondGameOneMinute = 61;
        int minuteGameTwoMinute = 1;
        int secondQuestion;
        double secondAnswering = 2;
        int correctAnswer = 0;
        int wrongAnswer = 0;
        int allQuestions = 0;
        int notAnsweredQuestions = 0;
        bool startStop = true;
        Random number = new Random();
        

       
        public int createOperation()
        {
            int result = 0;
            int smallNumberOne = number.Next(1, 10);
            int smallNumberTwo = number.Next(1, 10);
            int bigNumberOne = number.Next(10, 20);
            int bigNumberTwo = number.Next(10, 20);
            int hardNumber = number.Next(30, 99);
            string[] signs = { "+", "-", "X"};
            int signAllNumbers = number.Next(0, 3);
            int signFirstTwo = number.Next(0, 2);
            string lastSignAll = signs[signAllNumbers];
            string lastSignFirstTwo = signs[signFirstTwo];

            if (comboLevel.Text=="Easy")
            {
                if (comboOperation.Text == "Only addition")
                {
                    labelQuestion.Text = smallNumberOne  + " " + "+" + " " +  smallNumberTwo;
                    result = smallNumberOne + smallNumberTwo;

                }
                else if (comboOperation.Text == "Only abstraction")
                {
                    if (smallNumberTwo > smallNumberOne)
                    {
                        labelQuestion.Text = smallNumberTwo + " " + "-" + " " + smallNumberOne;

                        result = smallNumberTwo - smallNumberOne;
                    }
                    else
                    {
                        labelQuestion.Text = smallNumberOne + " " + "-" + " " + smallNumberTwo;
                        result = smallNumberOne - smallNumberTwo;
                    }

                }
              
                else if (comboOperation.Text == "Only multiplication")
                {
                    labelQuestion.Text = smallNumberOne  + " " + "X" + " " +  smallNumberTwo;
                    result = smallNumberOne * smallNumberTwo;
                }
                else if (comboOperation.Text == "Addition and abstraction")
                {
                   
                    if (lastSignFirstTwo=="+")
                    {
                        result = smallNumberOne + smallNumberTwo;
                        labelQuestion.Text = smallNumberOne + " " + "+" + " " + smallNumberTwo;

                    }
                    if (lastSignFirstTwo == "-")
                    {
                        if (smallNumberTwo > smallNumberOne)
                        {
                            labelQuestion.Text = smallNumberTwo + " " + "-" + " " + smallNumberOne;

                            result = smallNumberTwo - smallNumberOne;
                        }
                        else
                        {
                            labelQuestion.Text = smallNumberOne + " " + "-" + " " + smallNumberTwo;
                            result = smallNumberOne - smallNumberTwo;
                        }

                    }

                }
                else if (comboOperation.Text == "All")
                {
                   
                    
                    if (lastSignAll == "+")
                    {
                        result = smallNumberOne + smallNumberTwo;
                        labelQuestion.Text = smallNumberOne + " " + "+" + " " + smallNumberTwo;
                    }
                    if (lastSignAll == "-")
                    {
                        if (smallNumberTwo > smallNumberOne)
                        {
                            labelQuestion.Text = smallNumberTwo + " " + "-" + " " + smallNumberOne;

                            result = smallNumberTwo - smallNumberOne;
                        }
                        else
                        {
                            labelQuestion.Text = smallNumberOne + " " + "-" + " " + smallNumberTwo;
                            result = smallNumberOne - smallNumberTwo;
                        }

                    }
                    if (lastSignAll == "X")
                    {
                        labelQuestion.Text = smallNumberOne + " " + "X" + " " + smallNumberTwo;
                        result = smallNumberOne * smallNumberTwo;
                    }
                }
            }

            if (comboLevel.Text == "Medium")
            {
                if (comboOperation.Text == "Only addition")
                {
                    labelQuestion.Text = smallNumberOne + " " + "+" + " " + bigNumberOne;
                    result = smallNumberOne + bigNumberOne;
                }
                else if (comboOperation.Text == "Only abstraction")
                {
                    labelQuestion.Text = bigNumberOne + " " + "-" + " " + smallNumberOne;
                    result = bigNumberOne - smallNumberOne;
                }
               
                else if (comboOperation.Text == "Only multiplication")
                {
                    labelQuestion.Text = smallNumberOne + " " + "X" + " " + bigNumberOne;
                    result = smallNumberOne * bigNumberOne;
                }
                else if (comboOperation.Text == "Addition and abstraction")
                {
                    labelQuestion.Text = bigNumberOne + " " + lastSignFirstTwo + " " + smallNumberOne;
                    if (lastSignFirstTwo == "+")
                    {
                        result = smallNumberOne + bigNumberOne;
                    }
                    if (lastSignFirstTwo == "-")
                    {
                        result =  bigNumberOne-smallNumberOne;
                    }
                }
                else if (comboOperation.Text == "All")
                {
                    labelQuestion.Text = smallNumberOne + " " + lastSignAll + " " + bigNumberOne;
                    if (lastSignAll == "+")
                    {
                        result = smallNumberOne + bigNumberOne;
                    }
                    if (lastSignAll == "-")
                    {
                        result = bigNumberOne-smallNumberOne;
                    }
                    if (lastSignAll == "X")
                    {
                        result = smallNumberOne * bigNumberOne;
                    }
                }
            }

            if (comboLevel.Text == "Hard")
            {   
                if (comboOperation.Text == "Only addition")
                {
                    labelQuestion.Text = bigNumberOne + " " + "+" + " " + bigNumberTwo;
                    result = bigNumberOne + bigNumberTwo;
                }
                else if (comboOperation.Text == "Only abstraction")
                { 
                     labelQuestion.Text = hardNumber + " " + "-" + " " + bigNumberOne;
                     result = hardNumber - bigNumberOne;  
                }
               
                else if (comboOperation.Text == "Only multiplication")
                {
                    labelQuestion.Text = bigNumberOne + " " + "X" + " " + bigNumberTwo;
                    result = bigNumberOne * bigNumberTwo;
                }
                else if (comboOperation.Text == "Addition and abstraction")
                {
                    
                    if (lastSignFirstTwo == "+")
                    {
                        labelQuestion.Text = bigNumberOne + " " + "+" + " " + hardNumber;
                        result = bigNumberOne + hardNumber;
                    }
                    if (lastSignFirstTwo == "-")
                    {
                        labelQuestion.Text = hardNumber + " " + "-" + " " + bigNumberOne;
                        result = hardNumber - bigNumberOne;
                    }
                }
                else if (comboOperation.Text == "All")
                {
                    
                    if (lastSignAll == "+")
                    {
                        labelQuestion.Text = bigNumberOne + " " + "+" + " " + bigNumberTwo;
                        result = bigNumberOne + bigNumberTwo;
                    }
                    if (lastSignAll == "-")
                    {
                        labelQuestion.Text = hardNumber + " " + "-" + " " + bigNumberOne;
                        result = hardNumber - bigNumberOne;
                    }
                    if (lastSignAll == "X")
                    {
                        labelQuestion.Text = bigNumberOne + " " + "X" + " " + bigNumberTwo;
                        result = bigNumberOne * bigNumberTwo;
                    }
                }
            }


            return result;
        }

        public void buttonActiveControl()
        {
            this.ActiveControl = null;
        }

        private void comboBoxTip()
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 0;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 0;
            toolTip1.ShowAlways = true;
            if (this.comboOperation.Name == "comboOperation")
            {
                toolTip1.SetToolTip(this.comboOperation, "You can choose operation type.");
            }
            if (this.comboLevel.Name == "comboLevel")
            {
                toolTip1.SetToolTip(this.comboLevel, "You can choose difficultiy of the game.");
            }
            if (this.comboSpeed.Name == "comboSpeed")
            {
                toolTip1.SetToolTip(this.comboSpeed, "You can choose speed of the game. \n " +
                "It determines how many seconds later new question will appear.  ");
            }
            if (this.comboTime.Name == "comboTime")
            {
                toolTip1.SetToolTip(this.comboTime, "You can choose total time of the game.");
            }


        }

        private void comboBoxEnabledTrue()
        {
            comboOperation.Enabled = true;
            comboLevel.Enabled = true;
            comboSpeed.Enabled = true;
            comboTime.Enabled = true;
        }

        private void comboBoxEnabledFalse()
        {
            comboOperation.Enabled = false;
            comboLevel.Enabled = false;
            comboSpeed.Enabled = false;
            comboTime.Enabled = false;
        }

        private void objectsVisibleFalse()

        {
            buttonAnswerLeft.Visible = false;
            buttonAnswerRight.Visible = false;
            labelQuestion.Visible = false;
            labelQuestionTime.Visible = false;
            labelGameTime.Visible = false;
            labelStartTime.Visible = false;
            labelGameMinute.Visible = false;
            labelGameTimeColon.Visible =false;
            labelGameSecond.Visible = false;
            labelQuestionSecond.Visible = false;
        }

        private void objectsVisibleTrue()
        {
            buttonAnswerLeft.Visible = true;
            buttonAnswerRight.Visible = true;
            labelQuestion.Visible = true;
            labelQuestionTime.Visible = true;
            labelGameTime.Visible = true;
            labelGameMinute.Visible = true;
            labelGameTimeColon.Visible = true;
            labelGameSecond.Visible = true;
            labelQuestionSecond.Visible = true;
        }

        private void lastObjectsVisibleFalse()
        {
            groupBoxScore.Visible = false;
            labelCongurulate.Visible = false;
        }

        private void lastObjectsVisibleTrue()
        {
            groupBoxScore.Visible = true;
            labelCongurulate.Visible = true;
        }

        private void creatingNumber()
        {
            result = createOperation();
            int buttonText = number.Next(0, 2);
            int wrongAnswer = number.Next(result - 5, result + 5);
            if (buttonText == 0)
            {
                buttonAnswerLeft.Text = Convert.ToString(result);
                buttonAnswerRight.Text = Convert.ToString(wrongAnswer);
            }
            else
            {
                buttonAnswerLeft.Text = Convert.ToString(wrongAnswer);
                buttonAnswerRight.Text = Convert.ToString(result);
            }
        }

        private void correctAnswerLabel()
        {
            correctAnswer++;
            labelCorrectAnswer.Text = Convert.ToString(correctAnswer);
        }

        private void wrongAnswerLabel()
        {
            wrongAnswer++;
            labelWrongAnswer.Text = Convert.ToString(wrongAnswer);
        }

        private void allAnswer()
        {
            allQuestions++;
            labelAllQuestion.Text = Convert.ToString(allQuestions);
        }

        private void notAnsweredQuestion()
        {
            notAnsweredQuestions++;
            lblNotAnswerQuestions.Text = Convert.ToString(notAnsweredQuestions);
        }

        private void answerButtonsFirstColor()
        {
            buttonAnswerLeft.BackColor = Color.Azure;
            buttonAnswerRight.BackColor = Color.Azure;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboOperation.SelectedIndex = 0;
            comboLevel.SelectedIndex = 0;
            comboSpeed.SelectedIndex = 3;
            comboTime.SelectedIndex = 0;
            objectsVisibleFalse();
            lastObjectsVisibleFalse();
            secondQuestion = Convert.ToInt32(comboSpeed.Text);
        }

        private void comboOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTip();
        }

        private void comboLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTip();
        }

        private void comboSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTip();
        }

        private void comboTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTip();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonActiveControl();
            answerButtonsFirstColor();

            if (startStop==true)
            {
                buttonStart.Text = "Stop";
                timerStart.Start();
                startStop = false;
                labelGameSecond.Text = "59";
                labelQuestionSecond.Text = (comboSpeed.Text).ToString();
                comboBoxEnabledFalse();
               
            }
            else
            {
                buttonStart.Text = "Start";
                startStop = true;
                timerStart.Stop();
                timerGameTime.Stop();
                timerQuestionTime.Stop();                
                secondGameOneMinute = 60;
                secondStart = 4;
                comboBoxEnabledTrue();
                labelStartTime.Visible = false;
                objectsVisibleFalse();
                lastObjectsVisibleFalse();
                
            }
        
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            labelStartTime.Visible = true;
            secondStart-=1;
            labelStartTime.Text = secondStart.ToString();
            if (secondStart == 0)
            {
                timerStart.Stop();
                timerGameTime.Start();
                timerQuestionTime.Start();
                labelStartTime.Visible = false;
                objectsVisibleTrue();
                result=createOperation();
                int buttonText = number.Next(0, 2);
                int wrongAnswer = number.Next( result - 5,result + 5);
                if (buttonText==0)
                {
                    buttonAnswerLeft.Text = Convert.ToString(result);
                    buttonAnswerRight.Text = Convert.ToString(wrongAnswer);
                }
                else
                {
                    buttonAnswerLeft.Text = Convert.ToString(wrongAnswer);
                    buttonAnswerRight.Text = Convert.ToString(result);
                }
  
            }


        }

        private void timerGameTime_Tick_1(object sender, EventArgs e)
        {
            if (comboTime.Text == "1 Minutes")
            {
                secondGameOneMinute -= 1;
                labelGameSecond.Text = secondGameOneMinute.ToString();
            }
            if (comboTime.Text == "2 Minutes")
            {
                labelGameMinute.Text = minuteGameTwoMinute.ToString();
                secondGameOneMinute -= 1;
                labelGameSecond.Text = secondGameOneMinute.ToString();
                if (secondGameOneMinute==1)
                {
                    minuteGameTwoMinute--;
                    labelGameMinute.Text = minuteGameTwoMinute.ToString();
                    secondGameOneMinute = 59;
                }
            }
            if (secondGameOneMinute==0)
            {
                lastObjectsVisibleTrue();
                objectsVisibleFalse();
                labelCorrectAnswer.Text = Convert.ToString(correctAnswer);
                labelWrongAnswer.Text = Convert.ToString(wrongAnswer);
                lblNotAnswerQuestions.Text = Convert.ToString(notAnsweredQuestions);
                timerGameTime.Stop();
                timerQuestionTime.Stop();
                timerAnswerTime.Stop();
            }

        }

        private void timerQuestionTime_Tick(object sender, EventArgs e)
        {
            secondQuestion -= 1;
            labelQuestionSecond.Text = secondQuestion.ToString();
            if (secondQuestion==0)
            {
                creatingNumber();
                secondQuestion = Convert.ToInt32(comboSpeed.Text)+1;
                allAnswer();
                notAnsweredQuestion();
            }
                       
        }

        private void timerAnswerTime_Tick(object sender, EventArgs e)
        {
            secondAnswering -= 1;
            if (secondAnswering == 1)
            {
                creatingNumber();
                answerButtonsFirstColor();
                secondQuestion = Convert.ToInt32(comboSpeed.Text)+1;
            }    
        }

        private void buttonAnswerLeft_Click(object sender, EventArgs e)
        {
            allAnswer();

            if (buttonAnswerLeft.Text == Convert.ToString(result))
            {
                buttonAnswerLeft.BackColor = Color.Green;
                correctAnswerLabel();
            }
            else
            {
                buttonAnswerLeft.BackColor = Color.Red;
                wrongAnswerLabel();
            }
            timerAnswerTime.Start();
            secondAnswering = 2;
            
        }

        private void buttonAnswerRight_Click(object sender, EventArgs e)
        {
            allAnswer();

            if (buttonAnswerRight.Text == Convert.ToString(result))
            {
                buttonAnswerRight.BackColor = Color.Green;
                correctAnswerLabel();
            }
            else
            {
                buttonAnswerRight.BackColor = Color.Red;
                wrongAnswerLabel();
            }
            timerAnswerTime.Start();
            secondAnswering = 2;
        }
    }
}
