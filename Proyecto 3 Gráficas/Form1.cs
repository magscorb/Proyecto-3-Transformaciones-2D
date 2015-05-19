using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_3_Gráficas
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();

            cmbFigura.SelectedIndex = 0;
            cmbTransform.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
