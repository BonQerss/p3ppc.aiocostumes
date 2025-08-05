using p3ppc.aiocostumes.Configuration;
using p3ppc.aiocostumes.Template;
using PAK.Stream.Emulator.Interfaces;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;

namespace p3ppc.aiocostumes
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public class Mod : ModBase // <= Do not Remove.
    {
        /// <summary>
        /// Provides access to the mod loader API.
        /// </summary>
        private readonly IModLoader _modLoader;

        /// <summary>
        /// Provides access to the Reloaded.Hooks API.
        /// </summary>
        /// <remarks>This is null if you remove dependency on Reloaded.SharedLib.Hooks in your mod.</remarks>
        private readonly IReloadedHooks? _hooks;

        /// <summary>
        /// Provides access to the Reloaded logger.
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// Entry point into the mod, instance that created this class.
        /// </summary>
        private readonly IMod _owner;

        /// <summary>
        /// Provides access to this mod's configuration.
        /// </summary>
        private Config _configuration;

        /// <summary>
        /// The configuration of the currently executing mod.
        /// </summary>
        private readonly IModConfig _modConfig;

        public Mod(ModContext context)
        {
            _modLoader = context.ModLoader;
            _hooks = context.Hooks;
            _logger = context.Logger;
            _owner = context.Owner;
            _configuration = context.Configuration;
            _modConfig = context.ModConfig;

            var PakEmulatorController = _modLoader.GetController<IPakEmulator>();
            if (PakEmulatorController == null || !PakEmulatorController.TryGetTarget(out var _PakEmulator))
            {
                _logger.WriteLine($"PakEmulatorController returned as null! Files won't load!", System.Drawing.Color.Red);
                return;
            }

            _logger.WriteLine($"[DEBUG] PAK Emulator found and initialized successfully");
            _logger.WriteLine($"[DEBUG] PAK Emulator type: {_PakEmulator.GetType().Name}");

            var modDir = _modLoader.GetDirectoryForModId(_modConfig.ModId);

            // After getting the PAK emulator, add this debug
            var pakFiles = _PakEmulator.GetEmulatorInput();
            _logger.WriteLine($"[DEBUG] PAK Emulator has {pakFiles.Length} route groups:");
            foreach (var route in pakFiles)
            {
                _logger.WriteLine($"[DEBUG] Route: {route.Route}");
                if (route.Route.Contains("model") || route.Route.Contains("pack"))
                {
                    _logger.WriteLine($"[DEBUG] *** Model/Pack route found: {route.Route} ***");
                }
            }


            Config.MakotoCostume costumeChar1;
            Config.KotoneCostume costumeChar2;
            Config.YukariCostume costumeChar3;
            Config.JunpeiCostume costumeChar4;
            Config.AkihikoCostume costumeChar5;
            Config.MitsuruCostume costumeChar6;
            Config.AigisCostume costumeChar7;
            Config.KenCostume costumeChar8;
            Config.ShinjiroCostume costumeChar9;
            Config.KoromaruCostume costumeChar10;

            // you like my absolute dog shit config names? cool, right?

            if (_configuration.RandomizeMakotoCostumes)
            {
                costumeChar1 = GetRandomCostume<Config.MakotoCostume>();
            }
            else
            {
                costumeChar1 = _configuration.CostumeChar1;
            }

            if (_configuration.RandomizeKotoneCostumes)
            {
                costumeChar2 = GetRandomCostume<Config.KotoneCostume>();
            }
            else
            {
                costumeChar2 = _configuration.CostumeChar2;
            }

            if (_configuration.RandomizeYukariCostumes)
            {
                costumeChar3 = GetRandomCostume<Config.YukariCostume>();
            }
            else
            {
                costumeChar3 = _configuration.CostumeChar3;
            }

            if (_configuration.RandomizeJunpeiCostumes)
            {
                costumeChar4 = GetRandomCostume<Config.JunpeiCostume>();
            }
            else
            {
                costumeChar4 = _configuration.CostumeChar4;
            }

            if (_configuration.RandomizeAkihikoCostumes)
            {
                costumeChar5 = GetRandomCostume<Config.AkihikoCostume>();
            }
            else
            {
                costumeChar5 = _configuration.CostumeChar5;
            }

            if (_configuration.RandomizeMitsuruCostumes)
            {
                costumeChar6 = GetRandomCostume<Config.MitsuruCostume>();
            }
            else
            {
                costumeChar6 = _configuration.CostumeChar6;
            }

            if (_configuration.RandomizeAigisCostumes)
            {
                costumeChar7 = GetRandomCostume<Config.AigisCostume>();
            }
            else
            {
                costumeChar7 = _configuration.CostumeChar7;
            }

            if (_configuration.RandomizeKenCostumes)
            {
                costumeChar8 = GetRandomCostume<Config.KenCostume>();
            }
            else
            {
                costumeChar8 = _configuration.CostumeChar8;
            }

            if (_configuration.RandomizeShinjiroCostumes)
            {
                costumeChar9 = GetRandomCostume<Config.ShinjiroCostume>();
            }
            else
            {
                costumeChar9 = _configuration.CostumeChar9;
            }

            if (_configuration.RandomizeKoromaruCostumes)
            {
                costumeChar10 = GetRandomCostume<Config.KoromaruCostume>();
            }
            else
            {
                costumeChar10 = _configuration.CostumeChar10;
            }





            if (costumeChar1 != Config.MakotoCostume.None)
            {
                string costumeFolder = costumeChar1 switch
                {
                    Config.MakotoCostume.PhantomThief => "Phantom Thieves",
                    Config.MakotoCostume.Dancing => "Dancing",
                    Config.MakotoCostume.Nahobino => "Nahobino",
                    Config.MakotoCostume.Q2 => "Q2",
                    Config.MakotoCostume.JustAPhase => "Just-A-Phase",
                    Config.MakotoCostume.Messiah => "Persona Outfits",
                    Config.MakotoCostume.Orpheus => "Persona Outfits",
                    Config.MakotoCostume.OrpheusTelos => "Persona Outfits",
                    Config.MakotoCostume.Thanatos => "Persona Outfits",
                    Config.MakotoCostume.P4AU => "P4AU",
                    _ => string.Empty
                };

                string[] variants = _configuration.CostumeSlot1 switch
                {
                    Config.MakotoCostumeSlot.bc001 => new[] { "" },
                    Config.MakotoCostumeSlot.bc001_c0 => new[] { "_c0" },
                    Config.MakotoCostumeSlot.bc001_c1 => new[] { "_c1" },
                    Config.MakotoCostumeSlot.bc001_c2 => new[] { "_c2" },
                    Config.MakotoCostumeSlot.bc001_c5 => new[] { "_c5" },
                    Config.MakotoCostumeSlot.bc001_c9 => new[] { "_c9" },
                    _ => new[] { "" }
                };

                if (!string.IsNullOrEmpty(costumeFolder) && variants.Length > 0)
                {
                    string name = (costumeChar1 is Config.MakotoCostume.Messiah or Config.MakotoCostume.Orpheus or Config.MakotoCostume.OrpheusTelos or Config.MakotoCostume.Thanatos)
                        ? Path.Combine("Makoto", costumeChar1.ToString()) : "Makoto";

                    AddCharacterFiles(_PakEmulator, modDir, name, costumeFolder, "bc001", variants);
                }
            }




            // figure out kotone later
            // currently doesn't bind second phantom thief outfit due to how poorly this is written
            // probably just need to structure it like how persona outfits are strcutured
            if (costumeChar2 != Config.KotoneCostume.None)
            {
                string costumeFolder = costumeChar2 switch
                {
                    Config.KotoneCostume.PhantomThief => "Phantom Thieves",
                    Config.KotoneCostume.PhantomThief2 => "Phantom Thieves",
                    Config.KotoneCostume.Nahobino => "Nahobino",
                    Config.KotoneCostume.Q2 => "Q2",
                    Config.KotoneCostume.Messiah => "Persona Outfits",
                    Config.KotoneCostume.Orpheus => "Persona Outfits",
                    Config.KotoneCostume.OrpheusTelos => "Persona Outfits",
                    Config.KotoneCostume.Thanatos => "Persona Outfits",
                    _ => string.Empty
                };

                string[] variants = _configuration.CostumeSlot2 switch
                {
                    Config.KotoneCostumeSlot.bc063 => new[] { "" },
                    Config.KotoneCostumeSlot.bc063_c0 => new[] { "_c0" },
                    Config.KotoneCostumeSlot.bc063_c1 => new[] { "_c1" },
                    Config.KotoneCostumeSlot.bc063_c2 => new[] { "_c2" },
                    Config.KotoneCostumeSlot.bc063_c3 => new[] { "_c3" },
                    Config.KotoneCostumeSlot.bc063_c5 => new[] { "_c5" },
                    Config.KotoneCostumeSlot.bc063_c9 => new[] { "_c9" },
                    _ => new[] { "" }
                };

                if (!string.IsNullOrEmpty(costumeFolder) && variants.Length > 0)
                {
                    string name = (costumeChar2 is Config.KotoneCostume.Messiah or Config.KotoneCostume.Orpheus or Config.KotoneCostume.OrpheusTelos or Config.KotoneCostume.Thanatos)
                        ? Path.Combine("Kotone", costumeChar2.ToString()) : "Kotone";

                    AddCharacterFiles(_PakEmulator, modDir, name, costumeFolder, "bc063", variants);
                }
            }


            if (costumeChar3 != Config.YukariCostume.None)
            {
                string costumeFolder = costumeChar3 switch
                {
                    Config.YukariCostume.PhantomThief => "Phantom Thieves",
                    Config.YukariCostume.Q2 => "Q2",
                    Config.YukariCostume.P4AU => "P4AU",
                    Config.YukariCostume.JustAPhase => "Just-A-Phase",
                    _ => string.Empty
                };

                string[] variants = _configuration.CostumeSlot3 switch
                {
                    Config.YukariCostumeSlot.bc002 => new[] { "" },
                    Config.YukariCostumeSlot.bc002_c0 => new[] { "_c0" },
                    Config.YukariCostumeSlot.bc002_c1 => new[] { "_c1" },
                    Config.YukariCostumeSlot.bc002_c2 => new[] { "_c2" },
                    Config.YukariCostumeSlot.bc002_c3 => new[] { "_c3" },
                    Config.YukariCostumeSlot.bc002_c5 => new[] { "_c5" },
                    Config.YukariCostumeSlot.bc002_c6 => new[] { "_c6" },
                    _ => new[] { "" } // default to base pac
                };

                if (!string.IsNullOrEmpty(costumeFolder) && variants.Length > 0)
                {
                    AddCharacterFiles(_PakEmulator, modDir, "Yukari", costumeFolder, "bc002", variants);
                }
            }



            if (costumeChar4 != Config.JunpeiCostume.None)
            {
                string costumeFolder = costumeChar4 switch
                {
                    Config.JunpeiCostume.PhantomThief => "Phantom Thieves",
                    Config.JunpeiCostume.Q2 => "Q2",
                    Config.JunpeiCostume.P4AU => "P4AU",
                    Config.JunpeiCostume.JustAPhase => "Just-A-Phase",
                    _ => string.Empty
                };

                string[] variants = _configuration.CostumeSlot4 switch
                {
                    Config.JunpeiCostumeSlot.bc005 => new[] { "" },
                    Config.JunpeiCostumeSlot.bc005_c0 => new[] { "_c0" },
                    Config.JunpeiCostumeSlot.bc005_c1 => new[] { "_c1" },
                    Config.JunpeiCostumeSlot.bc005_c2 => new[] { "_c2" },
                    Config.JunpeiCostumeSlot.bc005_c5 => new[] { "_c5" },
                    Config.JunpeiCostumeSlot.bc005_c6 => new[] { "_c6" },
                    _ => new[] { "" } // default to base pac
                };

                if (!string.IsNullOrEmpty(costumeFolder) && variants.Length > 0)
                {
                    AddCharacterFiles(_PakEmulator, modDir, "Junpei", costumeFolder, "bc005", variants);
                }
            }



            if (costumeChar5 != Config.AkihikoCostume.None)
            {
                string costumeFolder = costumeChar5 switch
                {
                    Config.AkihikoCostume.PhantomThief => "Phantom Thieves",
                    Config.AkihikoCostume.Q2 => "Q2",
                    Config.AkihikoCostume.P4AU => "P4AU",
                    Config.AkihikoCostume.JustAPhase => "Just-A-Phase",
                    _ => string.Empty
                };

                string[] variants = _configuration.CostumeSlot5 switch
                {
                    Config.AkihikoCostumeSlot.bc007 => new[] { "" },
                    Config.AkihikoCostumeSlot.bc007_c0 => new[] { "_c0" },
                    Config.AkihikoCostumeSlot.bc007_c1 => new[] { "_c1" },
                    Config.AkihikoCostumeSlot.bc007_c2 => new[] { "_c2" },
                    Config.AkihikoCostumeSlot.bc007_c5 => new[] { "_c5" },
                    Config.AkihikoCostumeSlot.bc007_c6 => new[] { "_c6" },
                    _ => new[] { "" } // default to base pac
                };

                if (!string.IsNullOrEmpty(costumeFolder) && variants.Length > 0)
                {
                    AddCharacterFiles(_PakEmulator, modDir, "Akihiko", costumeFolder, "bc007", variants);
                }
            }




            if (costumeChar6 != Config.MitsuruCostume.None)
            {
                string costumeFolder = costumeChar6 switch
                {
                    Config.MitsuruCostume.PhantomThief => "Phantom Thieves",
                    Config.MitsuruCostume.Q2 => "Q2",
                    Config.MitsuruCostume.JustAPhase => "Just-A-Phase",
                    Config.MitsuruCostume.P4AU => "P4AU",
                    Config.MitsuruCostume.P3R => "P3R",
                    _ => string.Empty
                };

                string[] variants = _configuration.CostumeSlot6 switch
                {
                    Config.MitsuruCostumeSlot.bc004 => new[] { "" },
                    Config.MitsuruCostumeSlot.bc004_c0 => new[] { "_c0" },
                    Config.MitsuruCostumeSlot.bc004_c1 => new[] { "_c1" },
                    Config.MitsuruCostumeSlot.bc004_c2 => new[] { "_c2" },
                    Config.MitsuruCostumeSlot.bc004_c3 => new[] { "_c3" },
                    Config.MitsuruCostumeSlot.bc004_c5 => new[] { "_c5" },
                    Config.MitsuruCostumeSlot.bc004_c6 => new[] { "_c6" },
                    _ => new[] { "" } // default to base pac
                };

                if (!string.IsNullOrEmpty(costumeFolder) && variants.Length > 0)
                {
                    AddCharacterFiles(_PakEmulator, modDir, "Mitsuru", costumeFolder, "bc004", variants);
                }
            }

            // Aigis if that wasn't clear enough already
            if (costumeChar7 != Config.AigisCostume.None)
            {
                string costumeFolder = costumeChar7 switch
                {
                    Config.AigisCostume.PhantomThief => "Phantom Thieves",
                    Config.AigisCostume.Q2 => "Q2",
                    Config.AigisCostume.JustAPhase => "Just-A-Phase",
                    Config.AigisCostume.P4AU => "P4AU",
                    Config.AigisCostume.P3R => "P3R",
                    _ => string.Empty
                };

                string[] variants = _configuration.CostumeSlot7 switch
                {
                    Config.AigisCostumeSlot.bc003 => new[] { "" },
                    Config.AigisCostumeSlot.bc003_c0 => new[] { "_c0" },
                    Config.AigisCostumeSlot.bc003_c3 => new[] { "_c3" },
                    Config.AigisCostumeSlot.bc003_c4 => new[] { "_c4" },
                    Config.AigisCostumeSlot.bc003_c6 => new[] { "_c6" },
                    _ => new[] { "" } // default to base pac
                };

                if (!string.IsNullOrEmpty(costumeFolder) && variants.Length > 0)
                {
                    AddCharacterFiles(_PakEmulator, modDir, "Aigis", costumeFolder, "bc003", variants);
                }
            }


            // Ken
            if (costumeChar8 != Config.KenCostume.None)
            {
                string costumeFolder = costumeChar8 switch
                {
                    Config.KenCostume.PhantomThief => "Phantom Thieves",
                    Config.KenCostume.Q2 => "Q2",
                    Config.KenCostume.JustAPhase => "Just-A-Phase",
                    Config.KenCostume.P4AU => "P4AU",
                    _ => string.Empty
                };

                string[] variants = _configuration.CostumeSlot8 switch
                {
                    Config.KenCostumeSlot.bc008 => new[] { "" },
                    Config.KenCostumeSlot.bc008_c1 => new[] { "_c1" },
                    Config.KenCostumeSlot.bc008_c2 => new[] { "_c2" },
                    Config.KenCostumeSlot.bc008_c5 => new[] { "_c5" },
                    Config.KenCostumeSlot.bc008_c6 => new[] { "_c6" },
                    _ => new[] { "" } // default to base pac
                };

                if (!string.IsNullOrEmpty(costumeFolder) && variants.Length > 0)
                {
                    AddCharacterFiles(_PakEmulator, modDir, "Ken", costumeFolder, "bc008", variants);
                }
            }


            // Shinjiro
            if (costumeChar9 != Config.ShinjiroCostume.None)
            {
                string costumeFolder = costumeChar9 switch
                {
                    Config.ShinjiroCostume.PhantomThief => "Phantom Thieves",
                    Config.ShinjiroCostume.Q2 => "Q2",
                    Config.ShinjiroCostume.JustAPhase => "Just-A-Phase",
                    _ => string.Empty
                };

                string[] variants = _configuration.CostumeSlot9 switch
                {
                    Config.ShinjiroCostumeSlot.bc009 => new[] { "" },
                    Config.ShinjiroCostumeSlot.bc009_c5 => new[] { "_c5" },
                    Config.ShinjiroCostumeSlot.bc009_c6 => new[] { "_c6" },
                    _ => Array.Empty<string>()
                };

                if (!string.IsNullOrEmpty(costumeFolder) && variants.Length > 0)
                {
                    AddCharacterFiles(_PakEmulator, modDir, "Shinjiro", costumeFolder, "bc009", variants);
                }
            }

            // Koromaru
            if (costumeChar10 != Config.KoromaruCostume.None)
            {
                string costumeFolder = costumeChar10 switch
                {
                    Config.KoromaruCostume.PhantomThief => "Phantom Thieves",
                    Config.KoromaruCostume.Q2 => "Q2",
                    Config.KoromaruCostume.JustAPhase => "Just-A-Phase",
                    Config.KoromaruCostume.P3R => "P3R",
                    _ => string.Empty
                };

                string[] variants = _configuration.CostumeSlot10 switch
                {
                    Config.KoromaruCostumeSlot.bc00A => new[] { "" },
                    Config.KoromaruCostumeSlot.bc00A_c6 => new[] { "_c6" },
                    _ => Array.Empty<string>()
                };

                if (!string.IsNullOrEmpty(costumeFolder) && variants.Length > 0)
                {
                    AddCharacterFiles(_PakEmulator, modDir, "Koromaru", costumeFolder, "bc00A", variants);
                }
            }

        }

        private static T GetRandomCostume<T>() where T : Enum
        {
            Random rng = new();
            var values = Enum.GetValues(typeof(T)).Cast<T>().Where(e => !e.ToString().Equals("None")).ToArray();
            return values[rng.Next(values.Length)];
        }

        private void AddCharacterFiles(IPakEmulator pakEmulator, string modDir, string characterName, string costumeFolder, string baseFileName, string[] fileVariants)
        {
            string gmoPath = Path.Combine(modDir, costumeFolder, characterName, $"{baseFileName}.GMO");
            _logger.WriteLine($"[INFO] Looking for GMO file at: {gmoPath}");

            if (!File.Exists(gmoPath))
            {
                _logger.WriteLine($"[ERROR] GMO file NOT FOUND at path: {gmoPath}", System.Drawing.Color.Red);
                return;
            }

            _logger.WriteLine($"[INFO] Found GMO file. Attempting to add variants for {characterName}...");

            foreach (var variant in fileVariants)
            {
                // Add base pac (e.g. bc009.pac or bc009c6.pac)
                string basePacName = $"{baseFileName}{variant}.pac";
                string baseRoute = $@"model\pack\{basePacName}";
                string virtualPath = $"{baseFileName}.GMO";

                _logger.WriteLine($"[INFO] Adding to base PAC:");
                _logger.WriteLine($"       Physical path: {gmoPath}");
                _logger.WriteLine($"       Route: {baseRoute}");
                _logger.WriteLine($"       Virtual path: {virtualPath}");

                try
                {
                    pakEmulator.AddFile(gmoPath, baseRoute, virtualPath);
                    _logger.WriteLine($"[SUCCESS] Registered {baseRoute}", System.Drawing.Color.Green);
                }
                catch (Exception ex)
                {
                    _logger.WriteLine($"[ERROR] Failed to register {baseRoute}: {ex.Message}", System.Drawing.Color.Red);
                }

                // Add awakening pac (e.g. bc009a.pac or bc009c6a.pac)
                string awakeningPacName = $"{baseFileName}{variant}a.pac";
                string awakeningRoute = $@"model\pack\{awakeningPacName}";

                _logger.WriteLine($"[INFO] Adding to awakening PAC:");
                _logger.WriteLine($"       Physical path: {gmoPath}");
                _logger.WriteLine($"       Route: {awakeningRoute}");
                _logger.WriteLine($"       Virtual path: {virtualPath}");

                try
                {
                    pakEmulator.AddFile(gmoPath, awakeningRoute, virtualPath);
                    _logger.WriteLine($"[SUCCESS] Registered {awakeningRoute}", System.Drawing.Color.Green);
                }
                catch (Exception ex)
                {
                    _logger.WriteLine($"[ERROR] Failed to register {awakeningRoute}: {ex.Message}", System.Drawing.Color.Red);
                }
            }
        }











        #region For Exports, Serialization etc.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Mod() { }
#pragma warning restore CS8618
        #endregion
    }
}