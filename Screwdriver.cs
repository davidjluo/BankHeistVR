using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Screwdriver : VRTK_InteractableObject
{
    private Collider screw;

    bool isUsing = false;
    private void OnTriggerStay(Collider other)
    {
        if (other.name.Contains("closet_screw") && isUsing)
        {
            Debug.Log("Used on screw");
            other.gameObject.transform.Translate(Vector3.right * .01f, Space.Self);
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            other.gameObject.GetComponent<Collider>().isTrigger = false;
        }
    }

    public override void StartUsing(VRTK_InteractUse currentUsingObject)
    {
        base.StartUsing(currentUsingObject);
        isUsing = true;

    }

    public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true)
    {
        base.StopUsing(previousUsingObject, resetUsingObjectState);
        isUsing = false;

    }
}
