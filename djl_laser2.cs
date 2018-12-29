using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class djl_laser2 : MonoBehaviour {

    public AudioSource vault_audio;
    public AudioClip vault2;
    public Vault_laser_script vls;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (vls.laserstate == 1)
        {
            vls.laserstate++;
            vault_audio.PlayOneShot(vault2);
        }
    }
}
