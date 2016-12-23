/*
 * Crée par SharpDevelop.
 * Utilisateur: User
 * Date: 04/06/2012
 * Heure: 15:39
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
	/// Description of classementTournoi.
	/// </summary>
	public partial class classementTournoi : Form
	{
		public classementTournoi()
		{

			InitializeComponent();
		}
		
		void Button2Click(object sender, EventArgs e) // Fermer la page
		{
			this.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			// Objet commande SQL
			MySqlCommand objSql = MainForm.objCnx.CreateCommand();
			
			// La requete SQL sur l'objet objSql, récupère les équipes et les classe suivant leur nombre de victoires
			objSql.CommandText = "SELECT `nom_equipe`, `nombre_victoire` FROM `equipe` ORDER BY `nombre_victoire` DESC";
			
			// Executer la requete de l'objet objSql
			MySqlDataReader resultat = objSql.ExecuteReader();
			
			// Parcours du resultat, affichage du résultat dans le dataGridView1
			while(resultat.Read() == true)
			{
				dataGridView1.Rows.Add(resultat.GetValue(0).ToString(),resultat.GetValue(1).ToString());
			}
			resultat.Close();
			
			// permet de stopper l'action du bouton après le click
			button1.Enabled = false;
		}
	}
}
