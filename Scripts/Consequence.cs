using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

[CreateAssetMenu(menuName = "Consequence")]
public class Consequence : ScriptableObject
{
    [SerializeField] string[] conseText;

    [TextArea(10, 10)] [SerializeField] string[] situationText;

    [TextArea(5, 5)] [SerializeField] string[] result;


    [SerializeField] bool minusGold;
    [SerializeField] bool plusGold;
    [SerializeField] bool plusGlory;
    [SerializeField] bool plusHealth;
    [SerializeField] bool minusHealth;
    [SerializeField] bool plusStr;
    [SerializeField] bool plusInt;
    [SerializeField] bool plusAgl;
    [SerializeField] bool plusSteal;
    [SerializeField] bool plusChar;
    [SerializeField] bool minusStr;
    [SerializeField] bool minusInt;
    [SerializeField] bool minusAgl;
    [SerializeField] bool minusSteal;
    [SerializeField] bool minusChar;
    [SerializeField] bool plusRep;
    [SerializeField] bool minusRep;
    [SerializeField] bool playerDeath;

    [SerializeField] public bool skillIsTure;
    [SerializeField] public int skillIndex;
    [SerializeField] public bool backIsTure;
    [SerializeField] public int backIndex;
    [SerializeField] public bool firstOrderTure;
    [SerializeField] public bool secondOrderTure;

    [SerializeField] State[] nextStates;
    public string GetConseText(int lanIndex)
    {
        return conseText[lanIndex];
    }
    public string GetSituationText(int lanIndex)
    {
        return situationText[lanIndex];
    }
    public string GetResult(int lanIndex)
    {
        return result[lanIndex];
    }
    public bool minusGoldTure()
    {
        return minusGold;
    }
    public bool plusGoldTrue()
    {
        return plusGold;
    }
    public bool plusGloryTrue()
    {
        return plusGlory;
    }
    public bool minusHealthTure()
    {
        return minusHealth;
    }
    public bool plusHealthTrue()
    {
        return plusHealth;
    }
    public bool plusStrTrue()
    {
        return plusStr;
    }
    public bool plusIntTrue()
    {
        return plusInt;
    }
    public bool plusAglTrue()
    {
        return plusAgl;
    }
    public bool plusCharTrue()
    {
        return plusChar;
    }
    public bool plusStealTrue()
    {
        return plusSteal;
    }
    public bool minusStrTrue()
    {
        return minusStr;
    }
    public bool minusIntTrue()
    {
        return minusInt;
    }
    public bool minusAglTrue()
    {
        return minusAgl;
    }
    public bool minusCharTrue()
    {
        return minusChar;
    }
    public bool minusStealTrue()
    {
        return minusSteal;
    }

    public bool plusRepTrue()
    {
        return plusRep;
    }
    public bool minusRepTrue()
    {
        return minusRep;
    }

    public bool PlayerIsDead()
    {
        return playerDeath;
    }

    public bool SkillIsTrue()
    {
        return skillIsTure;
    }
    public int GetSkillIndex()
    {
        return skillIndex;
    }
    public bool BackIsTrue()
    {
        return backIsTure;
    }
    public int BackIndex()
    {
        return backIndex;
    }
    public bool FirstOrderTrue()
    {
        return firstOrderTure;
    }
    public bool SecondOrderTrue()
    {
        return secondOrderTure;
    }

    public State[] GetState()
    {
        return nextStates;
    }
}
