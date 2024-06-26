using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMan : MonoBehaviour
{
    public int healthPoint { get; set; }

    protected int hp = 100;
    public float attackPower = 5.5f;
    public string myName = "검객";

    // 생성자 함수(Constructor)
    //public SwordMan(int health, float atk, string nickName)
    //{
    //    hp = health;
    //    attackPower = atk;
    //    myName = nickName;
    //}



    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public virtual void Move()
    {
        print(myName + "(이)가 이동합니다!");
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

    public int GetHP()
    {
        return hp;
    }

    public void SetHP(int health)
    {
        hp = health;
    }
}
