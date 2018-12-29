namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEventHelper;
    using VRTK.Controllables;

    public class LeverScript : MonoBehaviour
    {
        public GameObject Gate;
        public bool gate_status = false;
#pragma warning disable 0618
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
            
            if (e.value == 1f && gate_status)
            {
                Vector3 FinalPos = Gate.transform.localPosition;
                FinalPos.y = 3;
                Gate.transform.localPosition = FinalPos;
            }
        }

        protected virtual void HandleChange(object sender, Control3DEventArgs e)
        {
            
        }

        
    }
}