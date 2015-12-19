using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskUnmanaged;

namespace Sample01_UnmanagedFunctions
{
	[TestClass]
	public class SimpleUnmanagedFunctionCall
	{

        [TestMethod]
        public void TestMethod1()
        {
            var liba = (IPowrProfLibaCall)new PowrProfLibaCall();

            Console.WriteLine(
                liba.LastSleepTime());

            Console.WriteLine(
                liba.LastWakeTime());
            Console.WriteLine(
                liba.SystemReserveHiberFile(true));
            Console.WriteLine(
                liba.SystemReserveHiberFile(false));

            Console.WriteLine(liba.SystemBatteryState());

            Console.WriteLine(liba.SystemPowerInfo());

        }
	}
}
