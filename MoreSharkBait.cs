using UnityEngine;

[ModTitle("MoreSharkBait")] 
[ModDescription("Use all fish as shark bait")] 
[ModAuthor("camarril")] 
[ModIconUrl("https://raw.githubusercontent.com/camarril/MoreSharkBait/master/Thumbnail.png")] 
[ModWallpaperUrl("https://raw.githubusercontent.com/camarril/MoreSharkBait/master/Banner.jpg")] 
[ModVersionCheckUrl("https://raftmodding.com/api/v1/mods/moresharkbait/version.txt")] 
[ModVersion("1.0")] 
[RaftVersion("Update 10.06 (4473383)")] 
[ModIsPermanent(false)] 
public class MoreSharkBait : Mod
{    
    public void Start()
    {
        RConsole.Log("MoreSharkBait has been loaded!");
    }

    public void Update()
    {
        
    }
    
    public void OnModUnload()
    {
        RConsole.Log("MoreSharkBait has been unloaded!");
        Destroy(gameObject); 
    }
}
