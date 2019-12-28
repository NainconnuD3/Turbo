// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
// *.txt files are not loaded automatically by TurboHUD
// you have to change this file's extension to .cs to enable it
// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

using Turbo.Plugins.Default;

namespace Turbo.Plugins.User
{

    public class PluginEnablerOrDisablerPlugin : BasePlugin, ICustomizer
    {

        public PluginEnablerOrDisablerPlugin()
        {
            Enabled = true;
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
        }

        // "Customize" methods are automatically executed after every plugin is loaded.
        // So these methods can use Hud.GetPlugin<class> to access the plugin instances' public properties (like decorators, Enabled flag, parameters, etc)
        // Make sure you test the return value against null!
        public void Customize()
        {
            // basic examples

            // turn on MultiplayerExperienceRangePlugin
            Hud.TogglePlugin<MultiplayerExperienceRangePlugin>(true);

            // turn off sell darkening
            Hud.GetPlugin<InventoryAndStashPlugin>().NotGoodDisplayEnabled = false;

            // disable arcane affix label
            Hud.GetPlugin<EliteMonsterAffixPlugin>().AffixDecorators.Remove(MonsterAffix.Arcane);

            // override an elite affix's text
            Hud.GetPlugin<EliteMonsterAffixPlugin>().CustomAffixNames.Add(MonsterAffix.Desecrator, "DES");
			
			// AriadnesThreadPlugin Customization
               Hud.RunOnPlugin<Resu.AriadnesThreadPlugin>(plugin => 
            { 
            plugin.ThreadBetweenPlayers = false; // Set to false to disable the thread between players.
			plugin.Pools = true; // Set to true to enable pools of reflection.
            plugin.BannerTimeSeconds = 3; // Number of seconds you want each player's banner to stay.
            plugin.MetricSystem = false; // Set to true to use metric system for bounty distance.
            });  
			
			// End of AriadnesThreadPlugin Customization
			
			
			// ChannelingPlugin Customization
               Hud.RunOnPlugin<Resu.ChannelingPlugin>(plugin => 
            { 
            plugin.ResourceMax = 100; // Resource % at which the HighNotification sound is played (also threshold for LowNotification to be replayed even if HighNotification is disabled)
            plugin.ResourceMin = 15; // Resource % at which the LowNotification sound is played (also threshold for HighNotification to be replayed even if LowNotification is disabled)
            plugin.DisciplineMax = 100; // Discipline % at which the HighNotification sound is played (also threshold for LowNotification to be replayed even if HighNotification is disabled)
            plugin.DisciplineMin = 15; // Discipline % at which the LowNotification sound is played (also threshold for HighNotification to be replayed even if LowNotification is disabled)           plugin.HatredMax = 100; // Hatred % at which the HighNotification sound is played (also threshold for LowNotification to be replayed even if HighNotification is disabled)
            plugin.HatredMin = 15; // Hatred % at which the LowNotification sound is played (also threshold for HighNotification to be replayed even if LowNotification is disabled)	      
			plugin.HighNotification = false; // Play HighNotification
			plugin.LowNotification = false; // Play LowNotification
	      
            });  
			// End of ChannelingPlugin Customization
			
			// DangerPlugin Customization
               Hud.RunOnPlugin<Resu.DangerPlugin>(plugin => 
            { 
            // set to false; the items you don't want to see 
            plugin.BloodSprings = true; 
            plugin.DemonicForge = true;
            plugin.ShockTower = true;
            plugin.Desecrator = true;
            plugin.Thunderstorm = true;
            plugin.Plagued = true;
            plugin.Molten = true;
            plugin.ArcaneEnchanted = true;
            plugin.PoisonEnchanted = true;
			plugin.GasCloud = true; // (Ghom)
			plugin.SandWaspProjectile = true;
			plugin.MorluSpellcasterMeteorPending = true;
			plugin.DemonMine = true;
			plugin.PoisonDeath = true;
			plugin.MoltenExplosion = true;
			plugin.Orbiter = true;
			plugin.GrotesqueExplosion = true;
            plugin.BetrayedPoisonCloud = true;
            });  
			// End of DangerPlugin Customization
			
			// DeluxeShrineLabelsPlugin Customization
            Hud.RunOnPlugin<Resu.DeluxeShrineLabelsPlugin>(plugin =>      
          {
            //Enable permanent Healing Well display
            plugin.ShowHealingWells = true;

            //Enable permanent Pool of reflection display
            plugin.ShowPoolOfReflection = true;

            // Disable displaying Healing Wells & Pools of reflection only when health is under 40%
			plugin.ShowAllWhenHealthIsUnder40 = false;
		
            //Change Pylon Short Name Example
            plugin.ShrineCustomNamesShort[ShrineType.BanditShrine] = "**BANDIT**";

            //Change Pylon Minimap Name Example
            plugin.ShrineCustomNames[ShrineType.BanditShrine] = "OMG A BANDIT SHRINE";

            //Change Pylon Minimap Decorator Example
            //CreateMapDecorators(Font Size, Saturation(0-255), Red(0-255), Green(0-255), Blue(0-255), Radius Offset)
            plugin.ShrineDecorators[ShrineType.BanditShrine] = plugin.CreateMapDecorators(8,255,255,0,0,5);

            //Change Pylon Ground Label Decorator Example
            //CreateGroundLabelDecorators(Font Size, Saturation(0-255), Red(0-255), Green(0-255), Blue(0-255), Bg Saturation(0-255), Bg Red(0-255), Bg Green(0-255), Bg Blue(0-255) )
            plugin.ShrineShortDecorators[ShrineType.BanditShrine] = plugin.CreateGroundLabelDecorators(8,255,255,0,0,255,0,0,0);
            }); 
			// End of DeluxeShrineLabelsPlugin Customization
			
			// CraftersDelightPlugin Customization
               Hud.RunOnPlugin<Resu.CraftersDelightPlugin>(plugin => 
            { 
            // set to false; the items you don't want to see 
            plugin.ShowAncientRank = true; 
            plugin.SlainFarmers = true;
            plugin.DeathsBreath = true;
            plugin.VeiledCrystal = true;
            plugin.ArcaneDust = true;
            plugin.Gems = true;
            plugin.ForgottenSoul = true;
            plugin.ReusableParts = true;
            plugin.GreaterRiftKeystone = true;
            plugin.BovineBardiche = true;
            plugin.PuzzleRing = true;
            plugin.BloodShards = true;
            plugin.RamaladnisGift = true;
            plugin.Potion = true;
            plugin.InfernalMachine = true;
            plugin.Bounty = true;
            plugin.HellFire = true;
            plugin.LegendaryGems = true;
            plugin.HoradricCaches = true;
            plugin.LoreChestsDisplay = true;
            plugin.NormalChestsDisplay = true;
            plugin.ResplendentChestsDisplay = true;
			plugin.GroupGems = true; // set to false to group gems by type, set to true to group all gems
            plugin.Equipped = true; // set to false to turn off "same item as equipped" drop sound drop & rendering on minimap & inventory.
			plugin.NoobGearMode = false; // set to false to turn off Noob Gear Mode.
            });  
			// End of CraftersDelightPlugin Customization
			
			// Settings for Custom Life Warning Plugin
               Hud.RunOnPlugin<Resu.CustomLifeWarningPlugin>(plugin => 
            { 
            // Sets the life % limit under which you want the warning
            plugin.lifePercentage = 50;
            // Sets the life % limit under which you want to see health globes on ground & minimap
		    plugin.lifePercentageToDisplayGlobes = 40;
            });  
			// End of Settings for Custom Life Warning Plugin
			
			// Settings for Group GR Level Adviser Plugin
               Hud.RunOnPlugin<Resu.GroupGRLevelAdviserPlugin>(plugin => 
            {        
             plugin.RedCircle = true;                  // Set to false if you don't want the red circle
		     plugin.PackLeaderLifePercentage = true;   // Set to false if you don't want the life percentage on elites
		     plugin.TimeToGRBoss = true;               // Set to false if you don't want the time left to boss fight in Grift bar 
            });  
			// End of Settings for Group GR Level Adviser Plugin
			
			// Settings for Hunter's Vengeance Plugin
               Hud.RunOnPlugin<Resu.HuntersVengeancePlugin>(plugin => 
            { 
             plugin.permanentCircle = false;      // Enable permanent circle : Set it to true;
             plugin.ElitesOnlyNumbers = false;    // Enable numbers on elites only : Set it to true;
		     plugin.TargetForAll = true;          // Disable cursor on minimap for all : Set it to false;
            });  
			// End of Settings for Hunter's Vengeance Plugin
			
			// Settings for Paragon Percentage Plugin
               Hud.RunOnPlugin<Resu.ParagonPercentagePlugin>(plugin => 
            { 
            plugin.ParagonPercentageOnTheRight = false; // set to true to display % on the left 
			plugin.ShowGreaterRiftMaxLevel = false; // set to true to disable GR level display
			plugin.DisplayParagonPercentage = true; // set to false to disable paragon percentage display
			plugin.NPCDeco = true; // set to false to disable NPC decorator
            });  
			// End of settings for Paragon Percentage Plugin

			// Disable Top Experience Statistics
               Hud.TogglePlugin<TopExperienceStatistics>(false); 
			// End of Disable Top Experience Statistics
			
			// Settings for UrshisGift Plugin
               Hud.RunOnPlugin<Resu.UrshisGiftPlugin>(plugin => 
            { 
            plugin.ChanceWantedPercentage = 100;  // % chance wanted : 100; 90; 80; 70; 60; 30; 15; 8; 4; 2; 1;
            plugin.NumberOfAttempts = 3;        // Number of consecutive attempts at this % : 1; 2; 3; (default) 4; (empowered GRift or no-death bonus) 5; (empowered GRift + no-death bonus)
            plugin.InventoryNumbers = true;    //show GRift level advised for the gem in inventory, stash, set to true; or false;
            plugin.HoveredNumbers = true;     //show upgrade hint on item hovered, set to true; or false;
            
            });  
			// End of Settings for UrshisGift Plugin
			
			// Settings for Diadra's First Gem Plugin
               Hud.RunOnPlugin<Resu.DiadrasFirstGemPlugin>(plugin => 
            { 
            plugin.ElitesnBossOnly = false;
		    plugin.BossOnly = false;
		    plugin.offsetX = 0;
		    plugin.offsetY = 0;
            });  
			// End of Settings for Diadra's First Gem Plugin
			
			// Settings for Hot Enabler/Disabler Plugin
			// One line per plugin, case sensitive 
               Hud.RunOnPlugin<Resu.HotEnablerDisablerPlugin>(plugin => 
            { 
			plugin.DisableThatGameMode.Add("NameOfThePlugin","Hardcore"); // This disables the plugin NameOfThePlugin for all Hardcore Heroes. 1 entry possible, 2 options : Hardcore Softcore 
			plugin.DisableThatGameType.Add("RandomPlugin","Seasonal"); // This disables the plugin RandomPlugin for all Seasonal Heroes. 1 entry possible, 2 options : Seasonal NonSeasonal 
			plugin.DisableTheseHeroClasses.Add("AnotherPlugin","DemonHunter Necromancer"); // This disables the plugin AnotherPlugin for all DemonHunter & Necromancer Heroes. Many entries possible for one plugin, separated by spaces : DemonHunter Barbarian Wizard WitchDoctor Monk Crusader Necromancer 
			plugin.DisableTheseHeroNames.Add("YetAnotherPlugin","IncredibleMe"); // This disables the plugin YetAnotherPlugin for the Hero named IncredibleMe. Many entries possible for one plugin, separated by spaces. 
			});	
			// End of Settings for Hot Enabler/Disabler Plugin
			
			// Settings for Other Player's Heads Plugin
               Hud.RunOnPlugin<Resu.OtherPlayersHeadsPlugin>(plugin => 
            { 
            plugin.ShowCompanions = true; // set to false to not display companions
            });  
			// End of Settings for Other Player's Heads Plugin
        }

    }

}