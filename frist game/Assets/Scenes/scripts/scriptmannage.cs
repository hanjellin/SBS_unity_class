using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scriptmannage : MonoBehaviour
{
    public static bool isGameStart = false;
    public static int score = 0;
    public Text scoreLabel;

   
    
    private void Start()
    {
        score = 0;
        isGameStart = false;
        if (isInit == false)
        {
            DontDestroyOnLoad(this.gameObject);

            isInit = true;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("game");
        isGameStart = true;
    }
   

}
