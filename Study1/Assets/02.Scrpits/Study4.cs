using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study4 : MonoBehaviour
{
    void Start()
    {
        Animal jack = new Animal();
        jack.name = "dog";
        jack.sound = "�п�";
        jack.weight = 4.5f;

        Animal nate = new Animal();
        nate.name = "cat";
        nate.sound = "�Ŀ�";
        nate.weight = 3.5f;

        Animal annie = new Animal();
        annie.name = "����";
        annie.sound = "����";
        annie.weight = 30.5f;

        nate = jack;

        nate.name = "����";

        Debug.Log(jack.name);
        Debug.Log(jack.sound);

        Debug.Log(nate.name);
        Debug.Log(nate.sound);

        Debug.Log(annie.name);
        Debug.Log(annie.sound);

    }


}


public class Animal
{
    public  string name;
    public string sound;
    public float weight;


}