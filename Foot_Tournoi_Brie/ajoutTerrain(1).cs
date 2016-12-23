/*
 * Crée par SharpDevelop.
 * Utilisateur: User
 * Date: 22/05/2012
 * Heure: 18:16
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
	/// Description of ajoutTerrain.
	/// </summary>
	public partial class ajoutTerrain : Form
	{
		public ajoutTerrain()
		{

			InitializeComponent();

		}
	
	
		
		void Button1Click(object sender, EventArgs e)
		{
			try {
			// Objet commande sql.
			MySqlCommand objSql = MainForm.objCnx.CreateCommand();
				
			// Insertion des champs dans la BDD
			objSql.CommandText="INSERT INTO terrain (nom_terrain, lieu_terrain, surface, nbe_spectateurs) values('"+textBox1.Text+"','"+textBox2.Text+"','"+comboBox1.Text+"', '"+textBox4.Text+"')";
			objSql.ExecuteNonQuery();
			
			MessageBox.Show("Terrain enregistré dans la BDD");
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
