using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JLibrary.JUI
{
    public  class UICanvas : MonoBehaviour
    {
        public Dictionary<string, Elements> UIElements;
        protected virtual void Start()
        {
            Run();
        }

        public virtual void Run()
        {
            UIElements = new Dictionary<string, Elements>();
            Run(gameObject.transform);
        }
        private void Run(Transform child)
        {
            if (child == null)
                return;

            AddElement(child);

            for (int i = 0; i < child.childCount; i++)
                Run(child.GetChild(i));
        }

        private void AddElement(Transform t)
        {
            JUI []j = t.GetComponents<JUI>();

            if (j.Length!=0)
            {
                Elements el = new Elements();

                for (int i = 0; i < j.Length; i++)
                    el.WhichElement.Add(j[i].WhichElementEnum, j[i]);
                   

                UIElements.Add(t.name, el);
            }
        }
    }
}



