namespace WindowsFormsApp2
{
    partial class Produit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            this.panelAjouter = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDispo = new System.Windows.Forms.NumericUpDown();
            this.tbCat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbImage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelModifier = new System.Windows.Forms.Panel();
            this.ModifDispo = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.ModifCat = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ModifUrl = new System.Windows.Forms.TextBox();
            this.ModifDesc = new System.Windows.Forms.TextBox();
            this.NameModif = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bddBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label1 = new System.Windows.Forms.Label();
            this.panelAjouter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDispo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelModifier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModifDispo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(509, 13);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(146, 25);
            label1.TabIndex = 3;
            label1.Text = "Nom du Produit";
            // 
            // panelAjouter
            // 
            this.panelAjouter.Controls.Add(this.label8);
            this.panelAjouter.Controls.Add(this.label7);
            this.panelAjouter.Controls.Add(this.tbDispo);
            this.panelAjouter.Controls.Add(this.tbCat);
            this.panelAjouter.Controls.Add(this.label4);
            this.panelAjouter.Controls.Add(this.tbImage);
            this.panelAjouter.Controls.Add(this.button1);
            this.panelAjouter.Controls.Add(this.label2);
            this.panelAjouter.Controls.Add(label1);
            this.panelAjouter.Controls.Add(this.tbDesc);
            this.panelAjouter.Controls.Add(this.tbname);
            this.panelAjouter.Location = new System.Drawing.Point(91, 64);
            this.panelAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAjouter.Name = "panelAjouter";
            this.panelAjouter.Size = new System.Drawing.Size(1159, 688);
            this.panelAjouter.TabIndex = 0;
            this.panelAjouter.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(529, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "disponibilté";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Categorie";
            // 
            // tbDispo
            // 
            this.tbDispo.Location = new System.Drawing.Point(407, 353);
            this.tbDispo.Name = "tbDispo";
            this.tbDispo.Size = new System.Drawing.Size(341, 30);
            this.tbDispo.TabIndex = 10;
            // 
            // tbCat
            // 
            this.tbCat.Location = new System.Drawing.Point(286, 262);
            this.tbCat.Name = "tbCat";
            this.tbCat.Size = new System.Drawing.Size(580, 30);
            this.tbCat.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "URL Image";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbImage
            // 
            this.tbImage.Location = new System.Drawing.Point(286, 188);
            this.tbImage.Margin = new System.Windows.Forms.Padding(8);
            this.tbImage.Name = "tbImage";
            this.tbImage.Size = new System.Drawing.Size(580, 30);
            this.tbImage.TabIndex = 7;
            this.tbImage.TextChanged += new System.EventHandler(this.tbetat_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 404);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description produit";
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(286, 117);
            this.tbDesc.Margin = new System.Windows.Forms.Padding(8);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(580, 30);
            this.tbDesc.TabIndex = 1;
            this.tbDesc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(286, 46);
            this.tbname.Margin = new System.Windows.Forms.Padding(8);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(580, 30);
            this.tbname.TabIndex = 0;
            this.tbname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produitsToolStripMenuItem,
            this.modifierToolStripMenuItem1,
            this.supprimerToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1309, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produitsToolStripMenuItem
            // 
            this.produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            this.produitsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.produitsToolStripMenuItem.Text = "Ajouter";
            this.produitsToolStripMenuItem.Click += new System.EventHandler(this.produitsToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(80, 24);
            this.modifierToolStripMenuItem1.Text = "Modifier";
            this.modifierToolStripMenuItem1.Click += new System.EventHandler(this.modifierToolStripMenuItem1_Click);
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(92, 24);
            this.supprimerToolStripMenuItem1.Text = "Supprimer";
            // 
            // panelModifier
            // 
            this.panelModifier.Controls.Add(this.ModifDispo);
            this.panelModifier.Controls.Add(this.label9);
            this.panelModifier.Controls.Add(this.ModifCat);
            this.panelModifier.Controls.Add(this.button2);
            this.panelModifier.Controls.Add(this.label6);
            this.panelModifier.Controls.Add(this.label5);
            this.panelModifier.Controls.Add(this.label3);
            this.panelModifier.Controls.Add(this.ModifUrl);
            this.panelModifier.Controls.Add(this.ModifDesc);
            this.panelModifier.Controls.Add(this.NameModif);
            this.panelModifier.Controls.Add(this.listBox1);
            this.panelModifier.Location = new System.Drawing.Point(87, 64);
            this.panelModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelModifier.Name = "panelModifier";
            this.panelModifier.Size = new System.Drawing.Size(1159, 740);
            this.panelModifier.TabIndex = 4;
            // 
            // ModifDispo
            // 
            this.ModifDispo.Location = new System.Drawing.Point(312, 574);
            this.ModifDispo.Name = "ModifDispo";
            this.ModifDispo.Size = new System.Drawing.Size(530, 30);
            this.ModifDispo.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Categorie";
            // 
            // ModifCat
            // 
            this.ModifCat.Location = new System.Drawing.Point(311, 510);
            this.ModifCat.Name = "ModifCat";
            this.ModifCat.Size = new System.Drawing.Size(656, 30);
            this.ModifCat.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 617);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(360, 68);
            this.button2.TabIndex = 7;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 395);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "URL image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom de produit";
            // 
            // ModifUrl
            // 
            this.ModifUrl.Location = new System.Drawing.Point(311, 425);
            this.ModifUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModifUrl.Name = "ModifUrl";
            this.ModifUrl.Size = new System.Drawing.Size(656, 30);
            this.ModifUrl.TabIndex = 3;
            // 
            // ModifDesc
            // 
            this.ModifDesc.Location = new System.Drawing.Point(312, 344);
            this.ModifDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModifDesc.Name = "ModifDesc";
            this.ModifDesc.Size = new System.Drawing.Size(655, 30);
            this.ModifDesc.TabIndex = 2;
            // 
            // NameModif
            // 
            this.NameModif.Location = new System.Drawing.Point(312, 264);
            this.NameModif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameModif.Name = "NameModif";
            this.NameModif.Size = new System.Drawing.Size(655, 30);
            this.NameModif.TabIndex = 1;
            this.NameModif.TextChanged += new System.EventHandler(this.NameModif_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(312, 13);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(656, 204);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // bddBindingSource
            // 
            this.bddBindingSource.DataSource = typeof(WindowsFormsApp2.Bdd);
            // 
            // Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1309, 871);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelModifier);
            this.Controls.Add(this.panelAjouter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Produit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.Produit_Load);
            this.panelAjouter.ResumeLayout(false);
            this.panelAjouter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDispo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelModifier.ResumeLayout(false);
            this.panelModifier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModifDispo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAjouter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbImage;
        private System.Windows.Forms.BindingSource bddBindingSource;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem1;
        private System.Windows.Forms.Panel panelModifier;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModifUrl;
        private System.Windows.Forms.TextBox ModifDesc;
        private System.Windows.Forms.TextBox NameModif;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbCat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.NumericUpDown tbDispo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ModifDispo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ModifCat;
    }
}