using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] DialogueState[] dialogueStates;
    Text text;
    int currentDlg = 0;
    float time = 3f;
    float transp;

    [SerializeField] Image diaPlace;
    private void Start()
    {
        text = GetComponent<Text>();
        text.text = dialogueStates[currentDlg].GetDialogue(Language.GetLanguage());
        transp = diaPlace.color.a;
    }
    public IEnumerator FadeOut()
    {
        while (transp > 0)
        {    
            transp -= Time.deltaTime / time;
            diaPlace.color = new Color(diaPlace.color.r, diaPlace.color.g, diaPlace.color.b, transp);
            yield return null;
        }
        yield return new WaitForSeconds(0.5f);
        diaPlace.gameObject.SetActive(false);
    }

    public void PressSkipBtn()
    {
        if (currentDlg >= dialogueStates.Length - 1)
        {
            StartCoroutine(FadeOut());
        }
        else
        {
            text.text = dialogueStates[currentDlg + 1].GetDialogue(Language.GetLanguage());
            currentDlg++;
        }
        
    }
}
