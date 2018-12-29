using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabcard : MonoBehaviour {

    public AudioSource vault;
    public AudioClip ericscard;

    public vault_alarm_master vam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(vam.wemessedup == 3)
        {
            vault.PlayOneShot(ericscard);
            vam.wemessedup = 4;
        }
    }
}
