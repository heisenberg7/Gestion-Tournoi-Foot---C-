/*
 * Crée par SharpDevelop.
 * Utilisateur: User
 * Date: 24/05/2012
 * Heure: 13:28
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Foot_Tournoi_Brie
{
	/// <summary>
	/// Description of listeTerrain.
	/// </summary>
	public partial class listeTerrain : Form
	{
		public listeTerrain()
		{
			
			InitializeComponent();
	
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			// Objet commande SQL
			MySqlCommand objSql = MainForm.objCnx.CreateCommand();
			
			// La requete SQL sur l'objet objSql
			objSql.CommandText = "SELECT * FROM terrain";
			
			// Executer la requete de l'objet objSql
			MySqlDataReader resultat = objSql.ExecuteReader();
			
			// Parcours du resultat
			while(resultat.Read() == true)
			{
				dataGridView1.Rows.Add(resultat.GetValue(0).ToString(),resultat.GetValue(1).ToString(),resultat.GetValue(2).ToString(),resultat.GetValue(3).ToString(),resultat.GetValue(4).ToString());
			}
			resultat.Close();
			
			// permet de stopper l'action du bouton après le click
			button1.Enabled = false;
		
		
		}
	}
}
