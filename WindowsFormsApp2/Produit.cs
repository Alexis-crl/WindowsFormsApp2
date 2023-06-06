using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Produit : Form
    {
        public Produit()
        {
            InitializeComponent();
            panelModifier.Hide();

            foreach (string item in Bdd.AfficherProduct())
            {
                listBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product(tbname.Text, tbDesc.Text, tbImage.Text, tbCat.Text, ((int)tbDispo.Value));

            if (Bdd.Connexion())
            {

                if (tbname.Text == "" || tbDesc.Text == "" || tbImage.Text == "" || tbCat.Text=="")
                {
                    MessageBox.Show("Merci de bien vouloir remplir tous les champs");
                }
                else
                {

                    if (Bdd.ProductExiste(product))
                    {
                        MessageBox.Show("Produit deja existant");
                    }
                    else
                    {
                        if (Bdd.CreateProduct(product))
                        {
                            MessageBox.Show("Le produit a bien ete ajoutée");
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }

                    

                }


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void ajouterUnProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void tbetat_TextChanged(object sender, EventArgs e)
        {

        }

        private void Produit_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listView1.Items.AddRange(Bdd.AfficherProduct());
        }

        private void produitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAjouter.Show();
            panelModifier.Hide();
        }

        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelAjouter.Hide();
            panelModifier.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product unProduit = Bdd.RequestProduct(listBox1.SelectedItem.ToString());

            NameModif.Text = unProduit.GetName();
            ModifDesc.Text = unProduit.GetDescription();
            ModifCat.Text = unProduit.GetCategory();
            ModifUrl.Text = unProduit.GetImage();
            ModifDispo.Value = unProduit.GetDisponibility();


        }

        private void NameModif_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            Product product = new Product(NameModif.Text, ModifDesc.Text, ModifUrl.Text, ModifCat.Text, ((int)ModifDispo.Value));
            if (NameModif.Text == "" || ModifDesc.Text == "" || ModifUrl.Text == "" || ModifCat.Text == "")
            {
                MessageBox.Show("Merci de bien vouloir remplir tous les champs");
            }
            else
            {
                if (Bdd.UpdateProduct(product))
                {
                    MessageBox.Show("Le produit a bien ete modifié");
                }
            }
        }
    }
}
