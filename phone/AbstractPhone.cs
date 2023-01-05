// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace phone
{
    internal abstract class AbstractPhone
    {
         
        public abstract void insertPhone(string name, string phone);
        public abstract void RemovePhone(string name);
        public abstract void UpdatePhone(string name, string oldphone, string newphone);
        public abstract PhoneNumber SearchPhone(string name);
        public abstract void Sort();
    }
}
