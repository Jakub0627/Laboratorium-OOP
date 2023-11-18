using LabOOP.Constructions;
using LabOOP.Constructions.Models;
using System;

namespace LabOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var constr = new Construction(32, 23, 3, 6, TypeOfMaterial.Brik);
            var constr2 = new Construction();
            var inputParam = new CreateConstructionDto()
            {
                Height = 23,
                Width = 12,
                Entrances = 1,
                HumanCapacity = 1,
                BuildMaterial = TypeOfMaterial.Brik
            };

            var constr3 = new Construction(inputParam);
            Console.WriteLine(constr.BuildMaterial);
            Console.WriteLine(constr2.BuildMaterial);
            Console.WriteLine(constr2.Width);
            Console.WriteLine(constr2.Height);
            Console.WriteLine(constr3.BuildMaterial);
            Console.WriteLine(constr3.GetSquareCost());
        }
    }
}
