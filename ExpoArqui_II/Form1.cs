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
using System.IO.Ports;
using System.Xml.Serialization;
using ExpoArqui_II.Properties;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ExpoArqui_II
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Puerto;
        string puertoSeleccionado;
        public Form1()
        {
            //detect the serial port where the Arduino is connected
            InitializeComponent();
            Puerto = new System.IO.Ports.SerialPort();
            Puerto.DataReceived += Puerto_DataReceived;
        }

        private void Puerto_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Leer los datos recibidos del puerto serial
            byte[] dataBuffer = new byte[Puerto.BytesToRead];
            Puerto.Read(dataBuffer, 0, dataBuffer.Length);

            // Convertir los bytes en una imagen y mostrarla en el PictureBox
            using (MemoryStream stream = new MemoryStream(dataBuffer))
            {
                try
                {
                    Image receivedImage = Image.FromStream(stream);
                    PbFoto.Image = receivedImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al procesar la imagen: " + ex.Message);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {           
            // TODO: esta línea de código carga datos en la tabla 'bD_FotosDataSet.Tb_Fotos' Puede moverla o quitarla según sea necesario.
            this.tableAdapterManager.Fill(this.bD_FotosDataSet.Tb_Fotos);
            tb_FotosDataGridView.Columns[2].ReadOnly = true;
            tb_FotosDataGridView.Columns[3].ReadOnly = true;
            tb_FotosDataGridView.Columns[4].ReadOnly = true;

            //get all serial ports availables and display them on the combobox
        }
        private void BtnCapturar_Click(object sender, EventArgs e)
        {
            //Obtener fecha
            DateTime date = DateTime.Now;
            string fecha = date.ToString("dd/MM/yyyy");
            
            //Obtener hora
            DateTime time = DateTime.Now;
            string hora = time.ToString("HH:mm:ss");

            //Generar nombre
            string nombre = "F"+(tb_FotosDataGridView.RowCount+1).ToString()+".jpg";

            //Guardar imagen
            PbFoto.Image.Save(@"C:\Users\alfre\Pictures\Fotos\"+nombre, System.Drawing.Imaging.ImageFormat.Jpeg);

            //Guardar datos en la tabla
            this.tableAdapterManager.Insertar(nombre, fecha, hora);

            //Actualizar tabla
            this.tableAdapterManager.Fill(this.bD_FotosDataSet.Tb_Fotos);


        }

        private void tb_FotosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Seleccionar filas de la 2-4
            if (e.ColumnIndex >= 2 && e.ColumnIndex <= 4) // Columna 2-4 (índices 2-4)
            {
                // Seleccionar la fila completa
                tb_FotosDataGridView.Rows[e.RowIndex].Selected = true;

                // Seleccionar las celdas de las columnas 2 a 4 en la misma fila
                for (int colIndex = 2; colIndex <= 4; colIndex++)
                {
                    tb_FotosDataGridView.Rows[e.RowIndex].Cells[colIndex].Selected = true;
                }
            }
            //----------

            //Activar Checkbox
            //----------
            //Capturar valores de la tabla
            string nombre = tb_FotosDataGridView.CurrentRow.Cells[2].Value.ToString();
            string fecha = tb_FotosDataGridView.CurrentRow.Cells[3].Value.ToString();
            string hora = tb_FotosDataGridView.CurrentRow.Cells[4].Value.ToString();
            //Generar la ruta 
            string path = @"C:\Users\alfre\Pictures\Fotos\" + nombre;
            //Mostrar la imagen de la ruta
            try
            {
                PbFoto.Image = Image.FromFile(path);
            }
            catch { 
                MessageBox.Show("Imagen no encontrada","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                PbFoto.Image = Resources.not_found_image_15383864787lu;
            }
            //Mostrar datos
            LbNombre.Text = nombre;
            LbFecha.Text = fecha;
            LbHora.Text = hora;

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                Puerto.PortName = puertoSeleccionado;
                Puerto.BaudRate = Convert.ToInt32(CbBaudios.Text);
                Puerto.Open();
            }
            catch
            {
                MessageBox.Show("No se pudo abrir el puerto serial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbPuertos_DropDown(object sender, EventArgs e)
        {
            CbPuertos.Items.Clear();

            // Obtener una lista de los puertos seriales disponibles
            string[] availablePorts = SerialPort.GetPortNames();

            // Agregar los puertos seriales disponibles al ComboBox
            CbPuertos.Items.AddRange(availablePorts);

            //Detect the port where ther arduino is connected
            if (availablePorts.Length > 0)
            {
                puertoSeleccionado = availablePorts[0];
                CbPuertos.Text = puertoSeleccionado;
            }
        }

        private void BtnDetener_Click(object sender, EventArgs e)
        {
            Puerto.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int ID,count=0;
            string[] nombres = new string[tb_FotosDataGridView.RowCount];
            // Recorrer todas las filas del DataGridView
            foreach (DataGridViewRow row in tb_FotosDataGridView.Rows)
            {
                bool s = Convert.ToBoolean(row.Cells[1].Value);
                if (s == true)
                {
                    ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    this.tableAdapterManager.Eliminar(ID);
                    //Eliminar imagen del directorio
                    string path = @"C:\Users\alfre\Pictures\Fotos\" + row.Cells[2].Value.ToString();
                    PbFoto.Image.Dispose();
                    PbFoto.Image = null;
                    File.Delete(path);
                    count++;
                }
            }

            //Actualizar tabla
            this.tableAdapterManager.Fill(this.bD_FotosDataSet.Tb_Fotos);

            if (count > 0)
            {
                MessageBox.Show(count + " registros eliminados","Información",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            //Actualizar tabla
            this.tableAdapterManager.Fill(this.bD_FotosDataSet.Tb_Fotos);
        }

        private void tb_FotosDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda seleccionada está en las columnas 2 a 4
            if (e.ColumnIndex >= 2 && e.ColumnIndex <= 4)
            {
                // Seleccionar la fila completa
                tb_FotosDataGridView.Rows[e.RowIndex].Selected = true;

                // Seleccionar las celdas de las columnas 2 a 4 en la misma fila
                for (int colIndex = 2; colIndex <= 4; colIndex++)
                {
                    tb_FotosDataGridView.Rows[e.RowIndex].Cells[colIndex].Selected = true;
                }
            }
            //set the image in the picturebox
            string nombre = tb_FotosDataGridView.CurrentRow.Cells[2].Value.ToString();
            string path = @"C:\Users\alfre\Pictures\Fotos\" + nombre;
            string fecha = tb_FotosDataGridView.CurrentRow.Cells[3].Value.ToString();
            string hora = tb_FotosDataGridView.CurrentRow.Cells[4].Value.ToString();
            //Mostrar valores
            LbNombre.Text = nombre;
            LbFecha.Text = fecha;
            LbHora.Text = hora;
            //Mostrar imagen
            try
            {
                PbFoto.Image = Image.FromFile(path);
            }
            catch
            {
                MessageBox.Show("Imagen no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PbFoto.Image = Resources.not_found_image_15383864787lu;
            }
        }

        private void CbBaudios_DropDown(object sender, EventArgs e)
        {
            //get available baud rates and add them to the combo box
            CbBaudios.Items.Clear();
            CbBaudios.Items.Add(9600);
            CbBaudios.Items.Add(19200);
            CbBaudios.Items.Add(115200);
            CbBaudios.Items.Add(250000);
            CbBaudios.Items.Add(500000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leer los datos recibidos del puerto serial
            byte[] dataBuffer = new byte[Puerto.BytesToRead];
            Puerto.Read(dataBuffer, 0, dataBuffer.Length);

            // Convertir los bytes en una imagen y mostrarla en el PictureBox
            using (MemoryStream stream = new MemoryStream(dataBuffer))
            {
                try
                {
                    Image receivedImage = Image.FromStream(stream);
                    PbFoto.Image = receivedImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al procesar la imagen: " + ex.Message);
                }
            }
        }
    }
}
