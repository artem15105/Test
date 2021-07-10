using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resolution : MonoBehaviour
{
    public Image backgrund;

    private int Width;
    private int Height;

    void Start()
    {
        Width = Screen.width;
        Height = Screen.height;
    }

    
    void Update()
    { 
        Width = Screen.width;
        Height = Screen.height;

       // backgrund.rectTransform.sizeDelta = new Vector2(Width - 128, Height - 258);
    
      //  Debug.Log(Width + " " + Height);
    }
}
