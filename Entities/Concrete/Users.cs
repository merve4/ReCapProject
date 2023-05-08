using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Users : IEntity
    {
        public int Id { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }

        public int UserPassword { get; set; }
        
        public string CompanyName { get; set; }

    }
    //AllowMultiple--> aynı yerde birden fazla kez kullanılabilir mi?
    //AttributeTarget hangi özelliklere uygulanabilir?
    //[AttributeUsage(AttributeTargets.Property,AllowMultiple =true)] // .All bu attibuteu her şeye kullanabilirsin.
    //class RequiredPropertyAttribute:Attribute
    //    {

    //    }
}
