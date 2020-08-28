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

        public void NumericUpDownTermen1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void NumericUpDownTermen2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ButonAdunare_Click(object sender, EventArgs e)
        {
            decimal termen1 = NumericUpDownTermen1.Value;
            decimal termen2 = NumericUpDownTermen2.Value;

            CalculatorHelper Result = new CalculatorHelper(termen1,termen2);
            decimal rezultat = Result.Add;
            TextBoxRezultat.Text = rezultat.ToString();

        }

        private void ButonScadere_Click(object sender, EventArgs e)
        {
            decimal termen1 = NumericUpDownTermen1.Value;
            decimal termen2 = NumericUpDownTermen2.Value;

            CalculatorHelper Result = new CalculatorHelper(termen1, termen2);
            decimal rezultat = Result.Substract;
           
            TextBoxRezultat.Text = rezultat.ToString();
        }

        private void ButonInmultire_Click(object sender, EventArgs e)
        {
            decimal termen1 = NumericUpDownTermen1.Value;
            decimal termen2 = NumericUpDownTermen2.Value;

            CalculatorHelper Result = new CalculatorHelper(termen1, termen2);
            decimal rezultat = Result.Multiply;
            TextBoxRezultat.Text = rezultat.ToString();
        }

        private void ButonImpartire_Click(object sender, EventArgs e)
        {
            decimal termen1 = NumericUpDownTermen1.Value;
            decimal termen2 = NumericUpDownTermen2.Value;


            CalculatorHelper Result = new CalculatorHelper(termen1, termen2);
            decimal rezultat = Result.Divide;
            Boolean afisare_err = Result.Flag;
            if(afisare_err == true)
            {
                string rezultat_err = "Try again later, Ali...gator";
                TextBoxRezultat.Text = rezultat_err.ToString();
            }
            else TextBoxRezultat.Text = rezultat.ToString();


            /*
             METODA 1
                       switch (termen2)
                       {
                           case 0:
                               string rezultat_err = "Try again later, Ali...gator";
                               TextBoxRezultat.Text = rezultat_err.ToString();
                               break;

                           default:
                               decimal rezultat = termen1 / termen2;
                               TextBoxRezultat.Text = rezultat.ToString();
                               break;

                       }

             METODA 2
                                try
                                {
                                    decimal rezultat = termen1 / termen2;

                                    TextBoxRezultat.Text = rezultat.ToString();
                                }
                                catch (Exception )
                                {
                                    string message1 = "Please, DO NOT divide by 0 <:slight_smile:> (again & again!)";
                                    string message2 = " - Err 605 -" ;
                                    string message = $" {message1} {message2}";
                                    string title = "Divide by 0";
                                    MessageBox.Show(message, title);
                                }

                                */


        }

        private void TextBoxRezultat_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void FormCalculator_Load_1(object sender, EventArgs e)
        {
            string mesaj_start = "Please, calculate something !";
            TextBoxRezultat.Text = mesaj_start.ToString();
        }
    }
    }

