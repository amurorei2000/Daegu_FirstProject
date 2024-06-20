using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCoding : MonoBehaviour
{
    public int age1 = 15;
    public int age2 = 7;
    public bool isMan = true;
    public bool runState;
    public bool walkState;

    void Start()
    {
        // <조건문 작성법>
        // if(조건식)
        // {
        //   조건이 참일 때 해야할 일
        // }
        // else if(조건식)
        // {
        //   두 번째 조건식이 참일 때 해야할 일
        // }
        // else
        // {
        //   앞에 있는 모든 조건들이 다 성립하지 않을 때 해야할 일
        // }


        #region Example 1
        //if (age1 == age2)
        //{
        //    print("age1이 age2보다 나이가 같습니다.");
        //}

        //if (age1 > age2)
        //{
        //    print("age1이 age2보다 나이가 많습니다.");
        //}

        //if (age1 < age2)
        //{
        //    print("age1이 age2보다 나이가 어립니다.");
        //}

        //if (age1 != age2)
        //{
        //    print("age1은 age2와 나이가 서로 다릅니다.");
        //}

        // age1의 나이를 기준으로 10대부터 40대까지 어느곳에 해당하는지를 출력한다.
        // 예) "age1은 30대 입니다."
        //if (age1 < 20)
        //{
        //    print("age1은 10대입니다.");
        //}
        //else if (age1 < 30)
        //{
        //    print("age1은 20대입니다.");
        //}
        //else if (age1 < 40)
        //{
        //    print("age1은 30대입니다.");
        //}
        //else if (age1 < 50)
        //{
        //    print("age1은 40대입니다.");
        //}
        //else
        //{
        //    print("age1의 나이는 50세 이상입니다");
        //}

        //if(age1 >= 20)
        //{
        //    print("age1의 나이는 20살 이상입니다.");
        //}
        //else
        //{
        //    print("age1의 나이는 20살 미만입니다.");
        //}
        #endregion

        #region Example 2
        // 1. And 조건
        // 만일, 성별이 여성이고 나이가 20살 이상일 경우
        // "성인 여성입니다"라고 출력한다.
        //if(isMan == false && age1 >= 20)
        //{
        //    print("성인 여성입니다.");
        //}
        //else
        //{
        //    print("미성년자이거나, 남성입니다");
        //}

        // 2. Or 조건
        // 만일, 움직이는 경우라면 "이동 중입니다."라고 출력하고,
        // 그렇지 않으면, "정지한 상태입니다."라고 출력한다.
        if(runState == true || walkState == true)
        {
            print("이동 중입니다.");
        }
        else
        {
            print("정지한 상태입니다.");
        }

        // bool 변수를 조건문의 조건으로 넣었을 때 생략 방법
        //if(runState == true)
        //if(runState)

        //if(runState == false)
        //if(!runState)

        #endregion
    }

    void Update()
    {
        
    }
}
