using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    public Text counter;
    private int final = 0;

    public List<GameObject> end = new List<GameObject>();

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
            if (final >= 14)
                end[0].SetActive(true);
            else if (final >= 7)
                end[1].SetActive(true);
            else if (final <= 7)
                end[2].SetActive(true);
            else if (final == 0)
                end[3].SetActive(true);
        }
    }

    public void Final1()
    {
        final++;
        next();
    }
    


    public void restart()
    {
        SceneManager.LoadScene("HelloWindow");
    }
}
