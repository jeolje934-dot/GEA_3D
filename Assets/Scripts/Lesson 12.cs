using UnityEngine;
using System.Collections.Generic;


public class Lesson12 : MonoBehaviour
{
    [ContextMenu("복사")]
    void CopyPaste()
    {
        int a = 12 - 5;
        if (a < 1) a = 1;

        int b = 3 - 10;
        if (b < 1) b = 1;
        int c = 20 - 4;
        if (c < 1) c = 1;
        Debug.Log(a + " " + b + " " + c);
    }
    int GetDamage(int attack, int defense)
    {
        int damage = attack - defense;
        if (damage < 1) return 1;
        return damage;
    }

    [ContextMenu("함수")]
    void UseFunction()
    {
        int a = GetDamage(12, 5);
        int b = GetDamage(3, 10);
        int c = GetDamage(20, 4);
        Debug.Log(a + "" + b + "" + c);
    }

    void PrintHp(int hp)
    {
        Debug.Log("Hp" + hp);

    }

    int GetHalf(int value)
    {
        return value / 2;
    }

    [ContextMenu("반환")]
    void ReturnTest()
    {
        PrintHp(GetHalf(50));
    }

    public int gold = 100;

    int AddBonus(int amount) // 매개변수 amount
    {
        int bonus = amount / 10;
        gold = gold + amount + bonus;
        return bonus;
    }
    [ContextMenu("변수와 종류")]
    void VariableKinds()
    {
        int a = AddBonus(200);
        int b = AddBonus(50);
        Debug.Log(gold + "" + a + "" + b);


    }

    int Square(int x) { return x * x; }
    void AddOne(int x) { x = x + 1; }
    void Fill(int[] arr) { arr[0] = 9; }

    [ContextMenu("예측1")]
    void Predict1()
    {
        int a = 3;
        AddOne(a);
        Debug.Log(a);
        Debug.Log(Square(a) + Square(2));
        Debug.Log(Square(Square(2)));
        int[] nums = { 1, 2 };
        Fill(nums);
        Debug.Log(nums[0]);
    }
    [ContextMenu("흩어진 값")]
    void SeparateVariables()
    {
        string[] names = { "슬라임", "고블린" };
        int[] hps = { 30, 50 };
        int[] attacks = { 5, 8 };

        hps[1] -= 20;
        Debug.Log(names[1] + " " + hps[1] + " " + attacks[1]);

    }

    [ContextMenu("예측2")]
    void Predict2()
    {
        Monster a = new Monster("슬라임", 30, 5);
        Monster b = a;
        b.hp = 10;
        Debug.Log(a.hp);
        Monster c = new Monster("슬라임", 30, 5);
        c.TakeDamage(100);
        Debug.Log(a == b);
        a = null;
        Debug.Log(b.name);
        Debug.Log(a.name);

    }
}

