using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Dialogue")]
public class DialogueState : ScriptableObject
{
    [TextArea(14, 10)] [SerializeField] string[] storyTexts;

    public string GetDialogue(int lanIndex)
    {
        return storyTexts[lanIndex];
    }

}