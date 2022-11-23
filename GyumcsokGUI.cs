using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
    }
}
