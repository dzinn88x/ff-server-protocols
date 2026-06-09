using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000034 RID: 52
[Token(Token = "0x2000034")]
[Serializable]
public class RoundInfo
{
	// Token: 0x060000A8 RID: 168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x23DE0E0", Offset = "0x23DE0E0", VA = "0x7BBCBDE0E0")]
	public RoundInfo()
	{
	}

	// Token: 0x040000CE RID: 206
	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x10")]
	public int RoundID;

	// Token: 0x040000CF RID: 207
	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x14")]
	public float RoundTime;

	// Token: 0x040000D0 RID: 208
	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x18")]
	public float GeneralHPScaleOnBase;

	// Token: 0x040000D1 RID: 209
	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x1C")]
	public bool IsRoundNeedTeleport;

	// Token: 0x040000D2 RID: 210
	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x20")]
	public float RoundAISpawnInterval;

	// Token: 0x040000D3 RID: 211
	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x28")]
	public List<AISpawnInfo> AISpawnInfos;
}
