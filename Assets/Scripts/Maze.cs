using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : SwordMan
{
    void Start()
    {
        //MoveForward();
        //MoveForward();
        Move();
    }

    void Update()
    {
        
    }

    public override void Move()
    {
        base.Move();

        print("먼지가 발생합니다.");
    }

    
}
