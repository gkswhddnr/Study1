using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ����: ���� �Ҵ�Ǵ� �̸�(�̸�ǥ)
// �Լ�: �̸� ������ ������ �����ϴ� �ڵ� ����
public class Study1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float CircleSize = 40;

        float r = GetRadius(CircleSize);

        Debug.Log("���� �������:" + CircleSize + "���� ��������:" + r);



    }

    float GetRadius(float s)
    {
        float pi = 3.14f;

        float middle = s / pi;

        float radius = Mathf.Sqrt(middle);

        return radius;

    }
}
