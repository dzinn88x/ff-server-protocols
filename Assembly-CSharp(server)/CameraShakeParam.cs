using System;
using Il2CppDummyDll;

// Token: 0x020000C2 RID: 194
[Token(Token = "0x20000C2")]
[Serializable]
public class CameraShakeParam
{
	// Token: 0x0600031C RID: 796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600031C")]
	[Address(RVA = "0x23DFF00", Offset = "0x23DFF00", VA = "0x7BBCBDFF00")]
	public CameraShakeParam()
	{
	}

	// Token: 0x0400031F RID: 799
	[Token(Token = "0x400031F")]
	[FieldOffset(Offset = "0x10")]
	public bool Enable;

	// Token: 0x04000320 RID: 800
	[Token(Token = "0x4000320")]
	[FieldOffset(Offset = "0x14")]
	public float Duration;

	// Token: 0x04000321 RID: 801
	[Token(Token = "0x4000321")]
	[FieldOffset(Offset = "0x18")]
	public float Factor;
}
