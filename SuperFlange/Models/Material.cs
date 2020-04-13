using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFlange.Models
{
    public class Material : ElementBase
    {
        private float _YoungModulus;
        [Measure(1, units: "mm", isRequired: true)]
        public float YoungModulus
        {
            get => _YoungModulus;
            set => SetPropertyBackingField(ref _YoungModulus, value, nameof(YoungModulus));
        }

        private float _PoissonRatio;
        [Measure(2, units: "mm", isRequired: true)]
        public float PoissonRatio
        {
            get => _PoissonRatio;
            set => SetPropertyBackingField(ref _PoissonRatio, value, nameof(PoissonRatio));
        }

        private float _AllowableStress;
        [Measure(3, units: "mm", isRequired: true)]
        public float AllowableStress
        {
            get => _AllowableStress;
            set => SetPropertyBackingField(ref _AllowableStress, value, nameof(AllowableStress));
        }

        private float _ThermalExpansionCoefficient;
        [Measure(4, units: "mm", isRequired: true)]
        public float ThermalExpansionCoefficient
        {
            get => _ThermalExpansionCoefficient;
            set => SetPropertyBackingField(ref _ThermalExpansionCoefficient, value, nameof(ThermalExpansionCoefficient));
        }

        private float _ThermalConductivity;
        [Measure(5, units: "mm", isRequired: true)]
        public float ThermalConductivity
        {
            get => _ThermalConductivity;
            set => SetPropertyBackingField(ref _ThermalConductivity, value, nameof(ThermalConductivity));
        }

        private float _OutsideHeatFilmTransferCoefficient;
        [Measure(6, units: "mm", isRequired: true)]
        public float OutsideHeatFilmTransferCoefficient
        {
            get => _OutsideHeatFilmTransferCoefficient;
            set => SetPropertyBackingField(ref _OutsideHeatFilmTransferCoefficient, value, nameof(OutsideHeatFilmTransferCoefficient));
        }

        private float _InsideHeatFilmTransferCoefficient;
        [Measure(7, units: "mm", isRequired: true)]
        public float InsideHeatFilmTransferCoefficient
        {
            get => _InsideHeatFilmTransferCoefficient;
            set => SetPropertyBackingField(ref _InsideHeatFilmTransferCoefficient, value, nameof(InsideHeatFilmTransferCoefficient));
        }

        private float _CreepConstantA;
        [Measure(8, units: "mm", isRequired: true)]
        public float CreepConstantA
        {
            get => _CreepConstantA;
            set => SetPropertyBackingField(ref _CreepConstantA, value, nameof(CreepConstantA));
        }

        private float _CreepConstantM;
        [Measure(9, units: "mm", isRequired: true)]
        public float CreepConstantM
        {
            get => _CreepConstantM;
            set => SetPropertyBackingField(ref _CreepConstantM, value, nameof(CreepConstantM));
        }

        private float _CreepConstantN;
        [Measure(10, units: "mm", isRequired: true)]
        public float CreepConstantN
        {
            get => _CreepConstantN;
            set => SetPropertyBackingField(ref _CreepConstantN, value, nameof(CreepConstantN));
        }
    }
}
