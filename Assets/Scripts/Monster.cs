
using UnityEngine;

public class Monster
{
    public string name;
    public int hp;
    public int attack;
    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp < 0) hp = 0;

    }
    public bool IsDead()
    {
        return hp <= 0;
    }
    
     
    [ContextMenu("객체")]
    void MakeObjects()
    {
        Monster slime = new Monster("슬라임" , 30 , 5);
        slime.name = " 슬라임";
        slime.hp = 30;
        slime.attack = 5;

        Monster goblin = new Monster("고블린" , 30 , 5);
        goblin.name = "고블린";
        goblin.hp -= 50;

        slime.hp -= 10;
        Debug.Log(slime.name + "" + slime.hp);
        Debug.Log(goblin.name + " " + goblin.hp + "" + goblin.attack);


    }
    


    public Monster(string name , int hp , int attack)
    {
        this.name = name;
        this.hp = hp;
        this.attack = attack;

    }
}
