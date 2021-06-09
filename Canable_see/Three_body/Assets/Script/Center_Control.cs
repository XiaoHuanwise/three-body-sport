using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Center_Control : MonoBehaviour {

  public GameObject R;
  public GameObject G;
  public GameObject B;
  public GameObject Camera;

  float speed = 1.5f;
  static public float X = 0f;
  static public float Y = 0f;
  static public float ZZ = 0f;
  float Z = 1500f;
  float minZ = 100f;
  float maxZ = 5000f;
  float sensitivity = 600f;

  // Start is called before the first frame update
  void Start() {

  }

  // Update is called once per frame
  void Update() {
    transform.position = new Vector3(((R.transform.position.x + G.transform.position.x) / 2 + B.transform.position.x) / 2, ((R.transform.position.y + G.transform.position.y) / 2 + B.transform.position.y) / 2, ((R.transform.position.z + G.transform.position.z) / 2 + B.transform.position.z) / 2);
    if (Input.GetMouseButton(1)) {
      float x = Input.GetAxis("Mouse X") * speed;
      float y = Input.GetAxis("Mouse Y") * speed;
      X += x;
      Y -= y;
    }
    X += 0.3f;
    Y += 0.3f;
    ZZ += 0.2f;
    transform.rotation = Quaternion.Euler(Y, X, ZZ);
    Z += -Input.GetAxis("Mouse ScrollWheel") * sensitivity;
    Z = Mathf.Clamp(Z, minZ, maxZ);
    Camera.transform.localPosition = new Vector3(0, 0, -Z);
  }
}
