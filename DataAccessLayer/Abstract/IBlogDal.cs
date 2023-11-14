using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IBlogDal
    {
        List<Blog> ListAllCategory(); //Tüm Blogları getir
        void Addblog(Blog blog); // Ekleme

        void DeleteBlog(Blog blog); // Silme

        void Updateblog(Blog blog); //Güncelleme

        Blog GetById(int id);// id ye göre işlemler
    }
}

// Üstteki Category ve Blog Interfacelerinin tanımlanma şekilleri yanlış olmasa da daha doğru bir yöntem var