using UnityEngine;

public class LevelSystem : MonoBehaviour
{
     public int expPerKill = 35000;     //몬스터 한 마리의 경험치
     public int killCount = 3;          //잡은 마릿수

    int level = 1; 
    int exp = 0;


    // level++; 레벨 하나 올리기 
    // 뭔가 레벨 하나 올라갈때 마다 경험치가 10,000씩 올라서 1레벨 => 10,000사용 하고 , 2렙 되면 20,000사용 해서 총 10,5000 중에서 75,000남는 그런 과제인지 이해가 안됩니다 

    [ContextMenu("레벨 계산")]
    void CalculateLevel()
    {
        while (exp >= level * 10000)
        {
            exp -= level * 10000;
            level++;
        }
        Debug.Log(level);

    }


















    
}
