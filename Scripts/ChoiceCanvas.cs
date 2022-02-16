using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceCanvas : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI storyText;
    [SerializeField] TextMeshProUGUI charName;
    [SerializeField] TextMeshProUGUI choiceOneText;
    [SerializeField] TextMeshProUGUI choiceTwoText;
    [SerializeField] TextMeshProUGUI choiceThreeText;
    [SerializeField] TextMeshProUGUI choose1TextBtn;
    [SerializeField] TextMeshProUGUI choose2TextBtn;
    [SerializeField] TextMeshProUGUI choose3TextBtn;
    [SerializeField] TextMeshProUGUI choose1TextTitle;
    [SerializeField] TextMeshProUGUI choose2TextTitle;
    [SerializeField] TextMeshProUGUI choose3TextTitle;
    [SerializeField] GameObject consequenceCanvas;
    [SerializeField] TextMeshProUGUI conseText;
    [SerializeField] TextMeshProUGUI situationText;
    [SerializeField] TextMeshProUGUI resultText;
    [SerializeField] TextMeshProUGUI continueButtonText;

    [SerializeField] string[] chooseButtonTexts;
    [SerializeField] string[] firstChooseTitleTexts;
    [SerializeField] string[] secondChooseTitleTexts;
    [SerializeField] string[] thirdChooseTitleTexts;
    [SerializeField] string[] continBtnTexts;

    bool gameOver = false;
    Choice choiceOne;
    Choice choiceTwo;
    Choice choiceThree;

    Choice selectedChoice;
   
    public void SetCurrentState(State currentState)
    {
        storyText.text = currentState.GetStoryText(Language.GetLanguage());
        charName.text = currentState.GetNameText(Language.GetLanguage());
        choiceOne = currentState.GetChoiceOne();
        choiceTwo = currentState.GetChoiceTwo();
        choiceThree = currentState.GetChoiceThree();
        choose1TextBtn.text = chooseButtonTexts[Language.GetLanguage()];
        choose2TextBtn.text = chooseButtonTexts[Language.GetLanguage()];
        choose3TextBtn.text = chooseButtonTexts[Language.GetLanguage()];
        choose1TextTitle.text = firstChooseTitleTexts[Language.GetLanguage()];
        choose2TextTitle.text = secondChooseTitleTexts[Language.GetLanguage()];
        choose3TextTitle.text = thirdChooseTitleTexts[Language.GetLanguage()];
        choiceOneText.text = choiceOne.GetChoiceText(Language.GetLanguage());
        choiceTwoText.text = choiceTwo.GetChoiceText(Language.GetLanguage());
        choiceThreeText.text = choiceThree.GetChoiceText(Language.GetLanguage());
        continueButtonText.text = continBtnTexts[Language.GetLanguage()];
        
    }

   public void onSelectChoiceOne()
    {
        consequenceCanvas.SetActive(true);
        selectedChoice = choiceOne;
        var currentConse = choiceOne.GetConsequence();
        conseText.text = currentConse.GetConseText(Language.GetLanguage());
        situationText.text = currentConse.GetSituationText(Language.GetLanguage());
        resultText.text = currentConse.GetResult(Language.GetLanguage());
        changeStats(currentConse);
        changeSkills(currentConse);
        changeBackground(currentConse);
        checkFirstOrder(currentConse);
        checkSecondOrder(currentConse);
        TakeCurrentNextOrder(currentConse);
        PlayerIsDead(currentConse);
    }
    public void onSelectChoiceTwo()
    {
        consequenceCanvas.SetActive(true);
        selectedChoice = choiceTwo;
        var currentConse = choiceTwo.GetConsequence();
        conseText.text = currentConse.GetConseText(Language.GetLanguage());
        situationText.text = currentConse.GetSituationText(Language.GetLanguage());
        resultText.text = currentConse.GetResult(Language.GetLanguage());
        changeStats(currentConse);
        changeSkills(currentConse);
        changeBackground(currentConse);
        checkFirstOrder(currentConse);
        checkSecondOrder(currentConse);
        TakeCurrentNextOrder(currentConse);
        PlayerIsDead(currentConse);
    }
    public void onSelectChoiceThree()
    {
        consequenceCanvas.SetActive(true);
        selectedChoice = choiceThree;
        var currentConse = choiceThree.GetConsequence();
        conseText.text = currentConse.GetConseText(Language.GetLanguage());
        situationText.text = currentConse.GetSituationText(Language.GetLanguage());
        resultText.text = currentConse.GetResult(Language.GetLanguage());
        changeStats(currentConse);
        changeSkills(currentConse);
        changeBackground(currentConse);
        checkFirstOrder(currentConse);
        checkSecondOrder(currentConse);
        TakeCurrentNextOrder(currentConse);
        PlayerIsDead(currentConse);
    }

    private void changeStats(Consequence currentCons)
    {
        if(currentCons.minusGoldTure())
        {
            FindObjectOfType<Player>().moneyMinus(selectedChoice.GetMoneyChange());
        }
        if (currentCons.plusGoldTrue())
        {
            FindObjectOfType<Player>().moneyPlus(selectedChoice.GetMoneyChange());
        }
        if (currentCons.minusHealthTure())
        {
            FindObjectOfType<Player>().healthMinus(selectedChoice.GetHealthChange());
        }
        if (currentCons.plusHealthTrue())
        {
            FindObjectOfType<Player>().healthPlus(selectedChoice.GetHealthChange());
        }
        if (currentCons.plusGloryTrue())
        {
            FindObjectOfType<Player>().gloryUp(selectedChoice.GetGloryChange());
        }
        if (currentCons.plusStrTrue())
        {
            FindObjectOfType<Player>().strPlus(selectedChoice.GetStrChange());
        }
        if (currentCons.minusStrTrue())
        {
            FindObjectOfType<Player>().strMinus(selectedChoice.GetStrChange());
        }
        if (currentCons.plusIntTrue())
        {
            FindObjectOfType<Player>().intPlus(selectedChoice.GetIntChange());
        }
        if (currentCons.minusIntTrue())
        {
            FindObjectOfType<Player>().intMinus(selectedChoice.GetIntChange());
        }
        if (currentCons.plusAglTrue())
        {
            FindObjectOfType<Player>().aglPlus(selectedChoice.GetAglChange());
        }
        if (currentCons.minusAglTrue())
        {
            FindObjectOfType<Player>().aglMinus(selectedChoice.GetAglChange());
        }
        if (currentCons.plusCharTrue())
        {
            FindObjectOfType<Player>().charPlus(selectedChoice.GetCharChange());
        }
        if (currentCons.minusCharTrue())
        {
            FindObjectOfType<Player>().charMinus(selectedChoice.GetCharChange());
        }
        if (currentCons.plusStealTrue())
        {
            FindObjectOfType<Player>().stealPlus(selectedChoice.GetStealChange());
        }
        if (currentCons.minusStealTrue())
        {
            FindObjectOfType<Player>().stealMinus(selectedChoice.GetStealChange());
        }
        if (currentCons.plusRepTrue())
        {
            FindObjectOfType<Player>().repPlus(selectedChoice.GetRepChange());
        }
        if (currentCons.minusRepTrue())
        {
            FindObjectOfType<Player>().repMinus(selectedChoice.GetRepChange());
        }

    }

    private void changeSkills(Consequence currentCons)
    {
        if(currentCons.SkillIsTrue())
        {
            FindObjectOfType<Skills>().MakeSkillTure(currentCons.GetSkillIndex());
        }
    }
    private void changeBackground(Consequence currentCons)
    {
        if (currentCons.BackIsTrue())
        {
            FindObjectOfType<BackGround>().UpdateMaterial(currentCons.BackIndex());
        }
    }
    public void TakeCurrentNextOrder(Consequence currentCons)
    {
        FindObjectOfType<PlayMoment>().SetCurrentNextState(currentCons.GetState());
    }
    private void checkFirstOrder(Consequence currentCons)
    {
        if (currentCons.FirstOrderTrue())
        {
            FindObjectOfType<Player>().FirstOrderUpdate();
        }
    }
    private void checkSecondOrder(Consequence currentCons)
    {
        if (currentCons.SecondOrderTrue())
        {
            FindObjectOfType<Player>().SecondOrderUpdate();
        }
    }

    private bool PlayerIsDead(Consequence currentCons)
    {
        if(currentCons.PlayerIsDead())
        {
            return gameOver = true;
        }
        return false;
    }

    public bool CheсkPlayerCond()
    {
        return gameOver;
    }
}
