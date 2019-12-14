using Vintagestory.API.Common;

namespace SteppesAndDeserts
{
  public class SteppesAndDeserts : ModSystem
  {

    public override void Start(ICoreAPI api)
    {
      base.Start(api);
      api.RegisterItemClass("ItemPapyrusRoot", typeof(ItemPapyrusRoot));
      //api.RegisterBlockClass("BlockReedsAsgarus", typeof(BlockReedsExtended));
    }
  }
}
