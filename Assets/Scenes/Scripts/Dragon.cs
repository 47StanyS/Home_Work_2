using UnityEngine;

public class Dragon : Person
{
    Dragon dragon = new Dragon();


    void Start()
    {
        PlayerHealth = 200;
        PlayerName = "Dragon";
        TakeDamage(45);
    }

    public override void TakeDamage(int damage)
    {
        PlayerHealth -= damage;
        Debug.Log(message:$" the mighty dragon, have lost:   hit points from a hunter's shot. ");
    }
}
