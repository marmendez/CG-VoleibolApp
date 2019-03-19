namespace CG_VoleibolApp
{
    partial class frmLives
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEqVisitante = new System.Windows.Forms.ComboBox();
            this.cbxLocal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMinusVisitante = new System.Windows.Forms.Button();
            this.btnPlusVisitante = new System.Windows.Forms.Button();
            this.btnPlusLocal = new System.Windows.Forms.Button();
            this.btnMinusLocal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSet1Vis = new System.Windows.Forms.Label();
            this.lblSet2Vis = new System.Windows.Forms.Label();
            this.lblSet3Vis = new System.Windows.Forms.Label();
            this.lblSet4Vis = new System.Windows.Forms.Label();
            this.lblSet5Vis = new System.Windows.Forms.Label();
            this.lblSet5Loc = new System.Windows.Forms.Label();
            this.lblSet4Loc = new System.Windows.Forms.Label();
            this.lblSet3Loc = new System.Windows.Forms.Label();
            this.lblSet2Loc = new System.Windows.Forms.Label();
            this.lblSet1Loc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblPtsVis = new System.Windows.Forms.Label();
            this.lblPtsLoc = new System.Windows.Forms.Label();
            this.lblSetWinnerVis = new System.Windows.Forms.Label();
            this.lblSetWinnerLoc = new System.Windows.Forms.Label();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnScorebox = new System.Windows.Forms.Button();
            this.btnParciales = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipo Local:";
            // 
            // cbxEqVisitante
            // 
            this.cbxEqVisitante.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEqVisitante.FormattingEnabled = true;
            this.cbxEqVisitante.Location = new System.Drawing.Point(314, 34);
            this.cbxEqVisitante.Name = "cbxEqVisitante";
            this.cbxEqVisitante.Size = new System.Drawing.Size(218, 24);
            this.cbxEqVisitante.TabIndex = 1;
            this.cbxEqVisitante.SelectedIndexChanged += new System.EventHandler(this.cbxEqVisitante_SelectedIndexChanged);
            // 
            // cbxLocal
            // 
            this.cbxLocal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLocal.FormattingEnabled = true;
            this.cbxLocal.Location = new System.Drawing.Point(49, 34);
            this.cbxLocal.Name = "cbxLocal";
            this.cbxLocal.Size = new System.Drawing.Size(218, 24);
            this.cbxLocal.TabIndex = 4;
            this.cbxLocal.SelectedIndexChanged += new System.EventHandler(this.cbxLocal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(313, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Equipo Visitante:";
            // 
            // btnMinusVisitante
            // 
            this.btnMinusVisitante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnMinusVisitante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.btnMinusVisitante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusVisitante.Image = global::CG_VoleibolApp.Properties.Resources.menus_b;
            this.btnMinusVisitante.Location = new System.Drawing.Point(420, 79);
            this.btnMinusVisitante.Name = "btnMinusVisitante";
            this.btnMinusVisitante.Size = new System.Drawing.Size(50, 55);
            this.btnMinusVisitante.TabIndex = 6;
            this.btnMinusVisitante.UseVisualStyleBackColor = false;
            this.btnMinusVisitante.Click += new System.EventHandler(this.btnMinusVisitante_Click);
            // 
            // btnPlusVisitante
            // 
            this.btnPlusVisitante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnPlusVisitante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.btnPlusVisitante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusVisitante.Image = global::CG_VoleibolApp.Properties.Resources.plus_b;
            this.btnPlusVisitante.Location = new System.Drawing.Point(470, 79);
            this.btnPlusVisitante.Name = "btnPlusVisitante";
            this.btnPlusVisitante.Size = new System.Drawing.Size(50, 55);
            this.btnPlusVisitante.TabIndex = 7;
            this.btnPlusVisitante.UseVisualStyleBackColor = false;
            this.btnPlusVisitante.Click += new System.EventHandler(this.btnPlusVisitante_Click);
            // 
            // btnPlusLocal
            // 
            this.btnPlusLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnPlusLocal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.btnPlusLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusLocal.Image = global::CG_VoleibolApp.Properties.Resources.plus_b;
            this.btnPlusLocal.Location = new System.Drawing.Point(107, 79);
            this.btnPlusLocal.Name = "btnPlusLocal";
            this.btnPlusLocal.Size = new System.Drawing.Size(50, 55);
            this.btnPlusLocal.TabIndex = 9;
            this.btnPlusLocal.UseVisualStyleBackColor = false;
            this.btnPlusLocal.Click += new System.EventHandler(this.btnPlusLocal_Click);
            // 
            // btnMinusLocal
            // 
            this.btnMinusLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnMinusLocal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.btnMinusLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusLocal.Image = global::CG_VoleibolApp.Properties.Resources.menus_b;
            this.btnMinusLocal.Location = new System.Drawing.Point(57, 79);
            this.btnMinusLocal.Name = "btnMinusLocal";
            this.btnMinusLocal.Size = new System.Drawing.Size(50, 55);
            this.btnMinusLocal.TabIndex = 8;
            this.btnMinusLocal.UseVisualStyleBackColor = false;
            this.btnMinusLocal.Click += new System.EventHandler(this.btnMinusLocal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "PUNTOS DEL SET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(408, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "PUNTOS DEL SET";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(295, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "SETS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(339, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 20);
            this.panel1.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(180, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "5to.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(135, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "4to.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(88, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "3er.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "2do.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-2, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "1er.";
            // 
            // lblSet1Vis
            // 
            this.lblSet1Vis.AutoSize = true;
            this.lblSet1Vis.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet1Vis.ForeColor = System.Drawing.Color.White;
            this.lblSet1Vis.Location = new System.Drawing.Point(332, 211);
            this.lblSet1Vis.Name = "lblSet1Vis";
            this.lblSet1Vis.Size = new System.Drawing.Size(33, 37);
            this.lblSet1Vis.TabIndex = 16;
            this.lblSet1Vis.Text = "0";
            this.lblSet1Vis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSet2Vis
            // 
            this.lblSet2Vis.AutoSize = true;
            this.lblSet2Vis.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet2Vis.ForeColor = System.Drawing.Color.White;
            this.lblSet2Vis.Location = new System.Drawing.Point(378, 211);
            this.lblSet2Vis.Name = "lblSet2Vis";
            this.lblSet2Vis.Size = new System.Drawing.Size(33, 37);
            this.lblSet2Vis.TabIndex = 17;
            this.lblSet2Vis.Text = "0";
            this.lblSet2Vis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSet3Vis
            // 
            this.lblSet3Vis.AutoSize = true;
            this.lblSet3Vis.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet3Vis.ForeColor = System.Drawing.Color.White;
            this.lblSet3Vis.Location = new System.Drawing.Point(424, 211);
            this.lblSet3Vis.Name = "lblSet3Vis";
            this.lblSet3Vis.Size = new System.Drawing.Size(33, 37);
            this.lblSet3Vis.TabIndex = 18;
            this.lblSet3Vis.Text = "0";
            this.lblSet3Vis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSet4Vis
            // 
            this.lblSet4Vis.AutoSize = true;
            this.lblSet4Vis.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet4Vis.ForeColor = System.Drawing.Color.White;
            this.lblSet4Vis.Location = new System.Drawing.Point(470, 211);
            this.lblSet4Vis.Name = "lblSet4Vis";
            this.lblSet4Vis.Size = new System.Drawing.Size(33, 37);
            this.lblSet4Vis.TabIndex = 19;
            this.lblSet4Vis.Text = "0";
            this.lblSet4Vis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSet5Vis
            // 
            this.lblSet5Vis.AutoSize = true;
            this.lblSet5Vis.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet5Vis.ForeColor = System.Drawing.Color.White;
            this.lblSet5Vis.Location = new System.Drawing.Point(515, 211);
            this.lblSet5Vis.Name = "lblSet5Vis";
            this.lblSet5Vis.Size = new System.Drawing.Size(33, 37);
            this.lblSet5Vis.TabIndex = 20;
            this.lblSet5Vis.Text = "0";
            this.lblSet5Vis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSet5Loc
            // 
            this.lblSet5Loc.AutoSize = true;
            this.lblSet5Loc.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet5Loc.ForeColor = System.Drawing.Color.White;
            this.lblSet5Loc.Location = new System.Drawing.Point(233, 211);
            this.lblSet5Loc.Name = "lblSet5Loc";
            this.lblSet5Loc.Size = new System.Drawing.Size(33, 37);
            this.lblSet5Loc.TabIndex = 27;
            this.lblSet5Loc.Text = "0";
            this.lblSet5Loc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSet4Loc
            // 
            this.lblSet4Loc.AutoSize = true;
            this.lblSet4Loc.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet4Loc.ForeColor = System.Drawing.Color.White;
            this.lblSet4Loc.Location = new System.Drawing.Point(188, 211);
            this.lblSet4Loc.Name = "lblSet4Loc";
            this.lblSet4Loc.Size = new System.Drawing.Size(33, 37);
            this.lblSet4Loc.TabIndex = 26;
            this.lblSet4Loc.Text = "0";
            this.lblSet4Loc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSet3Loc
            // 
            this.lblSet3Loc.AutoSize = true;
            this.lblSet3Loc.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet3Loc.ForeColor = System.Drawing.Color.White;
            this.lblSet3Loc.Location = new System.Drawing.Point(142, 211);
            this.lblSet3Loc.Name = "lblSet3Loc";
            this.lblSet3Loc.Size = new System.Drawing.Size(33, 37);
            this.lblSet3Loc.TabIndex = 25;
            this.lblSet3Loc.Text = "0";
            this.lblSet3Loc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSet2Loc
            // 
            this.lblSet2Loc.AutoSize = true;
            this.lblSet2Loc.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet2Loc.ForeColor = System.Drawing.Color.White;
            this.lblSet2Loc.Location = new System.Drawing.Point(96, 211);
            this.lblSet2Loc.Name = "lblSet2Loc";
            this.lblSet2Loc.Size = new System.Drawing.Size(33, 37);
            this.lblSet2Loc.TabIndex = 24;
            this.lblSet2Loc.Text = "0";
            this.lblSet2Loc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSet1Loc
            // 
            this.lblSet1Loc.AutoSize = true;
            this.lblSet1Loc.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet1Loc.ForeColor = System.Drawing.Color.White;
            this.lblSet1Loc.Location = new System.Drawing.Point(50, 211);
            this.lblSet1Loc.Name = "lblSet1Loc";
            this.lblSet1Loc.Size = new System.Drawing.Size(33, 37);
            this.lblSet1Loc.TabIndex = 23;
            this.lblSet1Loc.Text = "0";
            this.lblSet1Loc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSet1Loc.MouseHover += new System.EventHandler(this.lblSet1Loc_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Location = new System.Drawing.Point(51, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 20);
            this.panel2.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(186, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "5to.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(141, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "4to.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(94, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "3er.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(48, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "2do.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(4, 5);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "1er.";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(14, 199);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 16);
            this.label21.TabIndex = 21;
            this.label21.Text = "SETS";
            // 
            // lblPtsVis
            // 
            this.lblPtsVis.AutoSize = true;
            this.lblPtsVis.Font = new System.Drawing.Font("Nirmala UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPtsVis.ForeColor = System.Drawing.Color.White;
            this.lblPtsVis.Location = new System.Drawing.Point(448, 137);
            this.lblPtsVis.Name = "lblPtsVis";
            this.lblPtsVis.Size = new System.Drawing.Size(50, 59);
            this.lblPtsVis.TabIndex = 28;
            this.lblPtsVis.Text = "0";
            this.lblPtsVis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPtsVis.TextChanged += new System.EventHandler(this.lblPtsVis_TextChanged);
            // 
            // lblPtsLoc
            // 
            this.lblPtsLoc.AutoSize = true;
            this.lblPtsLoc.Font = new System.Drawing.Font("Nirmala UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPtsLoc.ForeColor = System.Drawing.Color.White;
            this.lblPtsLoc.Location = new System.Drawing.Point(84, 137);
            this.lblPtsLoc.Name = "lblPtsLoc";
            this.lblPtsLoc.Size = new System.Drawing.Size(50, 59);
            this.lblPtsLoc.TabIndex = 29;
            this.lblPtsLoc.Text = "0";
            this.lblPtsLoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPtsLoc.TextChanged += new System.EventHandler(this.lblPtsLoc_TextChanged);
            // 
            // lblSetWinnerVis
            // 
            this.lblSetWinnerVis.AutoSize = true;
            this.lblSetWinnerVis.BackColor = System.Drawing.Color.Lime;
            this.lblSetWinnerVis.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetWinnerVis.ForeColor = System.Drawing.Color.Black;
            this.lblSetWinnerVis.Location = new System.Drawing.Point(299, 219);
            this.lblSetWinnerVis.Name = "lblSetWinnerVis";
            this.lblSetWinnerVis.Size = new System.Drawing.Size(33, 37);
            this.lblSetWinnerVis.TabIndex = 30;
            this.lblSetWinnerVis.Text = "0";
            this.lblSetWinnerVis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSetWinnerLoc
            // 
            this.lblSetWinnerLoc.AutoSize = true;
            this.lblSetWinnerLoc.BackColor = System.Drawing.Color.Lime;
            this.lblSetWinnerLoc.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetWinnerLoc.ForeColor = System.Drawing.Color.Black;
            this.lblSetWinnerLoc.Location = new System.Drawing.Point(20, 219);
            this.lblSetWinnerLoc.Name = "lblSetWinnerLoc";
            this.lblSetWinnerLoc.Size = new System.Drawing.Size(33, 37);
            this.lblSetWinnerLoc.TabIndex = 31;
            this.lblSetWinnerLoc.Text = "0";
            this.lblSetWinnerLoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMatch
            // 
            this.btnMatch.BackColor = System.Drawing.Color.Lime;
            this.btnMatch.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatch.Location = new System.Drawing.Point(18, 413);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(139, 61);
            this.btnMatch.TabIndex = 32;
            this.btnMatch.Text = "ENFRENTAMIENTO";
            this.btnMatch.UseVisualStyleBackColor = false;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // btnScorebox
            // 
            this.btnScorebox.BackColor = System.Drawing.Color.Lime;
            this.btnScorebox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScorebox.Location = new System.Drawing.Point(224, 413);
            this.btnScorebox.Name = "btnScorebox";
            this.btnScorebox.Size = new System.Drawing.Size(139, 61);
            this.btnScorebox.TabIndex = 33;
            this.btnScorebox.Text = "SCOREBOX";
            this.btnScorebox.UseVisualStyleBackColor = false;
            this.btnScorebox.Click += new System.EventHandler(this.btnScorebox_Click);
            // 
            // btnParciales
            // 
            this.btnParciales.BackColor = System.Drawing.Color.Lime;
            this.btnParciales.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParciales.Location = new System.Drawing.Point(425, 413);
            this.btnParciales.Name = "btnParciales";
            this.btnParciales.Size = new System.Drawing.Size(139, 61);
            this.btnParciales.TabIndex = 34;
            this.btnParciales.Text = "PIZARRA";
            this.btnParciales.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(224, 155);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(139, 28);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Finalizar Set";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(229, 82);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 16);
            this.label22.TabIndex = 36;
            this.label22.Text = "SET:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(272, 69);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(37, 43);
            this.numericUpDown1.TabIndex = 38;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // frmLives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(584, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnParciales);
            this.Controls.Add(this.btnScorebox);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.lblSetWinnerLoc);
            this.Controls.Add(this.lblSetWinnerVis);
            this.Controls.Add(this.lblPtsLoc);
            this.Controls.Add(this.lblPtsVis);
            this.Controls.Add(this.lblSet5Loc);
            this.Controls.Add(this.lblSet4Loc);
            this.Controls.Add(this.lblSet3Loc);
            this.Controls.Add(this.lblSet2Loc);
            this.Controls.Add(this.lblSet1Loc);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblSet5Vis);
            this.Controls.Add(this.lblSet4Vis);
            this.Controls.Add(this.lblSet3Vis);
            this.Controls.Add(this.lblSet2Vis);
            this.Controls.Add(this.lblSet1Vis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPlusLocal);
            this.Controls.Add(this.btnMinusLocal);
            this.Controls.Add(this.btnPlusVisitante);
            this.Controls.Add(this.btnMinusVisitante);
            this.Controls.Add(this.cbxLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxEqVisitante);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLives";
            this.Text = "frmLives";
            this.Load += new System.EventHandler(this.frmLives_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEqVisitante;
        private System.Windows.Forms.ComboBox cbxLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMinusVisitante;
        private System.Windows.Forms.Button btnPlusVisitante;
        private System.Windows.Forms.Button btnPlusLocal;
        private System.Windows.Forms.Button btnMinusLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSet1Vis;
        private System.Windows.Forms.Label lblSet2Vis;
        private System.Windows.Forms.Label lblSet3Vis;
        private System.Windows.Forms.Label lblSet4Vis;
        private System.Windows.Forms.Label lblSet5Vis;
        private System.Windows.Forms.Label lblSet5Loc;
        private System.Windows.Forms.Label lblSet4Loc;
        private System.Windows.Forms.Label lblSet3Loc;
        private System.Windows.Forms.Label lblSet2Loc;
        private System.Windows.Forms.Label lblSet1Loc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblPtsVis;
        private System.Windows.Forms.Label lblPtsLoc;
        private System.Windows.Forms.Label lblSetWinnerVis;
        private System.Windows.Forms.Label lblSetWinnerLoc;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnScorebox;
        private System.Windows.Forms.Button btnParciales;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}