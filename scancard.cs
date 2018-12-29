using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scancard : MonoBehaviour {

    public vault_alarm_master vam;

    public GameObject ericscard; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(vam.wemessedup == 4 && other.gameObject == ericscard)
        {
            vam.disableAlarm();
        }
    }
}
