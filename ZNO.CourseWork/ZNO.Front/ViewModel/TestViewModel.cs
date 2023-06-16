using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZNO.DAL.Models;
using ZNO.Front.Command;
using ZNO.Front.Models;

namespace ZNO.Front.ViewModel
{
    public class TestViewModel : ViewModel
    {
        public RelayCommand OpenLinkCommand => new RelayCommand(OpenLink);
        public RelayCommand OpenLink2018Command => new RelayCommand(OpenLink2018);
        public RelayCommand OpenLink2019Command => new RelayCommand(OpenLink2019);
        public RelayCommand OpenLink2020Command => new RelayCommand(OpenLink2020);
        public RelayCommand OpenLink2021Command => new RelayCommand(OpenLink2021);

        public TestViewModel(IMapper mapper) : base(mapper)
        {

        }
        public int? NumberOfTest
        {
            get
            {
                return _num;
            }
            set
            {
                _num = value!;
                OnPropertyChanged("NumberOfTest");
            }
        }

        private int? _num;


        private void OpenLink(object sender)
        {
            string link = "https://zno.osvita.ua/mathematics/"; // zno
            try
            {
                System.Diagnostics.Process.Start("cmd", $"/c start {link}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open link: {ex.Message}");
            }
        }


        private void OpenLink2018(object sender)
        {
            string link = "https://zno.osvita.ua/mathematics/298/"; //2018
            try
            {
                System.Diagnostics.Process.Start("cmd", $"/c start {link}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open link: {ex.Message}");
            }
        }
        private void OpenLink2019(object sender)
        {
            string link = "https://zno.osvita.ua/mathematics/346/"; //2019
            try
            {
                System.Diagnostics.Process.Start("cmd", $"/c start {link}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open link: {ex.Message}");
            }
        }
        private void OpenLink2020(object sender)
        {
            string link = "https://zno.osvita.ua/mathematics/400/"; //2020
            try
            {
                System.Diagnostics.Process.Start("cmd", $"/c start {link}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open link: {ex.Message}");
            }
        }
        private void OpenLink2021(object sender)
        {
            string link = "https://zno.osvita.ua/mathematics/469/"; //2021
            try
            {
                System.Diagnostics.Process.Start("cmd", $"/c start {link}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open link: {ex.Message}");
            }
        }
    }
}
