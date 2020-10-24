﻿using System.Runtime.InteropServices;

namespace FFXIVClientStructs.Component.GUI
{
    public enum ComponentType
    { 
        Base = 0, 
        Button = 1,
        Window = 2, 
        CheckBox = 3,
        RadioButton = 4,
        GaugeBar = 5, 
        Slider = 6,
        TextInput = 7, 
        NumericInput = 8, 
        List = 9, 
        DropDownList = 10,
        Tab = 11, 
        TreeList = 12,
        ScrollBar = 13,
        ListItemRenderer = 14,
        Icon = 15, 
        IconText = 16,
        DragDrop = 17, 
        GuildLeveCard = 18,
        TextNineGrid = 19, 
        JournalCanvas = 20, 
        Multipurpose = 21, 
        Map = 22, 
        Preview = 23, 
        // added since 2.3, no rtti, but derives from Button
        UnknownButton = 24
    }

    // Component::GUI::AtkComponentBase
    //   Component::GUI::AtkEventListener

    // base class for UI components that are more complicated than a single node

    // size = 0xC0
    // common CreateAtkComponent function 8B FA 33 DB E8 ? ? ? ? 
    // type 0
    [StructLayout(LayoutKind.Explicit, Size = 0xC0)]
    public unsafe struct AtkComponentBase
    {
        [FieldOffset(0x0)] public AtkEventListener AtkEventListener;
        [FieldOffset(0x18)] public NodeList* ChildNodes;
    }
}
