using System;
using System.Collections.Generic;
using System.Text;

namespace AdminUsers.FakeDataBase
{
    internal static class DB
    {
        internal static List<Addmins> addmins = MockDataClass.GetMockAdmins();
    }
}
