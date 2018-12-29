using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushitman : MonoBehaviour {

    public AudioSource vault;
    public AudioClip pushhh;
    public vault_alarm_master vam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (vam.wemessedup == 2)
        {
            vault.PlayOneShot(pushhh);
            vam.wemessedup = 3;
        }
    }
}
