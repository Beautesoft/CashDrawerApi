using System;
using System.IO.Ports;

public class CashDrawerService
{
    private readonly string _portName;

    public CashDrawerService(string portName)
    {
        _portName = portName;
    }

    public void TriggerCashDrawer()
    {
        using (var serialPort = new SerialPort(_portName, 9600))
        {
            serialPort.Open();
            serialPort.WriteLine("echo hello > COM3\n");
        }
    }
}
