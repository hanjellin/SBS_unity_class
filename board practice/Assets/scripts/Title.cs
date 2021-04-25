using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //SceneManager

public class Title : MonoBehaviour
{
    public Text tweentarget;
    private void Start()
    {
        StartCoroutine(TweenAnimation());
    }
    private void Update()
    {
        if (Input.anyKeyDown == true)//아무키나 눌렸을때
        {
            //게임 선택 씬으로 이동 LoadSceneAsync =게임 안 멈투고 넘김
            SceneManager.LoadScene("Scenes/2choosegame");
        }
    }

    //코루틴 C#엔 없음
    //왠만하면 Update문(반복문) 안에서 실행시키면 안된다 코루틴문이 계속 쌓임
    private IEnumerator TweenAnimation()
    {
        tweentarget.color = new Color(tweentarget.color.r, tweentarget.color.g, tweentarget.color.b, 0.5f);//투명도 50%적용
        float alpha = tweentarget.color.a;
        while (true)
        {
            tweentarget.color = new Color(tweentarget.color.r, tweentarget.color.g, tweentarget.color.b, alpha);
            yield return null;
            if(alpha >= 1)
            {
                alpha = 0.5f;
            }
            alpha += 0.5f * Time.deltaTime; ;
        }

    }
   /*
    private IEnumerator TweenAnmiation() //UI애니메이션
    {
        Debug.Log("시작했습니다");
        yield return null; // 1프레임 대기
        Debug.Log("한프레임 대기");
        yield return new WaitForSeconds(3f);//n초 대기- 게임속도와 상관 O
        Debug.Log("3초대기");

        yield return new WaitForSeconds(0.5f); // n초 대기 - 게임속도와 상관  x
        Debug.Log("끝났습니다");
    }
   */
}
