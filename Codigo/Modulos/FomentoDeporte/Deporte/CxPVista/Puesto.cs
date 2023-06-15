using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CxPControlador;

namespace CxPVista
{
    public partial class Puesto : Form
    {
        public Puesto()
        {
            InitializeComponent();
        }


        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "5001";
            TextBox[] Grupotextbox = { txtid,txtnombre,txtSalario};
            TextBox[] Idtextbox = { txtid, txtnombre };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dtgPuesto;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dtgPuesto, Grupotextbox, "sig");
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {

        }

        private void txtabonoacum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
