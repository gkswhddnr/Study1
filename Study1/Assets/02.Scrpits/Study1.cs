using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 변수: 값이 할당되는 이름(이름표)
// 함수: 미리 정해진 동작을 수행하는 코드 묶음
public class Study1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float CircleSize = 40;

        float r = GetRadius(CircleSize);

        Debug.Log("원의 사이즈는:" + CircleSize + "원의 반지름은:" + r);



    }

    float GetRadius(float s)
    {
        float pi = 3.14f;

        float middle = s / pi;

        float radius = Mathf.Sqrt(middle);

        return radius;

    }
}
