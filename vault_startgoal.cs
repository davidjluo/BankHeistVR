using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vault_startgoal : MonoBehaviour {

    public AudioSource vault;
    public AudioClip vault_goal_voice1;
    public vault_alarm_master vam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(vam.wemessedup == 0)
        {
            vault.PlayOneShot(vault_goal_voice1);
            vam.wemessedup = 1;
        }
        
    }
}
