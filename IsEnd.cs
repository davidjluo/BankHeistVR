using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsEnd : MonoBehaviour {

	public Light end;
	public GameObject leftDoor;
	public GameObject rightDoor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision collision) {
		 if(!collision.collider.gameObject.CompareTag("Bullet") && end.intensity == 0f) {
			 // THIS IS THE END
			 rightDoor.transform.Translate(Vector3.left, Space.Self);
			 leftDoor.transform.Translate(Vector3.right, Space.Self);
            Application.LoadLevel("SecondRoom");
        }
     }
}
