using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HowToPlayCanvas : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI titleText;
    [SerializeField] TextMeshProUGUI firstText;
    [SerializeField] TextMeshProUGUI secondText;
    [SerializeField] TextMeshProUGUI thirdText;
    [SerializeField] TextMeshProUGUI fourthText;
    [SerializeField] TextMeshProUGUI getBackText;

    [SerializeField] string[] title;
    [SerializeField] string[] first;
    [SerializeField] string[] second;
    [SerializeField] string[] third;
    [SerializeField] string[] fourth;
    [SerializeField] string[] getBack;

    private void Update()
    {
        titleText.text = title[Language.GetLanguage()];
        firstText.text = first[Language.GetLanguage()];
        secondText.text = second[Language.GetLanguage()];
        thirdText.text = third[Language.GetLanguage()];
        fourthText.text = fourth[Language.GetLanguage()];
        getBackText.text = getBack[Language.GetLanguage()];
    }

    
}
