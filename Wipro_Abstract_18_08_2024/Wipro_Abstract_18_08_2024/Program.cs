using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Abstract_18_08_2024
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======WINDOWS FACTORY==========");
            
            WindowsFactory objWindows = new WindowsFactory();
            IButton objIButton = objWindows.CreateButton();
            IMenu objIMenu = objWindows.CreateMenu();
            IDialog objIDialog = objWindows.CreateDialog();
            objIButton.Render();
            objIButton.OnClick();

            objIMenu.Show();
            objIMenu.Hide();
            objIMenu.AddMenuItem("lodu");
            Console.WriteLine("======LINUX FACTORY==========");


            LinuxFactory objLinux = new LinuxFactory();
            objIButton = objLinux.CreateButton();
            objIMenu = objLinux.CreateMenu();
            objIDialog = objLinux.CreateDialog();
            objIButton.Render();
            objIButton.OnClick();
        }
    }

    public interface IButton
    {
        void Render();
        void OnClick();
    }

    public interface IMenu
    {
        void Show();
        void Hide();
        void AddMenuItem(string item);

    }
    public interface IDialog
    {
        void Open();
        void Close();

    }

    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Windows Button Rendered");
        }
        public void OnClick()
        {
            Console.WriteLine("Windows Button Clicked");
        }

    }

    public class LinuxButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Linux Button rendered");
        }
        public void OnClick()
        {
            Console.WriteLine("Linux Button Clicked");
        }

    }

    public class MacOSUIButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("MacOSUI Button Rendered");
        }
        public void OnClick()
        {
            Console.WriteLine("MacOSUI button Clicked");
        }

    }
    public class WindowsMenu : IMenu
    {
        public void Show()
        {
            Console.WriteLine("Windows Menu is being shown");
        }
        public void Hide()
        {
            Console.WriteLine("windows menu is being hidden");
        }
        public void AddMenuItem(string item)
        {
            Console.WriteLine($"{item} is added into Windows menu");
        }

    }

    public class LinuxMenu : IMenu
    {
        public void Show()
        {
            Console.WriteLine("Linux Menu is being shown");
        }
        public void Hide()
        {
            Console.WriteLine("Linux menu is bein Hidden");
        }
        public void AddMenuItem(string item)
        {
            Console.WriteLine($"{item} is added to Linux menu");
        }

    }

    public class MacOSUIMenu : IMenu
    {
        public void Show()
        {
            Console.WriteLine("MacOSUI Menu is being shown");
        }
        public void Hide()
        {
            Console.WriteLine("MacOSUI menu is bein Hidden");
        }
        public void AddMenuItem(string item)
        {
            Console.WriteLine($"{item} is added to MacOSUI menu");
        }

    }

    public class WindowsDialog : IDialog
    {

        public void Open()
        {
            Console.WriteLine("Windows dialog Opened");
        }
        public void Close()
        {
            Console.WriteLine("Windows dialog closed");
        }

    }

    public class LinuxDialog : IDialog
    {

        public void Open()
        {
            Console.WriteLine("Linux dialog Opened");
        }
        public void Close()
        {
            Console.WriteLine("Linux dialog closed");
        }


    }

    public class MacOSUIDialog : IDialog
    {

        public void Open()
        {
            Console.WriteLine("MacOSUI dialog Opened");
        }
        public void Close()
        {
            Console.WriteLine("MacOSUI dialog closed");
        }



    }

    public interface IAbstractFactory
    {
        IButton CreateButton();
        IMenu CreateMenu();
        IDialog CreateDialog();
    }

    public class WindowsFactory : IAbstractFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }
        public IMenu CreateMenu()
        {
            return new WindowsMenu();
        }
        public IDialog CreateDialog()
        {
            return new WindowsDialog();
        }
    }

    public class LinuxFactory : IAbstractFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }
        public IMenu CreateMenu()
        {
            return new LinuxMenu();
        }
        public IDialog CreateDialog()
        {
            return new LinuxDialog();
        }
    }
    public class MacOSUIFactory : IAbstractFactory
    {
        public IButton CreateButton()
        {
            return new MacOSUIButton();
        }
        public IMenu CreateMenu()
        {
            return new MacOSUIMenu();
        }
        public IDialog CreateDialog()
        {
            return new MacOSUIDialog();
        }
    }

}
