/*
 * Crée par SharpDevelop.
 * Utilisateur: User
 * Date: 01/06/2012
 * Heure: 16:21
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
	/// Description of saisieResultat.
	/// </summary>
	public partial class saisieResultat : Form
	{
		int num_match = 0; // Permet de pouvoir récupérer le numéro du match pour pouvoir saisir le résultat
		
		public saisieResultat()
		{
	
			InitializeComponent();
			
		}

		
		void SaisieResultatLoad(object sender, EventArgs e)
		{
			// Objet commande sql.
			MySqlCommand objSql = MainForm.objCnx.CreateCommand();
			
			// La requete SQL sur l'objet objSql
			objSql.CommandText = "SELECT * FROM `match`";
			
			// Executer la requete de l'objet objSql
			MySqlDataReader resultat = objSql.ExecuteReader();
			
			// Parcours du resultat, on à récupérer * de `match`, on choisi ici le numéro (0)
			while(resultat.Read() == true)
			{
				comboBox1.Items.Add(resultat.GetValue(0).ToString());
			}
			resultat.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			// Objet commande SQL
			MySqlCommand objSql = MainForm.objCnx.CreateCommand();
			
			// La requete SQL sur l'objet objSql
			objSql.CommandText = "SELECT * FROM `match` WHERE num_match="+num_match;
			
			// Executer la requete de l'objet objSql
			MySqlDataReader resultat = objSql.ExecuteReader();
			
			// Parcours du resultat, récupérer les équipes concernant le match choisi
			while(resultat.Read() == true)
			{
				dataGridView1.Rows.Add(resultat.GetValue(1).ToString(),resultat.GetValue(2).ToString());
				comboBox2.Items.Add(resultat.GetValue(1).ToString());
				comboBox2.Items.Add(resultat.GetValue(2).ToString());
			}
			resultat.Close();
			
			// permet de stopper l'action du bouton après le click
			button1.Enabled = false;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e) // On sélectionne les numéros des matchs de la BDD
		{
			num_match = int.Parse(comboBox1.SelectedItem.ToString());
		}
		
		void Button3Click(object sender, EventArgs e) // Enregistre le score du match ainsi que l'équipe vainqueur
		{
			int num_Equipe = 0;
			// Objet commande sql.
			MySqlCommand objSql = MainForm.objCnx.CreateCommand();
			try {
				objSql.CommandText = "SELECT num_equipe FROM `equipe` WHERE nom_equipe =\""+comboBox2.Text+"\"";
				MySqlDataReader resultat = objSql.ExecuteReader();
				
				while(resultat.Read()){
					num_Equipe = int.Parse(resultat.GetValue(0).ToString());
				}
				resultat.Close();
				
			} catch (Exception) {
			}
			
			try
			{
			// Insertion des champs dans la BDD
			objSql.CommandText="UPDATE `match` SET `score_equipe_dom`="+int.Parse(maskedTextBox1.Text)+", `score_equipe_ext`="+int.Parse(maskedTextBox2.Text)+", `equipe_victorieuse`=\""+comboBox2.Text+"\" WHERE num_match ="+num_match;
			objSql.ExecuteNonQuery();
			
			// Requête pour mettre à jour l'équipe gagnante en lui rajoutant +1 à son total
			objSql.CommandText="UPDATE `equipe` SET `nombre_victoire`=(`nombre_victoire`+1) WHERE num_equipe="+num_Equipe;
			objSql.ExecuteNonQuery();
			
			MessageBox.Show("Score enregistré dans la BDD");
			} catch (Exception ex) {
				MessageBox.Show(ex.Message.ToString());
				
			}
		
			// permet de stopper l'action du bouton après le click
			button3.Enabled = false;
		}
	}
}
