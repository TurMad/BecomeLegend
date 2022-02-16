using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fader : MonoBehaviour
{
    [SerializeField] GameObject image;
    CanvasGroup canvasGroup;

    private void Awake()
    {
        canvasGroup = image.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 1;
        StartCoroutine(FadeIn(0.2f));
       

    }
    public void TrasitionToCutScene()
    {
        StartCoroutine(FadeOut(0.2f));
    }
    public void TrasitionToGame()
    {
        StartCoroutine(FadeOutTwo(0.2f));
    }



    public IEnumerator FadeOut(float time)
    {
        image.SetActive(true);
        while (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += Time.deltaTime / time;
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }
    public IEnumerator FadeOutTwo(float time)
    {
        image.SetActive(true);
        while (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += Time.deltaTime / time;
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(2);
    }

    public IEnumerator FadeIn(float time)
    {
        while (canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= Time.deltaTime / time;
            yield return null;

        }
        yield return new WaitForSeconds(1f);
        image.SetActive(false);
    }
}
