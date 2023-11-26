using LabOOP.Constructions;
using LabOOP.Constructions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP.AbstractComercialBuildings
{
    abstract class AbstractCommercialBuilding : Construction
    {
        public string BusinessType { get; set; }
        protected AbstractCommercialBuilding(float height, float width, int entrances, int humanCapacity, TypeOfMaterial buildMaterial, string businessType) : base(height, width, entrances, humanCapacity, buildMaterial)
        {
            BusinessType = businessType;
        }
        public abstract void OpenBusiness();

    }
}
