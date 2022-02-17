using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
  class Receptor
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Singleton.Instance.mensaje);
      Singleton.Instance.mensaje = "Hola profesor";
      Console.WriteLine(Singleton.Instance.mensaje);
    }
  }
}
