using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;

public class MetalGate : MonoBehaviour {
    public GameObject Gate;
    public GameObject Trigger;

    public AudioSource ASource;
    public AudioClip GateClip;

    public LeverScript Lever;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Vector3 FinalPos = Gate.transform.localPosition;
        FinalPos.y = 0;
        Gate.transform.localPosition = FinalPos;
        Lever.gate_status = true;
        ASource.PlayOneShot(GateClip);
        Trigger.SetActive(false);
    }
}
