using FFXIVClientStructs.FFXIV.Client.Game.Character;

namespace FFXIVClientStructs.FFXIV.Client.Game.Control;

// Client::Game::Control::Control
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x5B00)]
public unsafe partial struct Control {
    [FieldOffset(0x00)] public CameraManager CameraManager;
    [FieldOffset(0x180)] public TargetSystem TargetSystem;

    [FieldOffset(0x5A7B)] public bool IsWalking;
    [FieldOffset(0x5AE8)] public uint LocalPlayerEntityId;
    [FieldOffset(0x5AF0)] public BattleChara* LocalPlayer;

    [StaticAddress("48 8D 0D ?? ?? ?? ?? 45 0F 57 E4 F3 0F 10 70 ??", 3)]
    public static partial Control* Instance();

    [StaticAddress("40 53 48 83 EC ?? 48 8B 41 ?? 48 8B D9 48 89 05 ?? ?? ?? ?? 48 8B 49", 3, true)]
    public static partial BattleChara* GetLocalPlayer(); // g_Client::Game::Control::Control_LocalPlayer
}
