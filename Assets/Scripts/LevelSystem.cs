using UnityEngine;

public class LevelSystem : MonoBehaviour
{
     public int expPerKill = 35000;     //몬스터 한 마리의 경험치
     public int killCount = 3;          //잡은 마릿수

    [ContextMenu("레벨 계산")]
    void CalculateLevel()
    {
        int level = 1; 
        int exp = 0;
        for (int row  = level; row > 0; row--)
        {
            for (int i = 0; i < expPerKill; i++)
            {
                int killcount = expPerKill - i;

                int exPerKill = row;
            }
        }

        Debug.Log(level);
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
