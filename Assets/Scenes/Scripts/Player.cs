using UnityEngine;

public class Player : Person
{
    Player player = new Player();
    public float PlayerExp {  get; private set; }

    private float _experience = 30;


    void Start()
    {
        PlayerHealth = 100;
        PlayerName = "Anupras";
        TakeDamage(40);
        ShowStat();
    }

    public override void ShowStat()
    {
        Debug.Log(message:$"This is your experience: {_experience} ");
        base.ShowStat();
    }

    public override void TakeDamage(int damage)
    {
        PlayerHealth -= damage;
        Debug.Log(message:$" My name is {PlayerName}: After hitting with force:  I have:health{PlayerHealth}");
        
    }
}
