using LabOOP.Constructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP.AbstractMaterials
{
    abstract class AbstractMaterial : Construction
    {
        protected double MaterialCost;
        public abstract double CalculateMaterialCost();
    }
}
