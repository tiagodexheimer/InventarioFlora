/*
 * ${res:XML.StandardHeader.Tiago Dexheimer}
 * User: SMMA
 * Date: 05/09/2019
 * Time: 16:22
 * 
 */
namespace InventarioFlora.Formularios
{
	partial class FrmEspecie
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridEspecie;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.Button btnAtualizar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.TextBox txtNCientifico;
		private System.Windows.Forms.TextBox txtNComum;
		private System.Windows.Forms.CheckBox checkNativa;
		private System.Windows.Forms.CheckBox checkAmeacada;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBPorte;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBFamilia;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridEspecie = new System.Windows.Forms.DataGridView();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.txtNCientifico = new System.Windows.Forms.TextBox();
			this.txtNComum = new System.Windows.Forms.TextBox();
			this.checkNativa = new System.Windows.Forms.CheckBox();
			this.checkAmeacada = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBPorte = new System.Windows.Forms.ComboBox();
			this.comboBFamilia = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridEspecie)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridEspecie
			// 
			this.dataGridEspecie.Location = new System.Drawing.Point(12, 12);
			this.dataGridEspecie.Name = "dataGridEspecie";
			this.dataGridEspecie.Size = new System.Drawing.Size(697, 241);
			this.dataGridEspecie.TabIndex = 0;
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Location = new System.Drawing.Point(6, 128);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
			this.btnAdicionar.TabIndex = 1;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionarClick);
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.Location = new System.Drawing.Point(87, 128);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
			this.btnAtualizar.TabIndex = 2;
			this.btnAtualizar.Text = "Atualizar";
			this.btnAtualizar.UseVisualStyleBackColor = true;
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(168, 128);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 23);
			this.btnExcluir.TabIndex = 3;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			// 
			// txtNCientifico
			// 
			this.txtNCientifico.Location = new System.Drawing.Point(113, 19);
			this.txtNCientifico.Name = "txtNCientifico";
			this.txtNCientifico.Size = new System.Drawing.Size(121, 20);
			this.txtNCientifico.TabIndex = 4;
			// 
			// txtNComum
			// 
			this.txtNComum.Location = new System.Drawing.Point(113, 45);
			this.txtNComum.Name = "txtNComum";
			this.txtNComum.Size = new System.Drawing.Size(121, 20);
			this.txtNComum.TabIndex = 5;
			// 
			// checkNativa
			// 
			this.checkNativa.Location = new System.Drawing.Point(246, 17);
			this.checkNativa.Name = "checkNativa";
			this.checkNativa.Size = new System.Drawing.Size(88, 24);
			this.checkNativa.TabIndex = 8;
			this.checkNativa.Text = "Nativa";
			this.checkNativa.UseVisualStyleBackColor = true;
			// 
			// checkAmeacada
			// 
			this.checkAmeacada.Location = new System.Drawing.Point(246, 47);
			this.checkAmeacada.Name = "checkAmeacada";
			this.checkAmeacada.Size = new System.Drawing.Size(88, 24);
			this.checkAmeacada.TabIndex = 9;
			this.checkAmeacada.Text = "Ameaçada";
			this.checkAmeacada.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBFamilia);
			this.groupBox1.Controls.Add(this.btnExcluir);
			this.groupBox1.Controls.Add(this.comboBPorte);
			this.groupBox1.Controls.Add(this.btnAtualizar);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnAdicionar);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtNCientifico);
			this.groupBox1.Controls.Add(this.checkAmeacada);
			this.groupBox1.Controls.Add(this.txtNComum);
			this.groupBox1.Controls.Add(this.checkNativa);
			this.groupBox1.Location = new System.Drawing.Point(12, 259);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(350, 157);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Adicionar/Editar/Deletar Espécie:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 10;
			this.label1.Text = "Nome Científico";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "Nome Comum";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(7, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "Família";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 13;
			this.label4.Text = "Porte";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBPorte
			// 
			this.comboBPorte.FormattingEnabled = true;
			this.comboBPorte.Location = new System.Drawing.Point(113, 97);
			this.comboBPorte.Name = "comboBPorte";
			this.comboBPorte.Size = new System.Drawing.Size(121, 21);
			this.comboBPorte.TabIndex = 15;
			// 
			// comboBFamilia
			// 
			this.comboBFamilia.FormattingEnabled = true;
			this.comboBFamilia.Location = new System.Drawing.Point(113, 69);
			this.comboBFamilia.Name = "comboBFamilia";
			this.comboBFamilia.Size = new System.Drawing.Size(121, 21);
			this.comboBFamilia.TabIndex = 16;
			// 
			// FrmEspecie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(720, 428);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridEspecie);
			this.Name = "FrmEspecie";
			this.Text = "FrmEspecie";
			this.Load += new System.EventHandler(this.FrmEspecieLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridEspecie)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
