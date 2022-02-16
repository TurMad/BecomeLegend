using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    [SerializeField] Sprite[] playSprites;
    Image myImage;

    private void Start()
    {
        myImage = GetComponent<Image>();
        myImage.sprite = playSprites[0];
    }
    private void OnMouseOver()
    {
        myImage.sprite = playSprites[1];
    }

    private void OnMouseExit()
    {
        myImage.sprite = playSprites[0];
    }
}
