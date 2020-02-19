using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace longitud
{
    public partial class longitud : Form
    {
        public longitud()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxentrada.Items.Add("metro");
            cbxentrada.Items.Add("centimetro");
            cbxentrada.Items.Add("milimetro");
            cbxentrada.Items.Add("pie");
            cbxentrada.Items.Add("yarda");
            cbxentrada.Items.Add("milla");
            cbxentrada.Items.Add("kilometro");
            cbxentrada.Items.Add("pulgada");
            

            cbxsalida.Items.Add("metro");
            cbxsalida.Items.Add("centimetro");
            cbxsalida.Items.Add("milimetro");
            cbxsalida.Items.Add("pie");
            cbxsalida.Items.Add("yarda");
            cbxsalida.Items.Add("milla");
            cbxsalida.Items.Add("kilometro");
            cbxsalida.Items.Add("pulgada");
            
        }
    }
}
