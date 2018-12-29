using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStart : MonoBehaviour {
    public AudioSource ESource;
    public AudioClip E;

    public GameObject Door1;
    public GameObject Door2;

    public WaitForSeconds Timer = new WaitForSeconds(2f);
    private WaitForSeconds VoiceTimer = new WaitForSeconds(16f);

	// Use this for initialization
	void Start () {
        StartCoroutine(Elevator());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private IEnumerator Elevator()
    {
        yield return Timer;
        print("cele");
        ESource.PlayOneShot(E);
        StartCoroutine(DoorOpen());
    }

    private IEnumerator DoorOpen()
    {
        yield return VoiceTimer;
        print("open");
        Door1.transform.localPosition = new Vector3(.7f, -.02f, 0);
        Door2.transform.localPosition = new Vector3(-.7f, .02f, 0);
    }

}
