using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMan : MonoBehaviour
{
    public int hp = 100;
    public float attackPower = 5.5f;
    string name = "�˰�";


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Move()
    {
        print("�̵��Ѵ�!");
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
