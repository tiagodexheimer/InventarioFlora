/*
 * User: Tiago Dexheimer
 * Date: 11/09/2019
 * Time: 10:47
 * 
 */
namespace InventarioFlora.Formularios
{
	partial class FrmIncluirEspecie
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBNCientifico;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtBFamilia;
		private System.Windows.Forms.TextBox txtBNComum;
		private System.Windows.Forms.CheckBox checkBNativa;
		private System.Windows.Forms.CheckBox checkBAmeacada;
		private System.Windows.Forms.TextBox txtBPorte;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnFechar;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtBNCientifico = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtBFamilia = new System.Windows.Forms.TextBox();
			this.txtBNComum = new System.Windows.Forms.TextBox();
			this.checkBNativa = new System.Windows.Forms.CheckBox();
			this.checkBAmeacada = new System.Windows.Forms.CheckBox();
			this.txtBPorte = new System.Windows.Forms.TextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnFechar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome Científico";
			// 
			// txtBNCientifico
			// 
			this.txtBNCientifico.Location = new System.Drawing.Point(118, 10);
			this.txtBNCientifico.Name = "txtBNCientifico";
			this.txtBNCientifico.Size = new System.Drawing.Size(154, 20);
			this.txtBNCientifico.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nome Comum";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Família";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 93);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "Porte";
			// 
			// txtBFamilia
			// 
			this.txtBFamilia.Location = new System.Drawing.Point(118, 38);
			this.txtBFamilia.Name = "txtBFamilia";
			this.txtBFamilia.Size = new System.Drawing.Size(154, 20);
			this.txtBFamilia.TabIndex = 7;
			// 
			// txtBNComum
			// 
			this.txtBNComum.Location = new System.Drawing.Point(118, 64);
			this.txtBNComum.Name = "txtBNComum";
			this.txtBNComum.Size = new System.Drawing.Size(154, 20);
			this.txtBNComum.TabIndex = 8;
			// 
			// checkBNativa
			// 
			this.checkBNativa.Location = new System.Drawing.Point(12, 119);
			this.checkBNativa.Name = "checkBNativa";
			this.checkBNativa.Size = new System.Drawing.Size(104, 24);
			this.checkBNativa.TabIndex = 9;
			this.checkBNativa.Text = "Nativa";
			this.checkBNativa.UseVisualStyleBackColor = true;
			// 
			// checkBAmeacada
			// 
			this.checkBAmeacada.Location = new System.Drawing.Point(12, 149);
			this.checkBAmeacada.Name = "checkBAmeacada";
			this.checkBAmeacada.Size = new System.Drawing.Size(104, 24);
			this.checkBAmeacada.TabIndex = 10;
			this.checkBAmeacada.Text = "Ameaçada";
			this.checkBAmeacada.UseVisualStyleBackColor = true;
			// 
			// txtBPorte
			// 
			this.txtBPorte.Location = new System.Drawing.Point(118, 90);
			this.txtBPorte.Name = "txtBPorte";
			this.txtBPorte.Size = new System.Drawing.Size(154, 20);
			this.txtBPorte.TabIndex = 11;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(13, 180);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 12;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvarClick);
			// 
			// btnFechar
			// 
			this.btnFechar.Location = new System.Drawing.Point(197, 180);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(75, 23);
			this.btnFechar.TabIndex = 13;
			this.btnFechar.Text = "Fechar";
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.BtnFecharClick);
			// 
			// FrmIncluirEspecie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 208);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtBPorte);
			this.Controls.Add(this.checkBAmeacada);
			this.Controls.Add(this.checkBNativa);
			this.Controls.Add(this.txtBNComum);
			this.Controls.Add(this.txtBFamilia);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtBNCientifico);
			this.Controls.Add(this.label1);
			this.Name = "FrmIncluirEspecie";
			this.Text = "FrmIncluirEspecie";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
