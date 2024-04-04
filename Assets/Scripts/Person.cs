using UnityEngine;

public abstract class Person : MonoBehaviour
{
    public string PlayerName
    {
        get { return _name; }
        set { _name = value; }
    }
    public float PlayerHealth
    {
        get
        {
            return _health;
        }
        set
        {
            if (value < 0 || value > 100)
            {
                Debug.Log(message: "Health should be between 0 and 100.");
            }
            else { _health = value; }
        }
    }

    private string _name;
    private float _health;

    public virtual void ShowStat()
    {
        Debug.Log(message: $"This is your name: {_name}");
    }
    public abstract void TakeDamage(int i);
}

