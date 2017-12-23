using SuperFlange.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFlange.ViewModel
{
    class FlangeViewModel : ViewModelBase
    {
        private Flange _Flange;

        public FlangeViewModel()
        {
            Flange _Flange = new Flange();
            _Flange.PropertyChanged += new PropertyChangedEventHandler(Flange_PropertyChanged);
        }

        private void Flange_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(_Flange.Thickness):
                    RaisePropertyChangedEvent(e.PropertyName);
                    break;
            }
        }
    }
}
