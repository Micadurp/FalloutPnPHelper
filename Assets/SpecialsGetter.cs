using UnityEngine;
using UnityEngine.UI;

public class SpecialsGetter : MonoBehaviour
{
    public GameObject mainObject;
    public string singeltonId;

    public void Start()
    {
        if (mainObject.GetComponent<InputField>() != null)
        {
            GetValue(mainObject.GetComponent<InputField>());
        }
        else if (mainObject.GetComponent<Text>() != null)
        {
            GetValue(mainObject.GetComponent<Text>());
        }

    }

    void GetValue(Text value)
    {
        switch (singeltonId)
        {
            case "str":
                value.text = Toolbox.Instance.strength.ToString();
                break;
            case "per":
                value.text = Toolbox.Instance.perception.ToString();
                break;
            case "end":
                value.text = Toolbox.Instance.endurance.ToString();
                break;
            case "cha":
                value.text = Toolbox.Instance.charisma.ToString();
                break;
            case "int":
                value.text = Toolbox.Instance.intelligence.ToString();
                break;
            case "agi":
                value.text = Toolbox.Instance.agility.ToString();
                break;
            case "lck":
                value.text = Toolbox.Instance.luck.ToString();
                break;
            default:
                Debug.LogWarning("singeltonId does not match a singelton");
                break;
        }
    }
    void GetValue(InputField value)
    {
        switch (singeltonId)
        {
            case "str":
                value.text = Toolbox.Instance.strength.ToString();
                break;
            case "per":
                value.text = Toolbox.Instance.perception.ToString();
                break;
            case "end":
                value.text = Toolbox.Instance.endurance.ToString();
                break;
            case "cha":
                value.text = Toolbox.Instance.charisma.ToString();
                break;
            case "int":
                value.text = Toolbox.Instance.intelligence.ToString();
                break;
            case "agi":
                value.text = Toolbox.Instance.agility.ToString();
                break;
            case "lck":
                value.text = Toolbox.Instance.luck.ToString();
                break;
            default:
                Debug.LogWarning("singeltonId does not match a singelton");
                break;
        }
    }
}