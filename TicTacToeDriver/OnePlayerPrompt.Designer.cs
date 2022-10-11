namespace TicTacToeDriver
{
    partial class OnePlayerPrompt
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
            this.xRadioButton = new System.Windows.Forms.RadioButton();
            this.oRadioButton = new System.Windows.Forms.RadioButton();
            this.difficultyTrackBar = new System.Windows.Forms.TrackBar();
            this.btnBegin = new System.Windows.Forms.Button();
            this.sideLabel = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // xRadioButton
            // 
            this.xRadioButton.AutoSize = true;
            this.xRadioButton.Location = new System.Drawing.Point(335, 97);
            this.xRadioButton.Name = "xRadioButton";
            this.xRadioButton.Size = new System.Drawing.Size(32, 17);
            this.xRadioButton.TabIndex = 0;
            this.xRadioButton.TabStop = true;
            this.xRadioButton.Text = "X";
            this.xRadioButton.UseVisualStyleBackColor = true;
            // 
            // oRadioButton
            // 
            this.oRadioButton.AutoSize = true;
            this.oRadioButton.Location = new System.Drawing.Point(388, 97);
            this.oRadioButton.Name = "oRadioButton";
            this.oRadioButton.Size = new System.Drawing.Size(33, 17);
            this.oRadioButton.TabIndex = 1;
            this.oRadioButton.TabStop = true;
            this.oRadioButton.Text = "O";
            this.oRadioButton.UseVisualStyleBackColor = true;
            // 
            // difficultyTrackBar
            // 
            this.difficultyTrackBar.Location = new System.Drawing.Point(145, 233);
            this.difficultyTrackBar.Maximum = 100;
            this.difficultyTrackBar.Name = "difficultyTrackBar";
            this.difficultyTrackBar.Size = new System.Drawing.Size(484, 45);
            this.difficultyTrackBar.TabIndex = 2;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(335, 317);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 23);
            this.btnBegin.TabIndex = 3;
            this.btnBegin.Text = "Begin";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // sideLabel
            // 
            this.sideLabel.AutoSize = true;
            this.sideLabel.Location = new System.Drawing.Point(332, 33);
            this.sideLabel.Name = "sideLabel";
            this.sideLabel.Size = new System.Drawing.Size(89, 13);
            this.sideLabel.TabIndex = 4;
            this.sideLabel.Text = "Select Your Side:";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(332, 185);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(83, 13);
            this.difficultyLabel.TabIndex = 5;
            this.difficultyLabel.Text = "Select Difficulty:";
            // 
            // OnePlayerPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.sideLabel);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.difficultyTrackBar);
            this.Controls.Add(this.oRadioButton);
            this.Controls.Add(this.xRadioButton);
            this.Name = "OnePlayerPrompt";
            this.Text = "OnePlayerPrompt";
            ((System.ComponentModel.ISupportInitialize)(this.difficultyTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label sideLabel;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.RadioButton xRadioButton;
        private System.Windows.Forms.RadioButton oRadioButton;
        private System.Windows.Forms.TrackBar difficultyTrackBar;
    }
}