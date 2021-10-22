using Respawning;
using Respawning.NamingRules;
using Exiled.API.Features;
using System;

namespace Gwkhtmsat
{
	public class Plugin : Plugin<Configs>
	{
		public override string Author => "Dark7eamplar#2683";
		public override string Name => "Guys who know how to make such a thing";
		public override string Prefix => "gwkhtmsat";
        public override Version RequiredExiledVersion => new Version(3, 0, 5);

        public override void OnEnabled()
		{
			Exiled.Events.Handlers.Server.WaitingForPlayers += this.WaitingForPlayers;
			base.OnEnabled();
		}

		public override void OnDisabled()
		{
			Exiled.Events.Handlers.Server.WaitingForPlayers -= this.WaitingForPlayers;
			base.OnDisabled();
		}

		private void WaitingForPlayers()
		{
			foreach (string line in Config.Lines)
			{
				SyncUnit unit = new SyncUnit
				{
					UnitName = line,
					SpawnableTeam = (byte)SpawnableTeamType.NineTailedFox
				};
				RespawnManager.Singleton.NamingManager.AllUnitNames.Add(unit);
			}
		}
	}
}