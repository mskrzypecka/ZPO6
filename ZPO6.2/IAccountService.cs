using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO6._2
{
    public interface IAccountService
    {
        void CreateUser();
        void ChangePassword();
        void ChangeAdress();
        void DeleteUser();
        void SelectAllUsers();
    }
}
