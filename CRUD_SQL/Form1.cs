using System.Data;
using System.Windows.Forms;

namespace CRUD_SQL
{
    public partial class Form1 : Form
    {
        private Conexiones.Conexion conexion = new Conexiones.Conexion();

        DataTable tablaClientes;
        DataTable tablaSucursales;


        public Form1()
        {
            conexion.crearTablaClientes();
            conexion.crearTablaSucursales();

            InitializeComponent();
            ActualizarTablas();

            List<object> listaSucursales = new List<object>();
            foreach (DataRow fila in tablaSucursales.Rows)
            {
                listaSucursales.Add(fila[1]);
            }

            comboSucursal.DataSource = listaSucursales;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            string sucursal = ObtenerCodigoSucursal();
            conexion.GuardarCliente(textNombre.Text,
                                    textTelefono.Text,
                                    textCorreo.Text,
                                    sucursal);
            ActualizarTablas();
            LimpiarEntradas();
        }

        private void ActualizarTablas()
        {
            tablaClientes = conexion.ObtenerDatosClientes();
            tablaSucursales = conexion.ObtenerDatosSucursales();
            gridClientes.DataSource = tablaClientes;
            gridSucursales.DataSource = tablaSucursales;
            foreach (DataGridViewColumn column in gridSucursales.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private string ObtenerCodigoSucursal()
        {
            int indiceSucursal = comboSucursal.SelectedIndex;
            return gridSucursales.Rows[indiceSucursal].Cells[0].Value.ToString();
        }

        private void gridClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (gridClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = gridClientes.SelectedRows[0];
                textCodigo.Text = filaSeleccionada.Cells[0].Value?.ToString();
                textNombre.Text = filaSeleccionada.Cells[1].Value?.ToString();
                textTelefono.Text = filaSeleccionada.Cells[2].Value?.ToString();
                textCorreo.Text = filaSeleccionada.Cells[3].Value?.ToString();

                string nombreSucursal = ObtenerNombreSucursal(filaSeleccionada.Cells[4].Value?.ToString());
                comboSucursal.Text = nombreSucursal;
            }

        }

        private string ObtenerNombreSucursal(string codigoSucursal)
        {
            foreach (DataGridViewRow fila in gridSucursales.Rows)
            {
                if (fila.Cells[0].Value.ToString() == codigoSucursal)
                {

                    return fila.Cells[1].Value.ToString();

                }
            }
            return "";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string sucursal = ObtenerCodigoSucursal();
            conexion.EliminarCliente(textCodigo.Text,
                                     textNombre.Text,
                                     textTelefono.Text,
                                     textCorreo.Text,
                                     sucursal);
            ActualizarTablas();
            LimpiarEntradas();
        }

        private void LimpiarEntradas()
        {
            textCodigo.Text = string.Empty;
            textNombre.Text = string.Empty;
            textTelefono.Text = string.Empty;
            textCorreo.Text = string.Empty;
            comboSucursal.SelectedIndex = 0;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            string sucursal = ObtenerCodigoSucursal();
            conexion.ModificarCliente(textCodigo.Text,
                                      textNombre.Text,
                                      textTelefono.Text,
                                      textCorreo.Text,
                                      sucursal);
            ActualizarTablas();
            LimpiarEntradas();
        }

        private void gridSucursales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboSucursal.SelectedIndex = e.RowIndex;
        }

    }
}