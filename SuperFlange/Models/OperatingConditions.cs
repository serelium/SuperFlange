using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFlange.Models
{
    public class OperatingConditions : ElementBase
    {
        private float _DesignPressure;
        [Measure(6, null, "MPa", true)]
        public float DesignPressure
        {
            get => _DesignPressure;
            set => SetPropertyBackingField(ref _DesignPressure, value, nameof(DesignPressure));
        }

        private float _DesignTemperature;
        [Measure(6, null, "°C", true)]
        public float DesignTemperature
        {
            get => _DesignTemperature;
            set => SetPropertyBackingField(ref _DesignTemperature, value, nameof(DesignTemperature));
        }

        private float _TestPressureRatio;
        [Measure(6, null, null, true)]
        public float TestPressureRatio
        {
            get => _TestPressureRatio;
            set => SetPropertyBackingField(ref _TestPressureRatio, value, nameof(TestPressureRatio));
        }

        private float _InitialBoltLoad;
        [Measure(6, null, "N", true)]
        public float InitialBoltLoad
        {
            get => _InitialBoltLoad;
            set => SetPropertyBackingField(ref _InitialBoltLoad, value, nameof(InitialBoltLoad));
        }

        private float _ExternalForce;
        [Measure(6, null, "N", true)]
        public float ExternalForce
        {
            get => _ExternalForce;
            set => SetPropertyBackingField(ref _ExternalForce, value, nameof(ExternalForce));
        }

        private float _ExternalMoment;
        [Measure(6, null, "N*mm", true)]
        public float ExternalMoment
        {
            get => _ExternalMoment;
            set => SetPropertyBackingField(ref _ExternalMoment, value, nameof(ExternalMoment));
        }

        private float _AmbiantTemperature;
        [Measure(6, null, "°C", true)]
        public float AmbiantTemperature
        {
            get => _AmbiantTemperature;
            set => SetPropertyBackingField(ref _AmbiantTemperature, value, nameof(AmbiantTemperature));
        }

        private float _CreepTime;
        [Measure(6, null, "hr", true)]
        public float CreepTime
        {
            get => _CreepTime;
            set => SetPropertyBackingField(ref _CreepTime, value, nameof(CreepTime));
        }
    }
}
