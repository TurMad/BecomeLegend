using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SeasonAndYearsChange : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI yearsText;
    [SerializeField] TextMeshProUGUI seasonText;
    [SerializeField] GameObject player;

    [SerializeField] int year = 950;
    [SerializeField] string[] seasonsEng;
    [SerializeField] string[] seasonsRu;
    [SerializeField] TextMeshProUGUI menuText;
    [SerializeField] string[] menu;
    [SerializeField] GameObject menuCanvas;

    int currentSeason = 0;
    private void Start()
    {
 
        menuCanvas.SetActive(false);
    }
    private void Update()
    {
        menuText.text = menu[Language.GetLanguage()]; 
        yearsText.text = year.ToString();
        CheckSeasons();
    }
    public void OpenMenu()
    {
        menuCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public int GetYear()
    {
        return year;
    }
    private void CheckSeasons()
    {
        if (Language.GetLanguage() == 0)
        {
            seasonText.text = seasonsEng[currentSeason];
        }
        else
        {
            seasonText.text = seasonsRu[currentSeason];
        }
    }

    public void ChangeYearAndSeason()
    {
        
        currentSeason += 1;
        if(currentSeason == 4)
        {
            currentSeason = 0;
            
        }
        if(currentSeason == 2)
        {
            year += 1;
        }

    }


}
