using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using eProdaja.Model;

namespace eProdaja.WinForm.UI.Proizvodi
{
    public partial class Proizvodi : Form
    {
        public APIService _service = new APIService("proizvodi");

        public Proizvodi()
        {
            InitializeComponent();
        }

        private void Proizvodi_Load(object sender, EventArgs e)
        {
            LoadProizvodi();
        }

        private async void LoadProizvodi()
        {
            Model.ProizvodiSearchObject _search = new Model.ProizvodiSearchObject();
            _search.Connections.Add("JedinicaMjere");
            _search.Connections.Add("Vrsta");

            dgvProizvodi.DataSource = await _service.GetAll<List<Model.Proizvodi>>(_search);
        }

        private void dgvProizvodi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
