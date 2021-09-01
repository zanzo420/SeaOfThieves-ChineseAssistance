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
        private static bool dgState = false;
        private static bool bhopState = false;
        private static bool AFKState = false;
        private static bool CannonState = false;
        private static bool LootState = false;

        private static Form1 Access;
        #endregion

        #region Imports
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vkCode);
        [DllImport("InputSimulator.dll")]
        private static extern void MouseEvent(bool aLeftOrRight, bool aDownOrUp, int x, int y);
        [DllImport("InputSimulator.dll")]
        private static extern void SpecificKey(bool aDownOrUp, int vkCode);
        [DllImport("InputSimulator.dll")]
        private static extern void MouseInterpolation(int x, int y, int speed);
        [DllImport("InputSimulator.dll")]
        private static extern void SpecificExtendedKey(bool aDownOrUp, int vkCode);
        #endregion

        #region INTERFACE
        public static void setAccess(Form1 aAccess) // De obnasaj se 
        {
            Access = aAccess;
        }

        public static bool toggleState(string type) // switch stavek
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
            if (type == "DoubleGun")
            {
                dgState = !dgState;
                if (dgState)
                {
                    Thread t = new Thread(new ThreadStart(Script.ThreadDoubleGun));
                    t.Start();
                }
                return dgState;
            }
            if (type == "Bhop")
            {
                bhopState = !bhopState;
                if (bhopState)
                {
                    Thread t = new Thread(new ThreadStart(Script.ThreadBhop));
                    t.Start();
                }
                return bhopState;
            }
            if (type == "AFK")
            {
                AFKState = !AFKState;
                if (AFKState)
                {
                    Thread t = new Thread(new ThreadStart(Script.ThreadAFK));
                    t.Start();
                }
                return AFKState;
            }
            if (type == "Cannon")
            {
                CannonState = !CannonState;
                if (CannonState)
                {
                    Thread t = new Thread(new ThreadStart(Script.ThreadAutoCannon));
                    t.Start();
                }
                return CannonState;
            }
            if (type == "Loot")
            {
                LootState = !LootState;
                if (LootState)
                {
                    Thread t = new Thread(new ThreadStart(Script.ThreadAutoLoot));
                    t.Start();
                }
                return LootState;
            }
            else return false;
        }
        #endregion

        #region THREADING
        private static void ThreadDoubleGun()
        {
            Model currentValues = new Model();
            Access.readValues(currentValues);
            while (dgState)
            {
                bool da = false, dd = false, dw = false;
                Thread.Sleep(currentValues.listenFrequency);
                if ((GetAsyncKeyState(currentValues.dgKeyStroke) & 0x8000) == 0x8000)
                {
                    if ((GetAsyncKeyState(0x41) & 0x8000) == 0x8000)
                    {
                        SpecificKey(true, 0x41);
                        da = true;
                    }
                    if ((GetAsyncKeyState(0x44) & 0x8000) == 0x8000)
                    {
                        SpecificKey(true, 0x44);
                        dd = true;
                    }
                    if ((GetAsyncKeyState(0x53) & 0x8000) == 0x8000)
                        SpecificKey(true, 0x53);

                    if ((GetAsyncKeyState(0x57) & 0x8000) == 0x8000)
                    {
                        SpecificKey(true, 0x57);
                        dw = true;
                    }

                    Access.readValues(currentValues);

                    SpecificKey(false, currentValues.switchKeyStroke);// Push switch
                    Thread.Sleep(5);
                    SpecificKey(false, 0x57); // Press W
                    Thread.Sleep(100);
                    SpecificExtendedKey(false, 0xA0); // Push sprint
                    Thread.Sleep(5);
                    SpecificKey(true, currentValues.switchKeyStroke); // release switch
                    
                    Thread.Sleep(currentValues.switchDelay);

                    if(currentValues.aimKeyStroke != 0x02)
                        SpecificKey(false, currentValues.aimKeyStroke); // aim
                    else
                        MouseEvent(true, false, 0, 0); // Press right 
                    Thread.Sleep(5);
                    if (!dw)
                        SpecificKey(true, 0x57); // release W
                    if (da)
                    {
                        SpecificKey(false, 0x41); Thread.Sleep(5);
                    }
                    if (dd)
                    {
                        SpecificKey(false, 0x44); Thread.Sleep(5);
                    }   
                    Thread.Sleep(currentValues.adsDelay);

                    if (currentValues.fireKeyStroke != 0x01) 
                        SpecificKey(false, currentValues.fireKeyStroke); // fire
                    else
                        MouseEvent(false, false, 0, 0); // Press left
                    Thread.Sleep(25);
                    MouseEvent(false, true, 0, 0); Thread.Sleep(15);// release left
                    MouseEvent(true, true, 0, 0); Thread.Sleep(5); // release right
                    SpecificExtendedKey(true, 0xA0); Thread.Sleep(5); // release sprint

                    Thread.Sleep(100); // Fat fingers
                }
            }
        }
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
                    MouseEvent(true, false, 0, 0); // Press right 
                    Thread.Sleep(currentValues.blockDelay); // Wait for block delay
                    MouseEvent(false, false, 0, 0); // Press left
                    Thread.Sleep(currentValues.jumpDelay); // Wait for jump delay
                    SpecificKey(false, 0x20); // Press space
                    Thread.Sleep(10); // Wait for 10 ms to not overload sendinput
                    MouseEvent(true, true, 0, 0); // release right
                    Thread.Sleep(10);
                    MouseEvent(false, true, 0, 0); // release left
                    Thread.Sleep(10);
                    SpecificKey(true, 0x20); // release space

                    Thread.Sleep(100); // Fat fingers
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
                    SpecificKey(false, 0x57); // Press W
                    Access.readValues(currentValues);

                    SpecificKey(false, currentValues.dropKeyStroke); // Push drop
                    MouseInterpolation(0, currentValues.mouseDistance, currentValues.mouseSpeed);// Look down
                    Thread.Sleep(currentValues.dropDelay); // Wait for drop delay

                    SpecificKey(true, currentValues.dropKeyStroke); // Pull drop
                    SpecificExtendedKey(false, 0xA0);
                    Thread.Sleep(currentValues.runDelay); // Wait for run delay

                    SpecificKey(false, currentValues.useKeyStroke); // Push use
                    MouseInterpolation(0, currentValues.mouseDistance * (-1), currentValues.mouseSpeed);// Look down
                    Thread.Sleep(currentValues.useDelay); // Wait for use delay

                    SpecificKey(true, currentValues.useKeyStroke); // Pull use
                    SpecificExtendedKey(true, 0xA0);
                    if ((GetAsyncKeyState(currentValues.moveKeyStroke) & 0x8000) != 0x8000)
                        SpecificKey(true, 0x57); // release W if loop is over
                }
            }
        }

        private static void ThreadBhop()
        {
            Model currentValues = new Model();
            Access.readValues(currentValues);
            while (bhopState)
            {
                Thread.Sleep(currentValues.listenFrequency/4);
                if ((GetAsyncKeyState(currentValues.bhopStateKeyStroke) & 0x8000) == 0x8000)
                {
                    Access.readValues(currentValues);
                    SpecificKey(false, 0x20); // Press Space
                    Thread.Sleep(5);
                    SpecificKey(true, 0x20);
                }
            }
        }

        private static void ThreadAFK()
        {
            while (AFKState)
            {
                Thread.Sleep(5000);
                SpecificKey(false, 0x20); // Jump
                Thread.Sleep(50);
                SpecificKey(true, 0x20);
            }
        }

        private static void ThreadAutoCannon()
        {
            Model currentValues = new Model();
            Access.readValues(currentValues);
            while (CannonState)
            {
                Thread.Sleep(currentValues.listenFrequency);
                if ((GetAsyncKeyState(currentValues.CannonStateKeyStroke) & 0x8000) == 0x8000)
                {
                    SpecificKey(true, currentValues.reloadKeyStroke);
                    Access.readValues(currentValues);


                    if (currentValues.fireKeyStroke != 0x01)
                        SpecificKey(false, currentValues.fireKeyStroke); // fire
                    else
                        MouseEvent(false, false, 0, 0); // Press left
                    Thread.Sleep(5);
                    MouseEvent(false, true, 0, 0);
                    if (currentValues.fireKeyStroke != 0x01)
                        SpecificKey(false, currentValues.fireKeyStroke); // fire
                    else
                        MouseEvent(false, false, 0, 0); // Press left
                    Thread.Sleep(5);
                    MouseEvent(false, true, 0, 0);

                    Thread.Sleep(2);
                    SpecificKey(false, currentValues.reloadKeyStroke);
                    Thread.Sleep(currentValues.reloadDelay);
                }
            }
        }

        private static void ThreadAutoLoot()
        {
            Model currentValues = new Model();
            Access.readValues(currentValues);
            while (LootState)
            {
                Thread.Sleep(currentValues.listenFrequency);
                if ((GetAsyncKeyState(currentValues.autoLootKeyStroke) & 0x8000) == 0x8000)
                {
                    Access.readValues(currentValues);
                    SpecificKey(false, currentValues.useKeyStroke);
                    Thread.Sleep(currentValues.listenFrequency / 4);
                    SpecificKey(true, currentValues.useKeyStroke);
                    Thread.Sleep(currentValues.listenFrequency / 4);
                }
            }
        }

        #endregion
    }
}
