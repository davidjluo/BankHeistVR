using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomBegun : MonoBehaviour {

	public AudioSource asc;
	public AudioClip initial;
	// Use this for initialization
	void Start () {
		asc.PlayOneShot(initial);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
