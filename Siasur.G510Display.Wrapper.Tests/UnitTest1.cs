using System;
using System.Diagnostics;
using System.Threading;
using Siasur.G510Display.Wrapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Siasur.G510Display.Wrapper.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Test = LcdConnector.LogiLcdInit("UnitTest", LcdConnector.LOGI_LCD_TYPE_MONO);

            Debug.WriteLine("break");

            bool done = false;

            int counter = 0;
            long lastTime = DateTime.Now.Ticks/TimeSpan.TicksPerMillisecond;

            while (!done)
            {
                LcdConnector.LogiLcdUpdate();

                if (DateTime.Now.Ticks/TimeSpan.TicksPerMillisecond - lastTime >= 1000)
                {
                    lastTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                    LcdConnector.LogiLcdMonoSetText(2, $"FPS: {counter}");
                    counter = 0;
                }
                
                LcdConnector.LogiLcdMonoSetText(1, counter++.ToString());

                Thread.Sleep(1000/60);
            }

        }
    }
}
