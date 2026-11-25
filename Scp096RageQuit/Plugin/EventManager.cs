using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.API.Features.Roles;
using Exiled.Events.EventArgs.Player;
using MEC;
using PlayerRoles;
using PlayerRoles.PlayableScps.Scp096;
using PluginAPI.Enums;
using Scp096RageQuit.Configs;
using Utils;
using Utils.NonAllocLINQ;
using Scp096Role = PlayerRoles.PlayableScps.Scp096.Scp096Role;
using Vector3 = UnityEngine.Vector3;

namespace Scp096RageQuit.Plugin
{
    public class EventManager
    {
        public static void RegisterEvent()
        {
            Exiled.Events.Handlers.Player.Dying += OnPlayerDying;
        }

        public static void UnregisterEvent()
        {
            Exiled.Events.Handlers.Player.Dying -= OnPlayerDying;
        }

        private static MainConfig Config => MainPlugin.Instance?.Config;

        private static void OnPlayerDying(DyingEventArgs ev)
        {
            if (ev.Player.Role == RoleTypeId.Scp096)
            {
                if (!Config.IsEnabled)
                    return;
                Timing.RunCoroutine(_throwHandler(ev.Attacker));
            }
        }

        private static IEnumerator<float> _throwHandler(Player player)
        {
            int timer = 10;
            for (int i = timer; i > 0; i--)
            {
                if (player == null || !player.IsAlive)  
                    yield break;
                
                foreach (var item in Config.ProjectilesThrowed.ToList())
                {
                    if (!item.Value)
                        continue;
                    
                    player.ThrowGrenade(item.Key);
                    
                }
                yield return Timing.WaitForSeconds(1);
            }
        }
    }
}