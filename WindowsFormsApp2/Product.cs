using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Product
    {
        private string name;
        private string description;
        private string image;
        private string category;
        private int disponibility;

        public Product()
        {

        }
        public Product (string name, string description, string image, string category, int disponibility)
        {
            this.name = name;
            this.description = description;
            this.image = image;
            this.category = category;
            this.disponibility = disponibility;
        }



        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public void setImage(string image)
        {
            this.image = image;
        }

        public void setCategory (string category)
        {
            this.category = category;
        }

        public void setDisponibility (int disponibility)
        {
            this.disponibility = disponibility;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetDescription()
        { 
            return this.description; 
        }

        public string GetImage()
        {
            return this.image;
        }

        public string GetCategory()
        {
            return this.category;
        }

        public int GetDisponibility()
        {
            return this.disponibility; 
        }

        internal string SetName(Product unProduit)
        {
            throw new NotImplementedException();
        }
    }
}
