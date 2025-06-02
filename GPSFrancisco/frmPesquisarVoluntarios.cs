﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFrancisco
{
    public partial class frmPesquisarVoluntarios : Form
    {
        public frmPesquisarVoluntarios()
        {
            InitializeComponent();
        }
        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = ltbPesquisar.SelectedItems.ToString();

            frmGerenciarVoluntarios abrir = new frmGerenciarVoluntarios(nome);
            abrir.Show();
            this.Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ltbPesquisar.Items.Add(txtDescricao.Text);
        }
    }
}
