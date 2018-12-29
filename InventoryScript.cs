using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour {

    public GameObject screwdriver;

    private void OnEnable()
    {
        if (screwdriver.transform.IsChildOf(transform))
        {
            screwdriver.GetComponent<Rigidbody>().isKinematic = true;
            Debug.Log("Is Kinematic: " + screwdriver.GetComponent<Rigidbody>().isKinematic);
        } else
        {
            screwdriver.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    // Update is called once per frame
    void Update () {
        //Debug.Log(screwdriver.transform.IsChildOf(transform));
        //Debug.Log("Is Kinematic: " + screwdriver.GetComponent<Rigidbody>().isKinematic);
	}
}
