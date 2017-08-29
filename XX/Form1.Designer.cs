namespace XX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar_climaxProgress = new System.Windows.Forms.ProgressBar();
            this.deClimaxer = new System.Windows.Forms.Timer(this.components);
            this.resetProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(80, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 123);
            this.button1.TabIndex = 0;
            this.button1.Text = "Beat off to XX";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar_climaxProgress
            // 
            this.progressBar_climaxProgress.Location = new System.Drawing.Point(12, 206);
            this.progressBar_climaxProgress.Maximum = 200;
            this.progressBar_climaxProgress.Name = "progressBar_climaxProgress";
            this.progressBar_climaxProgress.Size = new System.Drawing.Size(370, 63);
            this.progressBar_climaxProgress.TabIndex = 1;
            // 
            // deClimaxer
            // 
            this.deClimaxer.Enabled = true;
            this.deClimaxer.Tick += new System.EventHandler(this.deClimaxer_Tick);
            // 
            // resetProgressTimer
            // 
            this.resetProgressTimer.Tick += new System.EventHandler(this.resetProgressTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 334);
            this.Controls.Add(this.progressBar_climaxProgress);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I love you XX";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar_climaxProgress;
        private System.Windows.Forms.Timer deClimaxer;
        private System.Windows.Forms.Timer resetProgressTimer;
    }
}

