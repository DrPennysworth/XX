namespace XX
{
    partial class KeepGoingWindow
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
            this.btn_cum = new System.Windows.Forms.Button();
            this.btn_edge = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_cum
            // 
            this.btn_cum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cum.Location = new System.Drawing.Point(32, 54);
            this.btn_cum.Name = "btn_cum";
            this.btn_cum.Size = new System.Drawing.Size(123, 84);
            this.btn_cum.TabIndex = 0;
            this.btn_cum.Text = "Cum?";
            this.btn_cum.UseVisualStyleBackColor = true;
            this.btn_cum.Click += new System.EventHandler(this.btn_cum_Click);
            // 
            // btn_edge
            // 
            this.btn_edge.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edge.Location = new System.Drawing.Point(227, 54);
            this.btn_edge.Name = "btn_edge";
            this.btn_edge.Size = new System.Drawing.Size(123, 84);
            this.btn_edge.TabIndex = 1;
            this.btn_edge.Text = "Edge?";
            this.btn_edge.UseVisualStyleBackColor = true;
            this.btn_edge.Click += new System.EventHandler(this.btn_edge_Click);
            // 
            // KeepGoingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 201);
            this.ControlBox = false;
            this.Controls.Add(this.btn_edge);
            this.Controls.Add(this.btn_cum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeepGoingWindow";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Ultamate Choise";
            this.Load += new System.EventHandler(this.KeepGoingWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cum;
        private System.Windows.Forms.Button btn_edge;
        private System.Windows.Forms.Timer timer1;
    }
}