/*
 * User: Tiago Dexheimer
 * Date: 05/09/2019
 * Time: 15:28
 */
using System;

namespace InventarioFlora.Classes
{
	/// <summary>
	/// Gerencia a listagem, criação e modificação da lista de espécies.
	/// </summary>
	public class Especie
	{
		public int Id { get; set; }
		public string nomeComum { get; set; }
		public string nomeCientifico { get; set; }
		public string familia { get; set; }
		public string porte { get; set; }
		
		
		public void Listar() {
			//TODO Listar()
		}
		
		public void Adicionar() {
			//TODO Acicionar()
		}
		
		public void Modificar() {
			//TODO Modificar()
		}
		
		public void Excluir() {
			//TODO Excluir() {
			
		}
	}
}
