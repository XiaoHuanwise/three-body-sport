using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using three_body;

public class DestoryParticle : MonoBehaviour {
  // Start is called before the first frame update
  void Start() {
    Destroy(gameObject, 0.001f / (float)Open_box.T);
  }

  // Update is called once per frame
  void Update() {

  }
}
