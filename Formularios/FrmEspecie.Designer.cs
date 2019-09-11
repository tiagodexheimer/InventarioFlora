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
			((System.ComponentModel.ISupportInitialize)(this.dataGridEspecie)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridEspecie
			// 
			this.dataGridEspecie.Location = new System.Drawing.Point(12, 12);
			this.dataGridEspecie.Name = "dataGridEspecie";
			this.dataGridEspecie.Size = new System.Drawing.Size(991, 375);
			this.dataGridEspecie.TabIndex = 0;
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Location = new System.Drawing.Point(12, 393);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
			this.btnAdicionar.TabIndex = 1;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionarClick);
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.Location = new System.Drawing.Point(94, 393);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
			this.btnAtualizar.TabIndex = 2;
			this.btnAtualizar.Text = "Atualizar";
			this.btnAtualizar.UseVisualStyleBackColor = true;
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(176, 393);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 23);
			this.btnExcluir.TabIndex = 3;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			// 
			// FrmEspecie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1015, 428);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnAtualizar);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.dataGridEspecie);
			this.Name = "FrmEspecie";
			this.Text = "FrmEspecie";
			this.Load += new System.EventHandler(this.FrmEspecieLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridEspecie)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
