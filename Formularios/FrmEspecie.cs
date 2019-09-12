/*
 * User: Tiago Dexheimer
 * Date: 05/09/2019
 * Time: 16:22
 * 
 */
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using InventarioFlora.Classes;

namespace InventarioFlora.Formularios
{
	/// <summary>
	/// Description of FrmEspecie.
	/// </summary>
	public partial class FrmEspecie : Form
	{
		//private Especie[] especies;
		
		public FrmEspecie()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			//Especie[] especies = new Especie[5];
			//especies[0] = new Especie();
			/*try
			{
				BancoDeDados.CriarBancoSQLite();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro : " + ex.Message);
			}
			try
			{
				BancoDeDados.CriarTabelaSQlite();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro : " + ex.Message);
			}*/
			
			
		}
		private void btnExibirDados_Click(object sender, EventArgs e)
		{
			
		}
		public void ExibirDados()
		{
			try
			{
				DataTable dt = new DataTable();
				dt = BancoDeDados.GetEspecies();
				dataGridEspecie.DataSource = dt;
				
				//comboBFamilia.Items.Add(dt[i]);
				foreach (DataRow dataRow in dt.Rows)
				{
					//Adiciona na lista Especificando a clouna
					string informação = dataRow["Familia"].ToString();
					comboBFamilia.Items.Add(informação);
				}
				foreach (DataRow dataRow in dt.Rows)
				{
					//Adiciona na lista Especificando a clouna
					string informação = dataRow["Porte"].ToString();
					comboBPorte.Items.Add(informação);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro : " + ex.Message);
			}
		}
		void FrmEspecieLoad(object sender, EventArgs e)
		{
			ExibirDados();
			/*especies = new Especie[3];
			this.especies[0] = new Especie();
			this.especies[0].Id = 1;
			this.especies[0].nomeCientifico = "Inga marginata";
			this.especies[0].nomeComum = "Ingá-de-beira-de-rio";
			this.especies[0].porte = "Grande";
			this.especies[0].ameacada = false;
			this.especies[0].familia = "Fabaceae";
			this.especies[0].nativa = true;
			
			this.especies[1] = new Especie();
			this.especies[1].Id = 2;
			this.especies[1].nomeCientifico = "Ligustrum lucidum";
			this.especies[1].nomeComum = "Ligustro";
			this.especies[1].porte = "Pequeno";
			this.especies[1].ameacada = false;
			this.especies[1].familia = "Oleaceae";
			this.especies[1].nativa = false;

			this.especies[2] = new Especie();
			this.especies[2].Id = 3;
			this.especies[2].nomeCientifico = "Psidium guajava";
			this.especies[2].nomeComum = "Goiabeira";
			this.especies[2].porte = "Médio";
			this.especies[2].ameacada = false;
			this.especies[2].familia = "Myrtaceae";
			this.especies[2].nativa = false;

			this.dataGridEspecie.DataSource = especies;*/
		}
		void BtnAdicionarClick(object sender, EventArgs e)
		{
			try
			{
				
				FrmIncluirEspecie frm2 = new FrmIncluirEspecie();
				frm2.ShowDialog();
				ExibirDados();
				
				//CarregaDados();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro : " + ex.Message);
			}
		}
	}
}
