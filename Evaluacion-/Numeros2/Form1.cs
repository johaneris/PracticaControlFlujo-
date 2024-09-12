using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Numeros2.models;

namespace Numeros2
{
    public partial class Form1 : Form
    {
        Numeritos numbers = new Numeritos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNumber();
        }

        private void AddNumber()
        {
            try
            {
                int number = Convert.ToInt32(tbNumber.Text);
                if (number >= 0)
                {
                    numbers.AddElement(number);
                    MostrarResultados();
                    tbNumber.Clear();
                    tbNumber.Focus();
                }
                else
                {
                    MessageBox.Show("Número negativo detectado. Finalizando la captura.", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarResultadosFinales();
                    tbNumber.Clear();
                    tbNumber.Enabled = false; // Desactiva el campo de texto
                    btnAdd.Enabled = false; // Desactiva el botón de agregar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarResultados()
        {
            lbNumbers.Items.Clear();
            int[] nums = numbers.GetElements();
            for (int i = 0; i < numbers.GetIndex(); i++)
            {
                lbNumbers.Items.Add(nums[i]);
            }
        }

        private void MostrarResultadosFinales()
        {
            int sum = numbers.SumElements();
            int max = numbers.GetMaxElement();
            int min = numbers.GetMinElement();

            lblSuma.Text = "Suma: " + sum;
            lblMax.Text = "Máximo: " + max;
            lblMin.Text = "Mínimo: " + min;
        }

        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddNumber();
            }
        }
    }
}
