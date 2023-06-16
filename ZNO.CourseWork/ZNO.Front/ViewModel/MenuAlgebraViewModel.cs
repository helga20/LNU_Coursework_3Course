using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZNO.BLL.Services;
using ZNO.BLL.Services.Interface;
using ZNO.Front.Command;
using ZNO.Front.Models;

namespace ZNO.Front.ViewModel
{
    public class MenuAlgebraViewModel :ViewModel
    {
        public RelayCommand GetTopicsCommand => new RelayCommand(GetAllTopics);
        public RelayCommand PreviousInfoCommand => new RelayCommand(PreviousInfo);
        public RelayCommand NextInfoCommand => new RelayCommand(NextInfo);

        public MenuAlgebraViewModel(IMapper mapper, ITopicService topicService) : base(mapper)
        {
            _mapper = mapper;
            _topicService = topicService;
            GetTopicsCommand.Execute(this);
        }

        public MenuAlgebraViewModel(IMapper mapper) : base(mapper) 
        {
        }

        public MenuAlgebraViewModel() :base()
        {
        }

        public List<string>? Topics
        {
            get
            {
                return _topic;
            }
            set
            {
                _topic = value!;
                OnPropertyChanged("Topics");
            }
        }

        public string? Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value!;
                OnPropertyChanged("Selected");
            }
        }

        public string? Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value!;
                OnPropertyChanged("Data");
            }
        }

        private List<string> _topic;
        private string _data;
        private string _selected;
        private readonly IMapper _mapper;
        private readonly ITopicService _topicService;



        private void GetAllTopics(object sender)
        {
            var ListOfTopics = new List<string>();

            try
            {
                var topics = _mapper.Map<IEnumerable<TopicModel>>(_topicService!.GetAllTopics());

                foreach (var topic in topics)
                {
                    ListOfTopics.Add(topic.NameOfTopic!);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Topics = ListOfTopics;
        }

        private void PreviousInfo(object sender)
        {
            var info = "";

            try
            {
                var topics = _mapper.Map<IEnumerable<TopicModel>>(_topicService!.GetAllTopics());
                if (Data == null)
                {
                    foreach (var topic in topics)
                    {

                        if (topic.NameOfTopic == Selected)
                        {
                            info = topic.Info;
                        }
                    }
                    Data = info;
                    return;
                }
                if (Data != null)
                {
                    foreach (var topic in topics)
                    {

                        if (topic.NameOfTopic == Selected)
                        {
                            if (Data!.Contains(topic.Info!))
                            {
                                info = topic.Definition!;
                            }
                            else if (Data!.Contains(topic.Definition!))
                            {
                                info = topic.Info!;
                            }
                            else
                            {
                                info = topic.Info!;
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Data = info;
        }

        private void NextInfo(object sender) 
        {
            var info = "";
            try
            {
                var topics = _mapper.Map<IEnumerable<TopicModel>>(_topicService!.GetAllTopics());
                if (Data == null)
                {
                    foreach (var topic in topics)
                    {

                        if (topic.NameOfTopic == Selected)
                        {
                            info = topic.Info;
                        }
                    }
                    Data = info;
                    return;
                }
                if (Data != null)
                {
                    foreach (var topic in topics)
                    {
                        if (topic.NameOfTopic == Selected)
                        {
                            if (Data.Contains(topic.Info!))
                            {
                                info = topic.Definition!;
                            }
                            else if (Data.Contains(topic.Definition!))
                            {
                                info = topic.Info!;
                            }
                            else
                            {
                                info = topic.Info!;
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Data = info;
        }
    }
}
