using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Moura
{
    public partial class f_cadastro : Form
    {
        public f_cadastro(f_moura principal)
        {
            InitializeComponent();
            view(false, true, true, true, true, false,false, false, false);
        }

        private void view(bool bot_cad, bool bot_modelo, bool bot_bat, bool bot_ensa, bool bot_etap, bool modelo, bool bateria, bool ensaio, bool etapa)
        {          
            bt_cadastrar.Visible = bot_cad;
            bt_modelo.Visible = bot_modelo;
            bt_bateria.Visible = bot_bat;
            bt_ensa.Visible = bot_ensa;
            bt_etap.Visible = bot_etap;

            p_modelo.Visible = modelo;
            p_bat.Visible = bateria;
            p_ensa.Visible = ensaio;
            p_etapa.Visible = etapa;

        }

        private void bt_modelo_Click(object sender, EventArgs e)
        {
            view(true, false, false, false, false, true,false, false, false);
        }

        private void bt_bateria_Click(object sender, EventArgs e)
        {
            view(true, false, false, false, false, false, true, false, false);
        }

        private void bt_ensa_Click(object sender, EventArgs e)
        {
            view(true, false, false, false, false, false, false, true, false);
        }

        private void bt_etap_Click(object sender, EventArgs e)
        {
            view(true, false, false, false, false, false, false, false, true);
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {

        }

    }
}
