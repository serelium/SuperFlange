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

        private float _Thickness;
        [RequiredProperty]
        [Units("mm")]
        public float Thickness
        {
            get => _Thickness;
            set => SetPropertyBackingField(ref _Thickness, value, nameof(Thickness));
        }

        private float _OutsideDiameter;
        [RequiredProperty]
        [Units("mm")]
        public float OutsideDiameter
        {
            get => _OutsideDiameter;
            set => SetPropertyBackingField(ref _OutsideDiameter, value, nameof(OutsideDiameter));
        }

        private float _RaisedFaceDiameter;
        [RequiredProperty]
        [Units("mm")]
        public float RaisedFaceDiameter
        {
            get => _RaisedFaceDiameter;
            set => SetPropertyBackingField(ref _RaisedFaceDiameter, value, nameof(RaisedFaceDiameter));
        }

        private float _BoreDiameter;
        [RequiredProperty]
        [Units("mm")]
        public float BoreDiameter
        {
            get => _BoreDiameter;
            set => SetPropertyBackingField(ref _BoreDiameter, value, nameof(BoreDiameter));
        }

        private float _HubThickness;
        [RequiredProperty]
        [Units("mm")]
        public float HubThickness
        {
            get => _HubThickness;
            set => SetPropertyBackingField(ref _HubThickness, value, nameof(HubThickness));
        }

        private float _HubLength;
        [RequiredProperty]
        [Units("mm")]
        public float HubLength
        {
            get => _HubLength;
            set => SetPropertyBackingField(ref _HubLength, value, nameof(HubLength));
        }

        private float _RaisedFaceHeight;
        [RequiredProperty]
        [Units("mm")]
        public float RaisedFaceHeight
        {
            get => _RaisedFaceHeight;
            set => SetPropertyBackingField(ref _RaisedFaceHeight, value, nameof(RaisedFaceHeight));
        }

        private int _NumberOfBolts;
        [RequiredProperty]
        public int NumberOfBolts
        {
            get => _NumberOfBolts;
            set => SetPropertyBackingField(ref _NumberOfBolts, value, nameof(NumberOfBolts));
        }

        private float _BoltCircleDiameter;
        [RequiredProperty]
        [Units("mm")]
        public float BoltCircleDiameter
        {
            get => _BoltCircleDiameter;
            set => SetPropertyBackingField(ref _BoltCircleDiameter, value, nameof(BoltCircleDiameter));
        }

        private FlangeType _FlangeType;
        [RequiredProperty]
        public FlangeType FlangeType
        {
            get => _FlangeType;
            set => SetPropertyBackingField(ref _FlangeType, value, nameof(FlangeType));
        }
        #endregion

        public Flange()
        {
            Material = new Material();
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
