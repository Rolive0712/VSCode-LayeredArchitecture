using System;
using DotNetCoreApp.DataAccess;

namespace DotNetCoreApp.Business
{
    public class PersonBusinessRepo
    {
        public PersonBusinessRepo()
        {
            
        }

        public string GetBSString()
        {
           PersonDBRepository b = new PersonDBRepository();
           return "From Business Layer" + b.GetDBString() + b.CheckIntellisense();

        }

        public string CheckBSIntellisense()
        {
           
           return "From Business Layer intellisense";

        }
    }
}