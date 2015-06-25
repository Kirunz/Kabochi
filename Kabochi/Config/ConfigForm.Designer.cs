namespace Config
{
    partial class ConfigForm
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
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.btnDown1 = new System.Windows.Forms.TextBox();
            this.btnLeft1 = new System.Windows.Forms.TextBox();
            this.btnRight1 = new System.Windows.Forms.TextBox();
            this.btnShoot1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnShoot2 = new System.Windows.Forms.TextBox();
            this.btnRight2 = new System.Windows.Forms.TextBox();
            this.btnLeft2 = new System.Windows.Forms.TextBox();
            this.btnDown2 = new System.Windows.Forms.TextBox();
            this.btnUp2 = new System.Windows.Forms.TextBox();
            this.testLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.musicBar = new System.Windows.Forms.TrackBar();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.btnUp1 = new System.Windows.Forms.TextBox();
            this.volumeOn = new System.Windows.Forms.CheckBox();
            this.musicOn = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicBar)).BeginInit();
            this.SuspendLayout();
            // 
            // volumeBar
            // 
            this.volumeBar.LargeChange = 10;
            this.volumeBar.Location = new System.Drawing.Point(16, 279);
            this.volumeBar.Margin = new System.Windows.Forms.Padding(4);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(189, 56);
            this.volumeBar.TabIndex = 2;
            // 
            // btnDown1
            // 
            this.btnDown1.Location = new System.Drawing.Point(16, 92);
            this.btnDown1.Margin = new System.Windows.Forms.Padding(4);
            this.btnDown1.Name = "btnDown1";
            this.btnDown1.Size = new System.Drawing.Size(132, 22);
            this.btnDown1.TabIndex = 4;
            this.btnDown1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.controlBtnUp);
            // 
            // btnLeft1
            // 
            this.btnLeft1.Location = new System.Drawing.Point(16, 126);
            this.btnLeft1.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeft1.Name = "btnLeft1";
            this.btnLeft1.Size = new System.Drawing.Size(132, 22);
            this.btnLeft1.TabIndex = 5;
            this.btnLeft1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.controlBtnUp);
            // 
            // btnRight1
            // 
            this.btnRight1.Location = new System.Drawing.Point(16, 159);
            this.btnRight1.Margin = new System.Windows.Forms.Padding(4);
            this.btnRight1.Name = "btnRight1";
            this.btnRight1.Size = new System.Drawing.Size(132, 22);
            this.btnRight1.TabIndex = 6;
            this.btnRight1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.controlBtnUp);
            // 
            // btnShoot1
            // 
            this.btnShoot1.Location = new System.Drawing.Point(16, 192);
            this.btnShoot1.Margin = new System.Windows.Forms.Padding(4);
            this.btnShoot1.Name = "btnShoot1";
            this.btnShoot1.Size = new System.Drawing.Size(132, 22);
            this.btnShoot1.TabIndex = 7;
            this.btnShoot1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.controlBtnUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Button Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Button Down";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Button Left";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Button right";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Button Shoot";
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Location = new System.Drawing.Point(59, 11);
            this.Player1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(60, 17);
            this.Player1.TabIndex = 13;
            this.Player1.Text = "Player 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Player 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(496, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Button Shoot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Button right";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(496, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Button Left";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(496, 92);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Button Down";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(496, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Button Up";
            // 
            // btnShoot2
            // 
            this.btnShoot2.Location = new System.Drawing.Point(323, 192);
            this.btnShoot2.Margin = new System.Windows.Forms.Padding(4);
            this.btnShoot2.Name = "btnShoot2";
            this.btnShoot2.Size = new System.Drawing.Size(132, 22);
            this.btnShoot2.TabIndex = 18;
            this.btnShoot2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.controlBtnUp);
            // 
            // btnRight2
            // 
            this.btnRight2.Location = new System.Drawing.Point(323, 159);
            this.btnRight2.Margin = new System.Windows.Forms.Padding(4);
            this.btnRight2.Name = "btnRight2";
            this.btnRight2.Size = new System.Drawing.Size(132, 22);
            this.btnRight2.TabIndex = 17;
            this.btnRight2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.controlBtnUp);
            // 
            // btnLeft2
            // 
            this.btnLeft2.Location = new System.Drawing.Point(323, 126);
            this.btnLeft2.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeft2.Name = "btnLeft2";
            this.btnLeft2.Size = new System.Drawing.Size(132, 22);
            this.btnLeft2.TabIndex = 16;
            this.btnLeft2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.controlBtnUp);
            // 
            // btnDown2
            // 
            this.btnDown2.Location = new System.Drawing.Point(323, 92);
            this.btnDown2.Margin = new System.Windows.Forms.Padding(4);
            this.btnDown2.Name = "btnDown2";
            this.btnDown2.Size = new System.Drawing.Size(132, 22);
            this.btnDown2.TabIndex = 15;
            this.btnDown2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.controlBtnUp);
            // 
            // btnUp2
            // 
            this.btnUp2.Location = new System.Drawing.Point(323, 60);
            this.btnUp2.Margin = new System.Windows.Forms.Padding(4);
            this.btnUp2.Name = "btnUp2";
            this.btnUp2.Size = new System.Drawing.Size(132, 22);
            this.btnUp2.TabIndex = 14;
            this.btnUp2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.controlBtnUp);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(213, 279);
            this.testLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(100, 17);
            this.testLabel.TabIndex = 25;
            this.testLabel.Text = "Sound Volume";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 379);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 26;
            this.button1.Text = "Save config";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(213, 343);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Music Volume";
            // 
            // musicBar
            // 
            this.musicBar.LargeChange = 10;
            this.musicBar.Location = new System.Drawing.Point(16, 343);
            this.musicBar.Margin = new System.Windows.Forms.Padding(4);
            this.musicBar.Maximum = 100;
            this.musicBar.Name = "musicBar";
            this.musicBar.Size = new System.Drawing.Size(189, 56);
            this.musicBar.TabIndex = 27;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(16, 237);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(189, 22);
            this.nameTextBox.TabIndex = 29;
            // 
            // btnUp1
            // 
            this.btnUp1.Location = new System.Drawing.Point(16, 55);
            this.btnUp1.Margin = new System.Windows.Forms.Padding(4);
            this.btnUp1.Name = "btnUp1";
            this.btnUp1.Size = new System.Drawing.Size(132, 22);
            this.btnUp1.TabIndex = 3;
            this.btnUp1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.controlBtnUp);
            // 
            // volumeOn
            // 
            this.volumeOn.AutoSize = true;
            this.volumeOn.Location = new System.Drawing.Point(321, 279);
            this.volumeOn.Name = "volumeOn";
            this.volumeOn.Size = new System.Drawing.Size(94, 21);
            this.volumeOn.TabIndex = 31;
            this.volumeOn.Text = "Sound On";
            this.volumeOn.UseVisualStyleBackColor = true;
            this.volumeOn.CheckedChanged += new System.EventHandler(this.volumeOn_CheckedChanged);
            // 
            // musicOn
            // 
            this.musicOn.AutoSize = true;
            this.musicOn.Location = new System.Drawing.Point(321, 339);
            this.musicOn.Name = "musicOn";
            this.musicOn.Size = new System.Drawing.Size(89, 21);
            this.musicOn.TabIndex = 32;
            this.musicOn.Text = "Music On";
            this.musicOn.UseVisualStyleBackColor = true;
            this.musicOn.CheckedChanged += new System.EventHandler(this.musicOn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 500);
            this.Controls.Add(this.musicOn);
            this.Controls.Add(this.volumeOn);
            this.Controls.Add(this.btnUp1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.musicBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnShoot2);
            this.Controls.Add(this.btnRight2);
            this.Controls.Add(this.btnLeft2);
            this.Controls.Add(this.btnDown2);
            this.Controls.Add(this.btnUp2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShoot1);
            this.Controls.Add(this.btnRight1);
            this.Controls.Add(this.btnLeft1);
            this.Controls.Add(this.btnDown1);
            this.Controls.Add(this.volumeBar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.TextBox btnDown1;
        private System.Windows.Forms.TextBox btnLeft1;
        private System.Windows.Forms.TextBox btnRight1;
        private System.Windows.Forms.TextBox btnShoot1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox btnShoot2;
        private System.Windows.Forms.TextBox btnRight2;
        private System.Windows.Forms.TextBox btnLeft2;
        private System.Windows.Forms.TextBox btnDown2;
        private System.Windows.Forms.TextBox btnUp2;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar musicBar;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox btnUp1;
        private System.Windows.Forms.CheckBox volumeOn;
        private System.Windows.Forms.CheckBox musicOn;
    }
}

