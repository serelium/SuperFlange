using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFlange.Models
{
    public class Gasket : Element
    {
        private float _InsideDiameter;
        [Measure(1, null, "mm", true)]
        public float InsideDiameter
        {
            get => _InsideDiameter;
            set => SetPropertyBackingField(ref _InsideDiameter, value, nameof(InsideDiameter));
        }

        private float _OutsideDiameter;
        [Measure(2, null, "mm", true)]
        public float OutsideDiameter
        {
            get => _OutsideDiameter;
            set => SetPropertyBackingField(ref _OutsideDiameter, value, nameof(OutsideDiameter));
        }

        private float _RingOutsideDiameter;
        [Measure(3, null, "mm", true)]
        public float RingOutsideDiameter
        {
            get => _RingOutsideDiameter;
            set => SetPropertyBackingField(ref _RingOutsideDiameter, value, nameof(RingOutsideDiameter));
        }

        private float _CenteringRingDiameter;
        [Measure(4, null, "mm", true)]
        public float CenteringRingDiameter
        {
            get => _CenteringRingDiameter;
            set => SetPropertyBackingField(ref _CenteringRingDiameter, value, nameof(CenteringRingDiameter));
        }

        private float _GasketThickness;
        [Measure(5, null, "mm", true)]
        public float GasketThickness
        {
            get => _GasketThickness;
            set => SetPropertyBackingField(ref _GasketThickness, value, nameof(GasketThickness));
        }

        private float _EffectiveSeatingWidth;
        [Measure(6, null, "mm", true)]
        public float EffectiveSeatingWidth
        {
            get => _EffectiveSeatingWidth;
            set => SetPropertyBackingField(ref _EffectiveSeatingWidth, value, nameof(EffectiveSeatingWidth));
        }

        public Gasket()
            :base()
        {

        }
    }
}
