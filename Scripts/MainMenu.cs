using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI startText;
    [SerializeField] TextMeshProUGUI howToPlayText;
    [SerializeField] TextMeshProUGUI langText;
    [SerializeField] TextMeshProUGUI exitText;

    [SerializeField] string[] start;
    [SerializeField] string[] howToPlay;
    [SerializeField] string[] language;
    [SerializeField] string[] exit;


    private void Update()
    {
        startText.text = start[Language.GetLanguage()];
        howToPlayText.text = howToPlay[Language.GetLanguage()];
        langText.text = language[Language.GetLanguage()];
        exitText.text = exit[Language.GetLanguage()];
    }
}
