using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaultCheck : MonoBehaviour {
    public GameObject VaultCan;
    public GameObject CheckPoint;

    public AudioSource VSource;
    public AudioClip V;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        VaultCan.SetActive(true);
        CheckPoint.SetActive(false);
        VSource.PlayOneShot(V);
    }
}
