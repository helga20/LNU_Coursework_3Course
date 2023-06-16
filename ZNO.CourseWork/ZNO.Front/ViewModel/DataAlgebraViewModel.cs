using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZNO.BLL.Services.Interface;
using ZNO.Front.Command;
using ZNO.Front.Models;

namespace ZNO.Front.ViewModel
{
    public class DataAlgebraViewModel : ViewModel
    {
        public RelayCommand GetZmistCommand => new RelayCommand(GetZmist);

        public string? Header
        {
            get
            {
                return _head;
            }
            set
            {
                _head = value!;
                OnPropertyChanged("Header");
            }
        }

        public string? FirstPath
        {
            get
            {
                return _first;
            }
            set
            {
                _first = value!;
                OnPropertyChanged("FirstPath");
            }
        }

        public string? LastPath
        {
            get
            {
                return _last;
            }
            set
            {
                _last = value!;
                OnPropertyChanged("LastPath");
            }
        }

        public DataAlgebraViewModel(IMapper mapper, IZmistService zmistService) : base(mapper)
        {
            _mapper = mapper;
            _zmistService = zmistService;
        }

        private string _head = "";
        private string _first = "";
        private string _last = "";
        private readonly IMapper _mapper;
        private readonly IZmistService _zmistService;


        private async void GetZmist(object sender)
        {
            try
            {
                var zmist = _mapper.Map<ZmistModel>(await _zmistService!.GetAllZmist());
                Header = zmist.MathName;
                FirstPath = zmist.TypePageName;
                LastPath = zmist.FullInfo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
