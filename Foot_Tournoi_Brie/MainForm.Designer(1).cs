/*
 * Crée par SharpDevelop.
 * Utilisateur: User
 * Date: 22/05/2012
 * Heure: 15:34
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace Foot_Tournoi_Brie
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.equipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ajoutEquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listageEquipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.terrainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ajoutTerrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listageTerrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.matchsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ajoutMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listageMatchsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.résultatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saisieDeRésultatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.résultatsTournoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.règlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.déroulementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.classementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.classementTournoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fichierToolStripMenuItem,
									this.equipeToolStripMenuItem,
									this.terrainsToolStripMenuItem,
									this.matchsToolStripMenuItem,
									this.résultatsToolStripMenuItem,
									this.classementToolStripMenuItem,
									this.règlesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(828, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fichierToolStripMenuItem
			// 
			this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.quitterToolStripMenuItem});
			this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
			this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.fichierToolStripMenuItem.Text = "Fichier";
			// 
			// quitterToolStripMenuItem
			// 
			this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
			this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.quitterToolStripMenuItem.Text = "Quitter";
			this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItemClick);
			// 
			// equipeToolStripMenuItem
			// 
			this.equipeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ajoutEquipeToolStripMenuItem,
									this.listageEquipesToolStripMenuItem});
			this.equipeToolStripMenuItem.Name = "equipeToolStripMenuItem";
			this.equipeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.equipeToolStripMenuItem.Text = "Equipes";
			// 
			// ajoutEquipeToolStripMenuItem
			// 
			this.ajoutEquipeToolStripMenuItem.Name = "ajoutEquipeToolStripMenuItem";
			this.ajoutEquipeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.ajoutEquipeToolStripMenuItem.Text = "Ajout Equipe";
			this.ajoutEquipeToolStripMenuItem.Click += new System.EventHandler(this.AjoutEquipeToolStripMenuItemClick);
			// 
			// listageEquipesToolStripMenuItem
			// 
			this.listageEquipesToolStripMenuItem.Name = "listageEquipesToolStripMenuItem";
			this.listageEquipesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.listageEquipesToolStripMenuItem.Text = "Listage Equipes";
			this.listageEquipesToolStripMenuItem.Click += new System.EventHandler(this.ListageEquipesToolStripMenuItemClick);
			// 
			// terrainsToolStripMenuItem
			// 
			this.terrainsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ajoutTerrainToolStripMenuItem,
									this.listageTerrainToolStripMenuItem});
			this.terrainsToolStripMenuItem.Name = "terrainsToolStripMenuItem";
			this.terrainsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.terrainsToolStripMenuItem.Text = "Terrains";
			// 
			// ajoutTerrainToolStripMenuItem
			// 
			this.ajoutTerrainToolStripMenuItem.Name = "ajoutTerrainToolStripMenuItem";
			this.ajoutTerrainToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.ajoutTerrainToolStripMenuItem.Text = "Ajout Terrain";
			this.ajoutTerrainToolStripMenuItem.Click += new System.EventHandler(this.AjoutTerrainToolStripMenuItemClick);
			// 
			// listageTerrainToolStripMenuItem
			// 
			this.listageTerrainToolStripMenuItem.Name = "listageTerrainToolStripMenuItem";
			this.listageTerrainToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.listageTerrainToolStripMenuItem.Text = "Listage Terrains";
			this.listageTerrainToolStripMenuItem.Click += new System.EventHandler(this.ListageTerrainToolStripMenuItemClick);
			// 
			// matchsToolStripMenuItem
			// 
			this.matchsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ajoutMatchToolStripMenuItem,
									this.listageMatchsToolStripMenuItem});
			this.matchsToolStripMenuItem.Name = "matchsToolStripMenuItem";
			this.matchsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.matchsToolStripMenuItem.Text = "Matchs";
			// 
			// ajoutMatchToolStripMenuItem
			// 
			this.ajoutMatchToolStripMenuItem.Name = "ajoutMatchToolStripMenuItem";
			this.ajoutMatchToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.ajoutMatchToolStripMenuItem.Text = "Ajout Match";
			this.ajoutMatchToolStripMenuItem.Click += new System.EventHandler(this.AjoutMatchToolStripMenuItemClick);
			// 
			// listageMatchsToolStripMenuItem
			// 
			this.listageMatchsToolStripMenuItem.Name = "listageMatchsToolStripMenuItem";
			this.listageMatchsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.listageMatchsToolStripMenuItem.Text = "Listage Matchs";
			this.listageMatchsToolStripMenuItem.Click += new System.EventHandler(this.ListageMatchsToolStripMenuItemClick);
			// 
			// résultatsToolStripMenuItem
			// 
			this.résultatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.saisieDeRésultatToolStripMenuItem,
									this.résultatsTournoiToolStripMenuItem});
			this.résultatsToolStripMenuItem.Name = "résultatsToolStripMenuItem";
			this.résultatsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.résultatsToolStripMenuItem.Text = "Résultats";
			// 
			// saisieDeRésultatToolStripMenuItem
			// 
			this.saisieDeRésultatToolStripMenuItem.Name = "saisieDeRésultatToolStripMenuItem";
			this.saisieDeRésultatToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.saisieDeRésultatToolStripMenuItem.Text = "Saisie de résultat";
			this.saisieDeRésultatToolStripMenuItem.Click += new System.EventHandler(this.SaisieDeRésultatToolStripMenuItemClick);
			// 
			// résultatsTournoiToolStripMenuItem
			// 
			this.résultatsTournoiToolStripMenuItem.Name = "résultatsTournoiToolStripMenuItem";
			this.résultatsTournoiToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.résultatsTournoiToolStripMenuItem.Text = "Résultats Tournoi";
			this.résultatsTournoiToolStripMenuItem.Click += new System.EventHandler(this.RésultatsTournoiToolStripMenuItemClick);
			// 
			// règlesToolStripMenuItem
			// 
			this.règlesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.déroulementToolStripMenuItem});
			this.règlesToolStripMenuItem.Name = "règlesToolStripMenuItem";
			this.règlesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.règlesToolStripMenuItem.Text = "Règles";
			// 
			// déroulementToolStripMenuItem
			// 
			this.déroulementToolStripMenuItem.Name = "déroulementToolStripMenuItem";
			this.déroulementToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.déroulementToolStripMenuItem.Text = "Déroulement";
			this.déroulementToolStripMenuItem.Click += new System.EventHandler(this.DéroulementToolStripMenuItemClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(308, 123);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(199, 191);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(60, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(716, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tournoi de Foot masculin de la Ville de Brie-Comte-Robert";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(335, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(149, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Session 2012";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Black;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(403, 353);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(181, 28);
			this.label3.TabIndex = 4;
			this.label3.Text = "label3";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(188, 337);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(209, 44);
			this.button1.TabIndex = 5;
			this.button1.Text = "Connection à la base de données";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(23, 242);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(108, 72);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.White;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(689, 242);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(108, 72);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
			// 
			// classementToolStripMenuItem
			// 
			this.classementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.classementTournoiToolStripMenuItem});
			this.classementToolStripMenuItem.Name = "classementToolStripMenuItem";
			this.classementToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
			this.classementToolStripMenuItem.Text = "Classement";
			// 
			// classementTournoiToolStripMenuItem
			// 
			this.classementTournoiToolStripMenuItem.Name = "classementTournoiToolStripMenuItem";
			this.classementTournoiToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.classementTournoiToolStripMenuItem.Text = "Classement tournoi";
			this.classementTournoiToolStripMenuItem.Click += new System.EventHandler(this.ClassementTournoiToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(828, 448);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Foot_Tournoi_Brie";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem classementTournoiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem classementToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ToolStripMenuItem saisieDeRésultatToolStripMenuItem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem déroulementToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem règlesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem résultatsTournoiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem résultatsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listageMatchsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ajoutMatchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem matchsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listageTerrainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ajoutTerrainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem terrainsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listageEquipesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ajoutEquipeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem equipeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
