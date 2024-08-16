using System;
using System.Windows.Forms;

namespace RegistrosContactosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(TextBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(TextBoxTelefono.Text) ||
                string.IsNullOrWhiteSpace(TextBoxEmail.Text))
            {
                LabelEstado.Text = "Complete los campos";
                LabelEstado.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
           
                string contacto = $"Nombre: {TextBoxNombre.Text}, Teléfono: {TextBoxTelefono.Text}, Email: {TextBoxEmail.Text}";
                ListBoxContactos.Items.Add(contacto);

            
               
                LabelEstado.Text = "Contacto agregado";
                LabelEstado.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            TextBoxNombre.Text = string.Empty;
            TextBoxTelefono.Text = string.Empty;
            TextBoxEmail.Text = string.Empty;
            LabelEstado.Text = string.Empty;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void LabelEstado_Click(object sender, EventArgs e)
        {

        }
    }
}