using Guia3._2Jerarquiadeclases.Models;

namespace Guia3._2Jerarquiadeclases
{
    public partial class Form1 : Form
    {
        Cooperativa cooperativa;
        Cliente clienteSeleccion;
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormVer fResultado = new FormVer();
            fResultado.lbResultados.Items.Clear();

            fResultado.lbResultados.Items.Add($"Número de Servicio {clienteSeleccion.Medidor.NumeroServicio,-10}");

            for (int n = 0; n < clienteSeleccion.Medidor.CantidadConsumos; n++)
            {
                //imprimo el historico de este cliente
                string consumo = clienteSeleccion.Medidor.LeerConsumo(n).ToString("0.00");
                int periodo = (n + clienteSeleccion.Medidor.PeriodoActual) % 6;

                fResultado.lbResultados.Items.Add($"{periodo,-10} {consumo,10}");
            }

            fResultado.ShowDialog();

            fResultado.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = tbCoperativa.Text;
            cooperativa = new Cooperativa(nombre);

            #region limpiando controles
            btnIniciarCooperativa.Enabled = false;
            tbCoperativa.Enabled = false;
            
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDatosCliente fCliente = new FormDatosCliente();

            if (fCliente.ShowDialog() == DialogResult.OK)
            {
                int servicio = Convert.ToInt32(fCliente.tbNumeroServicio.Text);

                string nombre = fCliente.tbNombre.Text;
                int dni = Convert.ToInt32(fCliente.tbDNI.Text);
                string direccion = fCliente.tbDireccion.Text;

                Medidor medidor = new Medidor(servicio);
                Cliente nuevo = cooperativa.AgregarCliente(dni, nombre, direccion, medidor);

                MessageBox.Show($"Servicio nro: {nuevo.Medidor.NumeroServicio}. Cliente nuevo!");

              
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double medicionActual = Convert.ToDouble(tbLecturaMedidor.Text);


            clienteSeleccion.Medidor.RegistrarConsumo(medicionActual);

            

            tbLecturaMedidor.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region limpiando controles
           
            #endregion

            if (string.IsNullOrEmpty(tbNroServicio.Text.Trim()) == false)
            {
                int nroServicio = Convert.ToInt32(tbNroServicio.Text.Trim());
                clienteSeleccion = cooperativa.BuscarCliente(nroServicio);
                if (clienteSeleccion != null)
                {
                    lbDescripcion.Text = clienteSeleccion.ToString();

                   
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado!");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
