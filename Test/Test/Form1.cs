using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        CategoriesOps metodo = new CategoriesOps();
        public Form1()
        {
            InitializeComponent();
        }
    
        
        private void Browse_Click(object sender, EventArgs e)
        {
            Buscar();
        }

       
        private void Buscar()
           {
            foreach (Category c in metodo.GetCategories())
            {
                Resultado.Items.Add(c.CategoryName + "\t" + c.Description);
            }           
           }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (TxtName.Text.Equals(""))
            {
                MessageBox.Show("Please write te name of the company that you want to delete");
               
            }
            else
            {
                metodo.DeleteCategory(TxtName.Text);
                TxtName.Text = "";
                MessageBox.Show("Your item has been removed");
                
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {          
                Category category = new Category();        
                category.CategoryName = TxtName.Text;
                category.Description = TxtDescription.Text;
              

                metodo.SetCategory(category);
                MessageBox.Show("You add a new item");            
        }

        private void Update_Click(object sender, EventArgs e)
        {            
            metodo.UpdateCategory(TxtName.Text, TxtDescription.Text);
            MessageBox.Show("Your list has been updated");

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
