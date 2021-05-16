using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class charscript : MonoBehaviour
{
    //공통적으로 들어가는 요소: 플레이어, 몬스터 , NPC 3가지을 정의
    #region 캐릭터 컴포넌트
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    #endregion
    //#region 전처리기로 코드를 묶음
    #region 캐릭터 스탯
    public float Hp;
    public float moveSpeed;
    public float atk;
    #endregion


    public virtual void Update()
    {
        Move();
    }
    public abstract void Move();
}
