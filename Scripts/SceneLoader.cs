using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] GameObject howToPlayCanvas;
    private void Start()
    {
        howToPlayCanvas.SetActive(false);
    }
    public void OnStartButton()
    {
        SceneManager.LoadScene(1);
    }

    
    public void OnExitButton()
    {
        Application.Quit();
    }

    public void OnMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void TurnOnHowToPlayCanvas()
    {
        howToPlayCanvas.SetActive(true);
    }

    public void TurnOffHowToPlayCanvas()
    {
        howToPlayCanvas.SetActive(false);
    }
}
