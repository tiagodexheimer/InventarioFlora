/*
 * User: Tiago Dexheimer
 * Date: 06/09/2019
 * Time: 08:19
 * 
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioFlora.Classes
{
	/// <summary>
	/// Description of BancoDeDados.
	/// </summary>
	public static class BancoDeDados
	{
		private static SQLiteConnection sqliteConnection;
		
		private static SQLiteConnection DbConnection()
		{
			string path = System.IO.Directory.GetCurrentDirectory();
			path += "\\InventarioViveiro.sqlite";
			sqliteConnection = new SQLiteConnection("Data Source=" + path + "; Version=3;");
			sqliteConnection.Open();
			return sqliteConnection;
		}
		public static void CriarBancoSQLite()
		{
			try {
				string path = System.IO.Directory.GetCurrentDirectory();
				path += "\\InventarioViveiro.sqlite";
				SQLiteConnection.CreateFile(path);
			} catch {
				throw;
			}
		}
		public static void CriarTabelaEspecie()
		{
			try {
				using (var cmd = DbConnection().CreateCommand()) {
					cmd.CommandText = "CREATE TABLE IF NOT EXISTS Especies(id int, NomeCientifico Varchar(100), Familia Varchar(100), " +
						"NomeComum Varchar(100), Porte Varchar(100), Nativa boolean, Ameacada boolean)";
					cmd.ExecuteNonQuery();
				}
			} catch (Exception ex) {
				throw ex;
			}
		}

		public static void CriarTabelaFamilia()
		{
			try {
				using (var cmd = DbConnection().CreateCommand()) {
					cmd.CommandText = "CREATE TABLE IF NOT EXISTS Familia(id int, Familia Varchar(100))";
					cmd.ExecuteNonQuery();
					//DataTable fam = new DataTable();
					/*using (StreamReader fam = new StreamReader(File.Open(@"C:\Programas\Familias.txt", FileMode.Open)))
					{
						
						
						string line = "";
						while ((line = fam.ReadLine()) != "")
						{
				
							string parts = line;
							//string fam = System.IO.File.ReadLine();
						}
					}
					DataTable dt = new DataTable();
					using (System.IO.TextReader tr = File.OpenText((@"C:\Programas\Familias.txt")))
					{
						string line;
						while ((line = tr.ReadLine()) != null)
						{

							string[] items = line.Trim().Split(' ');
							if (dt.Columns.Count == 0)
							{
								// Create the data columns for the data table based on the number of items
								// on the first line of the file
								for (int i = 0; i < items.Length; i++)
									dt.Columns.Add(new DataColumn("Column" + i, typeof(string)));
							}
							dt.Rows.Add(items);
							using (var cmd2 = DbConnection().CreateCommand()) {
							cmd2.CommandText = "INSERT INTO Familia(Id, Familia) " +
								"values (@Id,@Familia)";
							cmd2.Parameters.AddWithValue("@Id", "NULL");
							cmd2.Parameters.AddWithValue("@Familia", dt);
							cmd2.ExecuteNonQuery();
							Console.WriteLine(dt);
						}

						}
						//show it in gridview
						/*this.GridView1.DataSource = dt;
						this.GridView1.DataBind();*/
					
					
					
					
					using (StreamReader sr = new StreamReader(File.Open(@"C:\Programas\Familias.txt", FileMode.Open)))
					{
						
						
						string line = "";
						while ((line = sr.ReadLine()) != "")
						{
							string[] parts = line.Split(new string[] { "," }, StringSplitOptions.None);
							//string cmdTxt = string.Format("INSERT INTO Familia(Id, Familia) VALUES ('{0}','{1}')", "NULL", parts[0]);//", parts[0], parts[1]);
							using (var cmd2 = DbConnection().CreateCommand()) {
								cmd2.CommandText = string.Format("INSERT INTO Familia(Id, Familia) VALUES ('{0}','{1}')", "NULL", parts[0]);//", parts[0], parts[1]);
								cmd2.ExecuteNonQuery();
								
								
							}
						}
					}
				}
			}
			catch (Exception ex) {
				throw ex;
			}
			
		}


		public static DataTable GetFamilia()
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try {
				using (var cmd = DbConnection().CreateCommand()) {
					cmd.CommandText = "SELECT * FROM Familia";
					da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
					da.Fill(dt);
					return dt;
				}
			} catch (Exception ex) {
				throw ex;
			}
		}

		public static DataTable GetEspecies()
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try {
				using (var cmd = DbConnection().CreateCommand()) {
					cmd.CommandText = "SELECT * FROM Especies";
					da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
					da.Fill(dt);
					return dt;
				}
			} catch (Exception ex) {
				throw ex;
			}
		}

		public static DataTable GetEspecies(int id)
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try {
				using (var cmd = DbConnection().CreateCommand()) {
					cmd.CommandText = "SELECT * FROM Especies Where Id=" + id;
					da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
					da.Fill(dt);
					return dt;
				}
			} catch (Exception ex) {
				throw ex;
			}
		}

		public static void Add(Especie especie)
		{
			/* Define o vador de especie.ID para inserção do próximo ID */
			DataTable contaLinha = new DataTable();
			contaLinha = GetEspecies();
			especie.Id = contaLinha.Rows.Count + 1;
			
			try {
				using (var cmd = DbConnection().CreateCommand()) {
					cmd.CommandText = "INSERT INTO Especies(Id, nomeCientifico, nomeComum, familia, porte, nativa, ameacada) " +
						"values (@Id, @nomeCientifico, @nomeComum, @familia, @porte, @nativa, @ameacada)";
					cmd.Parameters.AddWithValue("@Id", especie.Id);
					cmd.Parameters.AddWithValue("@nomeCientifico", especie.nomeCientifico);
					cmd.Parameters.AddWithValue("@nomeComum", especie.nomeComum);
					cmd.Parameters.AddWithValue("@familia", especie.familia);
					cmd.Parameters.AddWithValue("@porte", especie.porte);
					cmd.Parameters.AddWithValue("@nativa", especie.nativa);
					cmd.Parameters.AddWithValue("@ameacada", especie.ameacada);
					cmd.ExecuteNonQuery();
				}
			} catch (Exception ex) {
				throw ex;
			}
		}

		public static void Update(Especie especie)
		{
			try {
				using (var cmd = new SQLiteCommand(DbConnection())) {
					if (especie.Id != null) {
						cmd.CommandText = "UPDATE Especies SET @nomeCientifico, @nomeComum, @familia, @porte, @nativa, @ameacada WHERE Id=@Id";
						cmd.Parameters.AddWithValue("@Id", especie.Id);
						cmd.Parameters.AddWithValue("@nomeCientifico", especie.nomeCientifico);
						cmd.Parameters.AddWithValue("@nomeComum", especie.nomeComum);
						cmd.Parameters.AddWithValue("@familia", especie.familia);
						cmd.Parameters.AddWithValue("@porte", especie.porte);
						cmd.Parameters.AddWithValue("@nativa", especie.nativa);
						cmd.Parameters.AddWithValue("@ameacada", especie.ameacada);
						cmd.ExecuteNonQuery();
					}
				}
				;
			} catch (Exception ex) {
				throw ex;
			}
		}

		public static void Delete(int Id)
		{
			try {
				using (var cmd = new SQLiteCommand(DbConnection())) {
					cmd.CommandText = "DELETE FROM Especies Where Id=@Id";
					cmd.Parameters.AddWithValue("@Id", Id);
					cmd.ExecuteNonQuery();
				}
			} catch (Exception ex) {
				throw ex;
			}
		}
	}
}
