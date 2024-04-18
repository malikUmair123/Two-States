using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStatesDAL
{
    public class DALClass
    {
        TwoStates1Entities db = new TwoStates1Entities();
        public string Register(User_Details user)

        {
            try
            {
                db.User_Details.Add(user);
                db.SaveChanges();
                return "Success";

            } catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string Login(User_Details user)
        {
            try
            {
                var isPresent = (from User in db.User_Details
                                 where User.Username == user.Username && User.Password == user.Password
                                 select User).ToList();

                if (isPresent.Count != 0)
                {
                    return "Success";

                } else 

                return "Invalid User";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public bool IsUserExists(string user)
        {
            try
            {
                var isPresent = (from User in db.User_Details
                                 where User.Username == user
                                 select User.User_ID);

                if (isPresent != null)
                {
                    return false;

                }
                else

                    return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
    }
