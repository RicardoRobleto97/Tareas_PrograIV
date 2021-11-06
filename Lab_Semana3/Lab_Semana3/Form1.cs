using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Lab_Semana3
{
    public partial class Form1 : Form
    {
        //Variables globales
        List<Empleado> lista_empleados = new List<Empleado>();

        int indice_actual = -1;//Posicion actual de la lista de empleados
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void GuardarEmpleado()
        {
            Empleado nuevo = new Empleado();

            nuevo.identidad = txtID.Text;
            nuevo.nombre = txtNombre.Text;
            nuevo.sexo = (rdbMasculino.Checked ? "M" : "F");
            nuevo.fecha_nacimiento = dtpFechaNacimiento.Value;
            nuevo.sueldo_base = Math.Round(Convert.ToDouble(txtSueldo.Text), 2);
            nuevo.departament = cbxDept.Text;

            lista_empleados.Add(nuevo);
            MessageBox.Show("Empleados en lista: " + lista_empleados.Count.ToString());

        }
        private void Limpiar()
        {
            txtID.Text = " ";
            txtNombre.Text = " ";
            rdbMasculino.Checked = true;
            txtSueldo.Clear();
            cbxDept.SelectedIndex = 0;
            dtpFechaNacimiento.Value = DateTime.Today;
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
                txtID.Focus();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EstablecerFormatoNumero()
        {   //Declaracion de la variable
            double numero = 0;
            //pROCESOS
            try
            {
                numero = Convert.ToDouble(txtSueldo.Text);
            }
            catch
            {
                numero = 0;
                MessageBox.Show("Sueldo no validlo");
            }
            //Salidas
            txtSueldo.Text = numero.ToString("###,###.00");
        }
        private void txtSueldo_Leave(object sender, EventArgs e)
        {
            EstablecerFormatoNumero();
        }
        private void ExportarLista()
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarEmpleado();
                Limpiar();
                txtID.Focus();
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CambiarIndice(int direccion)
        {
            if (lista_empleados.Count == 0)
            {
                return;
                //indice_actual = 0;
            }
            indice_actual += direccion;
            if (indice_actual > lista_empleados.Count - 1)
            {
                indice_actual = 0;
            }
            if (indice_actual < 0)
            {
                indice_actual = lista_empleados.Count - 1;
            }

            Empleado temp = lista_empleados[indice_actual];
            txtID.Text = temp.identidad;
            txtNombre.Text = temp.nombre;
            dtpFechaNacimiento.Value = temp.fecha_nacimiento;
            txtSueldo.Text = temp.sueldo_base.ToString("###,###.00");
            rdbMasculino.Checked = (temp.sexo == "M" ? true : false);
            rdbFemenino.Checked = (temp.sexo == "F" ? true : false);
            cbxDept.Text = temp.departament;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            try
            {
                CambiarIndice(-1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            try
            {
                CambiarIndice(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Exportar_Lista()
        {

            sfdGuardar.Filter = "*.txt|*.txt";
            sfdGuardar.FilterIndex = 1;
            sfdGuardar.RestoreDirectory = true;
            string ruta = "";
            if (sfdGuardar.ShowDialog() == DialogResult.OK)
            {
                ruta = sfdGuardar.FileName;
                string linea = " ";
                StreamWriter sw = new StreamWriter(ruta);
                foreach( Empleado emp in lista_empleados)
                {
                    linea = "{0},{1},{2},{3},{4},{5},";
                    linea = string.Format(linea,
                         emp.identidad,
                        emp.nombre,
                        emp.sexo,
                        emp.fecha_nacimiento,
                        emp.sueldo_base,
                        emp.departament

                        );
                    sw.WriteLine(linea);
                }
                sw.Close();
                MessageBox.Show("Archivo exportado con exito");



            }
            else
            {
                MessageBox.Show("Elija una ruta para guardar archivo");
            }
        }

        private void Exportar_Click(object sender, EventArgs e)
        {
            try
            {
                Exportar_Lista();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ImportarDesdeArchivo()
        {
            ofdLeer.Filter = "*.txt|*.txt*";
            ofdLeer.FilterIndex = 1;
            ofdLeer.RestoreDirectory = true;
            string linea = "";string[] partes;
            if (ofdLeer.ShowDialog()== DialogResult.OK)
            {

                string ruta = ofdLeer.FileName;
                lista_empleados.Clear();
                StreamReader sr = new StreamReader(ruta);
                linea = sr.ReadLine();
                while(linea != "" && linea != null)
                {
                    partes = linea.Split(',');
                    Empleado nuevo = new Empleado();
                    nuevo.identidad = partes[0];
                    nuevo.nombre = partes[1];
                    nuevo.sexo = partes[2];
                    nuevo.fecha_nacimiento = Convert.ToDateTime(partes[3]);
                    nuevo.sueldo_base = Convert.ToDouble(partes[4]);
                    nuevo.departament = partes[5];
                    lista_empleados.Add(nuevo);
                    linea = sr.ReadLine();





                }
                sr.Close();
                if (lista_empleados.Count > 0)
                {
                    indice_actual = -1;
                    CambiarIndice(1);
                }
                MessageBox.Show("Archivo Importado con Exito");
            }
            else
            {
                MessageBox.Show("Elija un archivo para leer");
            }



        }

        private void Importar_Click(object sender, EventArgs e)
        {
            try
            {
                ImportarDesdeArchivo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

