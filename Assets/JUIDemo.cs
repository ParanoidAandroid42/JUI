using JLibrary.JUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUIDemo : MonoBehaviour
{
    private int _counter = 0;

    public void Counter()
    {
        _counter++;
        UIManager.FindText("CounterText").Text = _counter.ToString();
    }
    public void RandomColor()
    {
        UIManager.FindImage("RandomColorImage").ImageComponent.color = Random.ColorHSV();
    }
}
