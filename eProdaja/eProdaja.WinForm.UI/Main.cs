using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eProdaja.WinForm.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void mnProizvodi_Click(object sender, EventArgs e)
        {
            Proizvodi.Proizvodi p = new Proizvodi.Proizvodi();
            p.MdiParent = Main.ActiveForm;
            p.Show();
        }
    }
}
