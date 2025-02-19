﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Projeto_Principal
{
    public partial class GesClientes : Form
    {
        private Model1Container model;

        public GesClientes()
        {
            InitializeComponent();
        }

        private void btnRegistarCliente_Click(object sender, EventArgs e)
        {
            try
            {

                Morada moradaCliente = new Morada();
                Cliente cliente = new Cliente();

                string rua = txtRua.Text;
                string cidade = txtCidade.Text;
                string pais = txtPais.Text;
                string codpostal = txtPostalCod.Text;

                string nif = txtNumCont.Text;
                string nome = txtNome.Text;
                string tele = txtTelemovel.Text;

                if (nome.Trim() == "" || nif.Trim() == "" || tele.Trim() == "" || rua.Trim() == "" || cidade.Trim() == "" || pais.Trim() == "" || codpostal.Trim() == "") { throw new Exception("Preencha todos os campos"); }
                if (!txtPostalCod.MaskCompleted) { txtPostalCod.Focus(); throw new Exception("Preencha corretamente o código postal"); }
                if (!txtTelemovel.MaskCompleted) { txtTelemovel.Focus(); throw new Exception("Preencha corretamente o número de telemóvel"); }
                if (!txtNumCont.MaskCompleted) { txtNumCont.Focus(); throw new Exception("Preencha corretamente o NIF"); }

                moradaCliente.Rua = rua;
                moradaCliente.Cidade = cidade;
                moradaCliente.Pais = pais;
                moradaCliente.CodPostal = codpostal;

                cliente.NIF = nif;
                cliente.TotalGasto = 0;
                cliente.Morada = moradaCliente;
                cliente.Nome = nome;
                cliente.Telemovel = tele;

                model.Morada.Add(moradaCliente);
                model.Pessoa.Add(cliente);

                model.SaveChanges();
                LerDados();
                ClearTxtBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LerDados()
        {
            List<Cliente> listaCLientes = new List<Cliente>();

            foreach (Pessoa pessoa in model.Pessoa)
            {
                if (pessoa is Cliente)
                {
                    Cliente cliente = (Cliente)pessoa;
                    listaCLientes.Add(cliente);
                }
            }
            dataGridViewCliente.DataSource = listaCLientes;
        }

        private void GesClientes_Load(object sender, EventArgs e)
        {
            dataGridViewCliente.ReadOnly = true;
            model = new Model1Container();
            LerDados();
            AjustDataColumns();
        }

        private void btnApagarCliente_Click(object sender, EventArgs e)
        {
            Cliente userdata = GetSelectedCliente();

            if (VerifyPresenceCliente(userdata))
            {
                MessageBox.Show("Não pode apagar o Cliente selecionado pois ele já efetuou um pedido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                model.Pessoa.Remove(userdata);
                model.SaveChanges();
                LerDados();

                ClearTxtBox();
            }
        }

        private bool VerifyPresenceCliente(Cliente cliente)
        {
            List<Pedido> pedidos = model.Pedido.ToList();

            foreach (Pedido pedido in pedidos)
            {
                if(pedido.Cliente == cliente)
                {
                    return true;
                }
            }

            return false;
        }

        private void btnEditCliente_Click(object sender, EventArgs e)
        {
            try
            { 
                Cliente userdata = GetSelectedCliente();

                string rua = txtRua.Text;
                string cidade = txtCidade.Text;
                string pais = txtPais.Text;
                string codpostal = txtPostalCod.Text;

                string nif = txtNumCont.Text;
                string nome = txtNome.Text;
                string tele = txtTelemovel.Text;

                if (nome.Trim() == "" || nif.Trim() == "" || tele.Trim() == "" || rua.Trim() == "" || cidade.Trim() == "" || pais.Trim() == "" || codpostal.Trim() == "") { throw new Exception("Preencha todos os campos!"); }
                if (!txtPostalCod.MaskCompleted) { txtPostalCod.Focus(); throw new Exception("Preencha corretamente o código postal!"); }
                if (!txtTelemovel.MaskCompleted) { txtTelemovel.Focus(); throw new Exception("Preencha corretamente o número de telemóvel!"); }
                if (!txtNumCont.MaskCompleted) { txtNumCont.Focus(); throw new Exception("Preencha corretamente o NIF!"); }

                userdata.Nome = nome;
                userdata.Telemovel = tele;
                userdata.Morada.Cidade = cidade;
                userdata.NIF = nif;
                userdata.Morada.CodPostal = codpostal;
                userdata.Morada.Rua = rua;
                userdata.Morada.Pais = pais;

                model.SaveChanges();

                LerDados();
                ClearTxtBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Cliente userdata = GetSelectedCliente();

                txtNome.Text = userdata.Nome;
                txtTelemovel.Text = userdata.Telemovel;
                txtCidade.Text = userdata.Morada.Cidade;
                txtNumCont.Text = userdata.NIF;
                txtPostalCod.Text = userdata.Morada.CodPostal;
                txtRua.Text = userdata.Morada.Rua;
                txtPais.Text = userdata.Morada.Pais;
            }
            catch { }
        }

        private void AjustDataColumns()
        {
            dataGridViewCliente.Columns["Id"].DisplayIndex = 0;
            dataGridViewCliente.Columns["Nome"].DisplayIndex = 1;
        }

        private void ClearTxtBox()
        {
            txtRua.Text = "";
            txtCidade.Text = "";
            txtPais.Text = "";
            txtPostalCod.Text = "";
            txtNumCont.Text = "";
            txtNome.Text = "";
            txtTelemovel.Text = "";
        }

        private Cliente GetSelectedCliente()
        {
            try
            {
                int row = dataGridViewCliente.SelectedCells[0].RowIndex;
                int id = (int)dataGridViewCliente.Rows[row].Cells["id"].Value;
                Cliente data = model.Pessoa.First(c => c.Id == id) as Cliente;
                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um Cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente userdata = GetSelectedCliente();
                History.id = userdata.Id;

                Form menu = this.Parent.FindForm();
                Form form = new History(menu);
                form.Show();
                menu.Hide();
            }
            catch (Exception){}
        }
    }
}
