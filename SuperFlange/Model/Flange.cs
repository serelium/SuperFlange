using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFlange.Model
{
    class Flange : ObservableObject
    {
        #region Private Properties
        private double _Thickness;
        private double _OutsideDiameter;
        private double _RaisedFaceDiameter;
        private double _BoreDiameter;
        private double _HubThickness;
        private double _HubLength;
        private double _RaisedFaceHeight;
        private List<Bolt> _Bolts;
        private FlangeType _FlangeType;
        #endregion

        #region Public Properties
        public double Thickness
        {
            get { return _Thickness; }

            set {
                _Thickness = value;
                RaisePropertyChangedEvent(nameof(Thickness));
            }
        }

        public double OutsideDiameter
        {
            get { return _OutsideDiameter; }

            set
            {
                _OutsideDiameter = value;
                RaisePropertyChangedEvent(nameof(OutsideDiameter));
            }
        }

        public double RaisedFaceDiameter
        {
            get { return _RaisedFaceDiameter; }

            set
            {
                _RaisedFaceDiameter = value;
                RaisePropertyChangedEvent(nameof(RaisedFaceDiameter));
            }
        }

        public double BoreDiameter
        {
            get { return _BoreDiameter; }

            set
            {
                _BoreDiameter = value;
                RaisePropertyChangedEvent(nameof(BoreDiameter));
            }
        }

        public double HubThickness
        {
            get { return _HubThickness; }

            set
            {
                _HubThickness = value;
                RaisePropertyChangedEvent(nameof(HubThickness));
            }
        }

        public double HubLength
        {
            get { return _HubLength; }

            set
            {
                _HubLength = value;
                RaisePropertyChangedEvent(nameof(HubLength));
            }
        }

        public double RaisedFaceHeight
        {
            get { return _RaisedFaceHeight; }

            set
            {
                _RaisedFaceHeight = value;
                RaisePropertyChangedEvent(nameof(RaisedFaceHeight));
            }
        }
        #endregion
    }

    public enum FlangeType
    {
        WeldNeck,
        SlipOn,
        Lapped,
        SocketWeld,
        Threaded,
        Blind
    }
}
