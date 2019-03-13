namespace CG_VoleibolApp
{
    partial class frmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbTeamsFolder = new System.Windows.Forms.TextBox();
            this.btnFindFolderTeams = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbPlayersFolder = new System.Windows.Forms.TextBox();
            this.btnFindFolderPlayer = new System.Windows.Forms.Button();
            this.btnFindProjectFile = new System.Windows.Forms.Button();
            this.tbxProyectosXML = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Configuración";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Archivo de Nombre de Equipos:";
            // 
            // txtbTeamsFolder
            // 
            this.txtbTeamsFolder.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTeamsFolder.Location = new System.Drawing.Point(12, 70);
            this.txtbTeamsFolder.Name = "txtbTeamsFolder";
            this.txtbTeamsFolder.ReadOnly = true;
            this.txtbTeamsFolder.Size = new System.Drawing.Size(313, 22);
            this.txtbTeamsFolder.TabIndex = 3;
            // 
            // btnFindFolderTeams
            // 
            this.btnFindFolderTeams.Image = ((System.Drawing.Image)(resources.GetObject("btnFindFolderTeams.Image")));
            this.btnFindFolderTeams.Location = new System.Drawing.Point(331, 48);
            this.btnFindFolderTeams.Name = "btnFindFolderTeams";
            this.btnFindFolderTeams.Size = new System.Drawing.Size(75, 45);
            this.btnFindFolderTeams.TabIndex = 4;
            this.btnFindFolderTeams.UseVisualStyleBackColor = true;
            this.btnFindFolderTeams.Click += new System.EventHandler(this.btnFindFolderTeams_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(560, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Folder de Archivos con Listas de Jugadores:";
            // 
            // txtbPlayersFolder
            // 
            this.txtbPlayersFolder.Enabled = false;
            this.txtbPlayersFolder.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPlayersFolder.Location = new System.Drawing.Point(12, 129);
            this.txtbPlayersFolder.Name = "txtbPlayersFolder";
            this.txtbPlayersFolder.ReadOnly = true;
            this.txtbPlayersFolder.Size = new System.Drawing.Size(313, 22);
            this.txtbPlayersFolder.TabIndex = 6;
            // 
            // btnFindFolderPlayer
            // 
            this.btnFindFolderPlayer.Enabled = false;
            this.btnFindFolderPlayer.Image = ((System.Drawing.Image)(resources.GetObject("btnFindFolderPlayer.Image")));
            this.btnFindFolderPlayer.Location = new System.Drawing.Point(331, 107);
            this.btnFindFolderPlayer.Name = "btnFindFolderPlayer";
            this.btnFindFolderPlayer.Size = new System.Drawing.Size(75, 45);
            this.btnFindFolderPlayer.TabIndex = 7;
            this.btnFindFolderPlayer.UseVisualStyleBackColor = true;
            this.btnFindFolderPlayer.Click += new System.EventHandler(this.btnFindFolderPlayer_Click);
            // 
            // btnFindProjectFile
            // 
            this.btnFindProjectFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFindProjectFile.Image")));
            this.btnFindProjectFile.Location = new System.Drawing.Point(331, 164);
            this.btnFindProjectFile.Name = "btnFindProjectFile";
            this.btnFindProjectFile.Size = new System.Drawing.Size(75, 45);
            this.btnFindProjectFile.TabIndex = 10;
            this.btnFindProjectFile.UseVisualStyleBackColor = true;
            this.btnFindProjectFile.Click += new System.EventHandler(this.btnFindProjectFile_Click);
            // 
            // tbxProyectosXML
            // 
            this.tbxProyectosXML.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProyectosXML.Location = new System.Drawing.Point(12, 186);
            this.tbxProyectosXML.Name = "tbxProyectosXML";
            this.tbxProyectosXML.ReadOnly = true;
            this.tbxProyectosXML.Size = new System.Drawing.Size(313, 22);
            this.tbxProyectosXML.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Archivos de Proyectos Black Magic:";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(584, 486);
            this.Controls.Add(this.btnFindProjectFile);
            this.Controls.Add(this.tbxProyectosXML);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFindFolderPlayer);
            this.Controls.Add(this.txtbPlayersFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFindFolderTeams);
            this.Controls.Add(this.txtbTeamsFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfig";
            this.Text = "frmConfig";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbTeamsFolder;
        private System.Windows.Forms.Button btnFindFolderTeams;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbPlayersFolder;
        private System.Windows.Forms.Button btnFindFolderPlayer;
        private System.Windows.Forms.Button btnFindProjectFile;
        private System.Windows.Forms.TextBox tbxProyectosXML;
        private System.Windows.Forms.Label label4;
    }
}