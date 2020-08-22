using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp_Mihail_v1_04
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }
       

        private void FormCalculator_Load(object sender, EventArgs e)
        {

        }

        private void NumericUpDownTermen1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDownTermen2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ButonAdunare_Click(object sender, EventArgs e)
        {
            decimal termen1 = NumericUpDownTermen1.Value;
            decimal termen2 = NumericUpDownTermen2.Value;

            decimal rezultat = termen1 + termen2;
            TextBoxRezultat.Text = rezultat.ToString();

        }

        private void ButonScadere_Click(object sender, EventArgs e)
        {
            decimal termen1 = NumericUpDownTermen1.Value;
            decimal termen2 = NumericUpDownTermen2.Value;

            decimal rezultat = termen1 - termen2;
            TextBoxRezultat.Text = rezultat.ToString();
        }

        private void ButonInmultire_Click(object sender, EventArgs e)
        {
            decimal termen1 = NumericUpDownTermen1.Value;
            decimal termen2 = NumericUpDownTermen2.Value;

            decimal rezultat = termen1 * termen2;
            TextBoxRezultat.Text = rezultat.ToString();
        }

        private void ButonImpartire_Click(object sender, EventArgs e)
        {
            decimal termen1 = NumericUpDownTermen1.Value;
            decimal termen2 = NumericUpDownTermen2.Value;

           
            try
            {
                decimal rezultat = termen1 / termen2;
               
                TextBoxRezultat.Text = rezultat.ToString();
            }
            catch (Exception )
            {
                string message = "Please, DO NOT divide by 0 <:slight_smile:> (again & again!)  :-) ";
                string title = "Divide by 0";
                MessageBox.Show(message, title);
            }
           
        }

        private void TextBoxRezultat_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCalculator_Load_1(object sender, EventArgs e)
        {

        }
    }
    }

