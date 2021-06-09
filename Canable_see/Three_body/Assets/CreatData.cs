using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

public struct Planet { //恒星数据结构体
  public double x, y, z;
  public double vx, vy, vz;
  public double m;
};

namespace CreatData {
  public class Creat_data {
    public Planet[] Pl = new Planet[3];
    public double G, E;
    public void Creat() {
      Random random = new Random();
      E = 0;
      while (E >= 0) {
        E = 0;
        G = random.Next(300, 1000) * 0.914159265358979;
        //--------------------------------------------------------------------
        Pl[0].x = random.Next(-1000, 1000) * 0.914159265358979;
        Pl[0].y = random.Next(-1000, 1000) * 0.914159265358979;
        Pl[0].z = random.Next(-1000, 1000) * 0.914159265358979;
        Pl[0].vx = random.Next(-10, 10) * 0.914159265358979;
        Pl[0].vy = random.Next(-10, 10) * 0.914159265358979;
        Pl[0].vz = random.Next(-10, 10) * 0.914159265358979;
        Pl[0].m = random.Next(1000, 10000) * 0.914159265358979;
        //--------------------------------------------------------------------
        Pl[1].x = random.Next(-1000, 1000) * 0.914159265358979;
        Pl[1].y = random.Next(-1000, 1000) * 0.914159265358979;
        Pl[1].z = random.Next(-1000, 1000) * 0.914159265358979;
        Pl[1].vx = random.Next(-10, 10) * 0.914159265358979;
        Pl[1].vy = random.Next(-10, 10) * 0.914159265358979;
        Pl[1].vz = random.Next(-10, 10) * 0.914159265358979;
        Pl[1].m = random.Next(1000, 10000) * 0.914159265358979;
        //--------------------------------------------------------------------
        Pl[2].x = random.Next(-1000, 1000) * 0.914159265358979;
        Pl[2].y = random.Next(-1000, 1000) * 0.914159265358979;
        Pl[2].z = random.Next(-1000, 1000) * 0.914159265358979;
        Pl[2].vx = random.Next(-10, 10) * 0.914159265358979;
        Pl[2].vy = random.Next(-10, 10) * 0.914159265358979;
        Pl[2].vz = random.Next(-10, 10) * 0.914159265358979;
        Pl[2].m = random.Next(1000, 10000) * 0.914159265358979;
        //--------------------------------------------------------------------
        for (int i = 0; i < 3; i++) {
          double e = 0.5 * Pl[i].m * (Math.Pow(Pl[i].vx, 2) + Math.Pow(Pl[i].vy, 2) + Math.Pow(Pl[i].vz, 2));
          for (int j = 0; j < 3; j++) {
            if (i == j) continue;
            e += -G * Pl[i].m * Pl[j].m / Math.Sqrt(Math.Pow(Pl[i].x - Pl[j].x, 2) + Math.Pow(Pl[i].y - Pl[j].y, 2) + Math.Pow(Pl[i].z - Pl[j].z, 2));
          }
          E += e;
          if (e >= 0) {
            E = 0;
            break;
          }
        }
      }
    }
  }
}
