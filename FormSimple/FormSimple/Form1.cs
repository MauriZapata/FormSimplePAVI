using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSimple
{
    public partial class frmSimple : Form
    {
        public frmSimple()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            //Message Box con el nombre
            string name;
            name = this.txtName.Text;
            MessageBox.Show("Hola " + name, "Bienvenido");

        }

        private void FrmSimple_Load(object sender, EventArgs e)
        {

        }
    }
}
