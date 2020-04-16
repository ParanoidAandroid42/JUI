#if UNITY_EDITOR
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace JLibrary.JUI
{
    [ExecuteInEditMode]
    public class UIManagerEditor : MonoBehaviour
    {
        private List<string> _componentName = new List<string>();
        private bool _emptyControl = false;
        private void Update()
        {
            if (!Application.isPlaying)
            {
                _componentName.Clear();
                Run(transform);
            }
        }
        private void Run(Transform child)
        {
            if (child == null)
                return;

            CheckComponent(child);
            CheckName(child);

            for (int i = 0; i < child.childCount; i++)
                Run(child.GetChild(i));
        }
        private void CheckName(Transform t)
        {
            if (_componentName.Contains(t.name))
            {
                t.name += $"( {Guid.NewGuid().ToString()} )";
            }
            _componentName.Add(t.name);
        }
        private void CheckComponent(Transform c)
        {
            ButtonControl(c);
            ImageControl(c);
            TextControl(c);
            if (!_emptyControl)
            {
                EmptyControl(c);
            }
            _emptyControl = false;
        }
        private void EmptyControl(Transform c)
        {
            JEmpty je = c.GetComponent<JEmpty>();

            if (je == null)
                c.gameObject.AddComponent<JEmpty>();
        }
        private void DeleteEmpty(Transform c)
        {
            JEmpty je = c.GetComponent<JEmpty>();
            if (je != null)
            {
                DestroyImmediate(je);
            }
        }
        private void ButtonControl(Transform c)
        {
            Button b = c.GetComponent<Button>();

            if (b != null)
            {
                JButton jb = c.GetComponent<JButton>();

                if (jb == null)
                    c.gameObject.AddComponent<JButton>();

                _emptyControl = true;
                DeleteEmpty(c);
            }

        }
        private void ImageControl(Transform c)
        {
            Image i = c.GetComponent<Image>();

            if (i != null)
            {
                JImage ji = c.GetComponent<JImage>();

                if (ji == null)
                    c.gameObject.AddComponent<JImage>();

                _emptyControl = true;
                DeleteEmpty(c);
            }

        }
        private void TextControl(Transform c)
        {
            Text t = c.GetComponent<Text>();

            if (t != null)
            {
                JText jt = c.GetComponent<JText>();

                if (jt == null)
                    c.gameObject.AddComponent<JText>();

                _emptyControl = true;
                DeleteEmpty(c);
            }
        }
    }
}

#endif