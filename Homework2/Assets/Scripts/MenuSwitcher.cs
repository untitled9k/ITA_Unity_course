using UnityEngine;


public class MenuSwitcher : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject interactionPanelButton;
    public GameObject interactionToggleButton;
    public GameObject interactionDropButton;
    public GameObject interactionInputButton;
    public GameObject interactionScrollViewButton;

    private void Start()
    {
        mainMenuPanel.SetActive(true);
        interactionPanelButton.SetActive(false);
        interactionToggleButton.SetActive(false);
    }
    public void OpenInteractionPanelButtons()
    {
        mainMenuPanel.SetActive(false);
        interactionPanelButton.SetActive(true);
    }

    public void OpenInteractionPanelToggle()
    {
        mainMenuPanel.SetActive(false);
        interactionToggleButton.SetActive(true);
    }

    public void OpenInteractionPanelDrops()
    {
        mainMenuPanel.SetActive(false);
        interactionDropButton.SetActive(true);
    }

    public void OpenInteractionPanelInput()
    {
        mainMenuPanel.SetActive(false);
        interactionInputButton.SetActive(true);
    }
    public void OpenInteractionPanelScrollBar()
    {
        mainMenuPanel.SetActive(false);
        interactionScrollViewButton.SetActive(true);
    }

    public void ReturnToMainMenu()
    {
        interactionPanelButton.SetActive(false);
        interactionToggleButton.SetActive(false);
        interactionDropButton.SetActive(false);
        interactionInputButton.SetActive(false);
        interactionScrollViewButton.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}