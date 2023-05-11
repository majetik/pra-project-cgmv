using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGMV
{
    public partial class UrediObavijest : Form
    {
        public UrediObavijest()
        {
            InitializeComponent();
        }

        private void BtnNatrag_Click(object sender, EventArgs e)
        {
            Administrator_Pocetna administrator_Pocetna = new();
            administrator_Pocetna.Show();
            administrator_Pocetna.BringToFront();
            this.Close();
        }
    }
}
