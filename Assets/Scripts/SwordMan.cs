using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMan : MonoBehaviour
{
    public int hp = 100;
    public float attackPower = 5.5f;
    public string myName = "�˰�";

    // ������ �Լ�(Constructor)
    public SwordMan(int health, float atk, string nickName)
    {
        hp = health;
        attackPower = atk;
        myName = nickName;
    }



    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Move()
    {
        print(myName + "(��)�� �̵��մϴ�!");
    }

    public float Attack(string targetName)
    {
        print(targetName + "���� " + attackPower.ToString() + "��ŭ ���ظ� �ݴϴ�!");
        return attackPower;
    }

    void Die()
    {
        print("����߽��ϴ�.");
    }
}
