using System;

namespace DotNetCoreApp.DataAccess
{
    public class PersonDBRepository
    {
        public PersonDBRepository()
        {
            
        }

        public string GetDBString()
        {
            return "From DataAccess Layer";
        }
    }
}