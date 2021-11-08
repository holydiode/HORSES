using System;

namespace HORSES
{
    class SaveUnit : IUnit
    {
        public string Name => _unit.Name;
        private Unit _unit;

        public SaveUnit(Unit unit)
        {
            _unit = unit;
        }

        public void Move(string coord)
        {
            if (CheckProtection())
            {
                _unit.Move(coord);
            }
            else
            {
                Loger.GetLoger().Write(
                    "Юнит " + _unit.Name +
                    " не может переместится, так как сейчас ход игрока"
                    + GameMaster.GetMaster().CurentPlayer.ID.ToString());
            }
        }

        private bool CheckProtection()
        {
            return GameMaster.GetMaster().CurentPlayer == _unit.Owner;
        }

    }
}
