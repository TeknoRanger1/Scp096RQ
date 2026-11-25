# 😭 Scp096RageQuit

A lightweight and chaotic **EXILED** plugin for *SCP: Secret Laboratory* that turns **SCP-096's death** into a literal explosive rage quit.

When SCP-096 is eliminated, its killer is forced into a timed projectile-throwing frenzy, spawning configurable waves of grenades, flashbangs, SCP-018, or SCP-2176!

---

## ✨ Features

* **Explosive Revenge:** Triggers automatically when a player playing as `Scp096` dies.
* **Configurable Waves:** Set the total duration (`timer`) and delay between waves (`interval`).
* **Custom Projectile Pool:** Toggle individual throwables (`Flashbang`, `FragGrenade`, `Scp018`, `Scp2176`) directly from the config.
* **Aura Mode Support:** Option to spawn projectiles in an aura pattern around the target (`is_aura`).

---

## 📦 Installation

1. Make sure you have **EXILED** installed on your *SCP: Secret Laboratory* server.
2. Download the latest `Scp096RageQuit.dll` from the [Releases](../../releases) page.
3. Place `Scp096RageQuit.dll` inside your `EXILED/Plugins` folder.
4. Restart the server to generate the default configuration file.

---

## ⚙️ Configuration

Once generated, you can customize the plugin inside your EXILED config file (`...-config.yml`):

```yaml
scp096_rage_quit:
  # Enables or disables the Scp096RageQuit plugin.
  is_enabled: true
  # Displays detailed debug logs in the server console.
  debug: false
  # Total duration of the projectile throwing sequence in seconds.
  timer: 10
  # Delay interval in seconds between each projectile wave.
  interval: 1
  # Projectiles spawned during SCP-096's rage quit (true = enabled, false = disabled).
  projectiles_throwed:
    Flashbang: true
    FragGrenade: true
    Scp018: true
    Scp2176: true
  # If true, spawns projectiles in an aura pattern around SCP-096 instead of a single directional throw.
  is_aura: true
