using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Enums;
using Exiled.API.Interfaces;
using Scp096RageQuit.Components;
using YamlDotNet.Serialization;

namespace Scp096RageQuit.Configs
{
    public class MainConfig : IConfig
    {
        
        [Description("Enables or disables the Scp096RageQuit plugin.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Displays detailed debug logs in the server console.")]
        public bool Debug { get; set; } = false;

        [Description("Total duration of the projectile throwing sequence in seconds.")]
        public int Timer { get; set; } = 10;

        [Description("Delay interval in seconds between each projectile wave.")]
        public int Interval { get; set; } = 1;

        [Description("Projectiles spawned during SCP-096's rage quit (true = enabled, false = disabled).")]
        public Dictionary<ProjectileType, bool> ProjectilesThrowed { get; set; } = new()
        {
            { ProjectileType.Flashbang, true },
            { ProjectileType.FragGrenade, true },
            { ProjectileType.Scp018, true },
            { ProjectileType.Scp2176, true }
        };

        [Description("it's useless but AURA?")]
        public bool IsAura { get; set; } = true;
    }
}