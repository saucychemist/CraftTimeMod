using JetBrains.Annotations;
using ModSettings;
using System.Reflection;

namespace CraftTimeMod
{
	internal class CraftTimeBaselines
    {
        public int tinderBaseline = 10;
        public int bandageBaseline = 10;
        public int lichenDressingBaseline = 15;
        public int birchbarkBaseline = 5;
        public int mushroomBaseline = 15;
        public int rosehipBaseline = 15;
        public int acornBaseline = 10;
        public int acornGroundsBaseline = 15;
        public int arrowShaftBaseline = 60;
        public int arrowHeadBaseline = 60;
        public int arrowHardBaseline = 45;
        public int arrowBaseline = 90;
        public int gunpowderBaseline = 30;
        public int bulletBaseline = 60;
        public int revolverAmmoBaseline = 5;
        public int rifleAmmoBaseline = 5;
        public int noisemakerBaseline = 30;
        public int knifeBaseline = 180;
        public int hatchetBaseline = 240;
        public int bowBaseline = 600;
        public int torchBaseline = 15;
        public int snareBaseline = 30;
        public int hookBaseline = 20;
        public int lineBaseline = 15;
        public int tackleBaseline = 10;
        public int bearBedrollBaseline = 2100;
        public int headwrapBaseline = 60;
        public int handwrapBaseline = 75;
        public int rabbitHatBaseline = 420;
        public int rabbitMittsBaseline = 600;
        public int deerPantsBaseline = 1500;
        public int deerBootsBaseline = 1500;
        public int wolfCoatBaseline = 3000;
        public int bearCoatBaseline = 3600;
        public int mooseCloakBaseline = 2000;
        public int mooseBagBaseline = 1200;
        public int cramponsBaseline = 240;
    }
	internal class CraftTimeModSettings : JsonModSettings
	{
        [Section("Meds, Plants, and Tinder Crafting Time")]
        
        [Name("Set individual crafting times")]
        [Description("Enable to change times of individual items (will override multiplier)")]
        public bool medsFineTune = false;

        [Name("Crafting time multiplier")]
        [Description("Adjust times to craft items like bandages, rosehips, and acorns by a set factor.  Disabled if you select individual crafting times.  Set this to (1) for default values.")]
        [Slider(0.1f, 2f, 20)]
        public float medsMultiplier = 1f;

        [Name("... Tinder Plugs")]
        [Description("Time to craft tinder plugs. Default = 5")]
        [Slider(1, 10)]
        public int tinderCraftTime = 5;

        [Name("... Bandages")]
        [Description("Time to craft bandages. Default = 10")]
        [Slider(1, 20)]
        public int bandageCraftTime = 10;

        [Name("... Old Mans Beard Dressing")]
        [Description("Time to craft an Old Mans Beard Wound Dressing. Default = 15")]
        [Slider(1, 30)]
        public int lichenDressingCraftTime = 15;

        [Name("... Prepared Birch Bark")]
		[Description("Time to prepare birch bark. Default = 5")]
		[Slider(1, 10)]
		public int birchbarkCraftTime = 5;

        [Name("... Prepared Reishi Mushrooms")]
        [Description("Time to prepare reishi mushrooms. Default = 15")]
        [Slider(1, 30)]
        public int mushroomCraftTime = 15;

        [Name("... Prepared Rosehips")]
        [Description("Time to prepare rosehips. Default = 15")]
        [Slider(1, 30)]
        public int rosehipCraftTime = 15;

        [Name("... Shelled Acorns")]
        [Description("Time to shell acorns. Default = 10")]
        [Slider(1, 20)]
        public int acornCraftTime = 10;

        [Name("... Acorn Grounds")]
        [Description("Time to prepare acorn grounds. Default = 15")]
        [Slider(1, 30)]
        public int acornGroundsCraftTime = 15;

        [Section("Ammunition related Crafting Time")]

        [Name("Set individual crafting times")]
        [Description("Enable to change times of individual items (will override multiplier)")]
        public bool ammoFineTune = false;

        [Name("Crafting time multiplier")]
        [Description("Adjust times to craft ammunition related items like arrows, bullets, and gunpowder by a set factor.  Disabled if you select individual crafting times.  Set this to (1) for default values.")]
        [Slider(0.1f, 2f, 20)]
        public float ammoMultiplier = 1f;

        [Name("... Arrow Shafts")]
        [Description("Time to craft three arrowshafts. This will be sped up by using a tool. Default = 60")]
        [Slider(5, 120, 24)]
        public int arrowShaftCraftTime = 60;

        [Name("... Arrowheads")]
        [Description("Time to craft two arrowheads. Default = 60")]
        [Slider(5, 120, 24)]
        public int arrowHeadCraftTime = 60;

        [Name("... Fire-Hardened Arrows")]
        [Description("Time to craft fire-hardened arrows. This will be sped up by using a tool. Default = 45")]
        [Slider(5, 90, 18)]
        public int arrowHardCraftTime = 45;

        [Name("... Simple Arrow")]
        [Description("Time to craft a simple arrow. Default = 90")]
        [Slider(10, 180, 18)]
        public int arrowCraftTime = 90;

        [Name("... Can of Gunpowder")]
        [Description("Time to craft a can of gunpowder. Default = 30")]
        [Slider(5, 60, 12)]
        public int gunpowderCraftTime = 30;

        [Name("... Bullets")]
        [Description("Time to craft six bullets. Default = 60")]
        [Slider(10, 120, 12)]
        public int bulletCraftTime = 60;

        [Name("... Revolver Cartridge")]
        [Description("Time to craft a revolver cartridge. Default = 5")]
        [Slider(1, 10)]
        public int revolverAmmoCraftTime = 5;

        [Name("... Rifle Cartridge")]
        [Description("Time to craft a rifle cartridge. Default = 5")]
        [Slider(1, 10)]
        public int rifleAmmoCraftTime = 5;

        [Name("... Noisemaker")]
        [Description("Time to craft a noisemaker. Default = 30")]
        [Slider(5, 60, 12)]
        public int noisemakerCraftTime = 30;

        [Section("Tools and Equipment Crafting Time")]

        [Name("Set individual crafting times")]
        [Description("Enable to change times of individual items (will override multiplier)")]
        public bool toolsFineTune = false;

        [Name("Crafting time multiplier")]
        [Description("Adjust times to craft equipment like improvised knives, snares, or bedrolls items by a set factor.  Disabled if you select individual crafting times.  Set this to (1) for default values.")]
        [Slider(0.1f, 2f, 20)]
        public float toolsMultiplier = 1f;

        [Name("... Improvised Knife")]
        [Description("Time to craft an improvised knife (in Hours). Default = 3")]
        [Slider(0.5f, 6f, 12)]
        public float knifeCraftTime = 3f;

        [Name("... Improvised Hatchet")]
        [Description("Time to craft an improvised hatchet (in Hours). Default = 4")]
        [Slider(0.5f, 8f, 16)]
        public float hatchetCraftTime = 4f;

        [Name("... Survival Bow")]
        [Description("Time to craft a survival bow (in Hours). This will be sped up by using a tool. Default = 10")]
        [Slider(0.5f, 20f, 40)]
        public float bowCraftTime = 10f;

        [Name("... Torch")]
        [Description("Time to craft a torch. Default = 15")]
        [Slider(1, 30)]
        public int torchCraftTime = 15;

        [Name("... Snare")]
        [Description("Time to craft a snare. Default = 30")]
        [Slider(5, 60, 12)]
        public int snareCraftTime = 30;

        [Name("... Hooks")]
        [Description("Time to craft three hooks. Default = 20")]
        [Slider(1, 40)]
        public int hookCraftTime = 20;

        [Name("... Line")]
        [Description("Time to craft two lines. Default = 15")]
        [Slider(1, 30)]
        public int lineCraftTime = 15;

        [Name("... Fishing Tackle")]
        [Description("Time to craft two lines. Default = 10")]
        [Slider(1, 20)]
        public int tackleCraftTime = 10;

        [Name("... Bearskin Bedroll")]
        [Description("Time to craft a Bearskin Bedroll (in Hours). This will be sped up by using a tool. Default = 35")]
        [Slider(1, 70)]
        public int bearBedrollCraftTime = 35;

        [Section("Clothing and Gear (Wearable) Crafting Time")]

        [Name("Set individual crafting times")]
        [Description("Enable to change times of individual items (will override multiplier)")]
        public bool clothesFineTune = false;

        [Name("Crafting time multiplier")]
        [Description("Adjust times to craft items like rabbitskin hat, moosehide satchel, or improvised crampons by a set factor.  Disabled if you select individual crafting times.  Set this to (1) for default values.")]
        [Slider(0.1f, 2f, 20)]
        public float clothesMultiplier = 1f;

        [Name("... Improvised Head Wrap")]
        [Description("Time to craft an Improvised Head Wrap. This will be sped up by your stitching tool. Default = 60")]
        [Slider(5, 60)]
        public int headwrapCraftTime = 60;

        [Name("... Improvised Hand Wraps")]
        [Description("Time to craft Improvised Hand Wraps. This will be sped up by your stitching tool. Default = 75")]
        [Slider(5, 75)]
        public int handwrapCraftTime = 75;

        [Name("... Rabbitskin Hat")]
        [Description("Time to craft a Rabbitskin Hat (in Hours). This will be sped up by your stitching tool. Default = 7")]
        [Slider(1, 7)]
        public int rabbitHatCraftTime = 7;

        [Name("... Rabbitskin Mitts")]
        [Description("Time to craft Rabbitskin Mitts (in Hours). This will be sped up by your stitching tool. Default = 10")]
        [Slider(1, 10)]
        public int rabbitMittsCraftTime = 10;

        [Name("... Deerskin Pants")]
        [Description("Time to craft Deerskin Pants (in Hours). This will be sped up by your stitching tool. Default = 25")]
        [Slider(1, 25)]
        public int deerPantsCraftTime = 25;

        [Name("... Deerskin Boots")]
        [Description("Time to craft Deerskin Boots (in Hours). This will be sped up by your stitching tool. Default = 25")]
        [Slider(1, 25)]
        public int deerBootsCraftTime = 25;

        [Name("... Wolfskin Coat")]
        [Description("Time to craft Wolfskin Coat (in Hours). This will be sped up by using a tool. Default = 50")]
        [Slider(1, 50)]
        public int wolfCoatCraftTime = 50;

        [Name("... Bearskin Coat")]
        [Description("Time to craft Bearskin Coat (in Hours). This will be sped up by using a tool. Default = 60")]
        [Slider(1, 60)]
        public int bearCoatCraftTime = 60;

        [Name("... Moose-Hide Cloak")]
        [Description("Time to craft Moose-Hide Cloak (in Hours). This will be sped up by using a tool. Default = 33.33")]
        [Slider(1f, 33.333f)]
        public float mooseCloakCraftTime = 33.333f;

        [Name("... Moose-Hide Satchel")]
        [Description("Time to craft a Moose-Hide Satchel (in Hours). This will be sped up by your stitching tool. Default = 20")]
        [Slider(1, 20)]
        public int mooseBagCraftTime = 20;

        [Name("... Improvised Crampons")]
        [Description("Time to craft Improvised Crampons (in Hours). Default = 4")]
        [Slider(0.5f, 4f, 8)]
        public float cramponsCraftTime = 4f;

        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {
            if (field.Name == nameof(medsFineTune) || field.Name == nameof(ammoFineTune) || field.Name == nameof(toolsFineTune) || field.Name == nameof(clothesFineTune))
            {
                RefreshFields();
            }
        }

        internal void RefreshFields()
        {
            SetFieldVisible(nameof(medsMultiplier), !medsFineTune);
            SetFieldVisible(nameof(tinderCraftTime), medsFineTune);
            SetFieldVisible(nameof(bandageCraftTime), medsFineTune);
            SetFieldVisible(nameof(lichenDressingCraftTime), medsFineTune);
            SetFieldVisible(nameof(birchbarkCraftTime), medsFineTune);
            SetFieldVisible(nameof(mushroomCraftTime), medsFineTune);
            SetFieldVisible(nameof(rosehipCraftTime), medsFineTune);
            SetFieldVisible(nameof(acornCraftTime), medsFineTune);
            SetFieldVisible(nameof(acornGroundsCraftTime), medsFineTune);

            SetFieldVisible(nameof(ammoMultiplier), !ammoFineTune);
            SetFieldVisible(nameof(arrowShaftCraftTime), ammoFineTune);
            SetFieldVisible(nameof(arrowHeadCraftTime), ammoFineTune);
            SetFieldVisible(nameof(arrowHardCraftTime), ammoFineTune);
            SetFieldVisible(nameof(arrowCraftTime), ammoFineTune);
            SetFieldVisible(nameof(gunpowderCraftTime), ammoFineTune);
            SetFieldVisible(nameof(bulletCraftTime), ammoFineTune);
            SetFieldVisible(nameof(revolverAmmoCraftTime), ammoFineTune);
            SetFieldVisible(nameof(rifleAmmoCraftTime), ammoFineTune);
            SetFieldVisible(nameof(noisemakerCraftTime), ammoFineTune);

            SetFieldVisible(nameof(toolsMultiplier), !toolsFineTune);
            SetFieldVisible(nameof(knifeCraftTime), toolsFineTune);
            SetFieldVisible(nameof(hatchetCraftTime), toolsFineTune);
            SetFieldVisible(nameof(bowCraftTime), toolsFineTune);
            SetFieldVisible(nameof(torchCraftTime), toolsFineTune);
            SetFieldVisible(nameof(snareCraftTime), toolsFineTune);
            SetFieldVisible(nameof(hookCraftTime), toolsFineTune);
            SetFieldVisible(nameof(lineCraftTime), toolsFineTune);
            SetFieldVisible(nameof(tackleCraftTime), toolsFineTune);
            SetFieldVisible(nameof(bearBedrollCraftTime), toolsFineTune);

            SetFieldVisible(nameof(clothesMultiplier), !clothesFineTune);
            SetFieldVisible(nameof(headwrapCraftTime), clothesFineTune);
            SetFieldVisible(nameof(handwrapCraftTime), clothesFineTune);
            SetFieldVisible(nameof(rabbitHatCraftTime), clothesFineTune);
            SetFieldVisible(nameof(rabbitMittsCraftTime), clothesFineTune);
            SetFieldVisible(nameof(deerPantsCraftTime), clothesFineTune);
            SetFieldVisible(nameof(deerBootsCraftTime), clothesFineTune);
            SetFieldVisible(nameof(wolfCoatCraftTime), clothesFineTune);
            SetFieldVisible(nameof(bearCoatCraftTime), clothesFineTune);
            SetFieldVisible(nameof(mooseCloakCraftTime), clothesFineTune);
            SetFieldVisible(nameof(mooseBagCraftTime), clothesFineTune);
            SetFieldVisible(nameof(cramponsCraftTime), clothesFineTune);

        }
    }
	internal static class Settings
	{
        public static CraftTimeBaselines defaults;
		public static CraftTimeModSettings options;
		public static void OnLoad()
		{
			defaults = new CraftTimeBaselines();
            options = new CraftTimeModSettings();
            options.RefreshFields();
            options.AddToModSettings("Crafting Time Mod Settings");
		}
	}
}