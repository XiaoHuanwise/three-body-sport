using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatData;

namespace three_body {

  static class Box { //内部变量  
    //internal const double G = 6.80945234825343 /*6.67408e-11*/; //引力常量  
    internal const double T = 0.0001; //单位时间
  }

  public static class Open_box { //外部可调用变量  
    public static string res;
    public static double T = Box.T;
  }

  public class In_box {
    internal Planet[] Pl = new Planet[3];
    internal double G;
    internal long Time_count = 0, Max_time_count = (long)(1e4/Box.T);
  }

  public class Planet_data { //恒星数据维护  
    public In_box Ib = new In_box { };
    private Creat_data Cd = new Creat_data { };

    public void Init_Certainly() { //数据初始化
      Cd.Creat();
      Ib.G = Cd.G;
      Ib.Pl = Cd.Pl;
      /*Ib.Pl[0].x = 134.38141200777;
      Ib.Pl[0].y = 302.586716833822;
      Ib.Pl[0].z = -309.899990956694;
      Ib.Pl[0].vx = 2.74247779607694;
      Ib.Pl[0].vy = 0.914159265358979;
      Ib.Pl[0].vz = -4.57079632679489;
      Ib.Pl[0].m = 449.766358556618;
      Ib.Pl[1].x = 306.243353895258;
      Ib.Pl[1].y = 170.03362335677;
      Ib.Pl[1].z = -347.380520836412;
      Ib.Pl[1].vx = 0;
      Ib.Pl[1].vy = -0.914159265358979;
      Ib.Pl[1].vz = 0.914159265358979;
      Ib.Pl[1].m = 712.130067714645;
      Ib.Pl[2].x = 76.7893782901542;
      Ib.Pl[2].y = 618.885822648029;
      Ib.Pl[2].z = -466.221225333079;
      Ib.Pl[2].vx = 0.914159265358979;
      Ib.Pl[2].vy = 2.74247779607694;
      Ib.Pl[2].vz = -0.914159265358979;
      Ib.Pl[2].m = 611.572548525157;*/
    }

    public void Init_Certainly_Text() {
      Ib.G = 1;
      Ib.Pl[0].x = 0;
      Ib.Pl[0].y = 0;
      Ib.Pl[0].z = -100;
      Ib.Pl[0].vx = Math.Sqrt(1 / Math.Sqrt(3) / 10);
      Ib.Pl[0].vy = 0;
      Ib.Pl[0].vz = 0;
      Ib.Pl[0].m = 10;
      Ib.Pl[1].x = 50 * Math.Sqrt(3);
      Ib.Pl[1].y = 0;
      Ib.Pl[1].z = 50;
      Ib.Pl[1].vx = -Math.Sqrt(1 / Math.Sqrt(3) / 10) / 2;
      Ib.Pl[1].vy = 0;
      Ib.Pl[1].vz = Math.Sqrt(1 / Math.Sqrt(3) / 10) / 2 * Math.Sqrt(3);
      Ib.Pl[1].m = 10;
      Ib.Pl[2].x = -50 * Math.Sqrt(3);
      Ib.Pl[2].y = 0;
      Ib.Pl[2].z = 50;
      Ib.Pl[2].vx = -Math.Sqrt(1 / Math.Sqrt(3) / 10) / 2;
      Ib.Pl[2].vy = 0;
      Ib.Pl[2].vz = -Math.Sqrt(1 / Math.Sqrt(3) / 10) / 2 * Math.Sqrt(3);
      Ib.Pl[2].m = 10;
    }

    public void Planet_run() { //数值微分函数
      /*if(Ib.Time_count >= Ib.Max_time_count) {//更新坐标系原点，防止数据溢出
        Ib.Pl[1].x -= Ib.Pl[0].x;
        Ib.Pl[1].y -= Ib.Pl[0].y;
        Ib.Pl[1].z -= Ib.Pl[0].z;
        Ib.Pl[2].x -= Ib.Pl[0].x;
        Ib.Pl[2].y -= Ib.Pl[0].y;
        Ib.Pl[2].z -= Ib.Pl[0].z;
        Ib.Pl[0].x -= Ib.Pl[0].x;
        Ib.Pl[0].y -= Ib.Pl[0].y;
        Ib.Pl[0].z -= Ib.Pl[0].z;
        Ib.Time_count = 0;
      }*/

      /*for (int i = 0; i < 3; ++i) { //每个单位时间内将恒星看作匀速直线运动  
        Ib.Pl[i].x += Ib.Pl[i].vx * Box.T;
        Ib.Pl[i].y += Ib.Pl[i].vy * Box.T;
        Ib.Pl[i].z += Ib.Pl[i].vz * Box.T;
      }*/

      //计算各恒星间距离  
      /*double r01p = Math.Pow(Ib.Pl[0].x - Ib.Pl[1].x, 2) + Math.Pow(Ib.Pl[0].y - Ib.Pl[1].y, 2) + Math.Pow(Ib.Pl[0].z - Ib.Pl[1].z, 2);
      double r02p = Math.Pow(Ib.Pl[0].x - Ib.Pl[2].x, 2) + Math.Pow(Ib.Pl[0].y - Ib.Pl[2].y, 2) + Math.Pow(Ib.Pl[0].z - Ib.Pl[2].z, 2);
      double r12p = Math.Pow(Ib.Pl[2].x - Ib.Pl[1].x, 2) + Math.Pow(Ib.Pl[2].y - Ib.Pl[1].y, 2) + Math.Pow(Ib.Pl[2].z - Ib.Pl[1].z, 2);
      double r01 = Math.Sqrt(r01p);
      double r02 = Math.Sqrt(r02p);
      double r12 = Math.Sqrt(r12p);
      Open_box.res = (r01 * r02 / r12).ToString();*/

      //计算各恒星受到的加速度在各矢量轴上的投影  
      double[,] a = new double[3, 3];
      for (int i = 0; i < 3; i++) {
        a[i, 0] = a[i, 1] = a[i, 2] = 0;
        for (int j = 0; j < 3; j++) {
          if (i == j) continue;
          double K = Ib.G * Ib.Pl[j].m / Math.Pow(Math.Sqrt(Math.Pow(Ib.Pl[i].x - Ib.Pl[j].x, 2) + Math.Pow(Ib.Pl[i].y - Ib.Pl[j].y, 2) + Math.Pow(Ib.Pl[i].z - Ib.Pl[j].z, 2)), 3);
          a[i, 0] += K * (Ib.Pl[j].x - Ib.Pl[i].x);
          a[i, 1] += K * (Ib.Pl[j].y - Ib.Pl[i].y);
          a[i, 2] += K * (Ib.Pl[j].z - Ib.Pl[i].z);
        }
        a[i, 0] /= 2;
        a[i, 1] /= 2;
        a[i, 2] /= 2;
      }

      for (int i = 0; i < 3; ++i) { //每个单位时间内将恒星看作匀速直线运动  
        Ib.Pl[i].vx += a[i, 0] * Box.T;
        Ib.Pl[i].vy += a[i, 1] * Box.T;
        Ib.Pl[i].vz += a[i, 2] * Box.T;
      }

      for (int i = 0; i < 3; ++i) { //每个单位时间内将恒星看作匀速直线运动  
        Ib.Pl[i].x += Ib.Pl[i].vx * Box.T;
        Ib.Pl[i].y += Ib.Pl[i].vy * Box.T;
        Ib.Pl[i].z += Ib.Pl[i].vz * Box.T;
      }

      for (int i = 0; i < 3; ++i) { //每个单位时间内将恒星看作匀速直线运动  
        Ib.Pl[i].vx += a[i, 0] * Box.T;
        Ib.Pl[i].vy += a[i, 1] * Box.T;
        Ib.Pl[i].vz += a[i, 2] * Box.T;
      }

      ++Ib.Time_count;//计数
    }
  }
}
