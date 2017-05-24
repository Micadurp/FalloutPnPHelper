using UnityEngine;
using UnityEngine.UI;

public class MenuLogic : MonoBehaviour
{
    private Button [] menuButtons;

    void Awake()
    {
        menuButtons = GetComponentsInChildren<Button>();
        foreach (Button menuBtn in menuButtons)
        {
            menuBtn.onClick.AddListener(delegate { TaskOnClick(menuBtn); });
        }
    }

    void TaskOnClick(Button clickedBtn)
    {
        foreach (Button menuBtn in menuButtons)
        {
            menuBtn.enabled = true;
        }
        clickedBtn.enabled = false;
    }
}
