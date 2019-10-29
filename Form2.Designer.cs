namespace Guess_The_Prime
{
    partial class result_form
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
            this.score = new System.Windows.Forms.Label();
            this.replay_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.scoreProgressBar = new System.Windows.Forms.ProgressBar();
            this.mAnswersList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Aqua;
            this.score.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(511, 29);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(72, 37);
            this.score.TabIndex = 1;
            this.score.Text = "5/9";
            // 
            // replay_btn
            // 
            this.replay_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(192)))), ((int)(((byte)(149)))));
            this.replay_btn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replay_btn.Location = new System.Drawing.Point(34, 393);
            this.replay_btn.Name = "replay_btn";
            this.replay_btn.Size = new System.Drawing.Size(84, 40);
            this.replay_btn.TabIndex = 2;
            this.replay_btn.Text = "Replay";
            this.replay_btn.UseVisualStyleBackColor = false;
            this.replay_btn.Click += new System.EventHandler(this.replay_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.exit_btn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(237, 393);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(84, 40);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // scoreProgressBar
            // 
            this.scoreProgressBar.Location = new System.Drawing.Point(34, 29);
            this.scoreProgressBar.Name = "scoreProgressBar";
            this.scoreProgressBar.Size = new System.Drawing.Size(454, 23);
            this.scoreProgressBar.TabIndex = 4;
            // 
            // mAnswersList
            // 
            this.mAnswersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAnswersList.Location = new System.Drawing.Point(34, 77);
            this.mAnswersList.Name = "mAnswersList";
            this.mAnswersList.Size = new System.Drawing.Size(549, 295);
            this.mAnswersList.TabIndex = 5;
            this.mAnswersList.UseCompatibleStateImageBehavior = false;
            this.mAnswersList.View = System.Windows.Forms.View.List;
            // 
            // result_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(146)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(624, 476);
            this.Controls.Add(this.mAnswersList);
            this.Controls.Add(this.scoreProgressBar);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.replay_btn);
            this.Controls.Add(this.score);
            this.Name = "result_form";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.result_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button replay_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.ProgressBar scoreProgressBar;
        private System.Windows.Forms.ListView mAnswersList;
    }
}