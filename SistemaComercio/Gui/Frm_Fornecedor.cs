﻿using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SistemaComercio.Gui
{
    public partial class Frm_Fornecedor : Form
    {
        private IFornecedorPort service = new FornecedorService();

        public Frm_Fornecedor()
        {
            InitializeComponent();
        }

        private void CadastrarFornecedor(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor()
            {
                Nome = txtNome.Text,
                Cpf_Cnpj = txtCPF.Text,
                Telefone = txtTel.Text,
                Cep = txtCEP.Text,
                Cidade = txtCidade.Text,
                Complemento = txtComple.Text,
                Email = txtEmail.Text,
                Estado = txtEstado.Text,
                Logradouro = txtLogra.Text,
                Numero = txtNum.Text,
                Bairro = txtBairro.Text,
            };

            try
            {
                //FAZER COM TODOS OS CAMPOS
                if (ValidarCampos()) { 
                    service.AddFornecedor(fornecedor);
                    dataGridViewForne.DataSource = service.GetAllFornecedor(); //trazer o fornecedor q acabamos de cadastrar no dataGrid
                    LimparCampos();
                    MessageBox.Show("Fornecedor cadastrado!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Você deve preencher todos os campos!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { 
                MessageBox.Show("Erro ao cadastrar fornecedor!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool ValidarCampos()
        {
            //FAZER COM TODOS OS CAMPOS
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtCPF.Text) ||
                String.IsNullOrEmpty(txtTel.Text) || String.IsNullOrEmpty(txtCEP.Text) ||
                String.IsNullOrEmpty(txtCidade.Text) || String.IsNullOrEmpty(txtComple.Text) ||
                String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtEstado.Text) ||
                String.IsNullOrEmpty(txtLogra.Text) || String.IsNullOrEmpty(txtNum.Text) || String.IsNullOrEmpty(txtBairro.Text))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void Frm_Fornecedor_Load(object sender, EventArgs e)
        {
          dataGridViewForne.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
          dataGridViewForne.DataSource = service.GetAllFornecedor();
        }

        private void ClickSair(object sender, EventArgs e)
        {
            var principal = new Frm_Principal();
            this.Hide();
        }

        private void ClickLimpar(object sender, EventArgs e)
        {
            LimparCampos();
            MessageBox.Show("Campos resetados!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtTel.Clear();
            txtCidade.Clear();
            txtEmail.Clear();
            txtLogra.Clear();
            txtCPF.Clear();
            txtCEP.Clear();
            txtComple.Clear();
            txtEstado.Clear();
            txtNum.Clear();
            txtBairro.Clear();
        }

        private void ClickPesquisar(object sender, EventArgs e)
        {
            dataGridViewForne.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewForne.DataSource = service.GetByNomeFornecedor(txtProcurar.Text);
        }
    }
}
