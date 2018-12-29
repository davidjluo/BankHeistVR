using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakout : MonoBehaviour {

    public Collider hammer; //sledgehammer
    public Collider glass;

    public AudioSource vault;
    public AudioClip seenoalarm;

	// Use this for initialization
	void Start () {
        glass = GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other == hammer)
        {
            glass.attachedRigidbody.useGravity = true;
            vault.PlayOneShot(seenoalarm);
        }
    }
}
