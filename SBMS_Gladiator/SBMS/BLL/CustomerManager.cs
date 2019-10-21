using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using  SBMS.Model;
using  SBMS.Repository;

namespace SBMS.BLL
{
   public class CustomerManager
    {
        CustomerReporsitory _customerReporsitory = new CustomerReporsitory();
        
        public bool insertvalue(Customers customers)

        {
            return _customerReporsitory.insertvalue(customers);
        }

        public bool IsNameexist(Customers customers)
        {
            return _customerReporsitory.IsNameexist(customers);
        }

        public DataTable show()
        {
            return _customerReporsitory.show();
        }
        public bool update(Customers customers)
             
        {
            return _customerReporsitory.update(customers);
        }

        public bool delete(Customers customers)
        {
            return _customerReporsitory.delete(customers);
        }
    }
}
