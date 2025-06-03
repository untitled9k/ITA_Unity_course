using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextController : MonoBehaviour
{
    public TMP_Text mainText;
    public Button buttonOne;
    public Button buttonTwo;
    public Button buttonDisable;

    public void OnClickOne()
    {
        mainText.text = "One Clicked";
    }

    public void OnClickTwo()
    {
        mainText.text = "Two Clicked";
    }

    public void DisableButtons()
    {
        buttonOne.interactable = false;
        buttonTwo.interactable = false;
        buttonDisable.interactable = false;
    }

    public void EnableButtons()
    {
        buttonOne.interactable = true;
        buttonTwo.interactable = true;
        buttonDisable.interactable = true;
    }
}
