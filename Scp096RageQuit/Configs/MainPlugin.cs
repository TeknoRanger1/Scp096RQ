using System;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Loader;
using Scp096RageQuit.Components;
using EventManager = Scp096RageQuit.Plugin.EventManager;

namespace Scp096RageQuit.Configs
{
    public class MainPlugin : Plugin<MainConfig>
    {
        public override string Author => "TeknoRanger1";
        public override string Name => "Scp096RageQuit";
        public override Version Version { get; } = new Version(1, 0, 0, 0);
        public override Version RequiredExiledVersion { get; } = Loader.Version;
        public override PluginPriority Priority => PluginPriority.Low;
        
        public static MainPlugin Instance { get; private set; }

        public override void OnEnabled()
        {
            Instance = this;
            
            Log.Info(LoadASCII.Ascii096Plugin());
            Log.Info($"\n<======== {Name.ToUpper()} ========>\n- Author: {Author}\n- Version: {Version}\n<================================");
            EventManager.RegisterEvent();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            
            EventManager.UnregisterEvent();
            base.OnDisabled();
        }
    }
    // Scemo chi legge :)
}