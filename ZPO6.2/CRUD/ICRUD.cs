using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO6._2.Modele;

namespace ZPO6._2.CRUD
{
    interface ICRUD
    {
        int Create(IModel model);
        int Read(IModel id);
        int Update(IModel model);
        int Delete(IModel model);

        void GetAll();
    }
}
