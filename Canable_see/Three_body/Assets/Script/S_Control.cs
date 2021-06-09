using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using three_body;
using System.Threading;
using N_body_sport;

public class S_Control : MonoBehaviour {

  /*	public static Planet_data PD = new Planet_data();*/
  float G;
  static public CelestialBody[] cbody = new CelestialBody[3];

  void Loop() {
    while (true) {
      //PD.Planet_run();
      //if (PD.Ib.Time_count >= PD.Ib.Max_time_count) Debug.Log("KA");
      GoAhead.Ode4(0.001, G, cbody);
      if ((cbody[0].pos() - cbody[1].pos()).Mod() + (cbody[0].pos() - cbody[2].pos()).Mod() + (cbody[1].pos() - cbody[2].pos()).Mod() >= 10000.0) {
        for (int i = 0; i < cbody.Length; i++) {
          cbody[i] = new CelestialBody();
        }
        G = (float)Initialization.RandomIni(cbody);
        Center_Control.X = 0f;
        Center_Control.Y = 0f;
        Center_Control.ZZ = 0f;
      }
    }
  }

	// Start is called before the first frame update
	void Start() {
    //PD.Init_Certainly();
    for (int i = 0; i < cbody.Length; i++) {
      cbody[i] = new CelestialBody();
    }
    G = (float)Initialization.RandomIni(cbody);
    ThreadStart Child_run = new ThreadStart(Loop);
    Thread Run_thread = new Thread(Child_run);
    Run_thread.Start();
	}

	// Update is called once per frame
	void Update() {
		//print(Open_box.res.Remove(0, 2));
	}
}
