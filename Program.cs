/*
 * User: Tiago Dexheimer
 * Date: 27/08/2019
 * Time: 13:58
 */
using System;
using System.Windows.Forms;

namespace InventarioFlora
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Formularios.FrmEspecie());
		}
		
	}
}
