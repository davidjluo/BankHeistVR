using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Vault_laser_script : MonoBehaviour {

    public GameObject vault_laz;
    //voice cues
    public AudioSource vault_audio;
    public AudioClip djl_laser_4; //success case for turning off laser
    public AudioClip djl_laser_3; //fail case for turning off laser

    //variable to correctly time the voice cues for laser sequence
    public int laserstate;
    public List<int> numbuffer;

    public Renderer rend;

    // Use this for initialization
    void Start () {

        laserstate = 0;
        rend = vault_laz.GetComponent<Renderer>();
        rend.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SendSequence()
    {
        if (laserstate == 7)
        {
            if (numbuffer[0] == 4 && numbuffer[1] == 9 && numbuffer[2] == 8)
            {
                vault_laz.SetActive(false); //turn off that laser
                vault_audio.PlayOneShot(djl_laser_4);
                laserstate++;
            }
            else
            {
                vault_audio.PlayOneShot(djl_laser_3); //they didnt get it right but move along
                vault_laz.SetActive(false); //turn off that laser
                laserstate++;
            }
        }
        
    }

    public void vaultLaserColor()
    {
        rend.enabled = true;
    }
}
