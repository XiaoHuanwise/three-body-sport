using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolo {
  class Consolo {
    static void Main(string[] args) {
      CreatData.CreatData creatData = new CreatData.CreatData { };
      Console.WriteLine("Please input how many groups Data you want to get:");
      int n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine();
      for (int i = 1; i <= n; ++i) {
        creatData.Creat();
        Console.WriteLine("No.{0}:", i);
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("E = {0}", creatData.E);
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Ib.G = {0};", creatData.G);
        for(int j = 0; j < 3; j++) {
          Console.WriteLine("Ib.Pl[{0}].x = {1};", j, creatData.Pl[j].x);
          Console.WriteLine("Ib.Pl[{0}].y = {1};", j, creatData.Pl[j].y);
          Console.WriteLine("Ib.Pl[{0}].z = {1};", j, creatData.Pl[j].z);
          Console.WriteLine("Ib.Pl[{0}].vx = {1};", j, creatData.Pl[j].vx);
          Console.WriteLine("Ib.Pl[{0}].vy = {1};", j, creatData.Pl[j].vy);
          Console.WriteLine("Ib.Pl[{0}].vz = {1};", j, creatData.Pl[j].vz);
          Console.WriteLine("Ib.Pl[{0}].m = {1};", j, creatData.Pl[j].m);
        }
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine();
      }
      Console.ReadKey();
    }
  }
}
