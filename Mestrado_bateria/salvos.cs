using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Moura
{
    public partial class f_salvos : Form
    {
        string data_file;
        string volt;
        string amper;
        string hour;

        public f_salvos()
        {
            InitializeComponent();
            file_acess();
            chart_ten_file.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart_current_file.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void file_acess()
        {
            string[] path = Directory.GetFiles(@"C:\Users\User\Documents\GitHub\Mestrado_bateria", "*.txt");
            foreach(string file in path)
            {
                cB_file.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
            
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (cB_file.SelectedIndex != -1)
            {
                StreamReader save_file = new StreamReader(cB_file.SelectedIndex.ToString() + ".txt");

                while ((data_file = save_file.ReadLine()) != null)
                {

                    //TODO - Extração dos dados

                    Double tensao = Convert.ToDouble(volt);
                    Double corrente = Convert.ToDouble(amper);
                    DateTime hora = Convert.ToDateTime(hour);

                    chart_ten_file.Series[0].Points.AddXY(hora, tensao);
                    chart_current_file.Series[0].Points.AddXY(hora, corrente);
                    chart_current_file.Update();
                    chart_ten_file.Update();
                }
            }
        }


    }
}
