using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public static UImanager Instance
    {
        get
        {
            if (_Instance == null)
                _Instance = FindObjectOfType<UImanager>();
            return _Instance;
        }
    }
    private static UImanager _Instance;

    public Text scoreLabel;
    public scriptmannage gameoverUI;

    public void ShowGameoverUI()
    {
        gameoverUI.gameObject.SetActive(true);
        scriptmannage.
    }
    public void OnClickRestartGame()
    {
        titlescript.LoadScene(0);
    }

}
