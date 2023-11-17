using CineBack.Entidades;
using CineBack.Fachada.Interfaz;
using System.Text;

namespace CineFront
{
    public partial class FrmInsertarPelicula : Form
    {
        private string[] genero = { "Terror", "Accion", "Comedia", "Suspenso", "Ciencia Ficcion", "Drama" };
        private string[] idioma = { "Ingles", "Español", "Subtitulada", "Chino" };
        private string[] clasificacion = { "+13", "+15", "APT" };
        private string[] sala = { "1", "2", "3", "4" };        
        Funcion nueva = null;
        
        public FrmInsertarPelicula()
        {
            InitializeComponent();           
            nueva = new Funcion();
        }
        private void InsertPelicula_Load(object sender, EventArgs e)
        {
            txtTitulo.Text = string.Empty;
            txtDirector.Text = string.Empty;
            cboGenero.DataSource = genero;
            cboIdioma.DataSource = idioma;
            cboClasificacion.DataSource = clasificacion;
            nudDuracion.Value = 0;
            cboSala.DataSource = sala;
            dtpDia.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {   //Validar Datos
                GrabarPelicula(); //Confirmar y grabar
            }
        }

        private void GrabarPelicula()
        {
            nueva.Pelicula.Titulo = txtTitulo.Text;
            nueva.Pelicula.Genero = cboGenero.SelectedItem.ToString();
            nueva.Pelicula.Idioma = cboIdioma.SelectedItem.ToString();
            nueva.Pelicula.Clasificacion = cboClasificacion.SelectedItem.ToString();
            nueva.Pelicula.Duracion = (int)nudDuracion.Value;
            nueva.Sala = Convert.ToInt32(cboSala.SelectedItem);
            nueva.Dia = dtpDia.Value;
            nueva.Hora = dtpHora.Value;
            if (servicio.CrearFuncion(nueva))
            {
                MessageBox.Show("Se registró con éxito la función", "Informe", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la funcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                MessageBox.Show("Debe ingresar el titulo de la pelicula", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(txtDirector.Text))
            {
                MessageBox.Show("Debe ingresar al/los director/es de la pelicula", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un genero", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboIdioma.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un idioma", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboClasificacion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una clasificacion", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (nudDuracion.Value <= 0)
            {
                MessageBox.Show("Debe ingresar una duracion valida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboSala.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una sala ", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (dtpDia.Value < DateTime.Today)
            {
                MessageBox.Show("Debe ingresar una fecha valida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
    }
}
