using Clase12.Data.DataAccess;
using System;
using System.Data;
using System.Windows.Forms;

namespace Clase12
{
    public partial class Form1 : Form
    {
        private PersonajesDB personaje;
        private string[] razasDragonBall = {
            "Android",
            "Bio-Android",
            "Humana",
            "Humano",
            "Majin",
            "Namekuseijin",
            "Saiyajin",
            "Saiyajin/Humano",
            "Saiyajin/Saiyajin"
        };

        public Form1()
        {
            InitializeComponent();
            personaje = new PersonajesDB();
        }

        private void buttonPrueba_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conexión exitosa");
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            DataTable personajes = personaje.ListarPersonajes();
            dataGridViewPersonajes.DataSource = personajes;
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string raza = comboBoxRaza.Text;
            int nivelPoder = (int)numericUpDownNivelPoder.Value;
            string historia = textBoxHistoria.Text;
            DateTime fechaCreacion = DateTime.Now; 

            personaje.CrearPersonaje(nombre, raza, nivelPoder, fechaCreacion, historia);

            MessageBox.Show("Personaje creado con éxito");
            LimpiarCampos();
            Cargar_Click(sender, e);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int idPersonajeBuscar;
            if (int.TryParse(textBoxID.Text, out idPersonajeBuscar))
            {
                DataTable personajeEncontrado = personaje.BuscarPersonajePorId(idPersonajeBuscar);
                if (personajeEncontrado.Rows.Count > 0)
                {
                    string nombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                    string raza = personajeEncontrado.Rows[0]["raza"].ToString();
                    int nivelPoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());

                    textBoxNombre.Text = nombre;
                    comboBoxRaza.Text = raza;
                    numericUpDownNivelPoder.Value = nivelPoder;
                }
                else
                {
                    MessageBox.Show("No se encontró el personaje");
                }

            }
            else
            {
                MessageBox.Show("ID inválido");
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textBoxID.Clear();
            textBoxNombre.Clear();
            comboBoxRaza.SelectedIndex = -1;
            numericUpDownNivelPoder.Value = 0;
            textBoxHistoria.Clear();
            dateTimePickerFechaCreacion.Value = DateTime.Now;
        }

        private void textBoxID_Leave(object sender, EventArgs e)
        {
            buttonBuscar_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

