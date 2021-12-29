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
            this.brightSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBri = new System.Windows.Forms.GroupBox();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timecbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.brightSlider)).BeginInit();
            this.grpBri.SuspendLayout();
            this.grpColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkboxONOFF
            // 
            this.checkboxONOFF.AutoSize = true;
            this.checkboxONOFF.Location = new System.Drawing.Point(845, 80);
            this.checkboxONOFF.Margin = new System.Windows.Forms.Padding(4);
            this.checkboxONOFF.Name = "checkboxONOFF";
            this.checkboxONOFF.Size = new System.Drawing.Size(82, 21);
            this.checkboxONOFF.TabIndex = 0;
            this.checkboxONOFF.Text = "ON/OFF";
            this.checkboxONOFF.UseVisualStyleBackColor = true;
            this.checkboxONOFF.CheckedChanged += new System.EventHandler(this.checkboxONOFF_CheckedChanged);
            // 
            // tbxRed
            // 
            this.tbxRed.Location = new System.Drawing.Point(59, 194);
            this.tbxRed.Margin = new System.Windows.Forms.Padding(4);
            this.tbxRed.Name = "tbxRed";
            this.tbxRed.Size = new System.Drawing.Size(132, 22);
            this.tbxRed.TabIndex = 1;
            this.tbxRed.Text = "R";
            // 
            // tbxGreen
            // 
            this.tbxGreen.Location = new System.Drawing.Point(253, 194);
            this.tbxGreen.Margin = new System.Windows.Forms.Padding(4);
            this.tbxGreen.Name = "tbxGreen";
            this.tbxGreen.Size = new System.Drawing.Size(132, 22);
            this.tbxGreen.TabIndex = 2;
            this.tbxGreen.Text = "G";
            // 
            // tbxBlue
            // 
            this.tbxBlue.Location = new System.Drawing.Point(443, 194);
            this.tbxBlue.Margin = new System.Windows.Forms.Padding(4);
            this.tbxBlue.Name = "tbxBlue";
            this.tbxBlue.Size = new System.Drawing.Size(132, 22);
            this.tbxBlue.TabIndex = 3;
            this.tbxBlue.Text = "B";
            // 
            // tbxBrightness
            // 
            this.tbxBrightness.Location = new System.Drawing.Point(107, 37);
            this.tbxBrightness.Margin = new System.Windows.Forms.Padding(4);
            this.tbxBrightness.Name = "tbxBrightness";
            this.tbxBrightness.ReadOnly = true;
            this.tbxBrightness.Size = new System.Drawing.Size(132, 22);
            this.tbxBrightness.TabIndex = 4;
            this.tbxBrightness.Text = "10%";
            this.tbxBrightness.TextChanged += new System.EventHandler(this.tbxBrightness_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Rave",
            "Rainbow"});
            this.checkedListBox1.Location = new System.Drawing.Point(32, 423);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(159, 106);
            this.checkedListBox1.TabIndex = 5;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // checkboxSensor
            // 
            this.checkboxSensor.AutoSize = true;
            this.checkboxSensor.Location = new System.Drawing.Point(801, 334);
            this.checkboxSensor.Margin = new System.Windows.Forms.Padding(4);
            this.checkboxSensor.Name = "checkboxSensor";
            this.checkboxSensor.Size = new System.Drawing.Size(110, 21);
            this.checkboxSensor.TabIndex = 7;
            this.checkboxSensor.Text = "SensorMode";
            this.checkboxSensor.UseVisualStyleBackColor = true;
            this.checkboxSensor.CheckedChanged += new System.EventHandler(this.checkboxSensor_CheckedChanged);
            // 
            // tbxSensorDistance
            // 
            this.tbxSensorDistance.Location = new System.Drawing.Point(801, 380);
            this.tbxSensorDistance.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSensorDistance.Name = "tbxSensorDistance";
            this.tbxSensorDistance.Size = new System.Drawing.Size(132, 22);
            this.tbxSensorDistance.TabIndex = 8;
            this.tbxSensorDistance.Text = "Distance";
            // 
            // rbtnAway
            // 
            this.rbtnAway.AutoSize = true;
            this.rbtnAway.Location = new System.Drawing.Point(803, 423);
            this.rbtnAway.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnAway.Name = "rbtnAway";
            this.rbtnAway.Size = new System.Drawing.Size(62, 21);
            this.rbtnAway.TabIndex = 9;
            this.rbtnAway.TabStop = true;
            this.rbtnAway.Text = "Away";
            this.rbtnAway.UseVisualStyleBackColor = true;
            this.rbtnAway.CheckedChanged += new System.EventHandler(this.rbtnAway_CheckedChanged);
            // 
            // rbtnWithin
            // 
            this.rbtnWithin.AutoSize = true;
            this.rbtnWithin.Location = new System.Drawing.Point(803, 469);
            this.rbtnWithin.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnWithin.Name = "rbtnWithin";
            this.rbtnWithin.Size = new System.Drawing.Size(68, 21);
            this.rbtnWithin.TabIndex = 10;
            this.rbtnWithin.TabStop = true;
            this.rbtnWithin.Text = "Within";
            this.rbtnWithin.UseVisualStyleBackColor = true;
            // 
            // richtbx
            // 
            this.richtbx.Location = new System.Drawing.Point(364, 372);
            this.richtbx.Margin = new System.Windows.Forms.Padding(4);
            this.richtbx.Name = "richtbx";
            this.richtbx.Size = new System.Drawing.Size(132, 117);
            this.richtbx.TabIndex = 11;
            this.richtbx.Text = "";
            // 
            // btnRecieveMessage
            // 
            this.btnRecieveMessage.Location = new System.Drawing.Point(379, 336);
            this.btnRecieveMessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecieveMessage.Name = "btnRecieveMessage";
            this.btnRecieveMessage.Size = new System.Drawing.Size(100, 28);
            this.btnRecieveMessage.TabIndex = 12;
            this.btnRecieveMessage.Text = "Recieve";
            this.btnRecieveMessage.UseVisualStyleBackColor = true;
            this.btnRecieveMessage.Click += new System.EventHandler(this.btnRecieveMessage_Click);
            // 
            // tbxPublish
            // 
            this.tbxPublish.Location = new System.Drawing.Point(59, 330);
            this.tbxPublish.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPublish.Name = "tbxPublish";
            this.tbxPublish.Size = new System.Drawing.Size(132, 22);
            this.tbxPublish.TabIndex = 13;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(75, 294);
            this.btnPublish.Margin = new System.Windows.Forms.Padding(4);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(100, 28);
            this.btnPublish.TabIndex = 14;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // brightSlider
            // 
            this.brightSlider.AutoSize = false;
            this.brightSlider.Location = new System.Drawing.Point(720, 194);
            this.brightSlider.Maximum = 9;
            this.brightSlider.Name = "brightSlider";
            this.brightSlider.Size = new System.Drawing.Size(213, 56);
            this.brightSlider.TabIndex = 15;
            this.brightSlider.Scroll += new System.EventHandler(this.brightSlider_Scroll);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(731, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "10                    50               100";
            // 
            // grpBri
            // 
            this.grpBri.Controls.Add(this.tbxBrightness);
            this.grpBri.Location = new System.Drawing.Point(688, 128);
            this.grpBri.Name = "grpBri";
            this.grpBri.Size = new System.Drawing.Size(260, 155);
            this.grpBri.TabIndex = 17;
            this.grpBri.TabStop = false;
            this.grpBri.Text = "Brightness";
            // 
            // grpColor
            // 
            this.grpColor.Controls.Add(this.comboBox1);
            this.grpColor.Location = new System.Drawing.Point(48, 128);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(607, 155);
            this.grpColor.TabIndex = 18;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "RED",
            "BLUE",
            "GREEN",
            "WHITE",
            "PURPLE",
            "YELLOW",
            "ORANGE"});
            this.comboBox1.Location = new System.Drawing.Point(11, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Timer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Start time";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timecbx
            // 
            this.timecbx.FormattingEnabled = true;
            this.timecbx.Items.AddRange(new object[] {
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
            this.timecbx.Location = new System.Drawing.Point(32, 394);
            this.timecbx.Name = "timecbx";
            this.timecbx.Size = new System.Drawing.Size(121, 24);
            this.timecbx.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.timecbx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brightSlider);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.tbxPublish);
            this.Controls.Add(this.btnRecieveMessage);
            this.Controls.Add(this.richtbx);
            this.Controls.Add(this.rbtnWithin);
            this.Controls.Add(this.rbtnAway);
            this.Controls.Add(this.tbxSensorDistance);
            this.Controls.Add(this.checkboxSensor);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.tbxBlue);
            this.Controls.Add(this.tbxGreen);
            this.Controls.Add(this.tbxRed);
            this.Controls.Add(this.checkboxONOFF);
            this.Controls.Add(this.grpBri);
            this.Controls.Add(this.grpColor);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.brightSlider)).EndInit();
            this.grpBri.ResumeLayout(false);
            this.grpBri.PerformLayout();
            this.grpColor.ResumeLayout(false);
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
        private System.Windows.Forms.TrackBar brightSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBri;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox timecbx;
    }
}

