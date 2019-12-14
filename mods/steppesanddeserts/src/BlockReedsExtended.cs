/*using Vintagestory.API.Common;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;

namespace SteppesAndDeserts
{
    public class BlockExtendedReeds : BlockReeds
    {
        public override void OnBlockBroken(IWorldAccessor world, BlockPos pos, IPlayer byPlayer, float dropQuantityMultiplier = 1f)
        {
            if (world.Side == EnumAppSide.Server && (byPlayer == null || byPlayer.WorldData.CurrentGameMode != EnumGameMode.Creative))
            {
                ItemStack drop = null;

                if (Variant["state"] == "normal")
                {
                    if (Variant["type"] == "coopersreed")
                    {
                        drop = new ItemStack(world.GetItem(new AssetLocation("cattailtops")));
                    }
                    else
                    {
                        drop = new ItemStack(world.GetItem(new AssetLocation("steppesanddeserts:papyrusstems")));
                    }
                }
                else
                {
                    if (Variant["type"] == "coopersreed")
                    {
                        drop = new ItemStack(world.GetItem(new AssetLocation("cattailroot")));
                    }
                    else
                    {
                        drop = new ItemStack(world.GetItem(new AssetLocation("steppesanddeserts:papyrusroot")));
                    }
                }

                if (drop != null)
                {
                    world.SpawnItemEntity(drop, new Vec3d(pos.X + 0.5, pos.Y + 0.5, pos.Z + 0.5), null);
                }

                world.PlaySoundAt(Sounds.GetBreakSound(byPlayer), pos.X, pos.Y, pos.Z, byPlayer);
            }

            if (byPlayer != null && Variant["state"] == "normal" && byPlayer.InventoryManager.ActiveTool == EnumTool.Knife)
            {
                world.BlockAccessor.SetBlock(world.GetBlock(CodeWithVariant("state", "harvested")).BlockId, pos);
                return;
            }

            if (Variant["habitat"] != "free")
            {
                world.BlockAccessor.SetBlock(world.GetBlock(new AssetLocation("water-still-7")).BlockId, pos);
                world.BlockAccessor.GetBlock(pos).OnNeighourBlockChange(world, pos, pos);
            }
            else
            {
                world.BlockAccessor.SetBlock(0, pos);
            }
        }
    }
}*/
