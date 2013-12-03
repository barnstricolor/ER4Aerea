using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ER4Aerea
{
    class VooController:Controller
    {
        public static VooController criar() { return new VooController(); }
        
        protected frmVoo frmTela { get; set; }

        protected frmVoo tela()
        {
            return frmTela;
        }

        protected override void configurarPesquisaTela(frmPesquisa pesquisaTela, Form mdi)
        {
            pesquisaTela.Text = "Cadastro de Voo";
            pesquisaTela.grd.ColumnCount = 6;
            pesquisaTela.grd.Columns[2].Name = "Origem";
            pesquisaTela.grd.Columns[2].Width = 200;
            pesquisaTela.grd.Columns[3].Name = "Destino";
            pesquisaTela.grd.Columns[3].Width = 200;
            pesquisaTela.grd.Columns[4].Name = "Partida";
            pesquisaTela.grd.Columns[4].Width = 200;
            pesquisaTela.grd.Columns[5].Name = "Chegada";
            pesquisaTela.grd.Columns[5].Width = 200;
        }

        private bool validaTela() {
            foreach (Control x in tela().Controls)
            {
                if (x is TextBox)
                {
                    if (((TextBox)x).Name != "txtId")
                        if (string.IsNullOrWhiteSpace(((TextBox)x).Text))
                        {
                            MessageBox.Show("Informe todos os valores");
                            return false;
                        }                        
                }
            }
            return true;

        }
        protected override void salvar_Click(object sender, EventArgs e)
        {
            if (validaTela())
            {

                CidadeRepositorio cidadeRepositorio = new CidadeRepositorio();
                Cidade origem = (Cidade)cidadeRepositorio.obter((int)tela().dcbOrigem.SelectedValue);
                Cidade destino = (Cidade)cidadeRepositorio.obter((int)(tela().dcbDestino.SelectedValue));
                AviaoRepositorio aviaoRepositorio = new AviaoRepositorio();
                Aviao aviao = (Aviao)aviaoRepositorio.obter((int)tela().dcbAviao.SelectedValue);

                Voo voo = null;
                if (string.IsNullOrEmpty(tela().txtId.Text))
                    voo = new Voo(aviao, origem, destino, DateTime.Parse(tela().dtpPartida.Text), float.Parse(tela().txtPreco.Text));
                else
                    voo = (Voo)repositorio().obter(int.Parse(tela().txtId.Text));
                voo.aviao.id = (int)tela().dcbAviao.SelectedValue;
                voo.origem.id = (int)tela().dcbOrigem.SelectedValue;
                voo.destino.id = (int)tela().dcbDestino.SelectedValue;
                voo.preco = float.Parse(tela().txtPreco.Text);
                voo.partida = tela().dtpPartida.Value;
                
                voo.chegada = DateTime.Parse(tela().dtpChegada.Text);

                if (tela().chkPromocao.Checked)
                    voo.promocao = "S";
                else
                    voo.promocao = "N";

                repositorio().salvar(voo);

                if (voo.promocao == "S")
                {
                    enviarPromocao(voo);
                }

                tela().Close();
                pesquisaTela.btnPesquisar.PerformClick();
            }
        }

        protected override void editar_Click(object sender, EventArgs e)
        {
            int id = pesquisaTela.getIdDominio();
            Voo voo = (Voo)repositorio().obter(id);

            criarTela();

            carregarCidade(tela().dcbOrigem);
            carregarCidade(tela().dcbDestino);
            carregarAviao(tela().dcbAviao);

            tela().txtId.Text = voo.id.ToString();
            tela().dcbAviao.SelectedValue = voo.aviao.id;
            tela().dcbOrigem.SelectedValue = voo.origem.id;
            tela().dcbDestino.SelectedValue = voo.destino.id;
            tela().txtPreco.Text = voo.preco.ToString();
            tela().dtpPartida.Value = voo.partida;
            tela().dtpChegada.Value = voo.chegada;
            if (voo.promocao == "S")
                tela().chkPromocao.Checked = true;
            else
                tela().chkPromocao.Checked = false;
            tela().ShowDialog();                        
            
        }
       
        protected override Form criarTela() {
            this.frmTela = new frmVoo();
            frmTela.btnSalvar.Click += new EventHandler(this.salvar_Click);
            frmTela.dcbOrigem.Click += new EventHandler(this.carregarCidade);
            frmTela.dcbDestino.Click += new EventHandler(this.carregarCidade);
            frmTela.dcbAviao.Click += new EventHandler(this.carregarAviao);
            frmTela.Text = "Cadastro de Voo";
            return frmTela;
        }

        protected override Repositorio repositorio() {
            return new VooRepositorio();
        }

        public void enviarPromocao(Voo voo)
        {
            Email email = new Email();
            ClienteRepositorio repo = new ClienteRepositorio();
            HashSet<Cliente> result = new HashSet<Cliente>();
            
            string post = "Saldão ER4Aerea - Passagens Nacionais até pela metade do preço‏ ";
            post += "De: " + voo.origem.nome + " a " + voo.destino.nome + " por " + voo.preco.ToString("C2");

            int i = 0;
            foreach (Dominio dominio in repo.obterPromocao())
            {
                email.enviar(((Cliente)dominio).email,post);
                i++;
            }
            Twitter twitter = new Twitter();

            twitter.postar(post);
            MessageBox.Show("Emails enviados: " + i + " e Twitter Atualizado.");
        }
        protected void carregarCidade(object sender, EventArgs e)
        {
            CidadeRepositorio repo = new CidadeRepositorio();
            HashSet<Dominio> lista = repo.obterTodos();
            carregarDataComboCidade(lista, (ComboBox)sender);
        }

        protected void carregarCidade(ComboBox cbo)
        {
            CidadeRepositorio repo = new CidadeRepositorio();
            HashSet<Dominio> lista = repo.obterTodos();
            carregarDataComboCidade(lista, cbo);
        }
        protected void carregarDataComboCidade(HashSet<Dominio> lista, ComboBox dcb)
        {
            Hashtable table = new Hashtable();
            foreach (Dominio dominio in lista)
            {
                Cidade cidade = (Cidade)dominio;
                table.Add(cidade.id, cidade.nome);
            }
            dcb.DataSource = new BindingSource(table, null);
            dcb.DisplayMember = "Value";
            dcb.ValueMember = "Key";
        }
        protected void carregarAviao(object sender, EventArgs e)
        {
            AviaoRepositorio repo = new AviaoRepositorio();
            HashSet<Dominio> lista = repo.obterTodos();
            carregarDataComboAviao(lista, (ComboBox)sender);
        }

        protected void carregarAviao(ComboBox cbo)
        {
            AviaoRepositorio repo = new AviaoRepositorio();
            HashSet<Dominio> lista = repo.obterTodos();
            carregarDataComboAviao(lista, cbo);
        }
        protected void carregarDataComboAviao(HashSet<Dominio> lista, ComboBox dcb)
        {
            Hashtable table = new Hashtable();
            foreach (Dominio dominio in lista)
            {
                Aviao aviao = (Aviao)dominio;
                table.Add(aviao.id, aviao.modelo);
            }
            dcb.DataSource = new BindingSource(table, null);
            dcb.DisplayMember = "Value";
            dcb.ValueMember = "Key";
        }

    }
}
