using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdminUsers.FakeDataBase;
using AdminUsers.Exceptions;

namespace AdminUsers.AdminServ
{
    public static class Services
    {
        public static List<Addmins> GetAllAdmins()
        {
            return DB.addmins;
        }
        public static Addmins GetIdAdmins(int id)
        {
            Addmins admin = DB.addmins.Single(a => a.Id == id);
            return admin;
        }
        public static List<Addmins> GetAllAdminsHelper(Addmins findAllAdminsHelper)
        {
            try
            {
                var allAdminsHelper = DB.addmins.Single(admin => admin.Equals(findAllAdminsHelper));
                return allAdminsHelper.AdminsHelper;
            }
            catch (InvalidOperationException ex)
            {

                throw new AdmminException("You sand me a null", ex);
            }
            catch(Exception)
            {
                throw new Exception();
            }
        }
        
    }
}
