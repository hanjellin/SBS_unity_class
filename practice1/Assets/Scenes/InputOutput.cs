using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputOutput : MonoBehaviour
{
    int i = 0;
    
    // 스크립트가 시작될떄 한번 호출됩니다
    void Start()
    {
        //Console.WriteLine --> 콘솔프로그램의 ouput 기능
        Debug.Log("일반 로그"); //unity프로젝트에서 output기능을 담당하는 클래스 == Debug
        Debug.LogWarning("경고 로그");
        Debug.LogError("에러로그");
    }

    // 매 프레임마다 실행됨
    void Update()
    {
        //Debug.Log(this.transform.position);
        if (Input.GetKeyDown(KeyCode.W))//Input은 유저의 모든 입력을 받는다
        {
            Debug.Log("W키 누름");

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("W키 땜");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A키 누름");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("A키 땜");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S키 누름");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            Debug.Log("S키 땜");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D키 누름");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("D키 땜");
        }

        if (Input.GetKey(KeyCode.LeftShift) == true && Input.GetKeyDown(KeyCode.W) == true)
        {
            Debug.Log("대시");
        }
        if (Input.GetKey(KeyCode.LeftShift) == true && Input.GetKeyDown(KeyCode.A) == true)
        {
            Debug.Log("대시");
        }
        if (Input.GetKey(KeyCode.LeftShift) == true && Input.GetKeyDown(KeyCode.S) == true)
        {
            Debug.Log("대시");
        }
        if (Input.GetKey(KeyCode.LeftShift) == true && Input.GetKeyDown(KeyCode.D) == true)
        {
            Debug.Log("대시");
        }

    }

    public void OnclickButton()
    {
        Debug.Log($"버튼이 {++i}회 눌렸습니다.");
    }

    public void SliderValue(Slider sender)
    {
        Debug.Log($"ChangeValue - {sender.value}");
    }

    public void ScrollberValue(Scrollbar sender)
    {
        Debug.Log($"[Scrollbar]ChangeValue - {sender.value}");
    }
    public void DropDownValue(Dropdown sender)
    {
        Debug.Log($"[Dropdown]ChangeValue - {sender.value}");
    }

    public void InputFieldValue(InputField sender)
    {
        Debug.Log($"[InputField]ChangeValue - {sender.text}");
    }
    public void EditInputFieldValue(InputField sender)
    {
        Debug.Log($"[InputField]ChangeValue - {sender.text}");
    }
}

