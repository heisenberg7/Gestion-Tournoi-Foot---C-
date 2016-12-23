/*
 * Crée par SharpDevelop.
 * Utilisateur: User
 * Date: 22/05/2012
 * Heure: 15:34
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Foot_Tournoi_Brie
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static MySqlConnection objCnx; // static => même principe que les Sessions.
		
		public MainForm()
		{
		
			InitializeComponent();
			
		}
		
		void DéroulementToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Tournoi de Football masculin de la Ville de Brie-Comte-Robert. Tournoi sous forme de championnat composé d'équipes de la région parisienne uniquement, hors équipes guest invitées selon la volonté des organisateurs. Le nombre de matchs est en fonction du nombre d'équipes, sachant qu'il y a 1 confrontation entre chaque équipes. Les équipes sont composées de 10 joueurs, 8 sur le terrain et 2 remplaçants. Un match se joue en 2 mi-temps de 25 minutes chacune, si score nul à la fin des 50 minutes réglementaires, une prolongation de 2 x 10 minutes est jouée. Si les 2 équipes n'ont pas pu se départager à l'issu de cette prolongation, une séance de tirs au but est mise en place, avec un premier tour au meilleur total des 5 tirs et mort subite par la suite si égalité. Bon tournoi à tous !");
		}
				
		void MainFormLoad(object sender, EventArgs e)
		{
				try
			{
				string chcnx="Database=tournoi_foot_brie;Data Source=localhost;User Id=root;Password=";
				objCnx = new MySqlConnection(chcnx);
				objCnx.Open();
				label3.Text=objCnx.ConnectionString.ToString();
			}
			catch(Exception ex)
			{
				label3.Text=ex.Message.ToString();
			}	
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e) // Message quand on ferme l'application
		{
			objCnx.Close();
			MessageBox.Show("Connection terminée. Merci d'avoir visité notre espace foot consacré au tournoi de Brie-Comte-Robert.");
		}
			
		void Button1Click(object sender, EventArgs e) // Se connecter à la base de données
		{
			try
			{
			string chcnx="Database=tournoi_foot_brie;Data Source =localhost;User Id=root;Password=";
			objCnx=new MySqlConnection(chcnx);
			objCnx.Open();
			label3.Text="Connection établie";
			}
			catch(Exception ex)
			{
				label3.Text=ex.Message.ToString();
			}
		
			// permet de stopper l'action du bouton après le click
			button1.Enabled = false;
		}
			
		void QuitterToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
			
		void AjoutEquipeToolStripMenuItemClick(object sender, EventArgs e)
		{
			ajoutEquipe ObjAE = new ajoutEquipe();
			ObjAE.ShowDialog();
		}
		
		void ListageEquipesToolStripMenuItemClick(object sender, EventArgs e)
		{
			listeEquipe ObjLE = new listeEquipe();
			ObjLE.ShowDialog();
		}	
		
		void AjoutTerrainToolStripMenuItemClick(object sender, EventArgs e)
		{
			ajoutTerrain ObjAT = new ajoutTerrain();
			ObjAT.ShowDialog();
		}
		
		void ListageTerrainToolStripMenuItemClick(object sender, EventArgs e)
		{
			listeTerrain ObjLT = new listeTerrain();
			ObjLT.ShowDialog();
		}
		
		void AjoutMatchToolStripMenuItemClick(object sender, EventArgs e)
		{
			ajoutMatch ObjAM = new ajoutMatch();
			ObjAM.ShowDialog();
		}
		
		void ListageMatchsToolStripMenuItemClick(object sender, EventArgs e)
		{
			listeMatch ObjLM = new listeMatch();
			ObjLM.ShowDialog();
		}
		
		void RésultatsTournoiToolStripMenuItemClick(object sender, EventArgs e)
		{
			resultatTournoi ObjRT = new resultatTournoi();
			ObjRT.ShowDialog();
		}
		
		void SaisieDeRésultatToolStripMenuItemClick(object sender, EventArgs e)
		{
			saisieResultat ObjSR = new saisieResultat();
			ObjSR.ShowDialog();
		}
		
		void ClassementTournoiToolStripMenuItemClick(object sender, EventArgs e)
		{
			classementTournoi ObjCT = new classementTournoi();
			ObjCT.ShowDialog();
		}
	}
}
