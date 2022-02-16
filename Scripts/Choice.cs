using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Choice")]
public class Choice : ScriptableObject
{
    [TextArea(10, 10)] [SerializeField] string[] choiceText;
    [SerializeField] Consequence consequencePositive;
    [SerializeField] Consequence consequenceNegative;
    

    [SerializeField] int strReq = 1;
    [SerializeField] int intReq = 1;
    [SerializeField] int aglReq = 1;
    [SerializeField] int charReq = 1;
    [SerializeField] int stealReq = 1;
    [SerializeField] int moneyReq = 0;
    [SerializeField] int repReq = 0;
    [SerializeField] int gloryReq = 0;
    [SerializeField] int healthChange = 0;
    [SerializeField] int gloryChange = 0;
    [SerializeField] int strChange = 0;
    [SerializeField] int intChange = 0;
    [SerializeField] int aglChange = 0;
    [SerializeField] int charChange = 0;
    [SerializeField] int stealChange = 0;
    [SerializeField] int repChange = 0;
    [SerializeField] int moneyChange = 0;

    public Consequence GetConsequence()
    {
        Player player = FindObjectOfType<Player>();

        if(player.GetAGL() >= aglReq && player.GetCHAR() >= charReq && player.GetSTR() >= strReq && player.GetINT() >= intReq && player.GetSTEAL() >= stealReq && player.GetMoney() >= moneyReq && player.GetRep() >= repReq && player.GetGlory() >= gloryReq)
        {
            
            return consequencePositive;
            
        }
        else
        {
            
            return consequenceNegative;
        }
    }

    
    public string GetChoiceText(int lanIndex)
    {
        return choiceText[lanIndex];
    }

   public int GetReqMoney()
    {
        return moneyReq;
    }

    public int GetHealthChange()
    {
        return healthChange;
    }

    public int GetGloryChange()
    {
        return gloryChange;
    }
    public int GetStrChange()
    {
        return strChange;
    }
    public int GetIntChange()
    {
        return intChange;
    }
    public int GetAglChange()
    {
        return aglChange;
    }
    public int GetCharChange()
    {
        return charChange;
    }
    public int GetStealChange()
    {
        return stealChange;
    }

    public int GetRepChange()
    {
        return repChange;
    }
    public int GetMoneyChange()
    {
        return moneyChange;
    }
}
