using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vault_send : MonoBehaviour {

    public Vault_laser_script vls;

    public AudioSource vault;
    public AudioClip beep;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("pushed");
        vault.PlayOneShot(beep);
        vls.SendSequence();
    }
}
