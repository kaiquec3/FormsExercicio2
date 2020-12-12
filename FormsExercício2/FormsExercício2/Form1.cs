using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsExercício2
{
    public partial class frmCalculadoraDeAreaDeQuadrado : Form
    {
        public frmCalculadoraDeAreaDeQuadrado()
        {
            InitializeComponent();
            lblAreaValor.Text = "0";
        }

        private void clickou_calcular(object sender, EventArgs e)
        {
            Quadrado q1 = new Quadrado(double.Parse(txtAresta.Text));
            q1.CalcularArea();
            lblAreaValor.Text = q1.GetArea().ToString();
        }
    }
}
