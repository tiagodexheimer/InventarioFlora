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
			
			// Habilitar o preenchimento Automático
			comboBFamilia.DropDownStyle = ComboBoxStyle.DropDown;
			comboBFamilia.AutoCompleteMode = AutoCompleteMode.Suggest;
			comboBFamilia.AutoCompleteSource = AutoCompleteSource.CustomSource;
			dataGridEspecie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridEspecie.ClearSelection();
			
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
				BancoDeDados.CriarTabelaEspecie();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro : " + ex.Message);
			}
			try
			{
				BancoDeDados.CriarTabelaFamilia();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro : " + ex.Message);
			}*/
			
			
		}
		private bool Valida()
		{
			if(string.IsNullOrEmpty(txtNCientifico.Text))
			{
				return false;
			}
			else if (string.IsNullOrEmpty(txtNComum.Text))
			{
				return false;
			}
			else if (string.IsNullOrEmpty(comboBFamilia.Text))
			{
				return false;
			}
			else if (string.IsNullOrEmpty(comboBPorte.Text))
			{
				return false;
			}
			else
			{
				return true;
			}
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
				//Bind ComboBox
				comboBFamilia.DisplayMember = "Familia";
				comboBPorte.DisplayMember = "Porte";

				DataTable familia = new DataTable();
				familia = BancoDeDados.GetFamilia();
				foreach (DataRow dataRow in familia.Rows)
				{
					//Adiciona na lista Especificando a clouna
					string informação = dataRow["Familia"].ToString();
					comboBFamilia.Items.Add(informação);
					//comboBFamilia.AutoCompleteCustomSource.Add(informação);
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
		}
		void BtnAdicionarClick(object sender, EventArgs e)
		{
			
			if (!Valida())
			{
				MessageBox.Show("Informe os dados da Espécie a incluir");
				return;
			}
			try
			{
				Especie esp = new Especie();
				//esp.Id = Convert.ToInt32(txtID.Text);
				esp.nomeCientifico = txtNCientifico.Text;
				esp.familia = comboBFamilia.Text;
				esp.nomeComum = txtNComum.Text;
				esp.porte = comboBPorte.Text;
				esp.nativa = Convert.ToBoolean(checkNativa.Checked);
				esp.ameacada = Convert.ToBoolean(checkAmeacada.Checked);
				
				BancoDeDados.Add(esp);
				LimpaDados();
				ExibirDados();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show("Erro : " + ex.Message);
			}
		}
		void ComboBFamiliaKeyPress(object sender, KeyPressEventArgs e)
		{
			ComboAutoAtualizar(comboBFamilia, e);
		}
		void ComboBPorteKeyPress(object sender, KeyPressEventArgs e)
		{
			ComboAutoAtualizar(comboBPorte, e);
		}
		void BtnAtualizarClick(object sender, EventArgs e)
		{
			
		}
		
		void ComboAutoAtualizar(ComboBox combo, KeyPressEventArgs e)
		{
			//habilitar a abertura automatica da combo.
			combo.DroppedDown = true;
			if (char.IsControl(e.KeyChar))
			{
				return;
			}
			string str = combo.Text.Substring(0, combo.SelectionStart) + e.KeyChar;
			Int32 index = combo.FindStringExact(str);
			if (index == -1)
			{
				index = combo.FindString(str);
			}
			combo.SelectedIndex = index;
			combo.SelectionStart = str.Length;
			combo.SelectionLength = combo.Text.Length - combo.SelectionStart;
			e.Handled = true;
		}
		
		private void LimpaDados()
		{
			txtNCientifico.Text = "";
			txtNComum.Text = "";
			comboBFamilia.Text = "";
			comboBPorte.Text = "";
		}
		void DataGridEspecieCellClick(object sender, DataGridViewCellEventArgs e)
		{
			dataGridEspecie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			
			foreach (DataGridViewRow row in dataGridEspecie.SelectedRows)
			{
				txtNCientifico.Text = row.Cells[1].Value.ToString();
				txtNComum.Text = row.Cells[2].Value.ToString();
				comboBFamilia.Text = row.Cells[3].Value.ToString();
				comboBPorte.Text = row.Cells[3].Value.ToString();
			}
		}
		void BtnLimparClick(object sender, EventArgs e)
		{
			LimpaDados();
		}
	}
}
