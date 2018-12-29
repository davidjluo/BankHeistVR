using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vault_alarm_master : MonoBehaviour {

    public AudioClip alarmSound; // should be looped
    public GameObject redlite;
    public GameObject vlight1;
    public GameObject vlight2;
    public GameObject vlight3;
    public GameObject vlight4;
    public GameObject vlight5;

    public GameObject goal;
    public AudioSource vault;
    public AudioClip oops;
    public AudioClip djldisabled;

    public int wemessedup;
    // Use this for initialization
    void Start () {
        wemessedup = 0;
        redlite.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void grabGoal()
    {
        goal.SetActive(false);
        vault.PlayOneShot(oops); //thats an alarm isnt it

        vlight1.SetActive(false);
        vlight2.SetActive(false);
        vlight3.SetActive(false);
        vlight4.SetActive(false);
        vlight5.SetActive(false);

        redlite.SetActive(true);
        //vault.PlayOneShot(alarmSound);
        wemessedup = 2;
    }

    public void disableAlarm()
    {
        //vault.PlayOneShot(alarmSound);
        vlight1.SetActive(true);
        vlight2.SetActive(true);
        vlight3.SetActive(true);
        vlight4.SetActive(true);
        vlight5.SetActive(true);

        redlite.SetActive(false);
        vault.PlayOneShot(djldisabled);

        wemessedup = 5;
    }
}
