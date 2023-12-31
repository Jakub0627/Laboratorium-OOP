﻿using LabOOP.Constructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP.BuildingsWrapper
{
    class BuildingWrapper
    {
        public Construction _construction { get; set; }
        public BuildingWrapper(Construction construction)
        {
            _construction = construction;
        }
        public double GetWrappedSquareCost()
        {
            return _construction.CalculateSquareCost();
        }

        public void DisplayConstructionInfo()
        {
            _construction.DisplayConstructionInfo();
        }
    }
}
