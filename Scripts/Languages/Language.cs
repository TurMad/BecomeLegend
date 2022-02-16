using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Language : MonoBehaviour
{
    const string Lang = "lan";


    public static void SetLanguage(int lanIndex)
    {
        PlayerPrefs.SetInt(Lang, lanIndex);
    }
    public static int GetLanguage()
    {
        return PlayerPrefs.GetInt(Lang);
    }

}
