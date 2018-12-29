using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTriggerScript : MonoBehaviour {
	public BombSnapZone snapZoneScript;

	void OnTriggerStay(Collider other) {
		snapZoneScript.explodeIfInPlace();
	}
}
