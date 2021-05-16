using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// 타이틀 씬에서 메인씬으로 넘어가는 기능
/// </summary>
public class title : MonoBehaviour
{
    public void OnClickGameStartButton()
    {
        StartCoroutine(SceneLoadRoutine());
    }

    IEnumerator SceneLoadRoutine()
    {
        Debug.Log("씬 로딩 시작!");
        yield return SceneManager.LoadSceneAsync("Game");
        Debug.Log("씬 로딩끝!");
    }
}
