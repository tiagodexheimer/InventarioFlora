/*
 * User: Tiago Dexheimer
 * Date: 06/09/2019
 * Time: 08:19
 * 
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioFlora.Classes
{
	/// <summary>
	/// Description of BancoDeDados.
	/// </summary>
	public class BancoDeDados
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
		public static void CriarTabelaSQlite()
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
