using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using SBMS.Repository;
using SBMS.Model;

namespace SBMS.BLL
{
   public class CategoryManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();
         
        public bool insertvalue(Categories categories)

        {
            return _categoryRepository.insertvalue(categories);
        }
        public bool IsNameexist(string code, string name)
        {
            return _categoryRepository.IsNameexist(code, name);
        }

        public DataTable show()
        {
            return _categoryRepository.show();
        }

    }


   
}
