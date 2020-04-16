using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using JLibrary.JUI;
using System;

public class JUIEditor : EditorWindow
{
    private const string _layerName = "UI";
    private const string _canvasName = "Canvas";
    private const string _uIManager = "UIManager";
    private const string _buttonName = "Button";
   

    [MenuItem("JLibrary/JUI")]
    public static void JUI()
    {
        Creator();
    }
    private static void Creator()
    {
        GameObject uIManager = CreateUIManager();
        GameObject canvas = CreateCanvas();

        canvas.transform.SetParent(uIManager.transform);
    }
    private static GameObject CreateUIManager()
    {
        Type[] types = { typeof(UIManager), typeof(UIManagerEditor) };
        return new GameObject(_uIManager, types);
    }
    private static GameObject CreateCanvas()
    {
        GameObject canvas = new GameObject(_canvasName);
        canvas.layer = LayerMask.NameToLayer(_layerName);

        Canvas c = canvas.AddComponent<Canvas>();
        c.renderMode = RenderMode.ScreenSpaceOverlay;

        canvas.AddComponent<CanvasScaler>();
        canvas.AddComponent<GraphicRaycaster>();

        return canvas;
    }
    

}
