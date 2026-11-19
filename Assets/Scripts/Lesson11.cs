using UnityEngine;
using System.Collections.Generic;

public class Lesson11 : MonoBehaviour
{
    [ContextMenu("배열")]
    void ArrayLoop()
    {
        int[] scores = { 90, 75, 60, 88 };
        int sum = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }
        Debug.Log("합 " + sum);
        Debug.Log("평균 " + (float)sum / scores.Length);
    }

    [ContextMenu("예측 1")]
    void Predict1()
    {
        int[] hp = { 10, 20, 30 };
        hp[1] = hp[0] + hp[2];
        Debug.Log(hp[1]);
        Debug.Log(hp.Length);
        int[] copy = hp;
        copy[0] = 99;
        Debug.Log(hp[0]);
        int a = hp[2];
        a = 0;
        Debug.Log(hp[2]);
    }




    [ContextMenu("추가 비교")]
    void AddCompare()
    {
        int[] arr = { 10, 20 };
        int[] bigger = new int[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            bigger[i] = arr[i];
        }
        bigger[arr.Length] = 30;
        arr = bigger;

        List<int> list = new List<int> { 10, 20 };
        list.Add(30);
        Debug.Log(arr.Length + " " + list.Count);
    }

    [ContextMenu("foreach")]
    void ForEach()
    {
        string[] names = { "슬라임", "고블린", "보스" };
        foreach (string name in names)
        {
            Debug.Log(name);
        }
    }





    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
