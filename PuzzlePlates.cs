using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzlePlates : MonoBehaviour {
    public int CurrentPlate;

    private bool Fail;
    private int[] map = new int[] { 1, 6, 5, 10, 15, 16, 17, 18, 13, 14, 19, 24, 29 };
    private int Prev;
    private int PuzzleCounter;
	// Use this for initialization
	void Start () {
        CurrentPlate = -1;
        Prev = -1;
        PuzzleCounter = 0;
        Fail = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Prev != CurrentPlate)
        {
            PuzzleStep(CurrentPlate);
        }
        Prev = CurrentPlate;
	}

    private void PuzzleStep(int CurPlate)
    {
        if(CurPlate != map[PuzzleCounter])
        {
            if (Fail)
            {
                PuzzleCounter = 0;
                SceneManager.LoadScene(4);
            }
            Fail = true;
        }
        PuzzleCounter++;
        if(PuzzleCounter == 13)
        {
            PuzzleCounter = 0;
        }
    }


}
