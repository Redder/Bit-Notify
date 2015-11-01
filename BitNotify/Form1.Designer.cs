namespace BitNotify
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
            this.components = new System.ComponentModel.Container();
            this.srtBtn = new MetroFramework.Controls.MetroButton();
            this.stopBtn = new MetroFramework.Controls.MetroButton();
            this.currencyComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.intervalComboBox = new MetroFramework.Controls.MetroComboBox();
            this.valueLabel = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // srtBtn
            // 
            this.srtBtn.Location = new System.Drawing.Point(23, 288);
            this.srtBtn.Name = "srtBtn";
            this.srtBtn.Size = new System.Drawing.Size(127, 23);
            this.srtBtn.TabIndex = 0;
            this.srtBtn.Text = "Start";
            this.srtBtn.UseSelectable = true;
            this.srtBtn.Click += new System.EventHandler(this.srtBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(242, 288);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(127, 23);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseSelectable = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.ItemHeight = 23;
            this.currencyComboBox.Items.AddRange(new object[] {
            "USD"});
            this.currencyComboBox.Location = new System.Drawing.Point(111, 74);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(187, 29);
            this.currencyComboBox.TabIndex = 2;
            this.currencyComboBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 115);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Interval (m)";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Currency";
            // 
            // intervalComboBox
            // 
            this.intervalComboBox.FormattingEnabled = true;
            this.intervalComboBox.ItemHeight = 23;
            this.intervalComboBox.Items.AddRange(new object[] {
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
            this.intervalComboBox.Location = new System.Drawing.Point(111, 109);
            this.intervalComboBox.Name = "intervalComboBox";
            this.intervalComboBox.Size = new System.Drawing.Size(187, 29);
            this.intervalComboBox.TabIndex = 5;
            this.intervalComboBox.UseSelectable = true;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valueLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.valueLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.valueLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.valueLabel.Location = new System.Drawing.Point(111, 189);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(54, 25);
            this.valueLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.valueLabel.TabIndex = 6;
            this.valueLabel.Text = "Value";
            this.valueLabel.UseStyleColors = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 327);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.intervalComboBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.currencyComboBox);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.srtBtn);
            this.Name = "Form1";
            this.Text = "Bit Notify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton srtBtn;
        private MetroFramework.Controls.MetroButton stopBtn;
        private MetroFramework.Controls.MetroComboBox currencyComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox intervalComboBox;
        private MetroFramework.Controls.MetroLabel valueLabel;
        private System.Windows.Forms.Timer timer1;

    }
}

