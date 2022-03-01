using System;
using Projetos.Entities;

namespace Projetos
{

  class Program{


    static void Main(string[] args)
      {
      Hero arus = new Hero("Arudo", "knight", 1234, 555, 333);
      Wizard jef = new Wizard("Jef", "white-wizard", 1259, 440, 980);
    
      Console.WriteLine(jef);
      Console.WriteLine(jef.Attack());
      
      

      }

            }

}
