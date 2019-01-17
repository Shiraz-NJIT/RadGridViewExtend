namespace TelereikRadGridViewExtended
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
            this.radGridViewExtended1 = new Njit.Program.Telerik.Controls.RadGridViewExtended();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewExtended1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewExtended1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridViewExtended1
            // 
            this.radGridViewExtended1.Location = new System.Drawing.Point(32, 35);
            this.radGridViewExtended1.Name = "radGridViewExtended1";
            this.radGridViewExtended1.Size = new System.Drawing.Size(240, 150);
            this.radGridViewExtended1.TabIndex = 0;
            this.radGridViewExtended1.Text = "radGridViewExtended1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.radGridViewExtended1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewExtended1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewExtended1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Njit.Program.Telerik.Controls.RadGridViewExtended radGridViewExtended1;
    }
}