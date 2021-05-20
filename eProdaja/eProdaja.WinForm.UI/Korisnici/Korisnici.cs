using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eProdaja.WinForm.UI.Korisnici
{
    public partial class Korisnici : Form
    {
        public APIService _api = new APIService("korisnici");
        public Korisnici()
        {
            InitializeComponent();
            AfterLoad();
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Korisnici_Load(object sender, EventArgs e)
        {

        }

        private async void AfterLoad()
        {
            var list = await _api.GetAll<List<Model.Korisnici>>();
            dgvKorisnici.DataSource = list;
        }

        private void dgvKorisnici_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var k = dgvKorisnici.SelectedRows[0].DataBoundItem as Model.Korisnici;

            MessageBox.Show(k.KorisnikId.ToString());
        }
    }

    

}
