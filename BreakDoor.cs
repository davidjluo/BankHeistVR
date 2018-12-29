using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakDoor : MonoBehaviour
{
    public Collider Sledge;
    public GameObject Door;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other == Sledge)
        {
            Vector3 angle = new Vector3(0, 280, 0);
            Door.transform.eulerAngles = angle;
        }
    }
}
