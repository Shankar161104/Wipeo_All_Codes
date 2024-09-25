using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Practice_Abstract_Eg
{
    public class Program
    {
        static void Main(string[] args)
        {
            WindowsFaxctory objWindows= new WindowsFaxctory();
            IButton objIButton = objWindows.GetAbstractButton();
            ICheckBox objICheckBox = objWindows.GetAbstractCheckBox();
            Console.WriteLine($"Windows Button::{objIButton.GetButton()}");
            Console.WriteLine($"Windows CheckBox::{objICheckBox.GetCheckBox()}");


        }
    }
}
