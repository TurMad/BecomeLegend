using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageChanger : MonoBehaviour
{
    

    public void OnButtonDownEng()
    {
        Language.SetLanguage(0);
        print(Language.GetLanguage());
    }
    public void OnButtonDownRu()
    {
        Language.SetLanguage(1);

        print(Language.GetLanguage());
    }

    public void NextLanguage()
    {
        if (Language.GetLanguage() == 0)
        {
            Language.SetLanguage(1);
            print(Language.GetLanguage());
        }
        else
        {
            Language.SetLanguage(0);
            print(Language.GetLanguage());
        }
    }

    
}
