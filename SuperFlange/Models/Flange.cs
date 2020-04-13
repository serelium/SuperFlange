using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFlange.Models
{
    public class Flange : Element
    {
        private List<Bolt> _Bolts;

        #region Properties

        private FlangeType _FlangeType;
        [Measure(1, isRequired: true)]
        public FlangeType FlangeType
        {
            get => _FlangeType;
            set => SetPropertyBackingField(ref _FlangeType, value, nameof(FlangeType));
        }

        private int _NumberOfBolts;
        [Measure(2, isRequired: true)]
        public int NumberOfBolts
        {
            get => _NumberOfBolts;
            set => SetPropertyBackingField(ref _NumberOfBolts, value, nameof(NumberOfBolts));
        }

        private float _Thickness;
        [Measure(3, units: "mm", isRequired: true)]
        public float Thickness
        {
            get => _Thickness;
            set => SetPropertyBackingField(ref _Thickness, value, nameof(Thickness));
        }

        private float _OutsideDiameter;
        [Measure(4, units: "mm", isRequired: true)]
        public float OutsideDiameter
        {
            get => _OutsideDiameter;
            set => SetPropertyBackingField(ref _OutsideDiameter, value, nameof(OutsideDiameter));
        }

        private float _RaisedFaceDiameter;
        [Measure(5, units: "mm", isRequired: true)]
        public float RaisedFaceDiameter
        {
            get => _RaisedFaceDiameter;
            set => SetPropertyBackingField(ref _RaisedFaceDiameter, value, nameof(RaisedFaceDiameter));
        }

        private float _BoreDiameter;
        [Measure(6, units: "mm", isRequired: true)]
        public float BoreDiameter
        {
            get => _BoreDiameter;
            set => SetPropertyBackingField(ref _BoreDiameter, value, nameof(BoreDiameter));
        }

        private float _HubThickness;
        [Measure(7, units: "mm", isRequired: true)]
        public float HubThickness
        {
            get => _HubThickness;
            set => SetPropertyBackingField(ref _HubThickness, value, nameof(HubThickness));
        }

        private float _HubLength;
        [Measure(8, units: "mm", isRequired: true)]
        public float HubLength
        {
            get => _HubLength;
            set => SetPropertyBackingField(ref _HubLength, value, nameof(HubLength));
        }

        private float _RaisedFaceHeight;
        [Measure(9, units: "mm", isRequired: true)]
        public float RaisedFaceHeight
        {
            get => _RaisedFaceHeight;
            set => SetPropertyBackingField(ref _RaisedFaceHeight, value, nameof(RaisedFaceHeight));
        }

        private float _BoltCircleDiameter;
        [Measure(10, units: "mm", isRequired: true)]
        public float BoltCircleDiameter
        {
            get => _BoltCircleDiameter;
            set => SetPropertyBackingField(ref _BoltCircleDiameter, value, nameof(BoltCircleDiameter));
        }
        #endregion

        public Flange()
            : base()
        {

        }
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
