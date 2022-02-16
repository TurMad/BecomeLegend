using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI strengthText;
    [SerializeField] TextMeshProUGUI intelligenceText;
    [SerializeField] TextMeshProUGUI charismaText;
    [SerializeField] TextMeshProUGUI agilityText;
    [SerializeField] TextMeshProUGUI stealthText;
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] TextMeshProUGUI gloryText;
    [SerializeField] TextMeshProUGUI repText;
    [SerializeField] Slider repSlider;
    [SerializeField] GameObject deathCanvas;

    [SerializeField] int strenght = 0;
    [SerializeField] int intelligence = 0;
    [SerializeField] int charisma = 0;
    [SerializeField] int agility = 0;
    [SerializeField] int stealth = 0;
   
    

    int health = 100;
    int money = 30;
    int glory = 0;
    int reputation = 0;

    private void Start()
    {
        deathCanvas.SetActive(false);
    }
    private void Update()
    {
        strengthText.text = strenght.ToString();
        intelligenceText.text = intelligence.ToString();
        charismaText.text = charisma.ToString();
        agilityText.text = agility.ToString();
        stealthText.text = stealth.ToString();
        healthText.text = health.ToString();
        moneyText.text = money.ToString();
        gloryText.text = glory.ToString();
        repText.text = reputation.ToString();
        repSlider.value = reputation;
        
    }

    public void FirstOrderUpdate()
    {
        if (FindObjectOfType<Skills>().GetSkill(14))
        {
            moneyMinus(5);
            healthPlus(10);
        }
        else
        {
            moneyMinus(10);
            healthPlus(10);
        }
    }
    public void SecondOrderUpdate()
    {
        if (FindObjectOfType<Skills>().GetSkill(14))
        {
            moneyMinus(10);
            healthPlus(20);
        }
        else
        {
            moneyMinus(20);
            healthPlus(20);
        }
    }
    public void OnHealthZero()
    {
        if(health <= 0)
        {
            deathCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public int GetSTR()
    {
        return strenght;
    }
    public int GetINT()
    {
        return intelligence;
    }
    public int GetAGL()
    {
        return agility;
    }
    public int GetCHAR()
    {
        return charisma;
    }
    public int GetSTEAL()
    {
        return stealth;
    }

    public int GetMoney()
    {
        return money;
    }

    public int GetRep()
    {
        return reputation;
    }
    public int GetGlory()
    {
        return glory;
    }
    public void healthMinus(int healthToChange)
    {
        health = Mathf.Max(health - healthToChange, 0);
    }
    public void healthPlus(int healthToChange)
    {
        health = Mathf.Min(health + healthToChange, 100);
    }
    public void moneyMinus(int moneyToChange)
    {
        money = Mathf.Max(money - moneyToChange, 0);
    }
    public void moneyPlus(int moneyToChange)
    {
        money = Mathf.Max(money + moneyToChange, 0);
    }

    public void gloryUp(int gloryToChange)
    {
        glory += gloryToChange;
    }

    public void strPlus(int indexToChange)
    {
        strenght = Mathf.Min(strenght + indexToChange, 10);
    }
    public void strMinus(int indexToChange)
    {
        strenght = Mathf.Max(strenght - indexToChange, 0);
    }
    public void intPlus(int indexToChange)
    {
        intelligence = Mathf.Min(intelligence + indexToChange, 10);
    }
    public void intMinus(int indexToChange)
    {
        intelligence = Mathf.Max(intelligence - indexToChange, 0);
    }
    public void aglPlus(int indexToChange)
    {
        agility = Mathf.Min(agility + indexToChange, 10);
    }
    public void aglMinus(int indexToChange)
    {
        agility = Mathf.Max(agility - indexToChange, 0); 
    }
    public void charPlus(int indexToChange)
    {
        charisma = Mathf.Min(charisma + indexToChange, 10);
    }
    public void charMinus(int indexToChange)
    {
        charisma = Mathf.Max(charisma - indexToChange, 0);
    }
    public void stealPlus(int indexToChange)
    {
        stealth = Mathf.Min(stealth + indexToChange, 10);
    }
    public void stealMinus(int indexToChange)
    {
        stealth = Mathf.Max(stealth - indexToChange, 0);
    }
    public void repPlus(int indexToChange)
    {
        reputation = Mathf.Min(reputation + indexToChange, 50);
    }
    public void repMinus(int indexToChange)
    {
        reputation = Mathf.Max(reputation - indexToChange, -50);
    }

}
