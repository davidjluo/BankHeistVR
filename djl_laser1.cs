using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class djl_laser1 : MonoBehaviour {

    public AudioSource djl_laser_1;
    public AudioClip vault1;
    public Vault_laser_script vls;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("test");
        if(vls.laserstate == 0)
        {
            vls.laserstate++;
            djl_laser_1.PlayOneShot(vault1);
        }
    }
}
