using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern
{
    class SnapshotManager
    {
        private List<GameMaster.GameMasterSnapShot> _snapshots;

        public SnapshotManager()
        {
            _snapshots = new();
        }

        public void MakeSnapshot()
        {
            _snapshots.Add(GameMaster.GetMaster().SaveState());
            Loger.GetLoger().Write("Создан снимок игры, всего снимков " + _snapshots.Count.ToString());
        }

        public void LoadUndo()
        {
            GameMaster.GetMaster().LoadState(_snapshots.Last());
            Loger.GetLoger().Write("Снимок загружен " + _snapshots.Count.ToString());
            _snapshots.Remove(_snapshots.Last());
        }
    }
}
