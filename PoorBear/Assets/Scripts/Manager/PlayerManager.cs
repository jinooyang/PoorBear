using System;


public class PlayerManager
{
    private PlayerManager() { }

    private static readonly Lazy<PlayerManager> Manager
        = new Lazy<PlayerManager>(()=>new PlayerManager());
    public static PlayerManager Instance => Manager.Value;
    public string UserNickname { get; set; }
    public string SessionNumber { get; set; }
    public bool IsHost { get; set; }

    public string Roomname { get; set; }

}
