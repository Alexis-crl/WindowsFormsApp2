using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user1 = new User(textBox1.Text, textBox2.Text);

            if (Bdd.Connexion())
            {
                if (Bdd.UserVerify(user1))
                {
                    MessageBox.Show("Connexion : ok");

                    Produit formulaireProduit = new Produit();
                    formulaireProduit.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Email ou mot de passe incorrect");
                }
            }


            
        }

        private void creerUnCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.Show();
            this.Hide();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
