using System;
using Server.Targeting;
using Server.Items;
using static Server.Configurations.ResourceConfiguration;

namespace Server.Engines.Craft
{
    public enum SmeltResult
    {
        Success,
        Invalid,
        NoSkill
    }

    public class Resmelt
    {
        public Resmelt()
        {
        }

        public static void Do(Mobile from, CraftSystem craftSystem, BaseTool tool)
        {
            int num = craftSystem.CanCraft(from, tool, null);

            if (num > 0 && num != 1044267)
            {
                from.SendGump(new CraftGump(from, craftSystem, tool, num));
            }
            else
            {
                from.Target = new InternalTarget(craftSystem, tool);
                from.SendLocalizedMessage(1044273); // Target an item to recycle.
            }
        }

        private class InternalTarget : Target
        {
            private CraftSystem m_CraftSystem;
            private BaseTool m_Tool;

            public InternalTarget(CraftSystem craftSystem, BaseTool tool) : base(2, false, TargetFlags.None)
            {
                m_CraftSystem = craftSystem;
                m_Tool = tool;
            }

            private SmeltResult Resmelt(Mobile from, Item item, CraftResource resource)
            {
                try
                {
                    if (CraftResources.GetType(resource) != CraftResourceType.Metal)
                        return SmeltResult.Invalid;

                    CraftResourceInfo info = CraftResources.GetInfo(resource);

                    if (info == null || info.ResourceTypes.Length == 0)
                        return SmeltResult.Invalid;

                    CraftItem craftItem = m_CraftSystem.CraftItems.SearchFor(item.GetType());

                    if (craftItem == null || craftItem.Resources.Count == 0)
                        return SmeltResult.Invalid;

                    CraftRes craftResource = craftItem.Resources[0];

                    if (craftResource.Amount < 2)
                        return SmeltResult.Invalid; // Not enough metal to resmelt

                    var oreEntry = OreConfiguration.Entries[(int) resource - 1];

                    var difficulty = oreEntry.SmeltSkillRequired;

                    if (difficulty > from.Skills[SkillName.Mining].Value)
                        return SmeltResult.NoSkill;

                    Type resourceType = info.ResourceTypes[0];
                    Item ingot = (Item) Activator.CreateInstance(resourceType);

                    if (item is BaseArmor && ((BaseArmor) item).PlayerConstructed ||
                        item is BaseWeapon && ((BaseWeapon) item).PlayerConstructed ||
                        item is BaseClothing && ((BaseClothing) item).PlayerConstructed)
                        ingot.Amount = craftResource.Amount / 2;
                    else
                        ingot.Amount = 1;

                    item.Delete();
                    from.AddToBackpack(ingot);

                    from.PlaySound(0x2B);
                    return SmeltResult.Success;
                }
                catch
                {
                }

                return SmeltResult.Invalid;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                int num = m_CraftSystem.CanCraft(from, m_Tool, null);

                if (num > 0)
                {
                    if (num == 1044267)
                    {
                        if (!DefBlacksmithy.CheckForge(from, 1))
                            num = 1044265; // You must be near a forge.
                    }

                    from.SendGump(new CraftGump(from, m_CraftSystem, m_Tool, num));
                }
                else
                {
                    SmeltResult result = SmeltResult.Invalid;
                    bool isStoreBought = false;
                    int message;

                    if (targeted is BaseArmor)
                    {
                        result = Resmelt(from, (BaseArmor) targeted, ((BaseArmor) targeted).Resource);
                        isStoreBought = !((BaseArmor) targeted).PlayerConstructed;
                    }
                    else if (targeted is BaseWeapon)
                    {
                        result = Resmelt(from, (BaseWeapon) targeted, ((BaseWeapon) targeted).Resource);
                        isStoreBought = !((BaseWeapon) targeted).PlayerConstructed;
                    }

                    switch (result)
                    {
                        default:
                        case SmeltResult.Invalid:
                            message = 1044272;
                            break; // You can't melt that down into ingots.
                        case SmeltResult.NoSkill:
                            message = 1044269;
                            break; // You have no idea how to work this metal.
                        case SmeltResult.Success:
                            message = isStoreBought ? 500418 : 1044270;
                            break; // You melt the item down into ingots.
                    }

                    from.SendGump(new CraftGump(from, m_CraftSystem, m_Tool, message));
                }
            }
        }
    }
}