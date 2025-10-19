using MySql.Data.MySqlClient;
using System.Data;
using SpreadsheetLight;
using DocumentFormat.OpenXml;


namespace Proyecto
{
    public partial class Form1 : Form
    {

        string CadenaConexion = "Server=localhost;Port=3306;Database=pruebacensa;Uid=root;Pwd=";


        public Form1()
        {
            InitializeComponent();
        }


        private void but1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void guardar()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "INSERT INTO `pruebacensa`.`Estudiantes`(`ID`,`nombre`,`apellido`) VALUES ('" + txbID.Text + "', '" + txbnombre.Text + "', '" + txbapellido.Text + "');";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro Insertado Exitosamente");



        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            guardar();
            CargarDatos();

        }

        public DataSet Listar()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "Select * from pruebacensa.estudiantes;";
            MySqlDataAdapter Adaptador;
            DataSet dataSet = new DataSet();

            Adaptador = new MySqlDataAdapter(Query, mySqlConnection);
            Adaptador.Fill(dataSet, "tbl");

            return dataSet;
        }

        public void CargarDatos()
        {
            DgvEstudiantes.DataSource = Listar().Tables["tbl"];
        }
        private void txbapellido_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BtnReporteExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SLDocument perrito = new SLDocument();
                perrito.SetCellValue("A1", "Hola Mundo en Excel");
                perrito.SaveAs(@"C:\Temp\ArchivohZ.xlsx");
                MessageBox.Show("Archivo exportado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a Excel: " + ex.Message);
            }
        }


    }
}
