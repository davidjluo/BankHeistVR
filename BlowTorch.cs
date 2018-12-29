using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlowTorch : MonoBehaviour {
    public BoxCollider TopBar;
    public BoxCollider MiddleBar;
    public BoxCollider BottomBar;

    public GameObject TopPanel;
    public GameObject MiddlePanel;
    public GameObject BottomPanel;

    public GameObject Vault;
    public BoxCollider VaultCol;

    public GameObject FlameTip;
    public WaitForSeconds duration = new WaitForSeconds(0.2f);

    public LineRenderer Laser;
    private bool CastActive;
    private int Top;
    private int Middle;
    private int Bottom;
	// Use this for initialization
	void Start () {
        Top = 200;
        Middle = 200;
        Bottom = 200;
        CastActive = true;
	}

    // Update is called once per frame
    void Update()
    {
        if (CastActive)
        {
            RaycastHit target;
            Vector3 tip = FlameTip.transform.rotation * Vector3.forward;
            Ray pointer = new Ray(FlameTip.transform.position, tip);

            Laser.SetPosition(0, FlameTip.transform.position);
            Laser.SetPosition(1, (FlameTip.transform.position + tip * 20));

            Physics.Raycast(pointer, out target, 20);

            if (Laser.enabled) //if we are pressing A
            {
                if (target.collider == TopBar)
                {
                    Top--;
                }
                if (target.collider == MiddleBar)
                {
                    Middle--;
                }
                if (target.collider == BottomBar)
                {
                    Bottom--;
                }

            }
            if (Top == 0)
            {
                TopPanel.SetActive(false);
                TopBar.enabled = false;
            }
            if (Middle == 0)
            {
                MiddlePanel.SetActive(false);
                MiddleBar.enabled = false;
            }
            if (Bottom == 0)
            {
                BottomPanel.SetActive(false);
                BottomBar.enabled = false;
            }
            if (Top == 0 && Middle == 0 && Bottom == 0)
            {
                Vector3 angle = new Vector3(90, -180, 0);
                Vault.transform.eulerAngles = angle;
                VaultCol.enabled = true;
                CastActive = false;
                Top = 200;
                Middle = 200;
                Bottom = 200;
            }
        }
        
    }


    }
