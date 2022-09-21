namespace TicTacToeDriver
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.twoPlayer = new System.Windows.Forms.Button();
            this.onePlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(303, 39);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(322, 69);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "TicTacToe";
            // 
            // twoPlayer
            // 
            this.twoPlayer.Location = new System.Drawing.Point(388, 207);
            this.twoPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.twoPlayer.Name = "twoPlayer";
            this.twoPlayer.Size = new System.Drawing.Size(157, 75);
            this.twoPlayer.TabIndex = 1;
            this.twoPlayer.Text = "Pass and Play";
            this.twoPlayer.UseVisualStyleBackColor = true;
            this.twoPlayer.Click += new System.EventHandler(this.twoPlayer_Click);
            // 
            // onePlayer
            // 
            this.onePlayer.Location = new System.Drawing.Point(388, 356);
            this.onePlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.onePlayer.Name = "onePlayer";
            this.onePlayer.Size = new System.Drawing.Size(157, 74);
            this.onePlayer.TabIndex = 2;
            this.onePlayer.Text = "Versus AI";
            this.onePlayer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 554);
            this.Controls.Add(this.onePlayer);
            this.Controls.Add(this.twoPlayer);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button twoPlayer;
        private System.Windows.Forms.Button onePlayer;
    }
}

