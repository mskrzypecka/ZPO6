using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO6._2.CRUD
{
    interface ICRUD
    {
        void Create();
        void Read(long id);
        void Update(object model);
        void Delete();
    }
}
