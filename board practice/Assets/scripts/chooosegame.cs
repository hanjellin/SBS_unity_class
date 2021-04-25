using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //SceneManager

public class chooosegame : MonoBehaviour
{
    public void OnClickOthello()
    {
        SceneManager.LoadScene("Scenes/3Othello");
    }

    public void OnClickTicTacToe()
    {
        SceneManager.LoadScene("Scenes/4tictactoe");
    }
    public void OnClickBadok()
    {
        SceneManager.LoadScene("Scenes/5badok");
    }
}
