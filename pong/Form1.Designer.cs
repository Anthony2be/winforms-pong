namespace pong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pong1 = new System.Windows.Forms.TextBox();
            this.pong2 = new System.Windows.Forms.TextBox();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.TextBox();
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // pong1
            // 
            this.pong1.Enabled = false;
            this.pong1.Location = new System.Drawing.Point(55, 138);
            this.pong1.Multiline = true;
            this.pong1.Name = "pong1";
            this.pong1.ReadOnly = true;
            this.pong1.Size = new System.Drawing.Size(20, 142);
            this.pong1.TabIndex = 0;
            // 
            // pong2
            // 
            this.pong2.Enabled = false;
            this.pong2.Location = new System.Drawing.Point(726, 129);
            this.pong2.Multiline = true;
            this.pong2.Name = "pong2";
            this.pong2.ReadOnly = true;
            this.pong2.Size = new System.Drawing.Size(20, 142);
            this.pong2.TabIndex = 1;
            // 
            // inputbox
            // 
            this.inputbox.BackColor = System.Drawing.Color.Black;
            this.inputbox.ForeColor = System.Drawing.Color.Black;
            this.inputbox.Location = new System.Drawing.Point(12, 407);
            this.inputbox.Margin = new System.Windows.Forms.Padding(0);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(0, 31);
            this.inputbox.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ball
            // 
            this.ball.Enabled = false;
            this.ball.ForeColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(110, 195);
            this.ball.Name = "ball";
            this.ball.ReadOnly = true;
            this.ball.Size = new System.Drawing.Size(31, 31);
            this.ball.TabIndex = 3;
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score1.ForeColor = System.Drawing.Color.White;
            this.score1.Location = new System.Drawing.Point(55, 37);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(98, 32);
            this.score1.TabIndex = 4;
            this.score1.Text = "Score: 0";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score2.ForeColor = System.Drawing.Color.White;
            this.score2.Location = new System.Drawing.Point(648, 37);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(98, 32);
            this.score2.TabIndex = 5;
            this.score2.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.pong2);
            this.Controls.Add(this.pong1);
            this.Name = "Form1";
            this.Text = "Pong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox pong1;
        private TextBox pong2;
        private TextBox inputbox;
        private System.Windows.Forms.Timer timer1;
        private TextBox ball;
        private Label score1;
        private Label score2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}