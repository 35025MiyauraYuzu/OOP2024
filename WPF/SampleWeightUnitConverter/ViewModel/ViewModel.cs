using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SampleWeightUnitConverter {
    public class ViewModels : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            //if(this.PropertyChanged != null) {
            //    this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            //}
        }
    }
}
