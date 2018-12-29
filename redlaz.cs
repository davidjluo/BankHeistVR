using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redlaz : MonoBehaviour {

    public AudioSource vault;
    public AudioClip turnofflaser;
    public AudioClip beep;
    public Vault_laser_script vls;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(vls.laserstate == 2)
        {
            vls.laserstate++;
            //vault.PlayOneShot(beep);
            vault.PlayOneShot(turnofflaser);
            vls.vaultLaserColor();
        }
       
    }
}
