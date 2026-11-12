using UnityEngine;

public class DamagePractice : MonoBehaviour
{
    public float attack;
    public float defense;

    //swtich : 값별 분기
    [ContextMenu("무기")]
    void Weapon()
    {
        int weaponld = 2;
        switch (weaponld)
        {
            case 1:
                Debug.Log("검");
                break;
            case 2:
            default:
                Debug.Log("맨손");
                break;
        }
    }


    // switch : case 묶기 
    [ContextMenu("무기 종류")]
    void WeaponType()
    {
        int weaponld = 2;
        switch (weaponld)
        {
            case 1:
            case 2:

                Debug.Log("근접 무기");
                   break;
            case 3:
                Debug.Log("원거리 무기");
                break;
        }
    }


    

    [ContextMenu("for")]
    void ForBasic()
    {
        for (int i =0; i< 5;i ++)
        {
            Debug.Log(i);
        }
    }

    [ContextMenu("예측 3")]
    void Predict3()
    {
        for (int i = 0; i < 3; i++) Debug.Log(i);
        for (int i = 1; i <= 10; i += 3) Debug.Log(i);
        for (int i = 5; i > 0; i -= 2) Debug.Log(i);
        int sum = 0;
        for (int i = 1; i <= 4; i++) sum += i;
        Debug.Log(sum);


    }

    [ContextMenu("레벨업")]
    void LevelUp()
    {
        int level = 1;
        int exp = 45000;
        while (exp >= level * 10000)
        {
            exp -= level * 10000;
            level++;
        }
        Debug.Log(level + "" + exp);
    }


    [ContextMenu("예측 4")]
    void Predict4()
    {

        for (int i =1; i <=10; i++)
        {
            if (i % 3 == 0) continue;
            if (i > 7) break;
            Debug.Log(i);
        }
        int n = 0;
        while (n <= 10) n += 4;
        Debug.Log(n);
    }

    [ContextMenu("격자")]
    void Grid()
    {
        string text = "";
        for (int row =1; row <= 2; row++)
        {
            for (int col =1; col <= 3; col++)
            {
                text += row + "-" + col + "";
            }
            text+= "\n";
        }
        Debug.Log(text);
    }

    public int height = 3;
    public string result;


    [ContextMenu("계단")]
    void Stairs()
    {
        int height = 3;
        string result = "";
        for (int row =1; row <= height; row++)
        {
            for (int col = 0; col < row; col++)
            {
                result += "*";
            }
            result += "/n";
        }
        Debug.Log(result);
    }

    [ContextMenu("뒤집힌 계단")]
    void ReverseStairs()
    {
        int height = 4;
        string result = "";
        for (int row = height; row > 0; row--)
        {
            for (int i =0;i<row; i++)
            {
                result += "*";
            }
            result += "\n";
        }
        Debug.Log(result);
    }


    [ContextMenu("오른쪽 계단")]
    void RightStairs()
    {
        int heignt = 4;
        string result = "";
        for (int row =1; row <= heignt; row++)
        {
            int spaceCount = heignt- row;
            int starCount = row;
            for (int i =0; i < spaceCount; i++)
            {
                result += "";
            }
            for (int i =0; i< starCount; i++)
            {
                result += "*";
            }
            result += "\n";
        }
        Debug.Log(result);
    }


    
    

    [ContextMenu("트리")]
    void Tree()
    {

    }




}
