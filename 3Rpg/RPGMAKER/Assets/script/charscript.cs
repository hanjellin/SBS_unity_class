using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class charscript : MonoBehaviour
{
    //���������� ���� ���: �÷��̾�, ���� , NPC 3������ ����
    #region ĳ���� ������Ʈ
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    #endregion
    //#region ��ó����� �ڵ带 ����
    #region ĳ���� ����
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
