using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;

namespace SOTSimulator
{
    public static class Script
    {
        #region Variables
        private static bool lungeState = false;
        private static bool moveState = false;
        private static Form1 Access;
        #endregion

        #region Imports
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vkCode);
        [DllImport("InputSimulator.dll")]
        private static extern void MouseEvent(bool type);
        [DllImport("InputSimulator.dll")]
        private static extern void PressSpace();
        [DllImport("InputSimulator.dll")]
        private static extern void Look(int distance, int speed);
        [DllImport("InputSimulator.dll")]
        private static extern void pushSpecificKey(bool toggle, int vkCode);
        #endregion

        #region INTERFACE
        public static void setAccess(Form1 aAccess) // De obnasaj se 
        {
            Access = aAccess;
        }

        public static bool toggleState(string type)
        {
            if (type == "Lunge")
            {
                lungeState = !lungeState;
                if (lungeState)
                {
                    Thread t = new Thread(new ThreadStart(Script.ThreadLunge));
                    t.Start();
                }
                return lungeState;
            }
            if(type=="Move")
            {
                moveState = !moveState;
                if (moveState)
                {
                    Thread t = new Thread(new ThreadStart(Script.ThreadJuggle));
                    t.Start();
                }
                return moveState;
            }
            else return false;
        }
        #endregion


        #region THREADING
        private static void ThreadLunge()
        {
            Model currentValues = new Model();
            Access.readValues(currentValues);
            while (lungeState)
            {
                Thread.Sleep(currentValues.listenFrequency);
                if ((GetAsyncKeyState(currentValues.keyStroke) & 0x8000) == 0x8000)
                {
                    Access.readValues(currentValues);
                    MouseEvent(true); // Right click
                    Thread.Sleep(currentValues.blockDelay);

                    MouseEvent(false); // Left click
                    Thread.Sleep(currentValues.jumpDelay);

                    PressSpace(); 
                    Thread.Sleep(100);
                }
            }
        }

        private static void ThreadJuggle()
        {
            Model currentValues = new Model();
            Access.readValues(currentValues);
            while(moveState)
            {
                Thread.Sleep(currentValues.listenFrequency);
                if ((GetAsyncKeyState(currentValues.moveKeyStroke) & 0x8000) == 0x8000)
                {
                    Access.readValues(currentValues);
                    Thread.Sleep(50); // Repeat delay

                    pushSpecificKey(true, currentValues.dropKeyStroke); // Push drop
                    Look(currentValues.mouseDistance, currentValues.mouseSpeed); // Look down
                    Thread.Sleep(currentValues.dropDelay);
                    pushSpecificKey(false, currentValues.dropKeyStroke); // Pull drop


                    pushSpecificKey(true, currentValues.sprintKeyStroke); // Push sprint
                    Thread.Sleep(currentValues.runDelay);

                    pushSpecificKey(true, currentValues.useKeyStroke); // Push use
                    Look(currentValues.mouseDistance*(-1), currentValues.mouseSpeed); // Look up
                    Thread.Sleep(currentValues.useDelay);

                    pushSpecificKey(false, currentValues.useKeyStroke); // Pull use
                    pushSpecificKey(false, currentValues.sprintKeyStroke); // Pull sprint
                }
            }
        }
        #endregion
    }
}
