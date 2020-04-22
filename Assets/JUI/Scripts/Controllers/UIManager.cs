using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace JLibrary.JUI
{
    public class UIManager : UIManagerBase
    {
        public static UIManager Instance = null;

        protected override void Start()
        {
            base.Start();
            Instance = this;
        }
        public override void Run()
        {
            base.Run();
        }

        //JUI
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

        ///Button
        private JButton FindJButton(string componentName)
        {
            Elements e = UIElements[componentName];

            if (e != null)
                return (JButton)e.WhichElement[WhichElement.Button];

            return null;
        }

        public static JButton FindButton(string componentName)
        {
            return Instance.FindJButton(componentName);
        }

        //Image
        private JImage FindJImage(string componentName)
        {
            Elements e = UIElements[componentName];

            if (e != null)
                return (JImage)e.WhichElement[WhichElement.Image];

            return null;
        }

        public static JImage FindImage(string componentName)
        {
            return Instance.FindJImage(componentName);
        }

        //JText
        private JText FindJText(string componentName)
        {
            Elements e = UIElements[componentName];

            if (e != null)
                return (JText)e.WhichElement[WhichElement.Text];

            return null;
        }

        public static JText FindText(string componentName)
        {
            return Instance.FindJText(componentName);
        }

        // Empty

        private JEmpty FindJEmpty(string componentName) 
        {
            Elements e = UIElements[componentName];

            if (e != null)
                return (JEmpty)e.WhichElement[WhichElement.Empty];

            return null;
        }

        public static JEmpty FindEmpty(string componentName)
        {
            return Instance.FindJEmpty(componentName);
        }

    }
}

