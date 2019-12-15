using System.Linq;

[ModTitle("MoreSharkBait")] 
[ModDescription("Use all fish as shark bait")] 
[ModAuthor("camarril")] 
[ModIconUrl("https://raw.githubusercontent.com/camarril/MoreSharkBait/master/Thumbnail.jpg")] 
[ModWallpaperUrl("https://raw.githubusercontent.com/camarril/MoreSharkBait/master/Banner.jpg")] 
[ModVersionCheckUrl("https://raftmodding.com/api/v1/mods/moresharkbait/version.txt")] 
[ModVersion("v1.0")] 
[RaftVersion("Update 10.06 (4473383)")] 
[ModIsPermanent(false)] 
public class MoreSharkBait : Mod
{
    public void Start()
    {
        RConsole.Log("MoreSharkBait has been loaded!");
        allowItems("Raw_Herring", "Raw_Pomfret", "Raw_Mackerel", "Raw_Tilapia", "Raw_Catfish", "Raw_Salmon");
    }

    private void allowItems(params string[] validItemNames)
    {
        var ropeItem = ItemManager.GetItemByName("Rope");
        var ropeIngredient = new CostMultiple(new Item_Base[] { ropeItem }, 2);

        var validItems = validItemNames.Select(name => ItemManager.GetItemByName(name)).ToArray();
        var validIngredients = new CostMultiple(validItems, 2);

        var bait = ItemManager.GetItemByName("SharkBait");
        bait.settings_recipe.NewCost = new CostMultiple[] { ropeIngredient, validIngredients };
    }
    
    public void OnModUnload()
    {
        allowItems("Raw_Herring", "Raw_Pomfret");
        RConsole.Log("MoreSharkBait has been unloaded!");
        Destroy(gameObject); 
    }
}
