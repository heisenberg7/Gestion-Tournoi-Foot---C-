/*
 * Crée par SharpDevelop.
 * Utilisateur: User
 * Date: 22/05/2012
 * Heure: 17:20
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
	/// Description of ajoutEquipe.
	/// </summary>
	public partial class ajoutEquipe : Form
	{
		public ajoutEquipe()
		{
			
			InitializeComponent();
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			try
			{
			// Objet commande sql.
			MySqlCommand objSql = MainForm.objCnx.CreateCommand();
				
			// Insertion des champs dans la BDD, ajout d'une équipe
			objSql.CommandText="INSERT INTO equipe (nom_equipe, ville_equipe, nbe_de_joueurs) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')";
			objSql.ExecuteNonQuery();
			
			MessageBox.Show("Equipe enregistrée dans la BDD"); // Message de validation
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
	}
}
