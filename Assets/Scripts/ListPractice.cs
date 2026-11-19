using System.Collections.Generic;
using UnityEngine;

public class ListPractice : MonoBehaviour
{
    [ContextMenu("List 실습")]
    void ShowInventory()
    {
        List<string> inventory = new List<string>();
        inventory.Add("포션");
        inventory.Add("화살");
        inventory.Remove("포션");
        inventory.Add("열쇠");

        Debug.Log("아이템, 열쇠 ");
    }
}
