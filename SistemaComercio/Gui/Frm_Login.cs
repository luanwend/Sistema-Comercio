﻿using SistemaComercio.Gui;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaComercio
{
    public partial class Frm_Login : Form
    {
        IAdmPort service = new AdmService();


        public Frm_Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            var usuario = TxtUsuario.Text;
            var senha = TxtSenha.Text;

            var auth = service.Login(usuario, senha);


            if(auth)
            {
                MessageBox.Show("Bem vindo " + TxtUsuario.Text + "!");
                var principal = new Frm_Principal();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuário " + TxtUsuario.Text + " inválido!");
            }
        }
        private void SetPlaceholder(TextBox txtUsuario)
        {
            throw new NotImplementedException();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Cadastro cadastro = new Frm_Cadastro();
            cadastro.Show();
        }
    }
}