using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMan : MonoBehaviour
{
    public int hp = 100;
    public float attackPower = 5.5f;
    string name = "검객";


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Move()
    {
        print("이동한다!");
    }

    public float Attack(string targetName)
    {
        print(targetName + "에게 " + attackPower.ToString() + "만큼 피해를 줍니다!");
        return attackPower;
    }

    void Die()
    {
        print("사망했습니다.");
    }
}
