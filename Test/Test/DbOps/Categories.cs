using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{


    class CategoriesOps
    {
        private NorthwindEntities entities = new NorthwindEntities();
        

       
        public List <Category> GetCategories()
        {
            return entities.Categories.ToList();
        }

        public Category GetCategoryByName(string name)
            
        {
            return entities.Categories.FirstOrDefault(c => c.CategoryName==name);
        }
        public void SetCategory(Category category)
        {
            entities.Categories.Add(category);
            entities.SaveChanges();            
        }

        public void UpdateCategory(string name)
        {
            var category = GetCategoryByName(name);
            if (category != null)
            {
                category.CategoryName = name;
                entities.SaveChanges();                   
            }
        }
        public void UpdateCategory(string name,string description)
        {
            var category = GetCategoryByName(name);
            if (category != null)
            {
                category.CategoryName = name;
                category.Description = description;
                
            }
        }
        public void DeleteCategory(string name)
        {
            var category = GetCategoryByName(name);            
            entities.Categories.Remove(category);            
            entities.SaveChanges();          
        }

           
    }
}
