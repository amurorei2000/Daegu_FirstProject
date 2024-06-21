using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    SwordMan fighter;
    int number = 10;
    Transform trans;

    void Start()
    {
        fighter = new SwordMan();

        fighter.Move();
        fighter.hp = 200;
        fighter.attackPower = 10;
        fighter.Attack("플레이어");

    }

    void Update()
    {
        
    }
}
