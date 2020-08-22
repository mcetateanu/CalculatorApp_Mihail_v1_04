namespace CalculatorApp_Mihail_v1_04
{
    partial class FormCalculator
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
            this.ButonAdunare = new System.Windows.Forms.Button();
            this.ButonScadere = new System.Windows.Forms.Button();
            this.ButonInmultire = new System.Windows.Forms.Button();
            this.ButonImpartire = new System.Windows.Forms.Button();
            this.TextBoxRezultat = new System.Windows.Forms.TextBox();
            this.NumericUpDownTermen1 = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownTermen2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTermen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTermen2)).BeginInit();
            this.SuspendLayout();
            // 
            // ButonAdunare
            // 
            this.ButonAdunare.Location = new System.Drawing.Point(123, 181);
            this.ButonAdunare.Name = "ButonAdunare";
            this.ButonAdunare.Size = new System.Drawing.Size(75, 23);
            this.ButonAdunare.TabIndex = 0;
            this.ButonAdunare.Text = "Adunare";
            this.ButonAdunare.UseVisualStyleBackColor = true;
            this.ButonAdunare.Click += new System.EventHandler(this.ButonAdunare_Click);
            // 
            // ButonScadere
            // 
            this.ButonScadere.Location = new System.Drawing.Point(277, 180);
            this.ButonScadere.Name = "ButonScadere";
            this.ButonScadere.Size = new System.Drawing.Size(75, 23);
            this.ButonScadere.TabIndex = 1;
            this.ButonScadere.Text = "Scadere";
            this.ButonScadere.UseVisualStyleBackColor = true;
            this.ButonScadere.Click += new System.EventHandler(this.ButonScadere_Click);
            // 
            // ButonInmultire
            // 
            this.ButonInmultire.Location = new System.Drawing.Point(451, 180);
            this.ButonInmultire.Name = "ButonInmultire";
            this.ButonInmultire.Size = new System.Drawing.Size(75, 23);
            this.ButonInmultire.TabIndex = 2;
            this.ButonInmultire.Text = "Inmultire";
            this.ButonInmultire.UseVisualStyleBackColor = true;
            this.ButonInmultire.Click += new System.EventHandler(this.ButonInmultire_Click);
            // 
            // ButonImpartire
            // 
            this.ButonImpartire.Location = new System.Drawing.Point(646, 180);
            this.ButonImpartire.Name = "ButonImpartire";
            this.ButonImpartire.Size = new System.Drawing.Size(75, 23);
            this.ButonImpartire.TabIndex = 3;
            this.ButonImpartire.Text = "Impartire";
            this.ButonImpartire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButonImpartire.UseVisualStyleBackColor = true;
            this.ButonImpartire.Click += new System.EventHandler(this.ButonImpartire_Click);
            // 
            // TextBoxRezultat
            // 
            this.TextBoxRezultat.Location = new System.Drawing.Point(297, 301);
            this.TextBoxRezultat.Name = "TextBoxRezultat";
            this.TextBoxRezultat.Size = new System.Drawing.Size(285, 22);
            this.TextBoxRezultat.TabIndex = 4;
            this.TextBoxRezultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxRezultat.TextChanged += new System.EventHandler(this.TextBoxRezultat_TextChanged);
            // 
            // NumericUpDownTermen1
            // 
            this.NumericUpDownTermen1.Location = new System.Drawing.Point(297, 83);
            this.NumericUpDownTermen1.Name = "NumericUpDownTermen1";
            this.NumericUpDownTermen1.Size = new System.Drawing.Size(120, 22);
            this.NumericUpDownTermen1.TabIndex = 5;
            this.NumericUpDownTermen1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDownTermen1.ValueChanged += new System.EventHandler(this.NumericUpDownTermen1_ValueChanged);
            // 
            // NumericUpDownTermen2
            // 
            this.NumericUpDownTermen2.Location = new System.Drawing.Point(578, 83);
            this.NumericUpDownTermen2.Name = "NumericUpDownTermen2";
            this.NumericUpDownTermen2.Size = new System.Drawing.Size(120, 22);
            this.NumericUpDownTermen2.TabIndex = 6;
            this.NumericUpDownTermen2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDownTermen2.ValueChanged += new System.EventHandler(this.NumericUpDownTermen2_ValueChanged);
            // 
            // FormCalculator
            // 
            this.ClientSize = new System.Drawing.Size(959, 495);
            this.Controls.Add(this.NumericUpDownTermen2);
            this.Controls.Add(this.NumericUpDownTermen1);
            this.Controls.Add(this.TextBoxRezultat);
            this.Controls.Add(this.ButonImpartire);
            this.Controls.Add(this.ButonInmultire);
            this.Controls.Add(this.ButonScadere);
            this.Controls.Add(this.ButonAdunare);
            this.Name = "FormCalculator";
            this.Load += new System.EventHandler(this.FormCalculator_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTermen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTermen2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
       
        private System.Windows.Forms.Button ButonAdunare;
        private System.Windows.Forms.Button ButonScadere;
        private System.Windows.Forms.Button ButonInmultire;
        private System.Windows.Forms.Button ButonImpartire;
        private System.Windows.Forms.TextBox TextBoxRezultat;
        private System.Windows.Forms.NumericUpDown NumericUpDownTermen1;
        private System.Windows.Forms.NumericUpDown NumericUpDownTermen2;
    }
}