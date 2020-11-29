using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
}


public class first_talking : MonoBehaviour
{

    public GameObject Mom;

    [SerializeField] private Image sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue;

    private bool isDialogue = false;

    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    //다이얼로그 보여줌
    public void ShowDialogue() 
    {
       
            sprite_DialogueBox.gameObject.SetActive(true);
            txt_Dialogue.gameObject.SetActive(true);        
            isDialogue = true;
            count = 0;
            NextDialogue();
        
    }

    //다이얼로그 숨김
    private void HideDialogue()
    {
        sprite_DialogueBox.gameObject.SetActive(false);
        txt_Dialogue.gameObject.SetActive(false);        
        isDialogue = false;
    }

    //다음 대화 보여줌(다이얼로그)
    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        count++;
    }
    
    //엄마랑 닿았는지 충돌체크 해서 닿으면 ShowDialouge로 가서 보이게 해줌.
    private void Check(Collision other)
    {
        if(other.gameObject.tag=="Mom")
        {
            ShowDialogue();
        }
    }

    

    //오른쪽 shift를 누르면 다음 대화를 보이게 하고 더 이상 대화가 없으면 다이얼로그 숨김처리.
    void Update()
    {
        
        if(isDialogue)
        {
            if(Input.GetKeyDown(KeyCode.RightShift))
            {
                if(count<dialogue.Length)
                    NextDialogue();
                else
                    HideDialogue();
            }
        }
        
    }
}

