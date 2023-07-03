using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       /* int score1 = 90;
        int score2 = 60;
        int score3 = 30;

        Debug.Log(score1);
        Debug.Log(score2);
        Debug.Log(score3); */



        // 여러개의 값을 하나의 변수로 다루게 해준다

        int[] scores = new int[10]; // scores [0] [1] [2] [3] [4] [5] [6] [7] [8] [9]

        scores[0] = 90;
        scores[1] = 91;
        scores[2] = 92;
        scores[3] = 93;
        scores[4] = 94;
        scores[5] = 95;
        scores[6] = 96;
        scores[7] = 97;
        scores[8] = 98;
        scores[9] = 99;

        // Debug.Log(scores[3]);

        for (int i = 0; i < 10; i++)
        {
            Debug.Log(scores[i]);
        }
        Debug.Log("없는 순번");
    }


}
