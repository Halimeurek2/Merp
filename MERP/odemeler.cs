using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MERP
{
    public partial class odemeler : Form
    {
        public odemeler()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            txt_toplam.Text = Convert.ToString(Convert.ToDouble(txt_test.Text) + Convert.ToDouble(txt_avans.Text) + Convert.ToDouble(txt_cdr.Text) + Convert.ToDouble(txt_kabul.Text) + Convert.ToDouble(txt_pdr.Text) + Convert.ToDouble(txt_prototip.Text));

        }
    }
}
