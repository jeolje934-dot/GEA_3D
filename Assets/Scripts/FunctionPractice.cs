using UnityEngine;

public class FunctionPractice : MonoBehaviour
{
    
    string GetGrade(int Score)
    {
        if (Score >= 90) return "A";
        if (Score >= 70) return "B";
        return "C";

    }
    [ContextMenu("함수실습")]
    void ShowGrades()
    {
        Debug.Log("95점:" + GetGrade(95));
        Debug.Log("70점:" + GetGrade(70));
        Debug.Log("10점:" + GetGrade(10));

    }

    [ContextMenu("메서드")]
    void UseMethods()
    {
        Monster slime = new Monster();
        slime.name = "슬라임";
        slime.hp = 30;
        Monster goblin = new Monster();
        goblin.hp = 50;

        slime.TakeDamage(45);
        goblin.TakeDamage(45);
        Debug.Log(slime.hp + "" + slime.IsDead());
        Debug.Log(goblin.hp + "" + goblin.IsDead());

    }

   
}
