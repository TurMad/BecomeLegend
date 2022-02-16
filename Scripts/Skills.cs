using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skills : MonoBehaviour
{
    [SerializeField] Image[] skills;
    [SerializeField] bool[] skillsCon;
    private void Start()
    {
        foreach (var skill in skills)
        {
            skill.GetComponent<Image>().color = new Color32(80, 80, 80, 140);
        }

        MakeSkillTure(0);
    }

    private void Update()
    {
        if(FindObjectOfType<SeasonAndYearsChange>().GetYear() >= 992)
        {
            MakeSkillTure(2);
        }
        if (FindObjectOfType<Player>().GetRep() == 50)
        {
            MakeSkillTure(23);
        }
        if (FindObjectOfType<Player>().GetRep() == -50)
        {
            MakeSkillTure(22);
        }
        if (FindObjectOfType<Player>().GetAGL() == 10 && FindObjectOfType<Player>().GetSTR() == 10 && FindObjectOfType<Player>().GetINT() == 10 && FindObjectOfType<Player>().GetSTEAL() == 10 && FindObjectOfType<Player>().GetCHAR() == 10)
        {
            MakeSkillTure(9);
        }

    }
    public void MakeSkillTure(int skillIndex)
    {
        skillsCon[skillIndex] = true;
        if (skillsCon[skillIndex])
        {
            skills[skillIndex].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }

   public bool GetSkill(int skillIndex)
    {
        return skillsCon[skillIndex];
    }
}
