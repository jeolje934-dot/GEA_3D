using UnityEngine;

public class HpPractice : MonoBehaviour
{
    public float currentHp;
    public int maxHp;
    [ContextMenu("체력")]
    void PrintHp()
    {
        int a = (int)((float)currentHp / maxHp * 100);
        Debug.Log("HP " + a + "%");

        int b = (int)(currentHp * 100 / maxHp);
        Debug.Log("HP " + b + "%");
    }







    [ContextMenu("탄창")]
    void Ammo()
    {
        int ammo = 23;
        int magsize = 10;
        int fullMags = ammo / magsize;
        int rest = ammo % magsize;
        float ratio = (float)ammo / 25;
        Debug.Log(fullMags + "개" + rest + "발");
        Debug.Log("다음 턴: " + (ammo + magsize));
        Debug.Log(ratio);


    }





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
