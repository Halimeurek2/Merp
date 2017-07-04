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
    public partial class harcama_ongorusu : Form
    {
        HelperFunctions hf;

        public string harcama;

        public harcama_ongorusu()
        {
            InitializeComponent();
            hf = new HelperFunctions();
        }

        private void harcama_ongorusu_Load(object sender, EventArgs e)
        {

               }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            txt_avans.Text = hf.Comma2Dot(txt_avans.Text);
            txt_cdr.Text = hf.Comma2Dot(txt_cdr.Text);
            txt_el_mlz.Text = hf.Comma2Dot(txt_el_mlz.Text);
            txt_imalat.Text = hf.Comma2Dot(txt_imalat.Text);
            txt_kabul.Text = hf.Comma2Dot(txt_kabul.Text);
            txt_m_mlz.Text = hf.Comma2Dot(txt_m_mlz.Text);
            txt_o_test.Text = hf.Comma2Dot(txt_o_test.Text);
            txt_pdr.Text = hf.Comma2Dot(txt_pdr.Text);
            txt_prototip.Text = hf.Comma2Dot(txt_prototip.Text);
            txt_risk.Text = hf.Comma2Dot(txt_risk.Text);
            txt_test.Text = hf.Comma2Dot(txt_test.Text);
            txt_toplam.Text = hf.Comma2Dot(txt_toplam.Text);


            txt_toplam.Text = Convert.ToString(Convert.ToDecimal(txt_test.Text) + Convert.ToDecimal(txt_risk.Text)+ Convert.ToDecimal(txt_m_mlz.Text)+ Convert.ToDecimal(txt_imalat.Text)+ Convert.ToDecimal(txt_el_mlz.Text));

            proje_giris f1 = (proje_giris)Application.OpenForms["proje_giris"];
            proje_duzenle f2 = (proje_duzenle)Application.OpenForms["proje_duzenle"];
            if (f1 != null)
            {
                Label label_harcamalar = (Label)f1.Controls["lbl_harcamalar"];
                Label label_birim = (Label)f1.Controls["lbl_birim"];
                label_harcamalar.Text = txt_toplam.Text.ToString();
                label_birim.Text = cmb_toplam_brm.Text.ToString();
                f1.harcama_m_mlz = Convert.ToString(txt_m_mlz.Text);
                f1.harcama_el_mlz = Convert.ToString(txt_el_mlz.Text);
                f1.harcama_imalat = Convert.ToString(txt_imalat.Text);
                f1.harcama_test = Convert.ToString(txt_test.Text);
                f1.harcama_risk = Convert.ToString(txt_risk.Text);
                f1.odeme_avans = Convert.ToString(txt_avans.Text);
                f1.odeme_pdr = Convert.ToString(txt_pdr.Text);
                f1.odeme_cdr = Convert.ToString(txt_cdr.Text);
                f1.odeme_prototip = Convert.ToString(txt_prototip.Text);
                f1.odeme_test = Convert.ToString(txt_o_test.Text);
                f1.odeme_kabul = Convert.ToString(txt_kabul.Text);
                f1.dtp_avans = Convert.ToDateTime(dtp_avans.Text);
                f1.dtp_cdr = Convert.ToDateTime(dtp_cdr.Text);
                f1.dtp_kabul = Convert.ToDateTime(dtp_kabul.Text);
                f1.dtp_prototip = Convert.ToDateTime(dtp_prototip.Text);
                f1.dtp_pdr = Convert.ToDateTime(dtp_pdr.Text);
                f1.dtp_test = Convert.ToDateTime(dtp_test.Text);

            }
            else
            {
                Label label_harcamalar = (Label)f2.Controls["lbl_harcamalar"];
                Label label_birim = (Label)f2.Controls["lbl_birim"];
                label_harcamalar.Text = txt_toplam.Text.ToString();
                label_birim.Text = cmb_toplam_brm.Text.ToString();
                f2.harcama_m_mlz = Convert.ToString(txt_m_mlz.Text);
                f2.harcama_el_mlz = Convert.ToString(txt_el_mlz.Text);
                f2.harcama_imalat = Convert.ToString(txt_imalat.Text);
                f2.harcama_test = Convert.ToString(txt_test.Text);
                f2.harcama_risk = Convert.ToString(txt_risk.Text);
                f2.odeme_avans = Convert.ToString(txt_avans.Text);
                f2.odeme_pdr = Convert.ToString(txt_pdr.Text);
                f2.odeme_cdr = Convert.ToString(txt_cdr.Text);
                f2.odeme_prototip = Convert.ToString(txt_prototip.Text);
                f2.odeme_test = Convert.ToString(txt_o_test.Text);
                f2.odeme_kabul = Convert.ToString(txt_kabul.Text);
                f2.dtp_avans = Convert.ToDateTime(dtp_avans.Text);
                f2.dtp_cdr = Convert.ToDateTime(dtp_cdr.Text);
                f2.dtp_kabul = Convert.ToDateTime(dtp_kabul.Text);
                f2.dtp_prototip = Convert.ToDateTime(dtp_prototip.Text);
                f2.dtp_pdr = Convert.ToDateTime(dtp_pdr.Text);
                f2.dtp_test = Convert.ToDateTime(dtp_test.Text);
            }
            this.Close();
        }

    }
}
