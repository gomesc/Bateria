using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;


namespace Moura
{
    public partial class f_moura : Form
    {
        SerialPort serial;
        string[] portas;
        int time = 500;
 
        string text_input;

        private delegate void SetTextDeleg(string text);

        public f_moura()
        {
            InitializeComponent();
            define_status(false);
            serial = new SerialPort();
            permissoes_p(false, false, false, true,false,false,false,true,true,false);
        }

        private void portas_disponiveis()
        {
            portas = SerialPort.GetPortNames();

            if (portas.Length > 0)
            {
                cB_port.Items.Clear();
                cB_port.SelectedIndex = -1;

                foreach (string s in SerialPort.GetPortNames())
                {
                    cB_port.Items.Add(s);
                } //foreach

                define_status(false);
                permissoes_p(true,true,false,true,false,false,false,true,true,false);
            } // if portas

            else
            {
                define_status(false);
                permissoes_p(false, false, false, true,false,false,false,true,true,false);
            } //else
            
        } //função

        private void define_status(bool status)
        {
            if (status == true)
            {
                status_label.Text = "Conectada";
                status_label.ForeColor = Color.Green;
            }
            else
            {
                status_label.Text = "Desconectada";
                status_label.ForeColor = Color.Red;
            }
        }

        private void permissoes_p(bool port, bool connect, bool desconnect,
            bool verificar, bool tensao, bool corrente, bool temp_bateria, bool cad,
            bool view, bool ens)
        {
            cB_port.Enabled = port;
            bt_connect.Enabled = connect;
            bt_desconnect.Enabled = desconnect;
            bt_verify.Enabled = verificar;
            bt_cadastro.Enabled = cad;
            bt_view.Enabled = view;
            bt_ensaio.Enabled = ens;
            tB_ten.Enabled = tensao;
            tB_current.Enabled = corrente;
            tB_temp_bat.Enabled = temp_bateria;
        }

        private void bt_verify_Click(object sender, EventArgs e)
        {
            portas_disponiveis();
        }

        #region Conectar Botão
        private void bt_connect_Click(object sender, EventArgs e)
        {
            if (cB_port.SelectedIndex != -1)
            {
                serial.PortName = cB_port.SelectedItem.ToString();
                serial.BaudRate = 9600;
            }
            else
            {
                throw new Exception("Selecionar a Porta Serial.");
            }

            if (!serial.IsOpen)
            {
                serial.Open();
                permissoes_p(false, false, true, false,true,true,true,true,true,true);
                define_status(true);
            }
        }
        #endregion

        private void bt_desconnect_Click(object sender, EventArgs e)
        {
            if (serial != null && serial.IsOpen)
            {
                serial.Close();
                serial = null;
                define_status(false);
            }
            portas_disponiveis();
        }

        private void serialport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] data_input = new byte[10];

            serial.Read(data_input, 0, 10);
            Thread.Sleep(time);

            if (data_input[0] == 0x55)
            {
                //checksum
                byte soma = Convert.ToByte((data_input[0] + data_input[1] + data_input[2] + data_input[3] + data_input[4] + data_input[5] + data_input[6] + data_input[7] + data_input[8]) & 0xFF);
                byte cs = Convert.ToByte((soma + data_input[9]) & 0xFF);

                if (cs == 0)
                {
                    foreach (byte data in data_input)
                    {
                        text_input += string.Format("{0:X2}",data);
                    }

                    int i_bat = Convert.ToInt32(text_input.Substring(2, 4), 16);
                    int v_bat = Convert.ToInt32(text_input.Substring(6, 4), 16);
                    int t_bat = Convert.ToInt32(text_input.Substring(10, 4), 16);
                    int t_amb = Convert.ToInt32(text_input.Substring(14, 4), 16);

                    decimal voltage = v_bat / 1240.9090M;
                    decimal current = i_bat * 0.0093M - 19.5126M;
                    decimal temp_bat = (t_bat / 1240.9090M)*100;
                    decimal temp_amb = (t_amb / 1240.9090M)*100;

                    tB_ten.Text = voltage.ToString("N3");
                    tB_current.Text = current.ToString("N3");
                    tB_current.Text = temp_bat.ToString("N2");

                }
            }
        //    text_input = serial.ReadLine();
        //    this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] {text_input});
        }

        //Tratar os dados de entrada
 /*       private void si_DataReceived(string text_input)
        {
            
            tB_ten.Text = voltage.Trim();
            tB_current.Text = current.Trim();
            tB_temp_bat.Text = temp_battery.Trim();
        } */

        private void bt_cadastro_Click(object sender, EventArgs e)
        {
            f_cadastro cadastro = new f_cadastro();
            cadastro.Show();
            //permissoes_p(false,false,false,false,false,false,false,false,false,false,true);
        }

        private void f_moura_Load(object sender, EventArgs e)
        {
            serial.ReadTimeout = time;
            serial.WriteTimeout = time;
        }

        private void bt_view_Click(object sender, EventArgs e)
        {
            f_salvos salvo = new f_salvos();
            salvo.Show();
        }

        private void bt_ensaio_Click(object sender, EventArgs e)
        {
            f_ensaio ensaio_f = new f_ensaio();
            ensaio_f.Show();
        }

        private void f_moura_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serial != null && serial.IsOpen)
            {
                serial.Close();
                serial = null;
                define_status(false);
                portas_disponiveis();
            }
        } //f_moura_FormClosed

    }
}
