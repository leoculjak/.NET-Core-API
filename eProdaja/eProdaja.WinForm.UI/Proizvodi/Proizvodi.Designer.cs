
namespace eProdaja.WinForm.UI.Proizvodi
{
    partial class Proizvodi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.tbCijena = new System.Windows.Forms.TextBox();
            this.cbVrsta = new System.Windows.Forms.ComboBox();
            this.cbJedinicaMjere = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cijena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jedinica mjere";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vrsta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProizvodi);
            this.groupBox1.Location = new System.Drawing.Point(12, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1110, 291);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proizvodi";
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            this.dgvProizvodi.AllowUserToDeleteRows = false;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProizvodi.Location = new System.Drawing.Point(3, 19);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.RowTemplate.Height = 25;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(1104, 269);
            this.dgvProizvodi.TabIndex = 0;
            this.dgvProizvodi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProizvodi_CellContentClick);
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(147, 39);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(121, 23);
            this.tbNaziv.TabIndex = 7;
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(147, 75);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(121, 23);
            this.tbSifra.TabIndex = 8;
            // 
            // tbCijena
            // 
            this.tbCijena.Location = new System.Drawing.Point(147, 111);
            this.tbCijena.Name = "tbCijena";
            this.tbCijena.Size = new System.Drawing.Size(121, 23);
            this.tbCijena.TabIndex = 9;
            // 
            // cbVrsta
            // 
            this.cbVrsta.FormattingEnabled = true;
            this.cbVrsta.Location = new System.Drawing.Point(147, 144);
            this.cbVrsta.Name = "cbVrsta";
            this.cbVrsta.Size = new System.Drawing.Size(121, 23);
            this.cbVrsta.TabIndex = 10;
            // 
            // cbJedinicaMjere
            // 
            this.cbJedinicaMjere.FormattingEnabled = true;
            this.cbJedinicaMjere.Location = new System.Drawing.Point(147, 189);
            this.cbJedinicaMjere.Name = "cbJedinicaMjere";
            this.cbJedinicaMjere.Size = new System.Drawing.Size(121, 23);
            this.cbJedinicaMjere.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(147, 227);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 19);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Aktivan";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(372, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Trazi";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // Proizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 607);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbJedinicaMjere);
            this.Controls.Add(this.cbVrsta);
            this.Controls.Add(this.tbCijena);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Proizvodi";
            this.Text = "Proizvodi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Proizvodi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.TextBox tbCijena;
        private System.Windows.Forms.ComboBox cbVrsta;
        private System.Windows.Forms.ComboBox cbJedinicaMjere;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSearch;
    }
}