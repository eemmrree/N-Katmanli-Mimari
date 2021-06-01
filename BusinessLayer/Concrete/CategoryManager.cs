using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        private GenericRepos<Category> repo = new GenericRepos<Category>();

        public List<Category> GetAll()
        {
            return repo.List();
        }

        public void CategoryAddBL(Category p)
        {
            if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" ||
                p.CategoryName.Length >= 51)
            {
                //hata yeri
            }
            else
            {
                repo.Insert(p);
            }

        }
    }
}
