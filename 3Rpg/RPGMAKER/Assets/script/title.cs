using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// Ÿ��Ʋ ������ ���ξ����� �Ѿ�� ���
/// </summary>
public class title : MonoBehaviour
{
    public void OnClickGameStartButton()
    {
        StartCoroutine(SceneLoadRoutine());
    }

    IEnumerator SceneLoadRoutine()
    {
        Debug.Log("�� �ε� ����!");
        yield return SceneManager.LoadSceneAsync("Game");
        Debug.Log("�� �ε���!");
    }
}
