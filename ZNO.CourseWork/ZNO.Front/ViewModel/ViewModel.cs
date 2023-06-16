using AutoMapper;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ZNO.Front.ViewModel
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ViewModel(IMapper mapper)
        {
            _mapper = mapper;
        }

        protected ViewModel()
        {
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        protected readonly IMapper _mapper;
    }
}

