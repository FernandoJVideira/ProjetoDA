﻿namespace Projeto_Principal
{
    partial class GerirRestaurante
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
            this.components = new System.ComponentModel.Container();
            this.txtRemove = new System.Windows.Forms.Button();
            this.txtPosicao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddTrabalhador = new System.Windows.Forms.Button();
            this.RoundedBorders = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTrabalhadores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelemovel = new System.Windows.Forms.MaskedTextBox();
            this.txtPostalCod = new System.Windows.Forms.MaskedTextBox();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrabalhadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(184, 397);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(90, 23);
            this.txtRemove.TabIndex = 1;
            this.txtRemove.Text = "Remover";
            this.txtRemove.UseVisualStyleBackColor = true;
            this.txtRemove.Click += new System.EventHandler(this.txtRemove_Click);
            // 
            // txtPosicao
            // 
            this.txtPosicao.Location = new System.Drawing.Point(140, 363);
            this.txtPosicao.Name = "txtPosicao";
            this.txtPosicao.Size = new System.Drawing.Size(123, 20);
            this.txtPosicao.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Posição";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Salario";
            // 
            // btnAddTrabalhador
            // 
            this.btnAddTrabalhador.Location = new System.Drawing.Point(49, 397);
            this.btnAddTrabalhador.Name = "btnAddTrabalhador";
            this.btnAddTrabalhador.Size = new System.Drawing.Size(129, 23);
            this.btnAddTrabalhador.TabIndex = 28;
            this.btnAddTrabalhador.Text = "Registar Trabalhador";
            this.btnAddTrabalhador.UseVisualStyleBackColor = true;
            this.btnAddTrabalhador.Click += new System.EventHandler(this.btnAddTrabalhador_Click);
            // 
            // RoundedBorders
            // 
            this.RoundedBorders.TargetControl = this;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(140, 290);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(123, 20);
            this.txtPais.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Pais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Cod. Postal";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(140, 204);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(123, 20);
            this.txtCidade.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Cidade";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(140, 160);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(123, 20);
            this.txtRua.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Rua";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(140, 64);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(123, 20);
            this.txtNome.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nome";
            // 
            // dataGridViewTrabalhadores
            // 
            this.dataGridViewTrabalhadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrabalhadores.Location = new System.Drawing.Point(302, 51);
            this.dataGridViewTrabalhadores.Name = "dataGridViewTrabalhadores";
            this.dataGridViewTrabalhadores.Size = new System.Drawing.Size(662, 405);
            this.dataGridViewTrabalhadores.TabIndex = 44;
            this.dataGridViewTrabalhadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrabalhadores_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Telvemovel";
            // 
            // txtTelemovel
            // 
            this.txtTelemovel.Location = new System.Drawing.Point(140, 109);
            this.txtTelemovel.Mask = "990000000";
            this.txtTelemovel.Name = "txtTelemovel";
            this.txtTelemovel.Size = new System.Drawing.Size(123, 20);
            this.txtTelemovel.TabIndex = 46;
            // 
            // txtPostalCod
            // 
            this.txtPostalCod.Location = new System.Drawing.Point(140, 247);
            this.txtPostalCod.Mask = "0000-999";
            this.txtPostalCod.Name = "txtPostalCod";
            this.txtPostalCod.Size = new System.Drawing.Size(123, 20);
            this.txtPostalCod.TabIndex = 47;
            // 
            // btnAtualizarDados
            // 
            this.btnAtualizarDados.Location = new System.Drawing.Point(49, 433);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Size = new System.Drawing.Size(225, 23);
            this.btnAtualizarDados.TabIndex = 71;
            this.btnAtualizarDados.Text = "Salvar Alterações";
            this.btnAtualizarDados.UseVisualStyleBackColor = true;
            this.btnAtualizarDados.Click += new System.EventHandler(this.btnAtualizarDados_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.DecimalPlaces = 2;
            this.txtSalario.Location = new System.Drawing.Point(140, 327);
            this.txtSalario.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(123, 20);
            this.txtSalario.TabIndex = 72;
            this.txtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSalario.ThousandsSeparator = true;
            // 
            // GerirRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 545);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.btnAtualizarDados);
            this.Controls.Add(this.txtPostalCod);
            this.Controls.Add(this.txtTelemovel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTrabalhadores);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddTrabalhador);
            this.Controls.Add(this.txtPosicao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRemove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerirRestaurante";
            this.Text = "Gerir Funcionários";
            this.Load += new System.EventHandler(this.GerirRestaurante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrabalhadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button txtRemove;
        private System.Windows.Forms.TextBox txtPosicao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddTrabalhador;
        private Guna.UI2.WinForms.Guna2Elipse RoundedBorders;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewTrabalhadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtTelemovel;
        private System.Windows.Forms.MaskedTextBox txtPostalCod;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.NumericUpDown txtSalario;
    }
}