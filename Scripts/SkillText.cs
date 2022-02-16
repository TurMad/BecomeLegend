using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SkillText : MonoBehaviour
{
    [SerializeField] GameObject skillText;
    [SerializeField] string[] skillDefenition;

    Vector3 mousePos;
    private void Start()
    {
        skillText.SetActive(false);
        
    }

    private void Update()
    {
        var pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 15f, 0);
        mousePos = Camera.main.ScreenToWorldPoint(pos);
        skillText.GetComponentInChildren<TextMeshProUGUI>().text = skillDefenition[Language.GetLanguage()];
    }
    private void OnMouseOver()
    {
        skillText.SetActive(true);
        skillText.transform.position = mousePos;
    }

    private void OnMouseExit()
    {
        skillText.SetActive(false);
    }
}
