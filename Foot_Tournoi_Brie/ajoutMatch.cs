/*
 * Crée par SharpDevelop.
 * Utilisateur: User
 * Date: 24/05/2012
 * Heure: 14:15
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
	/// Description of ajoutMatch.
	/// </summary>
	public partial class ajoutMatch : Form
	{
		public ajoutMatch()
		{
			
			InitializeComponent();

		}
	
		
		void Button1Click(object sender, EventArgs e)
		{
			try {
			// Objet commande sql.
			MySqlCommand objSql = MainForm.objCnx.CreateCommand();
				
			// Insertion des champs dans la BDD
			objSql.CommandText="INSERT INTO `match` (nom_equipe_dom, nom_equipe_ext, terrain, date, heure) values('"+comboBox1.Text+"','"+comboBox2.Text+"','"+comboBox3.Text+"','"+dateTimePicker1.Value.ToShortDateString()+"','"+textBox1.Text+"')";
			objSql.ExecuteNonQuery();
			
			MessageBox.Show("Match enregistré dans la BDD");
			} catch (Exception ex) {
				MessageBox.Show(ex.Message.ToString());
				
			}
		
			// permet de stopper l'action du bouton après le click
			button1.Enabled = false;
		}
		
			
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void AjoutMatchLoad(object sender, EventArgs e)
		{
			// Objet commande sql.
			MySqlCommand objSql = MainForm.objCnx.CreateCommand();
			
			// La requete SQL sur l'objet objSql
			objSql.CommandText = "SELECT * FROM `equipe`";
			
			// Executer la requete de l'objet objSql
			MySqlDataReader resultat = objSql.ExecuteReader();
			
			// Parcours du resultat
			while(resultat.Read() == true)
			{
				comboBox1.Items.Add(resultat.GetValue(1).ToString());
			}
			resultat.Close();	
			
			
				// Pour la comboBox2, on renomme objSql résultat en mettant "1"
			
				// Objet commande sql.
				MySqlCommand objSql1 = MainForm.objCnx.CreateCommand();
				
				// La requete SQL sur l'objet objSql
				objSql1.CommandText = "SELECT * FROM `equipe`";
			
				// Executer la requete de l'objet objSql
				MySqlDataReader resultat1 = objSql1.ExecuteReader();
			
				// Parcours du resultat
				while(resultat1.Read() == true)
					{
						comboBox2.Items.Add(resultat1.GetValue(1).ToString());
					}
				resultat1.Close();	
	
				
					// Pour la comboBox3, on renomme objSql résultat en mettant "2"
			
					// Objet commande sql.
					MySqlCommand objSql2 = MainForm.objCnx.CreateCommand();
				
					// La requete SQL sur l'objet objSql
					objSql2.CommandText = "SELECT * FROM `terrain`";
			
					// Executer la requete de l'objet objSql
					MySqlDataReader resultat2 = objSql2.ExecuteReader();
			
					// Parcours du resultat
					while(resultat2.Read() == true)
						{
							comboBox3.Items.Add(resultat2.GetValue(1).ToString());
						}
					resultat2.Close();	
		
		
		}
	}
}
