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

namespace WindowsFormsApp2
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User unUser = new User(tbName.Text, tbPassword.Text);

            if (Bdd.Connexion())
            {

                if (tbName.Text == "" && tbPassword.Text == "")
                {
                    MessageBox.Show("Remplir tous les champs");
                }
                else
                {
                    if (Bdd.UserExiste(unUser))
                    {
                        MessageBox.Show("Un utilisateur est deja existant sous ce mail");
                    }
                    else
                    {
                        Bdd.CreateUser(unUser);
                        MessageBox.Show("Compte StreamIO creer avec succes");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.Show();
            this.Hide();
        }

        private void Inscription_Load(object sender, EventArgs e)
        {

        }
    }
}
