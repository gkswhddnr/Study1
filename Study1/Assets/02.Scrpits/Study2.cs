using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //����ȯ ĳ����

        int height = 170;
        float heightDetail = 170.3f;

        // �ڵ� ����ȯ (�Ҿ������ ������ ������)
        heightDetail = height;

        // ���� ����ؾ� �ϴ� ���(�Ҿ������ ������ ������) ex) height = heightDetail;
        height = (int)heightDetail;

        //���ǹ� if��

        //switch �б⹮ 

        int year = 2023;

        switch(year)
        {
            case 2013:
                Debug.Log("�ʵ�");
                break;
            case 2016:
                Debug.Log("�ߵ�");
                break;
            case 2019:
                Debug.Log("���");
                break;
            case 2023:
                Debug.Log("����");
                break;

            default:
                Debug.Log("���� �׋���");
                break;


        }


        //������ Loop �ݺ�����


        // for �� for(�ʱ�ȭ; ����; ������Ʈ)
        for (int i = 1; i < 10; i++)
        {
            Debug.Log("���� ������:" + i);



        }
        Debug.Log("for�� Ż��");

        bool Shot = false;
        int index = 0;
        int number = 4;
        while (Shot == false)
        {
            index = index + 1;
            if (index == number)
            {
                Debug.Log("�Ѿ��� �߻�ƴ�");
                Shot = true; 
            }
            else
            {
                Debug.Log("�Ѿ��� �ȳ�����");
            }
        }

        do
        {
            Debug.Log("Do While���� ������ �����ǵ� ���ϵ� �ϴ� �ѹ��� ������ �����Ѵ�");
        } while (Shot == false);



    }


}
