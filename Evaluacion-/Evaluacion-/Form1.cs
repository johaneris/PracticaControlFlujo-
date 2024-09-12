using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluacion_.models;

namespace Evaluacion_
{
    public partial class Form1 : Form
    {
        Estudiante estudiantes = new Estudiante();
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Agregar();

        }
        private void Agregar()
        {
            try
            {
                string nombreCompleto = tbNombre.Text;
                if (!string.IsNullOrWhiteSpace(nombreCompleto) && index < 25)
                {
                    estudiantes.AddElement(nombreCompleto, index);
                    index++;
                    longitud();
                    tbNombre.Clear();
                    tbNombre.Focus();
                }
                else
                {
                    MessageBox.Show("No se puede agregar más estudiantes o el nombre está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void longitud()
        {
            try
            {
                lbEstudiantes.Items.Clear();
                for (int i = 0; i < index; i++)
                {
                    if (estudiantes.GetElements()[i].Length > 25)
                    {
                        lbEstudiantes.Items.Add(estudiantes.GetElements()[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Agregar();
            }
        }
    }

}
