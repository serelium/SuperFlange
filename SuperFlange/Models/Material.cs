using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFlange.Models
{
    public class Material : Element
    {
        private float _YoungModulus;
        [RequiredProperty]
        public float YoungModulus
        {
            get => _YoungModulus;
            set => SetPropertyBackingField(ref _YoungModulus, value, nameof(YoungModulus));
        }

        private float _PoissonRatio;
        [RequiredProperty]
        public float PoissonRatio
        {
            get => _PoissonRatio;
            set => SetPropertyBackingField(ref _PoissonRatio, value, nameof(PoissonRatio));
        }

        private float _AllowableStress;
        [RequiredProperty]
        public float AllowableStress
        {
            get => _AllowableStress;
            set => SetPropertyBackingField(ref _AllowableStress, value, nameof(AllowableStress));
        }

        private float _ThermalExpansionCoefficient;
        [RequiredProperty]
        public float ThermalExpansionCoefficient
        {
            get => _ThermalExpansionCoefficient;
            set => SetPropertyBackingField(ref _ThermalExpansionCoefficient, value, nameof(ThermalExpansionCoefficient));
        }

        private float _ThermalConductivity;
        [RequiredProperty]
        public float ThermalConductivity
        {
            get => _ThermalConductivity;
            set => SetPropertyBackingField(ref _ThermalConductivity, value, nameof(ThermalConductivity));
        }

        private float _OutsideHeatFilmTransferCoefficient;
        [RequiredProperty]
        public float OutsideHeatFilmTransferCoefficient
        {
            get => _OutsideHeatFilmTransferCoefficient;
            set => SetPropertyBackingField(ref _OutsideHeatFilmTransferCoefficient, value, nameof(OutsideHeatFilmTransferCoefficient));
        }

        private float _InsideHeatFilmTransferCoefficient;
        [RequiredProperty]
        public float InsideHeatFilmTransferCoefficient
        {
            get => _InsideHeatFilmTransferCoefficient;
            set => SetPropertyBackingField(ref _InsideHeatFilmTransferCoefficient, value, nameof(InsideHeatFilmTransferCoefficient));
        }

        private float _CreepConstantA;
        [RequiredProperty]
        public float CreepConstantA
        {
            get => _CreepConstantA;
            set => SetPropertyBackingField(ref _CreepConstantA, value, nameof(CreepConstantA));
        }

        private float _CreepConstantM;
        [RequiredProperty]
        public float CreepConstantM
        {
            get => _CreepConstantM;
            set => SetPropertyBackingField(ref _CreepConstantM, value, nameof(CreepConstantM));
        }

        private float _CreepConstantN;
        [RequiredProperty]
        public float CreepConstantN
        {
            get => _CreepConstantN;
            set => SetPropertyBackingField(ref _CreepConstantN, value, nameof(CreepConstantN));
        }
    }
}
