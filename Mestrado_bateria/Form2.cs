using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Transferencia;
using Tabelas;

namespace Moura
{
    public partial class f_cadastro : Form
    {
        //Instanciando Modelo da Bateria
        Modelo_Tabela tabela_modelo = new Modelo_Tabela();
        ModeloBateriaColecao colecao_modelo = new ModeloBateriaColecao();

        //Instanciando Bateria
        Bateria_Tabela tabela_bateria = new Bateria_Tabela();
        BateriaColecao colecao_bateria = new BateriaColecao();

        //Instanciando Ensaio
        Ensaio_Tabela tabela_ensaio = new Ensaio_Tabela();
        EnsaioColecao colecao_ensaio = new EnsaioColecao();

        //Instanciando Etapas
        Etapa_Tabela tabela_etapa = new Etapa_Tabela();
        EtapaColecao colecao_etapa = new EtapaColecao();

        public f_cadastro()
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
            colecao_modelo = tabela_modelo.ConsultarModelosBateriaPorNome("");

            
            foreach (ModeloBateria modelo in colecao_modelo)
            {
                cB_modelo_bat.Items.Add(modelo.Modelo);
            }
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
            //Cadastro da Bateria
            if (p_bat.Visible == true)
            {
                try
                {
                    Bateria bateria = new Bateria();

                    bateria.NomeBateria = tB_nome_bat.Text;
                    bateria.Serie = tB_serie_bat.Text;
                    bateria.Lote = tB_lote_bat.Text;
                    bateria.Fabricacao = tB_fab_bat.Text;

                    ModeloBateriaColecao colecao_modelo = tabela_modelo.ConsultarModelosBateriaPorNome(cB_modelo_bat.Text);
                    bateria.Id = colecao_modelo[0].Id;

                    tabela_bateria.InserirBateria(bateria);

                    MessageBox.Show("Salvo com Sucesso!");
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Campos Inválidos! ");
                    MessageBox.Show(ex.ToString());

                }
            } //if Bateria

            //Cadastro do Modelo
            if (p_modelo.Visible == true)
            {
                try
                {
                    ModeloBateria modelobateria = new ModeloBateria();

                    modelobateria.Modelo = tB_modelo.Text;
                    modelobateria.Vbn = tB_Vbn.Text;
                    modelobateria.KT = tB_KT.Text;
                    modelobateria.Tb0 = tB_Tb0.Text;
                    modelobateria.C10 = tB_c10.Text;
                    modelobateria.C20 = tB_c20.Text;
                    modelobateria.C100 = tB_c100.Text;
                    modelobateria.VbFloat = tB_VbF.Text;
                    modelobateria.VbEq = tB_Vbe0.Text;

                    tabela_modelo.InserirModelosBateria(modelobateria);
                    MessageBox.Show("Salvo com Sucesso!");
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Campos Inválidos!");
                    MessageBox.Show(ex.ToString());
                }
            } // If Modelo

            //Cadastro Ensaio
            if (p_ensa.Visible == true)
            {
                Ensaio ensaio = new Ensaio();

                try
                {
                    //Pegar cliente selecionado no grid
                   // Etapa etapa = tabela_etapa.ConsultarEtapas();

                    ensaio.NomeEnsaio = tB_nome_ens.Text;
                    ensaio.Descricao = tB_desc_ensa.Text;
                    ensaio.TStart = tB_tstart_ensa.Text;
                    ensaio.TStop = tB_tstop_ensa.Text;
                    ensaio.TRun = tB_trun_ensa.Text;
                    ensaio.Ib = tB_ib_ensa.Text;
                    ensaio.KVb = tB_kvb_ensa.Text;
                    ensaio.Tbref = tB_tbref_ensa.Text;

                    tabela_ensaio.InserirEnsaio(ensaio);

                    MessageBox.Show("Salvo com Sucesso!");
                    this.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Campos Inválidos! ");
                    MessageBox.Show(ex.ToString());
                }

            }//If Ensaio

            //Cadastro Etapas
            if (p_etapa.Visible == true)
            {
                try
                {
                    Etapa etapa = new Etapa();

                    etapa.Tipo = tB_tipo_etap.Text;
                    etapa.Vb = tB_vb_etap.Text;
                    etapa.Qb = tB_qb_etap.Text;
                    etapa.NextQ = tB_neq_etap.Text;
                    etapa.NextV = tB_nev_etap.Text;
                    etapa.NextT = tB_net_etap.Text;
                    etapa.NextI = tB_nei_etap.Text;

                    tabela_etapa.InserirEtapa(etapa);

                    MessageBox.Show("Etapa inserida com sucesso!");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Campos Imválidos!!");
                    MessageBox.Show(ex.ToString());
                }
            }
        }

    }
}
