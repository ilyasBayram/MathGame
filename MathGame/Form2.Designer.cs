namespace MathGame
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelOperation = new System.Windows.Forms.Label();
            this.comboOperation = new System.Windows.Forms.ComboBox();
            this.comboLevel = new System.Windows.Forms.ComboBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.comboSpeed = new System.Windows.Forms.ComboBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.groupProperties = new System.Windows.Forms.GroupBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboTime = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelGameTime = new System.Windows.Forms.Label();
            this.buttonAnswerLeft = new System.Windows.Forms.Button();
            this.buttonAnswerRight = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelQuestionTime = new System.Windows.Forms.Label();
            this.timerStart = new System.Windows.Forms.Timer(this.components);
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelGameMinute = new System.Windows.Forms.Label();
            this.labelGameTimeColon = new System.Windows.Forms.Label();
            this.labelGameSecond = new System.Windows.Forms.Label();
            this.labelQuestionSecond = new System.Windows.Forms.Label();
            this.timerGameTime = new System.Windows.Forms.Timer(this.components);
            this.timerQuestionTime = new System.Windows.Forms.Timer(this.components);
            this.timerAnswerTime = new System.Windows.Forms.Timer(this.components);
            this.labelCorrectAnswer = new System.Windows.Forms.Label();
            this.labelWrongAnswer = new System.Windows.Forms.Label();
            this.labelAllQuestion = new System.Windows.Forms.Label();
            this.lblNotAnswerQuestions = new System.Windows.Forms.Label();
            this.groupBoxScore = new System.Windows.Forms.GroupBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelScored = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCongurulate = new System.Windows.Forms.Label();
            this.groupProperties.SuspendLayout();
            this.groupBoxScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperation.Location = new System.Drawing.Point(33, 43);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(184, 28);
            this.labelOperation.TabIndex = 0;
            this.labelOperation.Text = "Operation type";
            // 
            // comboOperation
            // 
            this.comboOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOperation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboOperation.FormattingEnabled = true;
            this.comboOperation.Items.AddRange(new object[] {
            "Only addition",
            "Only abstraction",
            "Only multiplication",
            "Addition and abstraction",
            "All"});
            this.comboOperation.Location = new System.Drawing.Point(38, 97);
            this.comboOperation.Name = "comboOperation";
            this.comboOperation.Size = new System.Drawing.Size(267, 33);
            this.comboOperation.TabIndex = 1;
            this.comboOperation.SelectedIndexChanged += new System.EventHandler(this.comboOperation_SelectedIndexChanged);
            // 
            // comboLevel
            // 
            this.comboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboLevel.FormattingEnabled = true;
            this.comboLevel.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.comboLevel.Location = new System.Drawing.Point(38, 213);
            this.comboLevel.Name = "comboLevel";
            this.comboLevel.Size = new System.Drawing.Size(267, 33);
            this.comboLevel.TabIndex = 3;
            this.comboLevel.SelectedIndexChanged += new System.EventHandler(this.comboLevel_SelectedIndexChanged);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.Location = new System.Drawing.Point(33, 161);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(87, 28);
            this.labelLevel.TabIndex = 2;
            this.labelLevel.Text = "Levels";
            // 
            // comboSpeed
            // 
            this.comboSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboSpeed.FormattingEnabled = true;
            this.comboSpeed.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboSpeed.Location = new System.Drawing.Point(38, 353);
            this.comboSpeed.Name = "comboSpeed";
            this.comboSpeed.Size = new System.Drawing.Size(267, 33);
            this.comboSpeed.TabIndex = 5;
            this.comboSpeed.SelectedIndexChanged += new System.EventHandler(this.comboSpeed_SelectedIndexChanged);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.Location = new System.Drawing.Point(33, 301);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(157, 28);
            this.labelSpeed.TabIndex = 4;
            this.labelSpeed.Text = "Game speed";
            // 
            // groupProperties
            // 
            this.groupProperties.BackColor = System.Drawing.Color.Tan;
            this.groupProperties.Controls.Add(this.labelTime);
            this.groupProperties.Controls.Add(this.buttonStart);
            this.groupProperties.Controls.Add(this.comboTime);
            this.groupProperties.Controls.Add(this.comboSpeed);
            this.groupProperties.Controls.Add(this.labelSpeed);
            this.groupProperties.Controls.Add(this.comboLevel);
            this.groupProperties.Controls.Add(this.labelLevel);
            this.groupProperties.Controls.Add(this.comboOperation);
            this.groupProperties.Controls.Add(this.labelOperation);
            this.groupProperties.Location = new System.Drawing.Point(10, 19);
            this.groupProperties.Name = "groupProperties";
            this.groupProperties.Size = new System.Drawing.Size(357, 666);
            this.groupProperties.TabIndex = 6;
            this.groupProperties.TabStop = false;
            this.groupProperties.Text = "Properties";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(33, 440);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(136, 28);
            this.labelTime.TabIndex = 9;
            this.labelTime.Text = "Game time";
            // 
            // buttonStart
            // 
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonStart.Location = new System.Drawing.Point(76, 567);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(166, 79);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboTime
            // 
            this.comboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboTime.FormattingEnabled = true;
            this.comboTime.Items.AddRange(new object[] {
            "1 Minutes",
            "2 Minutes"});
            this.comboTime.Location = new System.Drawing.Point(38, 484);
            this.comboTime.Name = "comboTime";
            this.comboTime.Size = new System.Drawing.Size(267, 33);
            this.comboTime.TabIndex = 7;
            this.comboTime.SelectedIndexChanged += new System.EventHandler(this.comboTime_SelectedIndexChanged);
            // 
            // labelGameTime
            // 
            this.labelGameTime.AutoSize = true;
            this.labelGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGameTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGameTime.Location = new System.Drawing.Point(386, 28);
            this.labelGameTime.Name = "labelGameTime";
            this.labelGameTime.Size = new System.Drawing.Size(194, 39);
            this.labelGameTime.TabIndex = 7;
            this.labelGameTime.Text = "Game Time";
            // 
            // buttonAnswerLeft
            // 
            this.buttonAnswerLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAnswerLeft.Location = new System.Drawing.Point(445, 397);
            this.buttonAnswerLeft.Name = "buttonAnswerLeft";
            this.buttonAnswerLeft.Size = new System.Drawing.Size(198, 90);
            this.buttonAnswerLeft.TabIndex = 8;
            this.buttonAnswerLeft.Text = "36";
            this.buttonAnswerLeft.UseVisualStyleBackColor = true;
            this.buttonAnswerLeft.Click += new System.EventHandler(this.buttonAnswerLeft_Click);
            // 
            // buttonAnswerRight
            // 
            this.buttonAnswerRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAnswerRight.Location = new System.Drawing.Point(746, 397);
            this.buttonAnswerRight.Name = "buttonAnswerRight";
            this.buttonAnswerRight.Size = new System.Drawing.Size(207, 90);
            this.buttonAnswerRight.TabIndex = 9;
            this.buttonAnswerRight.Text = "38";
            this.buttonAnswerRight.UseVisualStyleBackColor = true;
            this.buttonAnswerRight.Click += new System.EventHandler(this.buttonAnswerRight_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelQuestion.Location = new System.Drawing.Point(583, 235);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(229, 69);
            this.labelQuestion.TabIndex = 10;
            this.labelQuestion.Text = "16 + 20";
            // 
            // labelQuestionTime
            // 
            this.labelQuestionTime.AutoSize = true;
            this.labelQuestionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelQuestionTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelQuestionTime.Location = new System.Drawing.Point(780, 28);
            this.labelQuestionTime.Name = "labelQuestionTime";
            this.labelQuestionTime.Size = new System.Drawing.Size(232, 39);
            this.labelQuestionTime.TabIndex = 11;
            this.labelQuestionTime.Text = "Next Question";
            // 
            // timerStart
            // 
            this.timerStart.Interval = 1000;
            this.timerStart.Tick += new System.EventHandler(this.timerStart_Tick);
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStartTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelStartTime.Location = new System.Drawing.Point(606, 235);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(166, 181);
            this.labelStartTime.TabIndex = 12;
            this.labelStartTime.Text = "3";
            // 
            // labelGameMinute
            // 
            this.labelGameMinute.AutoSize = true;
            this.labelGameMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGameMinute.Location = new System.Drawing.Point(406, 81);
            this.labelGameMinute.Name = "labelGameMinute";
            this.labelGameMinute.Size = new System.Drawing.Size(53, 37);
            this.labelGameMinute.TabIndex = 13;
            this.labelGameMinute.Text = "00";
            // 
            // labelGameTimeColon
            // 
            this.labelGameTimeColon.AutoSize = true;
            this.labelGameTimeColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGameTimeColon.Location = new System.Drawing.Point(453, 80);
            this.labelGameTimeColon.Name = "labelGameTimeColon";
            this.labelGameTimeColon.Size = new System.Drawing.Size(26, 37);
            this.labelGameTimeColon.TabIndex = 14;
            this.labelGameTimeColon.Text = ":";
            // 
            // labelGameSecond
            // 
            this.labelGameSecond.AutoSize = true;
            this.labelGameSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGameSecond.Location = new System.Drawing.Point(472, 81);
            this.labelGameSecond.Name = "labelGameSecond";
            this.labelGameSecond.Size = new System.Drawing.Size(53, 37);
            this.labelGameSecond.TabIndex = 15;
            this.labelGameSecond.Text = "00";
            // 
            // labelQuestionSecond
            // 
            this.labelQuestionSecond.AutoSize = true;
            this.labelQuestionSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelQuestionSecond.Location = new System.Drawing.Point(847, 81);
            this.labelQuestionSecond.Name = "labelQuestionSecond";
            this.labelQuestionSecond.Size = new System.Drawing.Size(53, 37);
            this.labelQuestionSecond.TabIndex = 16;
            this.labelQuestionSecond.Text = "00";
            // 
            // timerGameTime
            // 
            this.timerGameTime.Interval = 1000;
            this.timerGameTime.Tick += new System.EventHandler(this.timerGameTime_Tick_1);
            // 
            // timerQuestionTime
            // 
            this.timerQuestionTime.Interval = 1000;
            this.timerQuestionTime.Tick += new System.EventHandler(this.timerQuestionTime_Tick);
            // 
            // timerAnswerTime
            // 
            this.timerAnswerTime.Tick += new System.EventHandler(this.timerAnswerTime_Tick);
            // 
            // labelCorrectAnswer
            // 
            this.labelCorrectAnswer.AutoSize = true;
            this.labelCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCorrectAnswer.ForeColor = System.Drawing.Color.Chartreuse;
            this.labelCorrectAnswer.Location = new System.Drawing.Point(365, 150);
            this.labelCorrectAnswer.Name = "labelCorrectAnswer";
            this.labelCorrectAnswer.Size = new System.Drawing.Size(95, 36);
            this.labelCorrectAnswer.TabIndex = 17;
            this.labelCorrectAnswer.Text = "label1";
            // 
            // labelWrongAnswer
            // 
            this.labelWrongAnswer.AutoSize = true;
            this.labelWrongAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWrongAnswer.ForeColor = System.Drawing.Color.Red;
            this.labelWrongAnswer.Location = new System.Drawing.Point(364, 222);
            this.labelWrongAnswer.Name = "labelWrongAnswer";
            this.labelWrongAnswer.Size = new System.Drawing.Size(95, 36);
            this.labelWrongAnswer.TabIndex = 18;
            this.labelWrongAnswer.Text = "label1";
            // 
            // labelAllQuestion
            // 
            this.labelAllQuestion.AutoSize = true;
            this.labelAllQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAllQuestion.Location = new System.Drawing.Point(368, 77);
            this.labelAllQuestion.Name = "labelAllQuestion";
            this.labelAllQuestion.Size = new System.Drawing.Size(95, 36);
            this.labelAllQuestion.TabIndex = 19;
            this.labelAllQuestion.Text = "label1";
            // 
            // lblNotAnswerQuestions
            // 
            this.lblNotAnswerQuestions.AutoSize = true;
            this.lblNotAnswerQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNotAnswerQuestions.ForeColor = System.Drawing.Color.Sienna;
            this.lblNotAnswerQuestions.Location = new System.Drawing.Point(364, 300);
            this.lblNotAnswerQuestions.Name = "lblNotAnswerQuestions";
            this.lblNotAnswerQuestions.Size = new System.Drawing.Size(95, 36);
            this.lblNotAnswerQuestions.TabIndex = 20;
            this.lblNotAnswerQuestions.Text = "label1";
            // 
            // groupBoxScore
            // 
            this.groupBoxScore.Controls.Add(this.labelScore);
            this.groupBoxScore.Controls.Add(this.labelScored);
            this.groupBoxScore.Controls.Add(this.label4);
            this.groupBoxScore.Controls.Add(this.label3);
            this.groupBoxScore.Controls.Add(this.label2);
            this.groupBoxScore.Controls.Add(this.label1);
            this.groupBoxScore.Controls.Add(this.labelAllQuestion);
            this.groupBoxScore.Controls.Add(this.lblNotAnswerQuestions);
            this.groupBoxScore.Controls.Add(this.labelCorrectAnswer);
            this.groupBoxScore.Controls.Add(this.labelWrongAnswer);
            this.groupBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxScore.Location = new System.Drawing.Point(413, 160);
            this.groupBoxScore.Name = "groupBoxScore";
            this.groupBoxScore.Size = new System.Drawing.Size(562, 464);
            this.groupBoxScore.TabIndex = 21;
            this.groupBoxScore.TabStop = false;
            this.groupBoxScore.Text = "Scores";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelScore.Location = new System.Drawing.Point(17, 397);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(251, 40);
            this.labelScore.TabIndex = 26;
            this.labelScore.Text = "Score             :";
            // 
            // labelScored
            // 
            this.labelScored.AutoSize = true;
            this.labelScored.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelScored.ForeColor = System.Drawing.Color.Black;
            this.labelScored.Location = new System.Drawing.Point(364, 397);
            this.labelScored.Name = "labelScored";
            this.labelScored.Size = new System.Drawing.Size(113, 40);
            this.labelScored.TabIndex = 25;
            this.labelScored.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(17, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "Not Answered       :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(17, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "Wrong Answers    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(18, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Correct Answers   :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(18, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "All Questions        :";
            // 
            // labelCongurulate
            // 
            this.labelCongurulate.AutoSize = true;
            this.labelCongurulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCongurulate.ForeColor = System.Drawing.Color.BurlyWood;
            this.labelCongurulate.Location = new System.Drawing.Point(525, 65);
            this.labelCongurulate.Name = "labelCongurulate";
            this.labelCongurulate.Size = new System.Drawing.Size(316, 52);
            this.labelCongurulate.TabIndex = 22;
            this.labelCongurulate.Text = "Congurulations";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 697);
            this.Controls.Add(this.labelCongurulate);
            this.Controls.Add(this.groupBoxScore);
            this.Controls.Add(this.labelQuestionSecond);
            this.Controls.Add(this.labelGameSecond);
            this.Controls.Add(this.labelGameTimeColon);
            this.Controls.Add(this.labelGameMinute);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.labelQuestionTime);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.buttonAnswerRight);
            this.Controls.Add(this.buttonAnswerLeft);
            this.Controls.Add(this.labelGameTime);
            this.Controls.Add(this.groupProperties);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Math Game";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupProperties.ResumeLayout(false);
            this.groupProperties.PerformLayout();
            this.groupBoxScore.ResumeLayout(false);
            this.groupBoxScore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.ComboBox comboOperation;
        private System.Windows.Forms.ComboBox comboLevel;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.ComboBox comboSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.GroupBox groupProperties;
        private System.Windows.Forms.ComboBox comboTime;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelGameTime;
        private System.Windows.Forms.Button buttonAnswerLeft;
        private System.Windows.Forms.Button buttonAnswerRight;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelQuestionTime;
        private System.Windows.Forms.Timer timerStart;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelGameMinute;
        private System.Windows.Forms.Label labelGameTimeColon;
        private System.Windows.Forms.Label labelGameSecond;
        private System.Windows.Forms.Label labelQuestionSecond;
        private System.Windows.Forms.Timer timerGameTime;
        private System.Windows.Forms.Timer timerQuestionTime;
        private System.Windows.Forms.Timer timerAnswerTime;
        private System.Windows.Forms.Label labelCorrectAnswer;
        private System.Windows.Forms.Label labelWrongAnswer;
        private System.Windows.Forms.Label labelAllQuestion;
        private System.Windows.Forms.Label lblNotAnswerQuestions;
        private System.Windows.Forms.GroupBox groupBoxScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCongurulate;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelScored;
    }
}