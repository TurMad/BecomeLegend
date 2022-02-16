using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStates : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI statesMainText;
    [SerializeField] TextMeshProUGUI skillMainText;
    [SerializeField] TextMeshProUGUI strText;
    [SerializeField] TextMeshProUGUI intText;
    [SerializeField] TextMeshProUGUI aglText;
    [SerializeField] TextMeshProUGUI stealText;
    [SerializeField] TextMeshProUGUI charText;

    [SerializeField] string[] mainText;
    [SerializeField] string[] skillText;
    [SerializeField] string[] str;
    [SerializeField] string[] intl;
    [SerializeField] string[] agl;
    [SerializeField] string[] steal;
    [SerializeField] string[] charisma;

    private void Update()
    {
        statesMainText.text = mainText[Language.GetLanguage()];
        skillMainText.text = skillText[Language.GetLanguage()];
        strText.text = str[Language.GetLanguage()];
        intText.text = intl[Language.GetLanguage()];
        aglText.text = agl[Language.GetLanguage()];
        stealText.text = steal[Language.GetLanguage()];
        charText.text = charisma[Language.GetLanguage()];
    }

}
