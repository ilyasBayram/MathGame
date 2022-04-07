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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelOperation = new System.Windows.Forms.Label();
            this.comboOperation = new System.Windows.Forms.ComboBox();
            this.comboLevel = new System.Windows.Forms.ComboBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.comboSpeed = new System.Windows.Forms.ComboBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.groupProperties = new System.Windows.Forms.GroupBox();
            this.comboTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupProperties.Controls.Add(this.button1);
            this.groupProperties.Controls.Add(this.comboTime);
            this.groupProperties.Controls.Add(this.label1);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Game time";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(92, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 57);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1027, 697);
            this.Controls.Add(this.groupProperties);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Math Game";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupProperties.ResumeLayout(false);
            this.groupProperties.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}