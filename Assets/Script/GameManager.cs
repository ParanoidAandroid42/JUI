using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JLibrary.JUI;

public class GameManager : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {
        // JButton j = UIController.Instance.UIElements["Button"] as JButton;
        // Debug.Log(j.Interactable);
        JButton jb = UIController.FindUIComponent("Button", WhichElement.Button) as JButton;
        JImage ji = UIController.FindUIComponent("Button", WhichElement.Image) as JImage;
        Debug.Log(jb.Interactable);
        Debug.Log(ji.ImageObj.color);
    }
}
