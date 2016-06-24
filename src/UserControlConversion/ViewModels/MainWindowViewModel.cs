using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace UserControlConversion.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChangedEventArgs eventArguments = new PropertyChangedEventArgs(propertyName);
            PropertyChanged?.Invoke(this, eventArguments);
        }

        private async Task LoadData()
        {
            IsLoadingData = true;

            // Simulate data loading.
            await Task.Delay(1000);

            IsLoadingData = false;
        }

        private ICommand _startLoadingData;

        public ICommand StartLoadingData
        {
            get
            {
                ICommand command = _startLoadingData ?? new RelayCommand(async () => await LoadData());
                return command;
            }
        }

        private bool _isLoadingData;
        public bool IsLoadingData
        {
            get
            {
                return _isLoadingData;
            }

            set
            {
                _isLoadingData = value;
                OnPropertyChanged();
            }
        }
    }
}