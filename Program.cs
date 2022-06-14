using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PC pc = new PC();
            Mobile mobile = new Mobile();
            pc.RAM = 50;
            pc.Status = false;
            pc.Reboot();
            pc.Show();
            mobile.Show();
        }
    }
    abstract class Device
    {
        public string keyboardcolor="Black";
        private bool status = true;
        private int ram;
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        public int RAM
        {
            get { return ram; }
            set { ram = value; }
        }
        virtual public void Show()
        {
            Console.WriteLine("Status: "+Status+ " | KeyboardColor: "+ keyboardcolor+" | Ram: "+ram+ " MB");
        }
        public void Reboot()
        {
            if (status)
            {
                status = false;
                status = true;
                Console.WriteLine("Rebooted");
            }
            else
            {
                Console.WriteLine("The device if off");
            }
        }
    }
    class PC : Device
    {

    }
    class Mobile : Device
    {
        public override void Show()
        {
            Console.WriteLine("Status: "+ Status + " | Ram: " + RAM+" MB");
        }
    }
    class Notebook : Device
    {

    }
    class Computer : Device
    {

    }
    

}
