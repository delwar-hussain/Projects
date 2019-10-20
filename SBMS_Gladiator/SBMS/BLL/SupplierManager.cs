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
   public class SupplierManager
    {
        SupplierRepository _supplierRepository = new SupplierRepository();
       // public bool insertvalue(string code, string name, string address, string email, string contact, string contactperson)
        public bool insertvalue(Suppliers suppliers)
        
        {
            return _supplierRepository.insertvalue(suppliers);
        }

        public bool IsNameexist(string code, string email, string contact)
        {
            return _supplierRepository.IsNameexist(code, email, contact);
        }

        public DataTable show()
        {
            return _supplierRepository.show();
        }
        public bool update(Suppliers suppliers)
        //public bool update(string code, string name, string address, string email, string contact, string contactperson)
        {
            return _supplierRepository.update(suppliers);
        }

        public bool delete(string code)
        {
            return _supplierRepository.delete(code);
        }
    }
}
