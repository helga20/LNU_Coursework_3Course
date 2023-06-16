using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZNO.BLL.Services;
using ZNO.BLL.Services.Interface;
using ZNO.DAL.Models;
using ZNO.Front.Command;
using ZNO.Front.Models;

namespace ZNO.Front.ViewModel
{
    public class StatisticsViewModel : ViewModel
    {

        public RelayCommand GetAllTimeCommand => new RelayCommand(GetAllTime);
        public RelayCommand GetLastTimeCommand => new RelayCommand(GetLastTime);

        public StatisticsViewModel(IMapper mapper, ITimeService timeService) : base(mapper)
        {
            _mapper = mapper;
            _timeService = timeService;
            GetAllTimeCommand.Execute(this);
            GetLastTimeCommand.Execute(this);
        }


        public StatisticsViewModel(IMapper mapper) : base(mapper)
        {
        }

        public StatisticsViewModel() : base()
        {
        }

        public string? AllTime
        {
            get
            {
                return _allTime;
            }
            set
            {
                _allTime = value!;
                OnPropertyChanged("AllTime");
            }
        }        
        
        public string? LastTime
        {
            get
            {
                return _lastTime;
            }
            set
            {
                _lastTime = value!;
                OnPropertyChanged("LastTime");
            }
        }

        private string _allTime = "";
        private string _lastTime = "";
        private readonly IMapper _mapper;
        private readonly ITimeService _timeService;



        private void GetAllTime(object sender)
        {
            try
            {
                var topics = _timeService.GetSumAllTimes();

                AllTime = topics;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void GetLastTime(object sender)
        {
            try
            {
                var topics = _timeService.GetLastTime();

                LastTime = topics.DataTime.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
