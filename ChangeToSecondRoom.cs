using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToSecondRoom : MonoBehaviour {
    public string sceneToChangeTo;
    public void ChangeScene(string scene)
    {
        Application.LoadLevel(scene);
    }
    private void OnTriggerEnter(Collider other)
    {
        ChangeScene("SecurityCamera");
    }
}
