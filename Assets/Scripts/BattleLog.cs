using UnityEngine;
using System.Collections.Generic;

public class BattleLog : MonoBehaviour
{
    public int[] damage = { 1200, 3500, 800, 12000, 3500, 950 };
    public int criticalLine = 3000;

    [ContextMenu("전투 기록")]
    void ShowBattleLog()
    {
       
       
        foreach (int damage in damage )
        {
            if ( damage > criticalLine)
            {
                break;
            }
        }
        Debug.Log("damage");
    }



}
