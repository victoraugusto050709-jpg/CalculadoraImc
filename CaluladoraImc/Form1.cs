using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaluladoraImc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculadora1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_TextChanged(object sender, EventArgs e)
        {
            decimal peso = Convert.ToDecimal(txtPeso.Text);
            decimal altura = Convert.ToDecimal(txtAltura.Text);

            decimal imc = peso / (altura * altura);

            lblResultado.Text = imc.ToString("F2");

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
        }

        private void numePe_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal Peso;
            decimal Altura;
            decimal Imc;

            Peso = decimal.Parse(txtPeso.Text);
            Altura = decimal.Parse(txtAltura.Text);

            if (Peso < 0);
            {
                txtPeso.Focus();
                MessageBox.Show("O peso não pode ser menor que 0", "Erro De Peso 0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                


                
            }
            Imc = Peso / (Altura * Altura);
            lblResultado.Text = Imc.ToString("0.00");


        }
    }
}