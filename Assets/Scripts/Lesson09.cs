using UnityEngine;

public class Lesson09 : MonoBehaviour
{
    public int attack = 10;  //필드

    int killCount = 0;       //필드

    [ContextMenu("처치")]
    void CountKill()
    {
        int defense = 3;  //지역 변수
        killCount = killCount + 1;
        Debug.Log(attack - defense);
        Debug.Log(killCount);
    }






    [ContextMenu("Hello")]
    void Hello()
    {
        Debug.Log("Hello");
    }


    [ContextMenu("테스트 1")]
    void Test1()
    {
        int hp = 10;
        Debug.Log(hp);
    }

    [ContextMenu("테스트 2")]
    void Test2()
    {
        int hp = 7;
        Debug.Log(hp);
    }

    public int gold = 100;
    [ContextMenu("골드 보기")]

    void ShowGold()
    {
        Debug.Log(gold);
    }


    [ContextMenu("예측 1")]
    void Predict()
    {
        int hp = 10;
        hp = hp - 3;
        Debug.Log(hp);
        hp = 20;
        Debug.Log(hp);
        int maxHp = hp;
        hp = 5;
        Debug.Log(maxHp);
    }




   
    
    void Start()
    {
        Debug.Log(attack);
    }

    void Hit()
    {
        killCount = killCount + 1;
    }



   
   void Update()
   {
        

   }
}
