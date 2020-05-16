using System;
using System.Collections.Generic;

namespace AdminUsers
{
    public class Addmins
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> NonAdminsMembers { get; set; }
        public List<Addmins> AdminsHelper { get; set; }
    }
    //public int GetAdminsId(int Id)
    //{
    //    return Id;
    //}
}
