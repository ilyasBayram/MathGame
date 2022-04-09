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
            this.answerLeft = new System.Windows.Forms.Button();
            this.answerRight = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelQuestionTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelStartTime = new System.Windows.Forms.Label();
            this.groupProperties.SuspendLayout();
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
            "Only abstarction",
            "Only division",
            "Only multiplication",
            "Addition  and abstarction",
            "Division and multipliciation",
            "All "});
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
            "Midium",
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
            "No speed",
            "1",
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
            "30 seconds",
            "1 Minutes",
            "1.5 Minutes",
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
            this.labelGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGameTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGameTime.Location = new System.Drawing.Point(401, 28);
            this.labelGameTime.Name = "labelGameTime";
            this.labelGameTime.Size = new System.Drawing.Size(148, 30);
            this.labelGameTime.TabIndex = 7;
            this.labelGameTime.Text = "Game Time";
            // 
            // answerLeft
            // 
            this.answerLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.answerLeft.Location = new System.Drawing.Point(445, 397);
            this.answerLeft.Name = "answerLeft";
            this.answerLeft.Size = new System.Drawing.Size(198, 90);
            this.answerLeft.TabIndex = 8;
            this.answerLeft.Text = "36";
            this.answerLeft.UseVisualStyleBackColor = true;
            // 
            // answerRight
            // 
            this.answerRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.answerRight.Location = new System.Drawing.Point(746, 397);
            this.answerRight.Name = "answerRight";
            this.answerRight.Size = new System.Drawing.Size(207, 90);
            this.answerRight.TabIndex = 9;
            this.answerRight.Text = "38";
            this.answerRight.UseVisualStyleBackColor = true;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelQuestion.Location = new System.Drawing.Point(573, 235);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(229, 69);
            this.labelQuestion.TabIndex = 10;
            this.labelQuestion.Text = "16 + 20";
            // 
            // labelQuestionTime
            // 
            this.labelQuestionTime.AutoSize = true;
            this.labelQuestionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelQuestionTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelQuestionTime.Location = new System.Drawing.Point(741, 28);
            this.labelQuestionTime.Name = "labelQuestionTime";
            this.labelQuestionTime.Size = new System.Drawing.Size(265, 30);
            this.labelQuestionTime.TabIndex = 11;
            this.labelQuestionTime.Text = "Time for next question";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 697);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.labelQuestionTime);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.answerRight);
            this.Controls.Add(this.answerLeft);
            this.Controls.Add(this.labelGameTime);
            this.Controls.Add(this.groupProperties);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Math Game";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupProperties.ResumeLayout(false);
            this.groupProperties.PerformLayout();
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
        private System.Windows.Forms.Button answerLeft;
        private System.Windows.Forms.Button answerRight;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelQuestionTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelStartTime;
    }
}