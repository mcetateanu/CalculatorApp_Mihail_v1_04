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
    public partial class FormHomepage : Form
    {
        FormAbout formAbout;
        FormCalculator formCalculator;
        
        public FormHomepage()
        {
            InitializeComponent();
            formAbout = new FormAbout();
            formAbout.Visible = false;
            formCalculator = new FormCalculator();
            formCalculator.Visible = false;
        }

        private void ButtonAboutForm_Click(object sender, EventArgs e)
        {
           

            if (formAbout.Visible == true)
                formAbout.Visible = false;
            else
            {
                if (formAbout.IsDisposed) formAbout = new FormAbout();
                formAbout.Visible = true;
            }

        }

        private void ButtonCalculatorForm_Click(object sender, EventArgs e)
        {
            if (formCalculator.Visible == true)
                formCalculator.Visible = false;
            else
            {
                if (formCalculator.IsDisposed) formCalculator = new FormCalculator();
                formCalculator.Visible = true;
            }
           
        }
    }
}
