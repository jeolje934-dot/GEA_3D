using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725, gold = 1234, members = 4, kills = 7, expPerKill = 35, totalDamage = 250, hits = 20;

    public float expRate = 1.5f;

    public int playhours = 1;




    [ContextMenu("정산")]


    void Settle()
    {

        int playHour = playSeconds / 3600;
        int playMinutes = (playSeconds - 3600) / 60;
        int playSecond = playSeconds%60;
        Debug.Log("플레이 시간 " + playHour + "시" + playMinutes + "분" + playSecond + "초");


        




        int gold = 1234;
        Debug.Log("획득 골드 " + gold + "G");

        int members = 4;
        Debug.Log("사람 수" + members + " 명 ");

        int kills = 7;
        Debug.Log("킬 수" + kills + "킬");

         int expPerKill = 35;
        Debug.Log("킬 당 경험치" + expPerKill + "exp");

        int totalDamage = 250;
        Debug.Log("총 데미지" + totalDamage + "데미지");

        int hits = 20;
        Debug.Log(" 타격 수" + hits + "타격");

        float expRate = 1.5f;
        Debug.Log("경험치 배율" + expRate + "배율");




    }


    
}
