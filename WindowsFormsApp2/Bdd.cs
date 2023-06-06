using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;

namespace WindowsFormsApp2
{
    internal class Bdd
    {
        private static MySqlConnection connexion = null;
        public static bool Connexion()
        {
            connexion = new MySqlConnection("server=localhost;database=stream;userid=root;pwd="); /* userid= Stream pdw = stream123*/

            try
            {
                connexion.Open();
                MessageBox.Show("Connexion a la base de donnée bien etablie");
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }


                                                           //METHODE USER 
                

            public static bool UserExiste(User unUser) {

                string reqUser = "SELECT email FROM `user` WHERE name='" + unUser.getUserEmail()+"'";
                
                MySqlCommand cmd = connexion.CreateCommand();
                cmd.CommandText = reqUser;
                MySqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
            }




            public static bool UserVerify(User unUser)
            {

                string reqUser = "SELECT email FROM `user` WHERE email='" + unUser.getUserEmail() + "' AND password ='" + unUser.getPassword() + "'";

                MySqlCommand cmd = connexion.CreateCommand();
                cmd.CommandText = reqUser;
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
            }

        public static bool CreateUser(User createUser)
            {
                string reqCreateUser = "INSERT INTO user (email, password,role) VALUES ('" + createUser.getUserEmail() + "','','" + createUser.getPassword() + "','')";
                MySqlCommand command= connexion.CreateCommand();
                command.CommandText = reqCreateUser;

                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show(createUser.getUserEmail() + " vient d'être ajouté !");
                        return true;
                    }
                } catch (MySqlException e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }

                return false;
           
            }



                                            //METHODE AJOUTER AFFIHER



        public static bool CreateProduct(Product unProduct)
        {
            string reqCreateProduct = "INSERT INTO product (name, description,image, category, disponibility) VALUES ('" + unProduct.GetName() + "','"+ unProduct.GetDescription() + "','" + unProduct.GetImage() + "' , '" + unProduct.GetCategory() + "' , '" + unProduct.GetDisponibility()  +"')";
            MySqlCommand command = connexion.CreateCommand();
            command.CommandText = reqCreateProduct;



            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(unProduct.GetName() + " vient d'être ajouté !");
                    return true;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return false;

        }




        public static List<String> AfficherProduct()
        {
            List<String> listNameProduct = new List<String>();
            string AfficherProduit = "SELECT name FROM product";
            MySqlCommand cmd = connexion.CreateCommand();
            cmd.CommandText = AfficherProduit;
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listNameProduct.Add(reader.GetString(0));
            }
            reader.Close();
            return listNameProduct;

        }



        public static bool ProductExiste(Product unProduct)
        {

            string reqUser = "SELECT name FROM `product` WHERE name='" + unProduct.GetName() + "'";

            MySqlCommand cmd = connexion.CreateCommand();
            cmd.CommandText = reqUser;
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }



                                            //METHODE MODIFIER



        public static Product RequestProduct (string nomProduit)
        {
            Product products = new Product();
            string ReqProduct = "SELECT * FROM `product` WHERE name ='" + nomProduit + "'";

            MySqlCommand cmd = connexion.CreateCommand();
            cmd.CommandText = ReqProduct;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                products.SetName(reader.GetString(1));
                products.SetDescription(reader.GetString(2));
                products.setCategory(reader.GetString(4));
                products.setDisponibility(reader.GetInt32(5));
                products.setImage(reader.GetString(3));

                reader.Close();
                return products;
            }
            else
            {
                reader.Close();
                return products;
            }
        }



        public static bool UpdateProduct(Product unProduct)
        {
            string reqCreateProduct = "UPDATE `product` SET name = '" + unProduct.GetName() + "', description = '" + unProduct.GetDescription() + "', image = '" + unProduct.GetImage() + "', category = '" + unProduct.GetCategory() + "', disponibility = '" + unProduct.GetDisponibility() + "' WHERE name = '"+ unProduct.GetName() + "' ";
            MySqlCommand command = connexion.CreateCommand();
            command.CommandText = reqCreateProduct;



            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(unProduct.GetName() + " vient d'être modifie !");
                    return true;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return false;

        }

    }


    
}
