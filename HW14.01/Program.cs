using System;
using System.Runtime.InteropServices;

public class Program
{
    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

    static void Main()
    {
        MessageBox(IntPtr.Zero, "Мене звати Маліка", "Інформація про мене", 0);
        MessageBox(IntPtr.Zero, "Мені 18 років", "Інформація про мене", 0);
        MessageBox(IntPtr.Zero, "Я навчаюсь програмуванню та паралельно працюю веб-дизайнером та верстальником на конструкторах", "Інформація про мене", 0);
    }
}
