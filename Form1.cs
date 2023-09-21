using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreriaSuma;
using libreriaMult;
using libreriaResta;
using libreriaDivision;

namespace NachoOpera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            long rSuma = 0;
            long rResta = 0;
            long rMult = 0; 
            long rDiv = 0;
            rSuma = libreriaSuma.Class1.suma(Int64.Parse(txtNum1.Text), Int64.Parse(txtNum2.Text));
            txtSuma.Text = rSuma.ToString();

            rMult = libreriaMult.Class1.mult(Int64.Parse(txtNum1.Text), Int64.Parse(txtNum2.Text));
            txtMult.Text = rMult.ToString();

            rResta = libreriaResta.Class1.resta(Int64.Parse(txtNum1.Text), Int64.Parse(txtNum2.Text));
            txtResta.Text = rResta.ToString();

            rDiv = libreriaDivision.Class1.divi(Int64.Parse(txtNum1.Text), Int64.Parse(txtNum2.Text));
            txtDiv.Text = rDiv.ToString();
        }
    }
}
