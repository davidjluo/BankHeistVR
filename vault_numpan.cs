using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vault_numpan : MonoBehaviour {
    public int number;

    public AudioSource vault_audio;
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
        if(vls.laserstate >= 3 && vls.laserstate < 7)
        {
            vault_audio.PlayOneShot(beep);
            vls.numbuffer.Add(number);
            vls.laserstate++;
        }    
    }
}
