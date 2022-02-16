using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayMoment : MonoBehaviour
{
    [SerializeField] State[] states;
    [SerializeField] GameObject choiceCanvas;
    [SerializeField] GameObject consequenceCanvas;
    [SerializeField] GameObject playButton;
    [SerializeField] BackGround background;
    [SerializeField] GameObject deathCanvas;
    [SerializeField] GameObject player;
    GameObject greatedObject;
    Vector3 movePosition = new Vector3(5.76f, 2.7f, 0);
    float speed = 2.5f;
    int waitTime = 5;
    State selectedState;
    SeasonAndYearsChange seasonAndYears;
    Skills skills;
  
    int year = 1;
    int fiveSkill = 0;
    int tenSkill = 0;
    int oneSkill = 0;
    int threeSkill = 0;
    int fourSkill = 0;
    int sixSkill = 0;
    int sevenSkill = 0;
    int eightSkill = 0;
    int nineSkill = 0;
    int elevenSkill = 0;
    int twelveSkill = 0;
    int thirteenSkill = 0;
    int fiveteenSkill = 0;
    int sixteenSkill = 0;
    int seventeenSkill = 0;
    int eightteenSkill = 0;
    int nineteenSkill = 0;
    int twentySkill = 0;
    int twentyOneSkill = 0;
    int twentyTwoSkill = 0;
    int twentyThreeSkill = 0;
    [SerializeField] State[] allStates;

    private void Awake()
    {
        Time.timeScale = 1;
    }
    private void Start()
    {
        choiceCanvas.SetActive(false);
        consequenceCanvas.SetActive(false);
        background.StopScrolling();
        seasonAndYears = GetComponent<SeasonAndYearsChange>();
        skills = FindObjectOfType<Skills>();
        foreach (var state in allStates)
        {
            state.StateFalse();
        }
    }
    public void onPlayButtonDown()
    {
        playButton.SetActive(false);
        player.GetComponent<Animator>().SetBool("isWalk", true);
        GetSelectedState(); 
        choiceCanvas.GetComponent<ChoiceCanvas>().SetCurrentState(selectedState);
        print(selectedState);
        selectedState.StateTure();     
        CheckSkills();
        seasonAndYears.ChangeYearAndSeason();
        
        background.ContScrolling();   
        StartCoroutine(GetSelectedSenario());
        
    }
    public void SetCurrentNextState(State[] nextState)
    {
        states = nextState;
    }    
    private void CheckSkills()
    {
        if(skills.GetSkill(0))
        {
            if(year == 4)
            {
                FindObjectOfType<Player>().moneyMinus(1);
                year = 1;
            }
            else
            {
                year++;
            }
        }
        if (skills.GetSkill(2))
        {
            FindObjectOfType<Player>().healthMinus(1);
        }
        if(skills.GetSkill(16))
        {
            FindObjectOfType<Player>().moneyMinus(1);
            if (year == 4)
            {               
                FindObjectOfType<Player>().healthMinus(1);
                year = 1;
            }
            else
            {
                year++;
            }
        }
       
    }

    private void UpdateSkills()
    {
        if(skills.GetSkill(1) && oneSkill == 0)
        {
            FindObjectOfType<Player>().strMinus(1);
            FindObjectOfType<Player>().aglMinus(1);
            FindObjectOfType<Player>().charPlus(1);
            oneSkill++;
        }
        if(skills.GetSkill(3) && threeSkill == 0)
        {
            FindObjectOfType<Player>().stealPlus(2);
            FindObjectOfType<Player>().aglPlus(1);
            FindObjectOfType<Player>().repMinus(10);
            threeSkill++;
        }
        if (skills.GetSkill(4) && fourSkill == 0)
        {
            FindObjectOfType<Player>().charPlus(2);
            fourSkill++;
        }
        if (skills.GetSkill(6) && sixSkill == 0)
        {
            FindObjectOfType<Player>().repPlus(10);
            sixSkill++;
        }
        if (skills.GetSkill(7) && sevenSkill == 0)
        {
            FindObjectOfType<Player>().healthMinus(10);
            FindObjectOfType<Player>().aglMinus(1);
            FindObjectOfType<Player>().strMinus(1);
            sevenSkill++;
        }
        if (skills.GetSkill(8) && eightSkill == 0)
        {
            FindObjectOfType<Player>().gloryUp(500);
            eightSkill++;
        }
        if (skills.GetSkill(9) && nineSkill == 0)
        {
            FindObjectOfType<Player>().gloryUp(200);
            nineSkill++;
        }
        if (skills.GetSkill(10) && tenSkill == 0)
        {
            FindObjectOfType<Player>().strPlus(1);
            FindObjectOfType<Player>().aglPlus(1);
            tenSkill++;
        }
        if (skills.GetSkill(11) && elevenSkill == 0)
        {
            FindObjectOfType<Player>().gloryUp(300);
            FindObjectOfType<Player>().charPlus(1);
            elevenSkill++;  
        }
        if (skills.GetSkill(5) && fiveSkill == 0)
        {
            FindObjectOfType<Player>().intPlus(2);
            FindObjectOfType<Player>().charPlus(1);
            FindObjectOfType<Player>().stealPlus(1);
            fiveSkill++;
        }
        if (skills.GetSkill(12) && twelveSkill == 0)
        {
            FindObjectOfType<Player>().gloryUp(500);
            twelveSkill++;
        }
        if (skills.GetSkill(13) && thirteenSkill == 0)
        {
            FindObjectOfType<Player>().strPlus(1);
            FindObjectOfType<Player>().aglPlus(1);
            FindObjectOfType<Player>().intPlus(1);
            FindObjectOfType<Player>().charPlus(1);
            FindObjectOfType<Player>().stealPlus(1);
            thirteenSkill++;
        }
        if (skills.GetSkill(15) && fiveteenSkill == 0)
        {
            FindObjectOfType<Player>().gloryUp(100);
            FindObjectOfType<Player>().repPlus(10); 
            fiveteenSkill++;
        }
        if (skills.GetSkill(16) && sixteenSkill == 0)
        {
            FindObjectOfType<Player>().strPlus(2);
            sixteenSkill++;
        }
        if (skills.GetSkill(17) && seventeenSkill == 0)
        {
            FindObjectOfType<Player>().strMinus(1);
            FindObjectOfType<Player>().aglMinus(1);
            FindObjectOfType<Player>().intMinus(1);
            FindObjectOfType<Player>().charMinus(1);
            FindObjectOfType<Player>().stealMinus(1);
            FindObjectOfType<Player>().healthMinus(20);
            seventeenSkill++;
        }
        if (skills.GetSkill(18) && eightteenSkill == 0)
        {
            FindObjectOfType<Player>().moneyPlus(150);
            eightteenSkill++;
        }
        if (skills.GetSkill(19) && nineteenSkill == 0)
        {
            FindObjectOfType<Player>().strPlus(2);
            FindObjectOfType<Player>().aglPlus(2);
            FindObjectOfType<Player>().intMinus(1);
            FindObjectOfType<Player>().charMinus(1);
            FindObjectOfType<Player>().stealMinus(1);
            nineteenSkill++;
        }
        if (skills.GetSkill(20) && twentySkill == 0)
        {
            FindObjectOfType<Player>().intPlus(1);
            FindObjectOfType<Player>().charPlus(1);
            twentySkill++;
        }
        if (skills.GetSkill(21) && twentyOneSkill == 0)
        {
            FindObjectOfType<Player>().moneyPlus(100);
            FindObjectOfType<Player>().healthPlus(20);
            twentyOneSkill++;
        }
        if (skills.GetSkill(22) && twentyTwoSkill == 0)
        {
            FindObjectOfType<Player>().gloryUp(500);
            twentyTwoSkill++;
        }
        if (skills.GetSkill(23) && twentyThreeSkill == 0)
        {
            FindObjectOfType<Player>().gloryUp(500);
            twentyThreeSkill++;
        }
    }
    public void onContinue()
    {
        playButton.SetActive(true);
        choiceCanvas.SetActive(false);
        consequenceCanvas.SetActive(false);
        FindObjectOfType<Player>().OnHealthZero();

        if (choiceCanvas.GetComponent<ChoiceCanvas>().CheсkPlayerCond())
        {
            deathCanvas.SetActive(true);
        }
       
    }
    private void GetSelectedState()
    {
        for (int i = 0; i < states.Length; i++)
        {
            selectedState = states[UnityEngine.Random.Range(0, states.Length)];
            if (!selectedState.StateAlready())
            {
                break;
            }
        }
    }

   

    private void Update()
    {
       
        UpdateSkills();
        
        if (greatedObject == null) return;
        if (greatedObject.transform.position != movePosition)
        {
            Vector3 newPos = Vector3.MoveTowards(greatedObject.transform.position, movePosition, speed * Time.deltaTime);
            greatedObject.transform.position = newPos;
        }
        

    }

 

    private IEnumerator GetSelectedSenario()
    {
        greatedObject  = Instantiate(selectedState.GetGameObject(), transform.position, Quaternion.identity);
        
        
        yield return new WaitForSeconds(waitTime);
        background.StopScrolling();
        player.GetComponent<Animator>().SetBool("isWalk", false);
        choiceCanvas.SetActive(true);
        Destroy(greatedObject);
        
        

    }
}
