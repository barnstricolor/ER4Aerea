﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ER4Aerea
{
    public partial class frmPesquisa : Form
    {
        public Repositorio repositorio { get; set; }
        
        public string codigo { get; set; }
        public string descricao { get; set; }
        public string tabela { get; set; }
        
        public Form tela { get; set; }

        public UCTextBox id_retorno { get; set; }
        public UCTextBox nom_retorno { get; set; }
        
        public frmPesquisa()
        {
            InitializeComponent();
        }

        public int getIdDominio() {
            if (grd.SelectedRows.Count > 0)
            {
                return (int)grd.SelectedRows[0].Cells[0].Value;
            }
            return 0;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            grd.Rows.Clear();
            HashSet<Dominio> lista = repositorio.obterByFiltroString(txtNomOrigem.Text);
            foreach (var dominio in lista)
            {
                preencherRow(dominio);
            }            
        }
        private void preencherRow(Dominio dominio) {
            object[] valores = repositorio.extrairValores(dominio);
            grd.Rows.Add(valores);
        }
        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnPesquisar.PerformClick();
        }
        private void grd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.PerformClick();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
