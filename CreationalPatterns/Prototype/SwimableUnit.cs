using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public class SwimableUnit:UnitUpgrade
    {
        public SwimableUnit(IUnit baseUnit):base(baseUnit)
        {
        }

        public override void MoveTo(int coord)
        {
            while (Position != coord)
            {
                if (Map.GetTerainType(Position + 1) == TerainType.Water)
                {
                    int endSampleCoord = Position;
                    while (endSampleCoord < coord && Map.GetTerainType(endSampleCoord + 1) == TerainType.Water)
                    {
                        endSampleCoord += 1;
                    }
                    Loger.GetLoger().Write(string.Format("Юнит {0} проплыл {1} клеток", Name, endSampleCoord - Position));
                    _coreUnit.Rearrange(endSampleCoord);
                }
                else
                {
                    int endSampleCoord = Position;
                    while(endSampleCoord < coord && Map.GetTerainType(endSampleCoord + 1) != TerainType.Water)
                    {
                        endSampleCoord += 1;
                    }
                    _coreUnit.MoveTo(endSampleCoord);
                    if (endSampleCoord != Position)
                        return;
                }
            }
        }

        public override IUnit Clone()
        {
            return new SwimableUnit(_coreUnit.Clone());
        }

    }
}
