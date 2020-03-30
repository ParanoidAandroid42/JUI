using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace JLibrary.JUI
{
    public class UIController : UICanvas
    {
        public static UIController Instance = null;

        private new void Start()
        {
            base.Start();
            Instance = this;
        }
        public override void Run()
        {
            base.Run();
        }
        private JUI FindComponent(string componentName, WhichElement whichElement)
        {
            Elements e = UIElements[componentName];

            if (e != null)
                return e.WhichElement[whichElement];

            return null;
        }
        public static JUI FindUIComponent(string componentName, WhichElement whichElement)
        {
           return Instance.FindComponent(componentName, whichElement);
        }
    }
}

