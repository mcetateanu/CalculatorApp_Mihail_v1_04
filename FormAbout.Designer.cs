namespace CalculatorApp_Mihail_v1_04
{
    partial class FormAbout
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
            this.LabelAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelAbout
            // 
            this.LabelAbout.AutoSize = true;
            this.LabelAbout.Location = new System.Drawing.Point(151, 146);
            this.LabelAbout.Name = "LabelAbout";
            this.LabelAbout.Size = new System.Drawing.Size(628, 17);
            this.LabelAbout.TabIndex = 0;
            this.LabelAbout.Text = "Acest label este un controller ce doar afiseaza text pt utilizator: aplicatie cal" +
    "culator, creata de, etc).";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelAbout);
            this.Name = "FormAbout";
            this.Text = "About:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAbout;
    }
}