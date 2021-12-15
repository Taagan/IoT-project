namespace InternetProject
{
    partial class Form1
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
            this.checkboxONOFF = new System.Windows.Forms.CheckBox();
            this.tbxRed = new System.Windows.Forms.TextBox();
            this.tbxGreen = new System.Windows.Forms.TextBox();
            this.tbxBlue = new System.Windows.Forms.TextBox();
            this.tbxBrightness = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkboxSensor = new System.Windows.Forms.CheckBox();
            this.tbxSensorDistance = new System.Windows.Forms.TextBox();
            this.rbtnAway = new System.Windows.Forms.RadioButton();
            this.rbtnWithin = new System.Windows.Forms.RadioButton();
            this.richtbx = new System.Windows.Forms.RichTextBox();
            this.btnRecieveMessage = new System.Windows.Forms.Button();
            this.tbxPublish = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkboxONOFF
            // 
            this.checkboxONOFF.AutoSize = true;
            this.checkboxONOFF.Location = new System.Drawing.Point(634, 65);
            this.checkboxONOFF.Name = "checkboxONOFF";
            this.checkboxONOFF.Size = new System.Drawing.Size(67, 17);
            this.checkboxONOFF.TabIndex = 0;
            this.checkboxONOFF.Text = "ON/OFF";
            this.checkboxONOFF.UseVisualStyleBackColor = true;
            // 
            // tbxRed
            // 
            this.tbxRed.Location = new System.Drawing.Point(44, 158);
            this.tbxRed.Name = "tbxRed";
            this.tbxRed.Size = new System.Drawing.Size(100, 20);
            this.tbxRed.TabIndex = 1;
            this.tbxRed.Text = "R";
            // 
            // tbxGreen
            // 
            this.tbxGreen.Location = new System.Drawing.Point(190, 158);
            this.tbxGreen.Name = "tbxGreen";
            this.tbxGreen.Size = new System.Drawing.Size(100, 20);
            this.tbxGreen.TabIndex = 2;
            this.tbxGreen.Text = "G";
            // 
            // tbxBlue
            // 
            this.tbxBlue.Location = new System.Drawing.Point(332, 158);
            this.tbxBlue.Name = "tbxBlue";
            this.tbxBlue.Size = new System.Drawing.Size(100, 20);
            this.tbxBlue.TabIndex = 3;
            this.tbxBlue.Text = "B";
            // 
            // tbxBrightness
            // 
            this.tbxBrightness.Location = new System.Drawing.Point(601, 158);
            this.tbxBrightness.Name = "tbxBrightness";
            this.tbxBrightness.Size = new System.Drawing.Size(100, 20);
            this.tbxBrightness.TabIndex = 4;
            this.tbxBrightness.Text = "100%";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Timer",
            "Rave",
            "Rainbow"});
            this.checkedListBox1.Location = new System.Drawing.Point(24, 344);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 5;
            // 
            // checkboxSensor
            // 
            this.checkboxSensor.AutoSize = true;
            this.checkboxSensor.Location = new System.Drawing.Point(601, 271);
            this.checkboxSensor.Name = "checkboxSensor";
            this.checkboxSensor.Size = new System.Drawing.Size(86, 17);
            this.checkboxSensor.TabIndex = 7;
            this.checkboxSensor.Text = "SensorMode";
            this.checkboxSensor.UseVisualStyleBackColor = true;
            // 
            // tbxSensorDistance
            // 
            this.tbxSensorDistance.Location = new System.Drawing.Point(601, 309);
            this.tbxSensorDistance.Name = "tbxSensorDistance";
            this.tbxSensorDistance.Size = new System.Drawing.Size(100, 20);
            this.tbxSensorDistance.TabIndex = 8;
            this.tbxSensorDistance.Text = "Distance";
            // 
            // rbtnAway
            // 
            this.rbtnAway.AutoSize = true;
            this.rbtnAway.Location = new System.Drawing.Point(602, 344);
            this.rbtnAway.Name = "rbtnAway";
            this.rbtnAway.Size = new System.Drawing.Size(51, 17);
            this.rbtnAway.TabIndex = 9;
            this.rbtnAway.TabStop = true;
            this.rbtnAway.Text = "Away";
            this.rbtnAway.UseVisualStyleBackColor = true;
            // 
            // rbtnWithin
            // 
            this.rbtnWithin.AutoSize = true;
            this.rbtnWithin.Location = new System.Drawing.Point(602, 381);
            this.rbtnWithin.Name = "rbtnWithin";
            this.rbtnWithin.Size = new System.Drawing.Size(55, 17);
            this.rbtnWithin.TabIndex = 10;
            this.rbtnWithin.TabStop = true;
            this.rbtnWithin.Text = "Within";
            this.rbtnWithin.UseVisualStyleBackColor = true;
            // 
            // richtbx
            // 
            this.richtbx.Location = new System.Drawing.Point(273, 302);
            this.richtbx.Name = "richtbx";
            this.richtbx.Size = new System.Drawing.Size(100, 96);
            this.richtbx.TabIndex = 11;
            this.richtbx.Text = "";
            // 
            // btnRecieveMessage
            // 
            this.btnRecieveMessage.Location = new System.Drawing.Point(284, 273);
            this.btnRecieveMessage.Name = "btnRecieveMessage";
            this.btnRecieveMessage.Size = new System.Drawing.Size(75, 23);
            this.btnRecieveMessage.TabIndex = 12;
            this.btnRecieveMessage.Text = "Recieve";
            this.btnRecieveMessage.UseVisualStyleBackColor = true;
            this.btnRecieveMessage.Click += new System.EventHandler(this.btnRecieveMessage_Click);
            // 
            // tbxPublish
            // 
            this.tbxPublish.Location = new System.Drawing.Point(44, 268);
            this.tbxPublish.Name = "tbxPublish";
            this.tbxPublish.Size = new System.Drawing.Size(100, 20);
            this.tbxPublish.TabIndex = 13;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(56, 239);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(75, 23);
            this.btnPublish.TabIndex = 14;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.tbxPublish);
            this.Controls.Add(this.btnRecieveMessage);
            this.Controls.Add(this.richtbx);
            this.Controls.Add(this.rbtnWithin);
            this.Controls.Add(this.rbtnAway);
            this.Controls.Add(this.tbxSensorDistance);
            this.Controls.Add(this.checkboxSensor);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.tbxBrightness);
            this.Controls.Add(this.tbxBlue);
            this.Controls.Add(this.tbxGreen);
            this.Controls.Add(this.tbxRed);
            this.Controls.Add(this.checkboxONOFF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkboxONOFF;
        private System.Windows.Forms.TextBox tbxRed;
        private System.Windows.Forms.TextBox tbxGreen;
        private System.Windows.Forms.TextBox tbxBlue;
        private System.Windows.Forms.TextBox tbxBrightness;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox checkboxSensor;
        private System.Windows.Forms.TextBox tbxSensorDistance;
        private System.Windows.Forms.RadioButton rbtnAway;
        private System.Windows.Forms.RadioButton rbtnWithin;
        private System.Windows.Forms.RichTextBox richtbx;
        private System.Windows.Forms.Button btnRecieveMessage;
        private System.Windows.Forms.TextBox tbxPublish;
        private System.Windows.Forms.Button btnPublish;
    }
}

