using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 일정시간마다 특정 ㅋ프리펩을 복사해서 생성
/// 1.얼마만큼의 시간인지?
/// 2.특정 프리펩 가져오기
/// 3. 생성영역 설정
/// </summary>
public class spawnmannage : MonoBehaviour
{
    public GameObject targetPrefab;
    private float _curTime;

    private void Update()
    {
        if (scriptmannage.isGameStart == true)
        {


            if (_curTime <= 0)
            {
                //카피한 게임오브젝트가 obj변수에 들어감
                GameObject obj = Instantiate(targetPrefab);
                obj.transform.position = new Vector3(Random.Range(-9f, 9f), 10, 0);
                Rigidbody2D targetRigid = obj.GetComponent<Rigidbody2D>();
                targetRigid.gravityScale = Random.Range(1f, 3f);
                _curTime = Random.Range(0.1f, 1f);//0.1부터 2초까지 랜덤


            }
            else
            {
                _curTime -= Time.deltaTime;
            }
        }
    }
}
