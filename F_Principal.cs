using System.Net.NetworkInformation;

using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Windows.Forms;



namespace Proyecto_Final_Base_De_Datos
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();

            string Rutaconexion = null;
            SqlConnection Conexion;
            string consulta = null;

            Rutaconexion = @"Data Source = LAPTOP-JIOEQ0B7; Initial Catalog = SISTEMA_VENTAS; User ID = sa; Password=1234567; ";
            Conexion = new SqlConnection(Rutaconexion);



            //Ruta de Conexion


        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {

            F_Cliente f_Cliente = new F_Cliente();
            f_Cliente.Show();


        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            F_Empleado f_Empleado = new F_Empleado();
            f_Empleado.Show();
        }

        private void btn_Factura_Click(object sender, EventArgs e)
        {
            F_Factura f_Factura = new F_Factura();
            f_Factura.Show();
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            F_Inventario f_Inventario = new F_Inventario();
            f_Inventario.Show();
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}