using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeathCanvas : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI titleText;
    [SerializeField] TextMeshProUGUI firstText;
    [SerializeField] TextMeshProUGUI secondText;
    [SerializeField] TextMeshProUGUI thirdText;
    [SerializeField] TextMeshProUGUI dieYearOldText;
    [SerializeField] TextMeshProUGUI nickNameText;
    [SerializeField] TextMeshProUGUI buttonText;

    [SerializeField] string[] title;
    [SerializeField] string[] first;
    [SerializeField] string[] second;
    [SerializeField] string[] third;
    [SerializeField] string[] button;
    [SerializeField] string[] nicknameGood49;
    [SerializeField] string[] nicknameGood99;
    [SerializeField] string[] nicknameGood149;
    [SerializeField] string[] nicknameGood199;
    [SerializeField] string[] nicknameBad49;
    [SerializeField] string[] nicknameBad99;
    [SerializeField] string[] nicknameBad149;
    [SerializeField] string[] nicknameBad199;

    private void Update()
    {
        firstText.text = first[Language.GetLanguage()];
        secondText.text = second[Language.GetLanguage()];
        thirdText.text = third[Language.GetLanguage()];
        titleText.text = title[Language.GetLanguage()];
        buttonText.text = button[Language.GetLanguage()];

        int dieAge = FindObjectOfType<SeasonAndYearsChange>().GetYear() - 932;
        dieYearOldText.text = dieAge.ToString();
        CheckNickName();
    }

    private void CheckNickName()
    {
        int rep = FindObjectOfType<Player>().GetRep();
        int glory = FindObjectOfType<Player>().GetGlory();
        if(glory <= 49 && rep >= 0)
        {
            nickNameText.text = nicknameGood49[Language.GetLanguage()];
        }
        if (glory >= 49 && glory <= 99 && rep >= 0)
        {
            nickNameText.text = nicknameGood99[Language.GetLanguage()];
        }
        if (glory >= 99 && glory <= 149 && rep >= 0)
        {
            nickNameText.text = nicknameGood149[Language.GetLanguage()];
        }
        if (glory >= 149 && rep >= 0)
        {
            nickNameText.text = nicknameGood199[Language.GetLanguage()];
        }
        if (glory <= 49 && rep < 0)
        {
            nickNameText.text = nicknameBad49[Language.GetLanguage()];
        }
        if (glory >= 49 && glory <= 99 && rep < 0)
        {
            nickNameText.text = nicknameBad99[Language.GetLanguage()];
        }
        if (glory >= 99 && glory <= 149 && rep < 0)
        {
            nickNameText.text = nicknameBad149[Language.GetLanguage()];
        }
        if (glory >= 149 && rep < 0)
        {
            nickNameText.text = nicknameBad199[Language.GetLanguage()];
        }

    }
}
