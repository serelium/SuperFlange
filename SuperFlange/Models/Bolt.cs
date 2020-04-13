using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFlange.Models
{
    public class Bolt : Element
    {
        private float _NominalDiameter;
        [Measure(1, null, "mm", true)]
        public float NominalDiameter
        {
            get => _NominalDiameter;
            set => SetPropertyBackingField(ref _NominalDiameter, value, nameof(NominalDiameter));
        }

        private int _NumberOfThreadsPerUnit;
        [Measure(2, "Number Of Threads / Unit Length", "mm-1", true)]
        public int NumberOfThreadsPerUnit
        {
            get => _NumberOfThreadsPerUnit;
            set => SetPropertyBackingField(ref _NumberOfThreadsPerUnit, value, nameof(NumberOfThreadsPerUnit));
        }

        private float _WachersRigidityPerBolt;
        [Measure(3, "Wachers Rigidity / Bolt", "N/mm", true)]
        public float WachersRigidityPerBolt
        {
            get => _WachersRigidityPerBolt;
            set => SetPropertyBackingField(ref _WachersRigidityPerBolt, value, nameof(WachersRigidityPerBolt));
        }

        private float _NutFactor;
        [Measure(4, null, null, true)]
        public float NutFactor
        {
            get => _NutFactor;
            set => SetPropertyBackingField(ref _NutFactor, value, nameof(NutFactor));
        }

        public Bolt()
            :base()
        {
            
        }
    }
}
