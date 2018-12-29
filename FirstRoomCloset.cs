using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class FirstRoomCloset : VRTK_InteractableObject {
    public override void StartUsing(VRTK_InteractUse currentUsingObject)
    {
        Debug.Log("Use");
    }
}
