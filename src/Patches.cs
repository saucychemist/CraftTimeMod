using MelonLoader;
using HarmonyLib;
using UnityEngine;
using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppTLD.Gear;
using UnityEngine.Playables;
using Il2CppSystem.Linq.Expressions;

namespace CraftTimeMod
{
    internal static class Patches
    {
        [HarmonyPatch(typeof(Panel_Crafting), "ItemPassesFilter")]
        private static class Panel_Crafting_ItemPassesFilter
        {
            private static void Postfix(Panel_Crafting __instance, ref bool __result, BlueprintData bpi)
            {
                float medsMulti = Settings.options.medsMultiplier;
                float ammoMulti = Settings.options.ammoMultiplier;
                float toolMulti = Settings.options.toolsMultiplier;
                float gearMulti = Settings.options.clothesMultiplier;

                if (bpi?.m_CraftedResult?.name == "GEAR_Tinder")
                {
                    if (Settings.options.medsFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.tinderCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.tinderBaseline * medsMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_HeavyBandage")
                {
                    if (Settings.options.medsFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.bandageCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.bandageBaseline * medsMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_OldMansBeardDressing")
                {
                    if (Settings.options.medsFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.lichenDressingCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.lichenDressingBaseline * medsMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_BirchbarkPrepared")
                {
                    if (Settings.options.medsFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.birchbarkCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.birchbarkBaseline * medsMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_ReishiPrepared")
                {
                    if (Settings.options.medsFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.mushroomCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.mushroomBaseline * medsMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_RosehipsPrepared")
                {
                    if (Settings.options.medsFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.rosehipCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.rosehipBaseline * medsMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_AcornShelled")
                {
                    if (Settings.options.medsFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.acornCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.acornBaseline * medsMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_AcornGrounds")
                {
                    if (Settings.options.medsFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.acornGroundsCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.acornGroundsBaseline * medsMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_ArrowShaft")
                {
                    if (Settings.options.ammoFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.arrowShaftCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.arrowShaftBaseline * ammoMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_ArrowHead")
                {
                    if (Settings.options.ammoFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.arrowHeadCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.arrowHeadBaseline * ammoMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_ArrowHardened")
                {
                    if (Settings.options.ammoFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.arrowHardCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.arrowHardBaseline * ammoMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_Arrow")
                {
                    if (Settings.options.ammoFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.arrowCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.arrowBaseline * ammoMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_GunpowderCan")
                {
                    if (Settings.options.ammoFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.gunpowderCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.gunpowderBaseline * ammoMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_Bullet")
                {
                    if (Settings.options.ammoFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.bulletCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.bulletBaseline * ammoMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_RevolverAmmoSingle")
                {
                    if (Settings.options.ammoFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.revolverAmmoCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.revolverAmmoBaseline * ammoMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_RifleAmmoSingle")
                {
                    if (Settings.options.ammoFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.rifleAmmoCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.rifleAmmoBaseline * ammoMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_Noisemaker")
                {
                    if (Settings.options.ammoFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.noisemakerCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.noisemakerBaseline * ammoMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_KnifeImprovised")
                {
                    if (Settings.options.toolsFineTune)
                    {
                        bpi.m_DurationMinutes = (int)(Settings.options.knifeCraftTime * 60);
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.knifeBaseline * toolMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_HatchetImprovised")
                {
                    if (Settings.options.toolsFineTune)
                    {
                        bpi.m_DurationMinutes = (int)(Settings.options.hatchetCraftTime * 60);
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.hatchetBaseline * toolMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_Bow")
                {
                    if (Settings.options.toolsFineTune)
                    {
                        bpi.m_DurationMinutes = (int)(Settings.options.bowCraftTime * 60);
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.bowBaseline * toolMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_Torch")
                {
                    if (Settings.options.toolsFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.torchCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.torchBaseline * toolMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_Snare")
                {
                    if (Settings.options.toolsFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.snareCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.snareBaseline * toolMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_Hook")
                {
                    if (Settings.options.toolsFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.hookCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.hookBaseline * toolMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_Line")
                {
                    if (Settings.options.toolsFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.lineCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.lineBaseline * toolMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_HookandLine")
                {
                    if (Settings.options.toolsFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.tackleCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.tackleBaseline * toolMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_BearSkinBedRoll")
                {
                    if (Settings.options.toolsFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.bearBedrollCraftTime * 60;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.bearBedrollBaseline * toolMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_ImprovisedHat")
                {
                    if (Settings.options.clothesFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.headwrapCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.headwrapBaseline * gearMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_ImprovisedMittens")
                {
                    if (Settings.options.clothesFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.handwrapCraftTime;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.handwrapBaseline * gearMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_RabbitskinHat")
                {
                    if (Settings.options.clothesFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.rabbitHatCraftTime * 60;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.rabbitHatBaseline * gearMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_RabbitSkinMittens")
                {
                    if (Settings.options.clothesFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.rabbitMittsCraftTime * 60;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.rabbitMittsBaseline * gearMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_DeerSkinPants")
                {
                    if (Settings.options.clothesFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.deerPantsCraftTime * 60;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.deerPantsBaseline * gearMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_DeerSkinBoots")
                {
                    if (Settings.options.clothesFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.deerBootsCraftTime * 60;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.deerBootsBaseline * gearMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_WolfSkinCape")
                {
                    if (Settings.options.clothesFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.wolfCoatCraftTime * 60;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.wolfCoatBaseline * gearMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_BearSkinCoat")
                {
                    if (Settings.options.clothesFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.bearCoatCraftTime * 60;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.bearCoatBaseline * gearMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_MooseHideCloak")
                {
                    if (Settings.options.clothesFineTune)
                    {
                        bpi.m_DurationMinutes = (int)(Settings.options.mooseCloakCraftTime * 60);
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.mooseCloakBaseline * gearMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_MooseHideBag")
                {
                    if (Settings.options.clothesFineTune)
                    {
                        bpi.m_DurationMinutes = Settings.options.mooseBagCraftTime * 60;
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.mooseBagBaseline * gearMulti);
                    }
                }
                else if (bpi?.m_CraftedResult?.name == "GEAR_ImprovisedCrampons")
                {
                    if (Settings.options.clothesFineTune)
                    {
                        bpi.m_DurationMinutes = (int)(Settings.options.cramponsCraftTime * 60);
                    }
                    else
                    {
                        bpi.m_DurationMinutes = (int)(Settings.defaults.cramponsBaseline * gearMulti);
                    }
                }
            }
        }
    }
}