using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SuperFlange.Models
{
    public class NotifyPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetPropertyBackingField<T>(ref T backingField, T value, [CallerMemberName] string propertyName = null)
        {
            if (!typeof(T).IsValueType)
            {
                if (ReferenceEquals(backingField, value))
                    return false;
            }
            else
            {
                if (backingField.Equals(value))
                    return false;
            }

            backingField = value;
            RaisePropertyChanged(propertyName);
            return true;
        }
    }
}
