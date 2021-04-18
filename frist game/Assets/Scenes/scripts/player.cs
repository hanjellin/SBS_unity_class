using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 플레이어 기능을 당당하는 클레스
///  움직임 구현
/// </summary>
/// 1개의 메소드가 1개의 기능을 담당
public class player : MonoBehaviour
{

    
    public float movespeed;
    Vector2 resultMoveDleta;
    void Update()
    {
        CheckMove();

    }
    void CheckMove()
    {
        resultMoveDleta = Vector2.zero;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            resultMoveDleta += Vector2.left;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            resultMoveDleta += Vector2.right;
        }

        //유니티는 프레임-프레임 간 걸린 시간을 제공합니다-> Time.deltaTime
        //Time.deltaTime를 곱한다 -> '초당'을 의미
        transform.position += (Vector3)resultMoveDleta/*벡터2에서 벡터3로 바꿈*/* Time.deltaTime * movespeed;
    }
 
}



