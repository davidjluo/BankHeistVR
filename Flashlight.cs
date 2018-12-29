namespace VRTK
{
    using UnityEngine;

    public class Flashlight : VRTK_InteractableObject
    {
        public Light light0;
        public Light light1;
        public Light light2;

        public override void StartUsing(VRTK_InteractUse currentUsingObject)
        {
            base.StartUsing(currentUsingObject);
            light0.intensity = 2.1f;
            light1.intensity = 2.1f;
            light2.intensity = 2.02f;
        }

        public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true)
        {
            base.StopUsing(previousUsingObject, resetUsingObjectState);
            light0.intensity = 0f;
            light1.intensity = 0f;
            light2.intensity = 0f;
        }
    }
}