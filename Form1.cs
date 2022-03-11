using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio7D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void GuardarVehiculo()
        {
            FileStream stream = new FileStream("Vehiculo.txt"fileName, FileMode.Open, FileAccess.Read);
            StreamReader writer = new StreamReader(stream);

            
        private void button1_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.placa = textBox1.Text;
            vehiculo.marca = textBox2.Text;
            vehiculo.color = textBox3.Text;
            vehiculo.modelo = Convert.ToDecimal;
            vehiculo.precioKilometro = Convert


        }
    }
}
