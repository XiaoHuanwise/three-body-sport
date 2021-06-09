using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using three_body;
using N_body_sport;

public class C_G : MonoBehaviour {
  // Start is called before the first frame update
  public GameObject Particle;
  void Start() {

  }

  // Update is called once per frame
  void Update() {
    //transform.position = new Vector3((float)S_Control.PD.Ib.Pl[2].x, (float)S_Control.PD.Ib.Pl[2].y, (float)S_Control.PD.Ib.Pl[2].z);
    if (S_Control.cbody[1].mass() == -1) return;
    transform.position = new Vector3((float)S_Control.cbody[1].pos().Read()[0], (float)S_Control.cbody[1].pos().Read()[1], (float)S_Control.cbody[1].pos().Read()[2]);
    Instantiate(Particle, transform.position, Quaternion.identity);
  }
}
