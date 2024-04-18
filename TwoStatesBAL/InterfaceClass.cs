using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoStatesDAL;

namespace TwoStatesBAL
{
    public class InterfaceClass
    {
        DALClass DALObj = new DALClass();
        public string Register(User_Details user)

        {
            return DALObj.Register(user);
            
        }

        public string Login(User_Details user)
        {
            return DALObj.Login(user);

        }

        public bool IsUserExists(string user)
        {
            return DALObj.IsUserExists(user);
        }
    }
}
