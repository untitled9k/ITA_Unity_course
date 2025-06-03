using TMPro;
using UnityEngine;

public class DropdownText : MonoBehaviour
{
    public TMP_Dropdown dropdownUI;
    public TMP_Text displayText;


    void Start()
    {
        dropdownUI.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    private void OnDropdownValueChanged(int intex)
    {
        if (dropdownUI.value == 0)
        {
            displayText.text = "Option A";
        }
        if (dropdownUI.value == 1)
        {
            displayText.text = "Option B";
        }
        if (dropdownUI.value == 2)
        {
            displayText.text = "Option C";
        }
        if (dropdownUI.value == 3)
        {
            displayText.text = "Option D";
        }
    }
}
