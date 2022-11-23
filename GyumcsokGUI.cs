using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Engines;

namespace GyumolcsokGyak
{
    public partial class GyumcsokGUI : Form
    {
        Adatbazis adatbazis = new Adatbazis();
        
        public GyumcsokGUI()
        {
            InitializeComponent();
        }

        private void GyumcsokGUI_Load(object sender, EventArgs e)
        {

            MennyisegNumUp.Maximum = Decimal.MaxValue;
            EgysegArNumUp.Maximum = Decimal.MaxValue;
            GyumolcsokBetoltese();

        }

        private void GyumolcsokBetoltese()
        {
            GyumolcsokList.Items.Clear();
            foreach (var item in adatbazis.getAllGyumolcs())
            {

                GyumolcsokList.Items.Add(item);

            }
        }

        private void KivalasztButton_Click(object sender, EventArgs e)
        {

            if (GyumolcsokList.SelectedIndex < 0)
            {

                return;

            };

            GyumolcsAdat kivalasztottGyum = (GyumolcsAdat)GyumolcsokList.SelectedItem;
            IDText.Text = kivalasztottGyum.Id.ToString();
            GyumolcsNevText.Text = kivalasztottGyum.Gyumolcsnev;
            MennyisegNumUp.Value =(decimal)kivalasztottGyum.Mennyiseg;
            EgysegArNumUp.Value = (decimal)kivalasztottGyum.Egysegar;


        }

        private void LetrehozButton_Click(object sender, EventArgs e)
        {

            if (nincsenadat())
            {

                return;

            }
            

        }

        private bool nincsenadat()
        {

            if (string.IsNullOrEmpty(GyumolcsNevText.Text))
            {

                MessageBox.Show("Adjon meg egy Gyümölcs Nevet!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GyumolcsNevText.Focus();
                return true;

            }
            return false;

        }

        private void ModositButton_Click(object sender, EventArgs e)
        {



        }

        private void TorolButton_Click(object sender, EventArgs e)
        {



        }

    }
}
