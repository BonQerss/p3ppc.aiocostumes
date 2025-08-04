using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using p3ppc.aiocostumes.Template.Configuration;
using Reloaded.Mod.Interfaces.Structs;

namespace p3ppc.aiocostumes.Configuration
{
    public class Config : Configurable<Config>
    {
        /*
            User Properties:
                - Please put all of your configurable properties here.
    
            By default, configuration saves as "Config.json" in mod user config folder.    
            Need more config files/classes? See Configuration.cs
    
            Available Attributes:
            - Category
            - DisplayName
            - Description
            - DefaultValue

            // Technically Supported but not Useful
            - Browsable
            - Localizable

            The `DefaultValue` attribute is used as part of the `Reset` button in Reloaded-Launcher.
        */

        public enum MakotoCostume
        {
            [Display(Name = "No Costume Selected")]
            None,
            [Display(Name = "Joker from Persona 5")]
            PhantomThief,
            [Display(Name = "Persona 3 Dancing")]
            Dancing,
            [Display(Name = "Second Form Nahobino")]
            Nahobino,
            [Display(Name = "Persona Q2")]
            Q2,
            [Display(Name = "Just-A-Phase")]
            JustAPhase,
            [Display(Name = "Messiah")]
            Messiah,
            [Display(Name = "Orpheus")]
            Orpheus,
            [Display(Name = "Orpheus Telos")]
            OrpheusTelos,
            [Display(Name = "Thanatos")]
            Thanatos,
            [Display(Name = "P4AU")]
            P4AU,
        }

        public enum KotoneCostume
        {
            [Display(Name = "No Costume Selected")]
            None,
            [Display(Name = "Violet from Persona 5 Royal")]
            PhantomThief,
            [Display(Name = "Joker from Persona 5")]
            PhantomThief2,
            [Display(Name = "Second Form Nahobino")]
            Nahobino,
            [Display(Name = "Persona Q2")]
            Q2,
            [Display(Name = "Messiah")]
            Messiah,
            [Display(Name = "Orpheus")]
            Orpheus,
            [Display(Name = "Orpheus Telos")]
            OrpheusTelos,
            [Display(Name = "Thanatos")]
            Thanatos,
        }

        public enum YukariCostume
        {
            [Display(Name = "No Costume Selected")]
            None,
            [Display(Name = "Panther from Persona 5")]
            PhantomThief,
            [Display(Name = "Persona Q2")]
            Q2,
            [Display(Name = "P4AU")]
            P4AU,
            [Display(Name = "Just-A-Phase")]
            JustAPhase,
        }

        public enum JunpeiCostume
        {
            [Display(Name = "No Costume Selected")]
            None,
            [Display(Name = "Wolf from Persona 5 Strikers")]
            PhantomThief,
            [Display(Name = "Persona Q2")]
            Q2,
            [Display(Name = "P4AU")]
            P4AU,
            [Display(Name = "Just-A-Phase")]
            JustAPhase,
        }

        public enum AkihikoCostume
        {
            [Display(Name = "No Costume Selected")]
            None,
            [Display(Name = "Skull from Persona 5")]
            PhantomThief,
            [Display(Name = "Persona Q2")]
            Q2,
            [Display(Name = "P4AU")]
            P4AU,
            [Display(Name = "Just-A-Phase")]
            JustAPhase,
        }

        public enum MitsuruCostume
        {
            [Display(Name = "No Costume Selected")]
            None,
            [Display(Name = "Noir from Persona 5")]
            PhantomThief,
            [Display(Name = "Persona Q2")]
            Q2,
            [Display(Name = "P4AU")]
            P4AU,
            [Display(Name = "Just-A-Phase")]
            JustAPhase,
            [Display(Name = "P3R SEES Gear")]
            P3R,
        }

        public enum AigisCostume
        {
            [Display(Name = "No Costume Selected")]
            None,
            [Display(Name = "Queen from Persona 5")]
            PhantomThief,
            [Display(Name = "Persona Q2")]
            Q2,
            [Display(Name = "P4AU")]
            P4AU,
            [Display(Name = "Just-A-Phase")]
            JustAPhase,
            [Display(Name = "P3R SEES Gear")]
            P3R,
        }

        public enum KenCostume
        {
            [Display(Name = "No Costume Selected")]
            None,
            [Display(Name = "Fox from Persona 5")]
            PhantomThief,
            [Display(Name = "Persona Q2")]
            Q2,
            [Display(Name = "P4AU")]
            P4AU,
            [Display(Name = "Just-A-Phase")]
            JustAPhase,
        }

        public enum ShinjiroCostume
        {
            [Display(Name = "No Costume Selected")]
            None,
            [Display(Name = "Crow from Persona 5")]
            PhantomThief,
            [Display(Name = "Persona Q2")]
            Q2,
            [Display(Name = "Just-A-Phase")]
            JustAPhase,
        }

        public enum KoromaruCostume
        {
            [Display(Name = "No Costume Selected")]
            None,
            [Display(Name = "Mona from Persona 5")]
            PhantomThief,
            [Display(Name = "Persona Q2")]
            Q2,
            [Display(Name = "Just-A-Phase")]
            JustAPhase,
            [Display(Name = "P3R SEES Gear")]
            P3R,
        }

        public enum MakotoCostumeSlot
        {
            [Display(Name = "Original costume (bc001)")]
            bc001,
            [Display(Name = "Swim Trunks (bc001_c0)")]
            bc001_c0,
            [Display(Name = "Summer Casual (bc001_c1)")]
            bc001_c1,
            [Display(Name = "Winter Casual (bc001_c2)")]
            bc001_c2,
            [Display(Name = "Shirt of Chivalry (bc001_c5)")]
            bc001_c5,
            [Display(Name = "Winter Uniform (no sees) (bc001_c9)")]
            bc001_c9,
        }

        public enum KotoneCostumeSlot
        {
            [Display(Name = "Original costume (bc063)")]
            bc063,
            [Display(Name = "Swimsuit (bc063_c0)")]
            bc063_c0,
            [Display(Name = "Summer Casual (bc063_c1)")]
            bc063_c1,
            [Display(Name = "Winter Casual (bc063_c2)")]
            bc063_c2,
            [Display(Name = "Maid Outfit (bc063_c3)")]
            bc063_c3,
            [Display(Name = "High-cut Armor (bc063_c5)")]
            bc063_c5,
            [Display(Name = "Winter Uniform (no sees) (bc063_c9)")]
            bc063_c9,
        }

        public enum YukariCostumeSlot
        {
            [Display(Name = "Original costume (bc002)")]
            bc002,
            [Display(Name = "Swimsuit (bc002_c0)")]
            bc002_c0,
            [Display(Name = "Summer Casual (bc002_c1)")]
            bc002_c1,
            [Display(Name = "Winter Casual (bc002_c2)")]
            bc002_c2,
            [Display(Name = "Maid Outfit (bc002_c3)")]
            bc002_c3,
            [Display(Name = "High-Cut Armor (bc002_c5)")]
            bc002_c5,
            [Display(Name = "Christmas Outfit (bc002_c6)")]
            bc002_c6,
        }

        public enum JunpeiCostumeSlot
        {
            [Display(Name = "Original costume (bc005)")]
            bc005,
            [Display(Name = "Swimsuit (bc005_c0)")]
            bc005_c0,
            [Display(Name = "Summer Casual (bc005_c1)")]
            bc005_c1,
            [Display(Name = "Winter Casual (bc005_c2)")]
            bc005_c2,
            [Display(Name = "Shirt of Chivalry (bc005_c5)")]
            bc005_c5,
            [Display(Name = "Butler Outfit (bc005_c6)")]
            bc005_c6,
        }

        public enum AkihikoCostumeSlot
        {
            [Display(Name = "Original costume (bc007)")]
            bc007,
            [Display(Name = "Swimsuit (bc007_c0)")]
            bc007_c0,
            [Display(Name = "Summer Casual (bc007_c1)")]
            bc007_c1,
            [Display(Name = "Winter Casual (bc007_c2)")]
            bc007_c2,
            [Display(Name = "Shirt of Chivalry (bc007_c5)")]
            bc007_c5,
            [Display(Name = "Butler Outfit (bc007_c6)")]
            bc007_c6,
            
        }

        public enum MitsuruCostumeSlot
        {
            [Display(Name = "Original costume (bc004)")]
            bc004,
            [Display(Name = "Swimsuit (bc004)")]
            bc004_c0,
            [Display(Name = "Summer Casual (bc004)")]
            bc004_c1,
            [Display(Name = "Winter Casual (bc004)")]
            bc004_c2,
            [Display(Name = "Maid Outfit (bc004)")]
            bc004_c3,
            [Display(Name = "High-Cut Armor (bc004_c5)")]
            bc004_c5,
            [Display(Name = "Christmas Outfit (bc004_c6)")]
            bc004_c6,
        }

        public enum AigisCostumeSlot
        {
            [Display(Name = "Original costume (bc003)")]
            bc003,
            [Display(Name = "Blue dress (bc003_c0)")]
            bc003_c0,
            [Display(Name = "Maid outfit (bc003_c3)")]
            bc003_c3,
            [Display(Name = "School Uniform (bc003_c4)")]
            bc003_c4,
            [Display(Name = "Christmas Outfit (bc003_c6)")]
            bc003_c6,
        }

        public enum KenCostumeSlot
        {
            [Display(Name = "Original costume (bc008)")]
            bc008,
            [Display(Name = "Summer Casual (bc008_c1)")]
            bc008_c1,
            [Display(Name = "Winter Casual (bc008_c2)")]
            bc008_c2,
            [Display(Name = "Shirt of Chivalry (bc008_c5)")]
            bc008_c5,
            [Display(Name = "Butler Outfit (bc008_c6)")]
            bc008_c6,
        }

        public enum ShinjiroCostumeSlot
        {
            [Display(Name = "Original costume (bc009)")]
            bc009,
            [Display(Name = "Shirt of Chivalry (bc009_c5)")]
            bc009_c5,
            [Display(Name = "Butler Outfit (bc009_c6)")]
            bc009_c6,
        }

        public enum KoromaruCostumeSlot
        {
            [Display(Name = "Original costume (bc00A)")]
            bc00A,
            [Display(Name = "Butler Outfit (bc00A_c6)")]
            bc00A_c6,
        }

        // Makoto Configuration
        [Category("Makoto Costume")]
        [Display(Order = 0)]
        [DisplayName("Choose which costume\nfor the Male Protag.")]
        [DefaultValue(MakotoCostume.None)]
        public MakotoCostume CostumeChar1 { get; set; } = MakotoCostume.None;

        [Category("Makoto Costume")]
        [Display(Order = 1)]
        [DisplayName("Choose which original costume\nto replace for Makoto.")]
        [DefaultValue(MakotoCostumeSlot.bc001)]
        public MakotoCostumeSlot CostumeSlot1 { get; set; } = MakotoCostumeSlot.bc001;

        [Category("Makoto Costume")]
        [Display(Order = 2)]
        [DisplayName("Randomize all costumes\nfor Makoto")]
        [DefaultValue(false)]
        public bool RandomizeMakotoCostumes { get; set; } = false;

        [Category("Kotone Costume")]
        [Display(Order = 3)]
        [DisplayName("Choose which costume\nfor the Female Protag.")]
        [DefaultValue(KotoneCostume.None)]
        public KotoneCostume CostumeChar2 { get; set; } = KotoneCostume.None;

        [Category("Kotone Costume")]
        [Display(Order = 4)]
        [DisplayName("Choose which original costume\nto replace for the Female Protag.")]
        [DefaultValue(KotoneCostumeSlot.bc063)]
        public KotoneCostumeSlot CostumeSlot2 { get; set; } = KotoneCostumeSlot.bc063;

        [Category("Kotone Costume")]
        [Display(Order = 5)]
        [DisplayName("Randomize all costumes\nfor Kotone")]
        [DefaultValue(false)]
        public bool RandomizeKotoneCostumes { get; set; } = false;

        [Category("Yukari Costume")]
        [Display(Order = 6)]
        [DisplayName("Choose which costume\nfor Yukari.")]
        [DefaultValue(YukariCostume.None)]
        public YukariCostume CostumeChar3 { get; set; } = YukariCostume.None;

        [Category("Yukari Costume")]
        [Display(Order = 7)]
        [DisplayName("Choose which original costume\nto replace for Yukari.")]
        [DefaultValue(YukariCostumeSlot.bc002)]
        public YukariCostumeSlot CostumeSlot3 { get; set; } = YukariCostumeSlot.bc002;

        [Category("Yukari Costume")]
        [Display(Order = 8)]
        [DisplayName("Randomize all costumes\nfor Yukari")]
        [DefaultValue(false)]
        public bool RandomizeYukariCostumes { get; set; } = false;

        [Category("Junpei Costume")]
        [Display(Order = 9)]
        [DisplayName("Choose which costume\nfor Junpei.")]
        [DefaultValue(JunpeiCostume.None)]
        public JunpeiCostume CostumeChar4 { get; set; } = JunpeiCostume.None;

        [Category("Junpei Costume")]
        [Display(Order = 10)]
        [DisplayName("Choose which original costume\nto replace for Junpei.")]
        [DefaultValue(JunpeiCostumeSlot.bc005)]
        public JunpeiCostumeSlot CostumeSlot4 { get; set; } = JunpeiCostumeSlot.bc005;

        [Category("Junpei Costume")]
        [Display(Order = 11)]
        [DisplayName("Randomize all costumes\nfor Junpei")]
        [DefaultValue(false)]
        public bool RandomizeJunpeiCostumes { get; set; } = false;

        [Category("Akihiko Costume")]
        [Display(Order = 12)]
        [DisplayName("Choose which costume\nfor Akihiko.")]
        [DefaultValue(AkihikoCostume.None)]
        public AkihikoCostume CostumeChar5 { get; set; } = AkihikoCostume.None;

        [Category("Akihiko Costume")]
        [Display(Order = 13)]
        [DisplayName("Choose which original costume\nto replace for Akihiko.")]
        [DefaultValue(AkihikoCostumeSlot.bc007)]
        public AkihikoCostumeSlot CostumeSlot5 { get; set; } = AkihikoCostumeSlot.bc007;

        [Category("Akihiko Costume")]
        [Display(Order = 14)]
        [DisplayName("Randomize all costumes\nfor Akihiko")]
        [DefaultValue(false)]
        public bool RandomizeAkihikoCostumes { get; set; } = false;

        [Category("Mitsuru Costume")]
        [Display(Order = 15)]
        [DisplayName("Choose which costume\nfor Mitsuru.")]
        [DefaultValue(MitsuruCostume.None)]
        public MitsuruCostume CostumeChar6 { get; set; } = MitsuruCostume.None;

        [Category("Mitsuru Costume")]
        [Display(Order = 16)]
        [DisplayName("Choose which original costume\nto replace for Mitsuru.")]
        [DefaultValue(MitsuruCostumeSlot.bc004)]
        public MitsuruCostumeSlot CostumeSlot6 { get; set; } = MitsuruCostumeSlot.bc004;

        [Category("Mitsuru Costume")]
        [Display(Order = 17)]
        [DisplayName("Randomize all costumes\nfor Mitsuru")]
        [DefaultValue(false)]
        public bool RandomizeMitsuruCostumes { get; set; } = false;

        [Category("Aigis Costume")]
        [Display(Order = 18)]
        [DisplayName("Choose which costume\nfor Aigis.")]
        [DefaultValue(AigisCostume.None)]
        public AigisCostume CostumeChar7 { get; set; } = AigisCostume.None;

        [Category("Aigis Costume")]
        [Display(Order = 19)]
        [DisplayName("Choose which original costume\nto replace for Aigis.")]
        [DefaultValue(AigisCostumeSlot.bc003)]
        public AigisCostumeSlot CostumeSlot7 { get; set; } = AigisCostumeSlot.bc003;

        [Category("Aigis Costume")]
        [Display(Order = 20)]
        [DisplayName("Randomize all costumes\nfor Aigis")]
        [DefaultValue(false)]
        public bool RandomizeAigisCostumes { get; set; } = false;

        [Category("Ken Costume")]
        [Display(Order = 21)]
        [DisplayName("Choose which costume\nfor Ken.")]
        [DefaultValue(KenCostume.None)]
        public KenCostume CostumeChar8 { get; set; } = KenCostume.None;

        [Category("Ken Costume")]
        [Display(Order = 22)]
        [DisplayName("Choose which original costume\nto replace for Ken.")]
        [DefaultValue(KenCostumeSlot.bc008)]
        public KenCostumeSlot CostumeSlot8 { get; set; } = KenCostumeSlot.bc008;

        [Category("Ken Costume")]
        [Display(Order = 23)]
        [DisplayName("Randomize all costumes\nfor Ken")]
        [DefaultValue(false)]
        public bool RandomizeKenCostumes { get; set; } = false;

        [Category("Shinjiro Costume")]
        [Display(Order = 24)]
        [DisplayName("Choose which costume\nfor Shinjiro.")]
        [DefaultValue(ShinjiroCostume.None)]
        public ShinjiroCostume CostumeChar9 { get; set; } = ShinjiroCostume.None;

        [Category("Shinjiro Costume")]
        [Display(Order = 25)]
        [DisplayName("Choose which original costume\nto replace for Shinjiro.")]
        [DefaultValue(ShinjiroCostumeSlot.bc009)]
        public ShinjiroCostumeSlot CostumeSlot9 { get; set; } = ShinjiroCostumeSlot.bc009;

        [Category("Shinjiro Costume")]
        [Display(Order = 26)]
        [DisplayName("Randomize all costumes\nfor Shinjiro")]
        [DefaultValue(false)]
        public bool RandomizeShinjiroCostumes { get; set; } = false;

        [Category("Koromaru Costume")]
        [Display(Order = 27)]
        [DisplayName("Choose which costume\nfor Koromaru.")]
        [DefaultValue(KoromaruCostume.None)]
        public KoromaruCostume CostumeChar10 { get; set; } = KoromaruCostume.None;

        [Category("Koromaru Costume")]
        [Display(Order = 28)]
        [DisplayName("Choose which original costume\nto replace for Koromaru.")]
        [DefaultValue(KoromaruCostumeSlot.bc00A)]
        public KoromaruCostumeSlot CostumeSlot10 { get; set; } = KoromaruCostumeSlot.bc00A;

        [Category("Koromaru Costume")]
        [Display(Order = 29)]
        [DisplayName("Randomize all costumes\nfor Koromaru")]
        [DefaultValue(false)]
        public bool RandomizeKoromaruCostumes { get; set; } = false;
    }

    /// <summary>
    /// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
    /// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
    /// </summary>
    public class ConfiguratorMixin : ConfiguratorMixinBase
    {
        // 
    }
}