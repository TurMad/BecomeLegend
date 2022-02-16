using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CutScene : MonoBehaviour
{
    TextMeshProUGUI text;
    Animator animator;
    [SerializeField] string[] firstText;
    [SerializeField] string[] secondText;
    [SerializeField] string[] thirdText;
    [SerializeField] TextMeshProUGUI buttonText;
    [SerializeField] string[] button;

    private void Start()
    {
        buttonText.text = button[Language.GetLanguage()];
        text = GetComponent<TextMeshProUGUI>();
        animator = GetComponent<Animator>();
        text.text = firstText[Language.GetLanguage()];
        StartCoroutine(CutSceneCoroutine());
    }

    public void OnPassButton()
    {
        FindObjectOfType<Fader>().TrasitionToGame();
    }

    private IEnumerator CutSceneCoroutine()
    {
        yield return new WaitForSeconds(1f);
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(5.2f);
        text.text = secondText[Language.GetLanguage()];
        yield return new WaitForSeconds(6.2f);
        text.text = thirdText[Language.GetLanguage()];
        yield return new WaitForSeconds(5f);
        FindObjectOfType<Fader>().TrasitionToGame();
    }
}
