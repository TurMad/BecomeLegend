using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject 
{
    [SerializeField] string[] characterName;
    [TextArea(14,10)][SerializeField] string[] storytext ;
    [SerializeField] GameObject gameObject;
    [SerializeField] Choice choiceOne;
    [SerializeField] Choice choiceTwo;
    [SerializeField] Choice choiceThree;
    

    //[SerializeField] State[] nextStates;

     [SerializeField] bool stateAlreadyWas;


   
    public GameObject GetGameObject()
    {
        return gameObject;
    }

    //public State[] GetNextState()
    //{
    //    return nextStates;
    //}

    public string GetStoryText(int lanIndex)
    {
        return storytext[lanIndex];
    }
    public string GetNameText(int lanIndex)
    {
        return characterName[lanIndex];
    }

    public Choice GetChoiceOne()
    {
        return choiceOne;
    }
    public Choice GetChoiceTwo()
    {
        return choiceTwo;
    }
    public Choice GetChoiceThree()
    {
        return choiceThree;
    }

    public bool StateAlready()
    {
        return stateAlreadyWas;
    }
     public bool StateTure()
    {
        return stateAlreadyWas = true;
    }

    public bool StateFalse()
    {
        return stateAlreadyWas = false;
    }
}
