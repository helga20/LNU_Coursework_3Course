using AutoMapper;
using System;
using System.Windows;
using System.Windows.Controls;
using ZNO.BLL.Services.Interface;
using ZNO.Front.Command;
using ZNO.Front.Models;
using ZNO.Front.View;

namespace ZNO.Front.ViewModel
{
    public class MainMenuModel :ViewModel
    {

        public CalculateTime _calculateTime;

        public RelayCommand MenuCommand => new RelayCommand(Menu);
        public RelayCommand CloseWindowCommand => new RelayCommand(CloseWindow);
        public RelayCommand ResizeWindowCommand => new RelayCommand(ResizeWindow);
        public RelayCommand FloatWindowCommand => new RelayCommand(FloatWindow);
        public RelayCommand ToHomePageCommand => new RelayCommand(ToHomePage);

        public Page? Page
        {
            get
            {
                return _page;
            }
            set
            {
                _page = value;
                OnPropertyChanged("Page");
            }
        }

        private Page? _page;
        private ITimeService _timeService;

        private void Menu(object pageNumber)
        {
            ArgumentNullException.ThrowIfNull(pageNumber);
            
            switch ((int)pageNumber)
            {
                case 1:
                    {
                        Page = new MenuAlgebra();
                        break;
                    }
                case 2:
                    {
                        Page = new MenuGeometry();
                        break;
                    }
                case 3:
                    {
                        Page = new TestPage();
                        break;
                    }
                case 4:
                    {
                        Page = new AboutDevPage();
                        break;
                    }
                case 5:
                    {
                        Page = new StatisticsPage();
                        break;
                    }
                case 6:
                    {
                        this.CloseApp();
                        break;
                    }
                case 99:
                    {
                        string link = "https://testportal.gov.ua/progmath/"; 
                        try
                        {
                            System.Diagnostics.Process.Start("cmd", $"/c start {link}");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to open link: {ex.Message}");
                        }
                        break;
                    }

            }
        }

        private void FloatWindow(object sender)
        {
            Window currentWindow = Application.Current.MainWindow;
            currentWindow.WindowState = WindowState.Minimized;
        }

        private void ResizeWindow(object sender)
        {
            // Отримуємо поточне вікно
            Window currentWindow = Application.Current.MainWindow;

            if (currentWindow.WindowState == WindowState.Normal)
            {
                currentWindow.WindowState = WindowState.Maximized;
                currentWindow.WindowStyle = WindowStyle.None;
            }
            else
            {
                currentWindow.WindowState = WindowState.Normal;
                currentWindow.WindowStyle = WindowStyle.SingleBorderWindow;
            }
        }

        private void CloseWindow(object sender)
        {
            this.CloseApp();
        }

        public MainMenuModel(IMapper mapper, ITimeService timeService) : base(mapper)
        {
            _timeService = timeService;
            _calculateTime = new CalculateTime();
            _calculateTime.startProgram = DateTime.Now;
            this.ToHomePage(1);
        }
        private void CloseApp()
        {
            _calculateTime.endProgram = DateTime.Now;


            TimeSpan currentTime = _calculateTime.endProgram - _calculateTime.startProgram;
            _timeService!.SetCurrentTime(currentTime.ToString());
            Application.Current.Shutdown();
        }

        private void ToHomePage(object sender)
        {
            Page = new HomePage();
        }
    }
}
