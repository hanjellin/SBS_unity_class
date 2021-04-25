using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToecell : MonoBehaviour
{
    public Text targetText;
    public eState currentState;
    public int x;
    public int y;
    public enum eState
    {
        None,
        o,
        x,
    }
    private void Start()
    {
        SetState(eState.None);
    }

    public void SetState(eState targetState)
    {
        switch (targetState)
        {
            case eState.None:
                targetText.text = "";
                break;
            case eState.x:
                targetText.text = "x";
                break;
            case eState.o:
                targetText.text = "o";
                break;
        }
        currentState = targetState;
    }

}
