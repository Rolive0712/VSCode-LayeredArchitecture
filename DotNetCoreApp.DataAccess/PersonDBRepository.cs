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

        public string CheckIntellisense()
        {
            return "Checking Intellisense";
        }
    }
}