namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEventHelper;
    using VRTK.Controllables;

    public class SecurityLever : MonoBehaviour
    {
        public Light light0;
        public Light light1;
        public Light light2;
        bool lightsOn = false;

        protected VRTK_Control_UnityEvents controlEvents;
#pragma warning restore 0618
        protected VRTK_BaseControllable controllableEvents;
    

        protected virtual void OnEnable()
        {
#pragma warning disable 0618
            if (GetComponent<VRTK_Control>() != null && GetComponent<VRTK_Control_UnityEvents>() == null)
            {
                controlEvents = gameObject.AddComponent<VRTK_Control_UnityEvents>();
            }
            controlEvents = GetComponent<VRTK_Control_UnityEvents>();
#pragma warning restore 0618
            controllableEvents = GetComponent<VRTK_BaseControllable>();

            ManageListeners(true);
        }

        protected virtual void OnDisable()
        {
            ManageListeners(false);
        }

        protected virtual void ManageListeners(bool state)
        {
            if (state)
            {
                if (controlEvents != null)
                {
                    controlEvents.OnValueChanged.AddListener(HandleChange);
                }
                if (controllableEvents != null)
                {
                    controllableEvents.ValueChanged += ValueChanged;
                }
            }
            else
            {
                if (controlEvents != null)
                {
                    controlEvents.OnValueChanged.RemoveListener(HandleChange);
                }
                if (controllableEvents != null)
                {
                    controllableEvents.ValueChanged -= ValueChanged;
                }
            }
        }

        protected virtual void ValueChanged(object sender, ControllableEventArgs e)
        {
            if (e.normalizedValue >= 0.99f && !lightsOn)
            {
                lightsOn = true;
                light0.intensity = 0.0f;
                light1.intensity = 0.0f;
                light2.intensity = 0.0f;
              
            }

            else if (e.normalizedValue <= 0.1 && lightsOn)
            {
                lightsOn = false;
                light0.intensity = 1f;
                light1.intensity = 1f;
                light2.intensity = 1f;
            }
        }

        protected virtual void HandleChange(object sender, Control3DEventArgs e)
        {
            Debug.Log("Handle Change");
        }
    }
}