/*
 * User: Tiago Dexheimer
 * Date: 11/09/2019
 * Time: 10:47
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using InventarioFlora.Classes;

namespace InventarioFlora.Formularios
{
	/// <summary>
	/// Description of FrmIncluirEspecie.
	/// </summary>
	public partial class FrmIncluirEspecie : Form
	{
		public FrmIncluirEspecie()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private bool Valida()
		{
			if(string.IsNullOrEmpty(txtBNCientifico.Text) && string.IsNullOrEmpty(txtBFamilia.Text) && string.IsNullOrEmpty(txtBNComum.Text)
			   && string.IsNullOrEmpty(txtBPorte.Text))
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		void BtnSalvarClick(object sender, EventArgs e)
		{
			if (!Valida())
			{
				MessageBox.Show("Informe os dados da Espécie a incluir");
				return;
			}
			try
			{
				Especie cli = new Especie();
				//cli.Id = Convert.ToInt32(txtID.Text);
				cli.nomeCientifico = txtBNCientifico.Text;
				cli.familia = txtBFamilia.Text;
				cli.nomeComum = txtBNComum.Text;
				cli.porte = txtBPorte.Text;
				cli.nativa = Convert.ToBoolean(checkBNativa.Checked);
				cli.ameacada = Convert.ToBoolean(checkBAmeacada.Checked);
				
				BancoDeDados.Add(cli);
				this.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show("Erro : " + ex.Message);
			}
		}
		void BtnFecharClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
