using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IcategoryDal
    {
        List<Category> ListAllCategory(); //Tüm Categorileri getir
        void AddCategory(Category category); // Ekleme

        void DeleteCategory(Category category); // Silme

        void UpdateCategory(Category category); //Güncelleme

        Category GetById(int id);// id ye göre işlemler

    }
}
