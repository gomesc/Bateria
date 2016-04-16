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

        string text_input;

        string voltage;
        string current;
        string temp_battery;

        private delegate void SetTextDeleg(string text);

        public f_moura()
        {
            InitializeComponent();
            portas_disponiveis();
            serial = new SerialPort();
            permissoes_p(false, false, false, true,false,false,false,true,true,false,false);
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
                permissoes_p(true,true,false,true,false,false,false,true,true,false,false);

            } // if portas

            else
            {
                define_status(false);
                permissoes_p(false, false, false, true,false,false,false,true,true,false,false);
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
            bool view, bool ens, bool painel_cadastro)
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

            p_cadastro.Visible = painel_cadastro;

        }

        private void bt_verify_Click(object sender, EventArgs e)
        {
            portas_disponiveis();
        }

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
                permissoes_p(false, false, true, false,true,true,true,true,true,true,false);
                define_status(true);
            }
        }

        private void bt_desconnect_Click(object sender, EventArgs e)
        {
            if (serial != null && serial.IsOpen)
            {
                serial.Close();
                serial = null;
                define_status(false);
                portas_disponiveis();
            }
        }

        private void serialport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(500);
            text_input = serial.ReadLine();
            this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] {text_input});
        }

        //Tratar os dados de entrada
        private void si_DataReceived(string text_input)
        {
            //Implementar!!!
            tB_ten.Text = voltage.Trim();
            tB_current.Text = current.Trim();
            tB_temp_bat.Text = temp_battery.Trim();
        }

        private void bt_cadastro_Click(object sender, EventArgs e)
        {
            permissoes_p(false,false,false,false,false,false,false,false,false,false,true);
        }

    }
}
