
namespace TrackerUI
{
    partial class TournamentResultForm
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
            this.congratsLabel = new System.Windows.Forms.Label();
            this.whoWonText = new System.Windows.Forms.Label();
            this.prizeWonText = new System.Windows.Forms.Label();
            this.prizeTwoText = new System.Windows.Forms.Label();
            this.thanksForPlayingLabel = new System.Windows.Forms.Label();
            this.runnerUpText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // congratsLabel
            // 
            this.congratsLabel.AutoSize = true;
            this.congratsLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.congratsLabel.Location = new System.Drawing.Point(280, 28);
            this.congratsLabel.Name = "congratsLabel";
            this.congratsLabel.Size = new System.Drawing.Size(232, 65);
            this.congratsLabel.TabIndex = 0;
            this.congratsLabel.Text = "Congrats!";
            // 
            // whoWonText
            // 
            this.whoWonText.AutoSize = true;
            this.whoWonText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whoWonText.Location = new System.Drawing.Point(280, 120);
            this.whoWonText.Name = "whoWonText";
            this.whoWonText.Size = new System.Drawing.Size(220, 37);
            this.whoWonText.TabIndex = 1;
            this.whoWonText.Text = "<someone won>";
            // 
            // prizeWonText
            // 
            this.prizeWonText.AutoSize = true;
            this.prizeWonText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizeWonText.Location = new System.Drawing.Point(325, 157);
            this.prizeWonText.Name = "prizeWonText";
            this.prizeWonText.Size = new System.Drawing.Size(133, 37);
            this.prizeWonText.TabIndex = 2;
            this.prizeWonText.Text = "<prize 1>";
            // 
            // prizeTwoText
            // 
            this.prizeTwoText.AutoSize = true;
            this.prizeTwoText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizeTwoText.Location = new System.Drawing.Point(325, 262);
            this.prizeTwoText.Name = "prizeTwoText";
            this.prizeTwoText.Size = new System.Drawing.Size(133, 37);
            this.prizeTwoText.TabIndex = 3;
            this.prizeTwoText.Text = "<prize 2>";
            // 
            // thanksForPlayingLabel
            // 
            this.thanksForPlayingLabel.AutoSize = true;
            this.thanksForPlayingLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thanksForPlayingLabel.Location = new System.Drawing.Point(280, 318);
            this.thanksForPlayingLabel.Name = "thanksForPlayingLabel";
            this.thanksForPlayingLabel.Size = new System.Drawing.Size(247, 37);
            this.thanksForPlayingLabel.TabIndex = 4;
            this.thanksForPlayingLabel.Text = "Thanks For playing!";
            // 
            // runnerUpText
            // 
            this.runnerUpText.AutoSize = true;
            this.runnerUpText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.runnerUpText.Location = new System.Drawing.Point(292, 225);
            this.runnerUpText.Name = "runnerUpText";
            this.runnerUpText.Size = new System.Drawing.Size(220, 37);
            this.runnerUpText.TabIndex = 5;
            this.runnerUpText.Text = "<someone won>";
            // 
            // TournamentResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.runnerUpText);
            this.Controls.Add(this.thanksForPlayingLabel);
            this.Controls.Add(this.prizeTwoText);
            this.Controls.Add(this.prizeWonText);
            this.Controls.Add(this.whoWonText);
            this.Controls.Add(this.congratsLabel);
            this.Name = "TournamentResultForm";
            this.Text = "TournamentResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label congratsLabel;
        private System.Windows.Forms.Label whoWonText;
        private System.Windows.Forms.Label prizeWonText;
        private System.Windows.Forms.Label prizeTwoText;
        private System.Windows.Forms.Label thanksForPlayingLabel;
        private System.Windows.Forms.Label runnerUpText;
    }
}