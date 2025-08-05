using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorswitchtry : MonoBehaviour
{
    public void blue()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
    public void Green()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
}
