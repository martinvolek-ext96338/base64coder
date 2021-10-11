using System.ComponentModel;
using System.Runtime.CompilerServices;
using Base64Coder.Annotations;

namespace Base64Coder
{
    public class Model : INotifyPropertyChanged
    {
        private string output = string.Empty;
        
        public string Input { get; set; } = string.Empty;

        public string Output
        {
            get => output;
            set
            {
                output = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}