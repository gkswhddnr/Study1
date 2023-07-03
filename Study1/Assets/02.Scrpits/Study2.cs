using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //형변환 캐스팅

        int height = 170;
        float heightDetail = 170.3f;

        // 자동 형변환 (잃어버리는 정보가 없으면)
        heightDetail = height;

        // 직접 명시해야 하는 경우(잃어버리는 정보가 있으면) ex) height = heightDetail;
        height = (int)heightDetail;

        //조건문 if문

        //switch 분기문 

        int year = 2023;

        switch(year)
        {
            case 2013:
                Debug.Log("초딩");
                break;
            case 2016:
                Debug.Log("중딩");
                break;
            case 2019:
                Debug.Log("고딩");
                break;
            case 2023:
                Debug.Log("성인");
                break;

            default:
                Debug.Log("몰라 그떄는");
                break;


        }


        //루프문 Loop 반복문들


        // for 문 for(초기화; 조건; 업데이트)
        for (int i = 1; i < 10; i++)
        {
            Debug.Log("현재 순번은:" + i);



        }
        Debug.Log("for문 탈출");

        bool Shot = false;
        int index = 0;
        int number = 4;
        while (Shot == false)
        {
            index = index + 1;
            if (index == number)
            {
                Debug.Log("총알이 발사됐다");
                Shot = true; 
            }
            else
            {
                Debug.Log("총알이 안나갔다");
            }
        }

        do
        {
            Debug.Log("Do While문은 조건이 만족되든 안하든 일단 한번은 무조건 실행한다");
        } while (Shot == false);



    }


}
