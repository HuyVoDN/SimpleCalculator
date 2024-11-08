namespace SimpleCalculator
{
    partial class Calculator
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
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.PnlHistory = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(434, 72);
            this.PnlTitle.TabIndex = 0;
            this.PnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PnlHistory
            // 
            this.PnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlHistory.Location = new System.Drawing.Point(0, 459);
            this.PnlHistory.Name = "PnlHistory";
            this.PnlHistory.Size = new System.Drawing.Size(434, 72);
            this.PnlHistory.TabIndex = 1;
            this.PnlHistory.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(434, 531);
            this.Controls.Add(this.PnlTitle);
            this.Controls.Add(this.PnlHistory);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Panel PnlHistory;
    }
}

