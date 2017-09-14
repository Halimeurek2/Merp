using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MERP
{
    public partial class OdenecekFaturalar : Form
    {

        public float[] month_sumG = new float[12];
        public DateTime[] monthG = new DateTime[12];

        public float[] month_sumNewG = new float[12];
        public DateTime[] monthNewG = new DateTime[12];

        public float[] month_sumK = new float[12];
        public DateTime[] monthK = new DateTime[12];

        public float[] month_sumNewK = new float[12];
        public DateTime[] monthNewK = new DateTime[12];

        int i, j = 0;

        public OdenecekFaturalar()
        {
            InitializeComponent();
        }

        private void OdenecekFaturalar_Load(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            chart2.Series["Series1"].Points.Clear();

            Array.Clear(monthNewG, 0, 12);
            Array.Clear(month_sumNewG, 0, 12);
            Array.Clear(monthNewK, 0, 12);
            Array.Clear(month_sumNewK, 0, 12);

            for (int index = 0; index < 12; index++)
            {
                if (monthG[index].Year == DateTime.Now.Year)
                {
                    monthNewG[i] = monthG[index];
                    month_sumNewG[i] = month_sumG[index];
                    i++;
                }
            }
            for (int index = 0; index < 12; index++)
            {
                if (monthK[index].Year == DateTime.Now.Year)
                {
                    monthNewK[i] = monthK[index];
                    month_sumNewK[i] = month_sumK[index];
                    j++;
                }
            }

            for (int k = 0; k < i; k++)
            {
                chart1.Series["Series1"].Points.AddXY(Convert.ToString(monthNewG[k].Month) + ". ay", Convert.ToDecimal(month_sumNewG[k]));
                chart1.Series["Series1"].Points[k].Label = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(month_sumNewG[k]));
            }
            for (int k = 0; k < j; k++)
            {
                chart2.Series["Series1"].Points.AddXY(Convert.ToString(monthNewK[k].Month) + ". ay", Convert.ToDecimal(month_sumNewK[k]));
                chart2.Series["Series1"].Points[k].Label = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(month_sumNewK[k]));
            }
        }
    }
}
