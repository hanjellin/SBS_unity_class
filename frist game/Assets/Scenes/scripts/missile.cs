using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 미사일을 관리하는 스크립트
/// 1.미사일이 특정 지점에 도착하면 삭제
/// 2.플레이어 충돌 감지
/// </summary>
public class missile : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        CheckDeadLine();
    }

    private void OnCollisionEnter2D(Collision2D collision)//충돌했을때
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("트리거");
            Onhit();
        }
    }

   

    void CheckDeadLine()
    {
      
        if (this.transform.position.y < -5)
        {
            scriptmannage.score += 100;
            UImanager.Instance.scoreLabel.text = scriptmannage.score.ToString();

            Destroy(this.gameObject);
        }
    }

    void Onhit()
    {
        UImanager.Instance.ShowGameoverUI();

        Destroy(this.gameObject);
    }
}
