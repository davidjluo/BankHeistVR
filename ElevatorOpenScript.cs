using VRTK;
using UnityEngine;

public class ElevatorOpenScript : VRTK_InteractableObject
{
    bool isOpened = false;
    public GameObject leftDoor;
    public GameObject rightDoor;

    public override void StartUsing(VRTK_InteractUse currentUsingObject)
    {
        if (!isOpened)
        {
            isOpened = true;
            leftDoor.transform.Translate(Vector3.right, Space.Self);
            rightDoor.transform.Translate(Vector3.left, Space.Self);
        }
    }
}
