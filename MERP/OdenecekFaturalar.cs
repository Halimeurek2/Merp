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

        public float[] month_sum = new float[12];
        public DateTime[] month = new DateTime[12];

        public float[] month_sumNew = new float[12];
        public DateTime[] monthNew = new DateTime[12];
        int i = 0;

        public OdenecekFaturalar()
        {
            InitializeComponent();
        }

        private void OdenecekFaturalar_Load(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();

            Array.Clear(monthNew, 0, 12);
            Array.Clear(month_sumNew, 0, 12);

            for (int index = 0; index < 12; index++)
            {
                if (month[index].Month >= DateTime.Now.Month)
                {
                    monthNew[i] = month[index];
                    month_sumNew[i] = month_sum[index];
                    i++;
                }
            }
            for (int k = 0; k < i; k++)
            {
                chart1.Series["Series1"].Points.AddXY(Convert.ToString(monthNew[k].Month) + ". ay", Convert.ToDecimal(month_sumNew[k]));
                chart1.Series["Series1"].Points[k].Label = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(month_sumNew[k]));
            }
        }
    }
}
