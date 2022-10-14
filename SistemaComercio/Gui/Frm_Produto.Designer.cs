﻿namespace SistemaComercio.Gui
{
    partial class Frm_Produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.cmbNomeForne = new System.Windows.Forms.ComboBox();
            this.lblNomeForne = new System.Windows.Forms.Label();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.dataGridViewProd = new System.Windows.Forms.DataGridView();
            this.pnlMeio = new System.Windows.Forms.Panel();
            this.pnlFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblNome.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(95, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Produto:";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblEstoque.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(12, 72);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(120, 13);
            this.lblEstoque.TabIndex = 1;
            this.lblEstoque.Text = "Quantidade em estoque:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblPreco.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(12, 102);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(37, 13);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço:";
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblUnidade.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.Location = new System.Drawing.Point(256, 102);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(50, 13);
            this.lblUnidade.TabIndex = 3;
            this.lblUnidade.Text = "Unidade:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(113, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(345, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(135, 68);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(323, 20);
            this.txtEstoque.TabIndex = 5;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(50, 98);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(200, 20);
            this.txtPreco.TabIndex = 6;
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlFundo.Controls.Add(this.cmbNomeForne);
            this.pnlFundo.Controls.Add(this.lblNomeForne);
            this.pnlFundo.Controls.Add(this.txtNome);
            this.pnlFundo.Controls.Add(this.cmbUnidade);
            this.pnlFundo.Controls.Add(this.lblNome);
            this.pnlFundo.Controls.Add(this.btnSair);
            this.pnlFundo.Controls.Add(this.txtEstoque);
            this.pnlFundo.Controls.Add(this.btnExcluir);
            this.pnlFundo.Controls.Add(this.lblEstoque);
            this.pnlFundo.Controls.Add(this.btnLimpar);
            this.pnlFundo.Controls.Add(this.txtPreco);
            this.pnlFundo.Controls.Add(this.btnAtualizar);
            this.pnlFundo.Controls.Add(this.lblPreco);
            this.pnlFundo.Controls.Add(this.btnCadastrar);
            this.pnlFundo.Controls.Add(this.lblUnidade);
            this.pnlFundo.Controls.Add(this.btnPesquisar);
            this.pnlFundo.Controls.Add(this.txtPesquisar);
            this.pnlFundo.Controls.Add(this.lblPesquisar);
            this.pnlFundo.Controls.Add(this.dataGridViewProd);
            this.pnlFundo.Controls.Add(this.pnlMeio);
            this.pnlFundo.Location = new System.Drawing.Point(-3, -4);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(475, 401);
            this.pnlFundo.TabIndex = 8;
            // 
            // cmbNomeForne
            // 
            this.cmbNomeForne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeForne.FormattingEnabled = true;
            this.cmbNomeForne.Items.AddRange(new object[] {
            "Nenhum"});
            this.cmbNomeForne.Location = new System.Drawing.Point(126, 9);
            this.cmbNomeForne.Name = "cmbNomeForne";
            this.cmbNomeForne.Size = new System.Drawing.Size(332, 21);
            this.cmbNomeForne.TabIndex = 18;
            // 
            // lblNomeForne
            // 
            this.lblNomeForne.AutoSize = true;
            this.lblNomeForne.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblNomeForne.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeForne.Location = new System.Drawing.Point(12, 13);
            this.lblNomeForne.Name = "lblNomeForne";
            this.lblNomeForne.Size = new System.Drawing.Size(111, 13);
            this.lblNomeForne.TabIndex = 17;
            this.lblNomeForne.Text = "Nome do Fornecedor:";
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Items.AddRange(new object[] {
            "Nenhum",
            "N"});
            this.cmbUnidade.Location = new System.Drawing.Point(302, 98);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(156, 21);
            this.cmbUnidade.TabIndex = 16;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::SistemaComercio.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(386, 361);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(72, 26);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "    Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.ClickSair);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::SistemaComercio.Properties.Resources.lixo;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(276, 361);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 26);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "     Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::SistemaComercio.Properties.Resources.limpar;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(189, 361);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(81, 26);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "    Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.ClickLimpar);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = global::SistemaComercio.Properties.Resources.atualizar;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(102, 361);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(81, 26);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "    Editar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = global::SistemaComercio.Properties.Resources.adicionar;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(15, 361);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(81, 26);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "    Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.CadastrarProduto);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = global::SistemaComercio.Properties.Resources.lupa;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(372, 154);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(86, 28);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "    Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(113, 158);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(251, 20);
            this.txtPesquisar.TabIndex = 9;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblPesquisar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(12, 162);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(104, 13);
            this.lblPesquisar.TabIndex = 9;
            this.lblPesquisar.Text = "Pesquisar por nome:";
            // 
            // dataGridViewProd
            // 
            this.dataGridViewProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProd.Location = new System.Drawing.Point(15, 184);
            this.dataGridViewProd.Name = "dataGridViewProd";
            this.dataGridViewProd.Size = new System.Drawing.Size(443, 171);
            this.dataGridViewProd.TabIndex = 1;
            // 
            // pnlMeio
            // 
            this.pnlMeio.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlMeio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMeio.Location = new System.Drawing.Point(3, 135);
            this.pnlMeio.Name = "pnlMeio";
            this.pnlMeio.Size = new System.Drawing.Size(472, 10);
            this.pnlMeio.TabIndex = 0;
            // 
            // Frm_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 391);
            this.Controls.Add(this.pnlFundo);
            this.MaximizeBox = false;
            this.Name = "Frm_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewProd;
        private System.Windows.Forms.Panel pnlMeio;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.ComboBox cmbNomeForne;
        private System.Windows.Forms.Label lblNomeForne;
    }
}