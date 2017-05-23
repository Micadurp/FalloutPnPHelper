using UnityEngine;

public class Toolbox : Singleton<Toolbox>
{
    protected Toolbox() { } // guarantee this will be always a singleton only - can't use the constructor!

    public int strength = 1;
    public int perception = 1;
    public int endurance = 1;
    public int charisma = 1;
    public int intelligence = 1;
    public int agility = 1;
    public int luck = 1;

    void Awake()
    {
        // Your initialization code here
    }

    // (optional) allow runtime registration of global objects
    static public T RegisterComponent<T>() where T : Component
    {
        return Instance.GetOrAddComponent<T>();
    }
}