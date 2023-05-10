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
    public partial class UrediObavijestGlavnaForma : Form
    {
        public UrediObavijestGlavnaForma()
        {
            InitializeComponent();
        }

        private void BtnNatrag_Click(object sender, EventArgs e)
        {
            UrediObavijest urediObavijest = new();
            urediObavijest.Show();
            urediObavijest.BringToFront();
            this.Close();
        }
    }
}
