using System;
using System.Collections.Generic;
using System.Text;
using AdminUsers;

namespace AdminUsers.FakeDataBase
{
    internal class MockDataClass
    {
        internal static List<Addmins> GetMockAdmins()
        {
            Addmins pavel = new Addmins()
            {
                Id = 1,
                FirstName = "Pavel",
                LastName = "Poborsky",

            };
            Addmins srecko = new Addmins()
            {
                Id = 2,
                FirstName = "Srecko",
                LastName = "Katanec",

            };
            Addmins vasil = new Addmins()
            {
                Id = 3,
                FirstName = "Vasil",
                LastName = "Ringov",
                NonAdminsMembers = new List<string>() { "Andon Doncevski", "Ilija Najdovski", "Pepi Baftirovski" },
                AdminsHelper = new List<Addmins>() { pavel }

            };
            Addmins arpad = new Addmins()
            {
                Id = 4,
                FirstName = "Arpad",
                LastName = "Sterbik",
                NonAdminsMembers = new List<string>() { "Toni Micevski", "Nikola Markovski", "Dragan Djaic" },
                AdminsHelper = new List<Addmins>() { pavel,  srecko }
            };
            Addmins petar = new Addmins()
            {
                Id = 5,
                FirstName = "Petar",
                LastName = "Deljan",
                AdminsHelper = new List<Addmins>() { vasil, arpad, srecko }
            };
            return new List<Addmins>() { pavel, srecko, vasil, arpad, petar};
        }
    }
}
