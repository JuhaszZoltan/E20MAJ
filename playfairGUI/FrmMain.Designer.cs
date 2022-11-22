namespace playfairGUI
{
    partial class FrmMain
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
            this.lblSzoveg = new System.Windows.Forms.Label();
            this.rtbElokeszitett = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblSzoveg
            // 
            this.lblSzoveg.AutoSize = true;
            this.lblSzoveg.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSzoveg.ForeColor = System.Drawing.Color.Green;
            this.lblSzoveg.Location = new System.Drawing.Point(15, 27);
            this.lblSzoveg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSzoveg.Name = "lblSzoveg";
            this.lblSzoveg.Size = new System.Drawing.Size(270, 37);
            this.lblSzoveg.TabIndex = 0;
            this.lblSzoveg.Text = "Előkészített szöveg:";
            // 
            // rtbElokeszitett
            // 
            this.rtbElokeszitett.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbElokeszitett.Location = new System.Drawing.Point(15, 93);
            this.rtbElokeszitett.Margin = new System.Windows.Forms.Padding(4);
            this.rtbElokeszitett.Name = "rtbElokeszitett";
            this.rtbElokeszitett.Size = new System.Drawing.Size(780, 261);
            this.rtbElokeszitett.TabIndex = 1;
            this.rtbElokeszitett.Text = "HI DE TH EG OL DI NT HE TR EX ES TU MP";
            this.rtbElokeszitett.TextChanged += new System.EventHandler(this.RtbElokeszitett_TextChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 367);
            this.Controls.Add(this.rtbElokeszitett);
            this.Controls.Add(this.lblSzoveg);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "playfairGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSzoveg;
        private RichTextBox rtbElokeszitett;
    }
}