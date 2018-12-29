using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockbox_audio_trig : MonoBehaviour {

    public vault_alarm_master vam;
    public AudioSource vault;
    public AudioClip theresabomb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(vam.wemessedup == 5)
        {
            vam.wemessedup = 6;
            vault.PlayOneShot(theresabomb);
        }
    }
}
