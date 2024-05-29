using FFXIVClientStructs.FFXIV.Client.System.String;

namespace FFXIVClientStructs.FFXIV.Client.System.Input;

public partial struct SoftKeyboardDeviceInterface {

    [GenerateInterop]
    [StructLayout(LayoutKind.Explicit, Size = 0x8)]
    public unsafe partial struct SoftKeyboardInputInterface {
        // CAUTION: May be the concrete class' dtor!
        [VirtualFunction(0)]
        public partial void Dtor(bool freeMemory);

        [VirtualFunction(2)]
        public partial void WriteString(Utf8String* stringToWrite);

        [VirtualFunction(4)]
        public partial uint GetInputMaxLength();
    }

}
