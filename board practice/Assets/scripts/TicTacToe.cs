using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TicTacToe : MonoBehaviour
{
    private GameObject gameoverpanel;
    private Text Gtext;

    private bool isTurnO = true;
    private TicTacToecell[ , ] cells = new TicTacToecell[3,3];

    

    public void ONClickCell(TicTacToecell cell)
    {
        if(cell.currentState != TicTacToecell.eState.None)
        {
            return;
        }
        if (isTurnO == true)
        {
            cell.SetState(TicTacToecell.eState.o);
        }
        else
        {
            cell.SetState(TicTacToecell.eState.x);

        }
        cells[cell.x, cell.y] = cell;
        CheckResult();

        isTurnO = !isTurnO;

    }
    private void gameover()
    {
        Gtext.text = string.Format(Gtext.text, isTurnO == true ? "o" : "x");
        gameoverpanel.SetActive(true);
    }

    private void CheckResult()
    {
        //3개가 연달아서 같은(None제외) state인지 체크
        //그러기 위해서 필요한 데이터 ?셀들의 위치값, 몇번째 칸에 있는지
        foreach (TicTacToecell cell in cells)
        {
            if(cell == null)
            {
                continue;
            }
            int sameCount = 0;
            for (int x = -2; x <= 2; x++)//가로
            {
                
                    if (cell.x + x < 0 || cell.x + x > 2 || cells[cell.x + x, cell.y] == null)
                        continue;

                    if(cells[cell.x + x,cell.y].currentState == cell.currentState)
                {
                sameCount += 1;
                }
                
            }

            
            Debug.Log($"samecount가 {sameCount}입니다");
            Debug.Log($"cell가 {cell}입니다");
            if(sameCount >= 3)
            {
                Debug.Log("게임오버");
                gameover();
                return;
            }
            sameCount += 0;
            for (int y = -2; y <= 2; y++)//상하
            {
                if (cell.x < 0 || cell.x > 2 || cells[cell.x, cell.y] == null)
                    continue;
                if (cells[cell.x, cell.y].currentState == cell.currentState)
                {
                    sameCount += 1;
                }
            }
            if (sameCount >= 3)
            {
                Debug.Log("게임오버");
                gameover();
                return;
            }


        }
        
    }

    public void back()
    {
        SceneManager.LoadScene("Scenes/2choosegame");

    }
}
