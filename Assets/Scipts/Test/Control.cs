using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    public Text counter;

    private int final1 = 0;
    private int final2 = 0;
    private int final3 = 0;
    private int final4 = 0;

    private int number = 0;
    public List<GameObject> questions = new List<GameObject>();

    public void next()
    {
        if(questions.Count != number + 1)
        {
            questions[number].SetActive(false);
            questions[number + 1].SetActive(true);
            number++;


            counter.text = number + 1 + "/15";


        }
        else
        {
            questions[number].SetActive(false);
            Debug.Log("Hello");
        }
    }

    public void Final1()
    {
        final1++;
        next();
    }
    public void Final2()
    {
        final2++;
        next();
    }
    public void Final3()
    {
        final3++;
        next();
    }
    public void Final4()
    {
        final4++;
        next();
    }
}
