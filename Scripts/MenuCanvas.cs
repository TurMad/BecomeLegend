using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCanvas : MonoBehaviour
{
    [SerializeField] GameObject retireCanvas;
    [SerializeField] GameObject howToPlayCanvas;
    [SerializeField] TextMeshProUGUI howToPlayText;
    [SerializeField] TextMeshProUGUI restartText;
    [SerializeField] TextMeshProUGUI retairText;
    [SerializeField] TextMeshProUGUI langText;
    [SerializeField] TextMeshProUGUI backText;

    [SerializeField] string[] howToPlay;
    [SerializeField] string[] restartPlay;
    [SerializeField] string[] retairPlay;
    [SerializeField] string[] langPlay;
    [SerializeField] string[] backPlay;

    private void Start()
    {
        howToPlayCanvas.SetActive(false);
        retireCanvas.SetActive(false);
    }
    private void Update()
    {
        howToPlayText.text = howToPlay[Language.GetLanguage()];
        restartText.text = restartPlay[Language.GetLanguage()];
        retairText.text = retairPlay[Language.GetLanguage()];
        langText.text = langPlay[Language.GetLanguage()];
        backText.text = backPlay[Language.GetLanguage()];
    }

    public void OnHowToPlayBtn()
    {
        howToPlayCanvas.SetActive(true);
    }

    public void OnRestartBtn()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }

    public void OnBackBtn()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void TurnOffHowToPlay()
    {
        howToPlayCanvas.SetActive(false);
    }

    public void ShowRetireCanvas()
    {
        retireCanvas.SetActive(true);
    }
    public void GoMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
        
    }
}
