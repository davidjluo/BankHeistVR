namespace VRTK.Examples
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class FirstRoomLogic : MonoBehaviour
    {

        public GameObject closetScrew0;
        public GameObject closetScrew1;
        public GameObject closetDoor;

        public GameObject note;
        public GameObject blowtorch;

        public GameObject inventory;

        public LightSwitch lightSwitch;

        public AudioSource start;
        public AudioSource lightOn;
        public AudioSource getBlowtorch;
        public AudioSource getNote;
        public AudioSource findStuff;
        public AudioSource elevator;

        bool closetOpened = false;
        bool turnedOnLight = false;
        bool hasNote = false;
        bool hasBlowtorch = false;

        bool triggeredAudioStart = false;
        bool triggeredAudioTurnOnLight = false;
        bool triggeredAudioFindStuff = false;
        bool triggeredAudioGetNote = false;
        bool triggeredAudioGetBlowtorch = false;
        bool triggeredAudioGoToElevator = false;

        private void Start()
        {
            TriggerAudioStart();
        }

        // Update is called once per frame
        void Update()
        {
            if (!triggeredAudioTurnOnLight && closetScrew0.GetComponent<Rigidbody>().useGravity && closetScrew1.GetComponent<Rigidbody>().useGravity && !closetOpened)
            {
                Debug.Log("Closet Open!");
                TriggerClosetOpen();
                closetOpened = true;
                TriggerAudioTurnOnLight();
                triggeredAudioTurnOnLight = true;
            }

            if (!triggeredAudioFindStuff && lightSwitch.isLightsOn())
            {
                turnedOnLight = true;
                TriggerAudioFindStuff();
                triggeredAudioFindStuff = true;
            }

            if (turnedOnLight && !hasNote && note.transform.IsChildOf(inventory.transform))
            {
                hasNote = true;

                if (!hasBlowtorch && !triggeredAudioGetBlowtorch)
                {
                    TriggerAudioGetBlowtorch();
                    triggeredAudioGetBlowtorch = true;
                }
            }

            if (turnedOnLight && !hasBlowtorch && blowtorch.transform.IsChildOf(inventory.transform))
            {
                hasBlowtorch = true;

                if (!hasNote && !triggeredAudioGetNote)
                {
                    TriggerAudioGetNote();
                    triggeredAudioGetNote = true;
                }
            }

            if (!triggeredAudioGoToElevator && turnedOnLight && hasNote && hasBlowtorch)
            {
                TriggerAudioGoToElevator();
                triggeredAudioGoToElevator = true;
            }
        }

        private void TriggerAudioDontUseBlowtorch()
        {
            Debug.Log("TriggerAudioDontUseBlowtorch");
        }

        private void TriggerClosetOpen()
        {
            Debug.Log("TriggerClosetOpen()");

            closetDoor.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            closetDoor.GetComponent<Rigidbody>().useGravity = true;
            closetDoor.GetComponent<Rigidbody>().isKinematic = false;
            closetDoor.transform.Translate(Vector3.back * .1f, Space.Self);
        }

        private void TriggerAudioStart()
        {
            Debug.Log("Trigger Audio Start");
            start.Play();
        }

        private void TriggerAudioTurnOnLight()
        {
            Debug.Log("TriggerAudioTurnOnLight");
            lightOn.Play();
        }
        private void TriggerAudioFindStuff()
        {
            Debug.Log("TriggerAudioFindStuff");
            findStuff.Play();
        }

        private void TriggerAudioRememberFindStuff()
        {
            Debug.Log("TriggerAudioRememberFindStuff");
        }

        private void TriggerAudioGetBlowtorch()
        {
            Debug.Log("TriggerAudioGetBlowtorch");
            getBlowtorch.Play();
        }

        private void TriggerAudioGetNote()
        {
            Debug.Log("TriggerAudioGetNote");
            getNote.Play();
        }

        private void TriggerAudioGoToElevator()
        {
            Debug.Log("TriggerAudioGoToElevator");
            elevator.Play();
        }
    }
}