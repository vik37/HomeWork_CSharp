using System;
using AdminUsers.AdminServ;
using AdminUsers.Exceptions;
using AddminFace.Logger;
using AdminUsers;
using System.Linq;

namespace AddminFace
{
    class Program
    {
        static void Main(string[] args)
        {
            var allAdmins = Services.GetAllAdmins();
            var log = new AdminExceptionLogger();
            try
            {
                var allAdminsHelper = Services.GetAllAdminsHelper(null);
                foreach (var admin in allAdminsHelper)
                {
                    Console.WriteLine(admin.LastName);
                }
            }
            catch (AdmminException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                
                log.LogException(ex);
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine("Find your addmin by id");
                var inputNumber = int.Parse(Console.ReadLine());
                var getIdFromAdmin = Services.GetIdAdmins(inputNumber);
                Console.WriteLine($"{getIdFromAdmin.FirstName} {getIdFromAdmin.LastName} ");
            }
            catch (NullReferenceException ex)
            {
                log.LogException(ex);
            }
            catch (Exception ex)
            {
                log.LogException(ex);
                
                
            }
            Console.WriteLine("I proceed to work");
            Console.ReadLine();
        }
     
    }
}
