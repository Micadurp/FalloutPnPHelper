using UnityEngine;
using UnityEngine.UI;

public class SingeltonSetter : MonoBehaviour
{
    public InputField mainInputField;
    public string singeltonId;

    public void Start()
    {
        //Adds a listener that invokes the "LockInput" method when the player finishes editing the main input field.
        //Passes the main input field into the method when "LockInput" is invoked
        mainInputField.onEndEdit.AddListener(delegate { SetValue(mainInputField); });
    }

    void SetValue(InputField input)
    {
        switch (singeltonId)
        {
            case "str":
                Toolbox.Instance.strength = int.Parse(input.text);
                break;
            case "per":
                Toolbox.Instance.perception = int.Parse(input.text);
                break;
            case "end":
                Toolbox.Instance.endurance = int.Parse(input.text);
                break;
            case "cha":
                Toolbox.Instance.charisma = int.Parse(input.text);
                break;
            case "int":
                Toolbox.Instance.intelligence = int.Parse(input.text);
                break;
            case "agi":
                Toolbox.Instance.agility = int.Parse(input.text);
                break;
            case "lck":
                Toolbox.Instance.luck = int.Parse(input.text);
                break;
            default:
                Debug.LogWarning("singeltonId does not match a singelton");
                break;
        }
    }
}