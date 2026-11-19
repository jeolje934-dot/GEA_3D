using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    public int[] golds = { 300, 1200, 50, 800 };
    [ContextMenu("배열 실습")]
    void ShowGolds()
    {
        int total = 0;
        for (int i = 0; i < golds.Length; i++)
        {
            Debug.Log(i + "번: " + golds[i]);
            total += golds[i];
        }
        Debug.Log("합계 " + total);
    }


    [ContextMenu("예측 2")]
    void Predict2()
    {
        List<int> nums = new List<int>();
        nums.Add(5);
        nums.Add(3);
        nums.Add(5);
        nums.Remove(5);
        Debug.Log(nums.Count);
        Debug.Log(nums[0]);
        nums.RemoveAt(0);
        Debug.Log(nums[0]);
        Debug.Log(nums.Contains(3));
    }



    

}

