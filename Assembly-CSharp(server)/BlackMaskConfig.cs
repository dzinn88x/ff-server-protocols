using System;
using Il2CppDummyDll;

// Token: 0x02000017 RID: 23
[Token(Token = "0x2000017")]
[Serializable]
public class BlackMaskConfig
{
	// Token: 0x0600004D RID: 77 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1F8C458", Offset = "0x1F8C458", VA = "0x7BBC78C458")]
	public BlackMaskConfig()
	{
	}

	// Token: 0x04000065 RID: 101
	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x10")]
	public float BeginPlayTime;

	// Token: 0x04000066 RID: 102
	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x14")]
	public EMaskAnimType maskType;

	// Token: 0x04000067 RID: 103
	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x18")]
	public float changeDuration;

	// Token: 0x04000068 RID: 104
	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x1C")]
	public float stableDuration;
}
