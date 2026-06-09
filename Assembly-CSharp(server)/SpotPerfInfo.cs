using System;
using Il2CppDummyDll;

// Token: 0x0200020D RID: 525
[Token(Token = "0x200020D")]
[Serializable]
public class SpotPerfInfo
{
	// Token: 0x06000A60 RID: 2656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A60")]
	[Address(RVA = "0x2262910", Offset = "0x2262910", VA = "0x7BBCA62910")]
	public SpotPerfInfo()
	{
	}

	// Token: 0x040009DF RID: 2527
	[Token(Token = "0x40009DF")]
	[FieldOffset(Offset = "0x10")]
	public int totalTris;

	// Token: 0x040009E0 RID: 2528
	[Token(Token = "0x40009E0")]
	[FieldOffset(Offset = "0x14")]
	public int totalMats;

	// Token: 0x040009E1 RID: 2529
	[Token(Token = "0x40009E1")]
	[FieldOffset(Offset = "0x18")]
	public int totalObjects;

	// Token: 0x040009E2 RID: 2530
	[Token(Token = "0x40009E2")]
	[FieldOffset(Offset = "0x1C")]
	public int totalDrawCalls;

	// Token: 0x040009E3 RID: 2531
	[Token(Token = "0x40009E3")]
	[FieldOffset(Offset = "0x20")]
	public int totalDrawCallsMax;

	// Token: 0x040009E4 RID: 2532
	[Token(Token = "0x40009E4")]
	[FieldOffset(Offset = "0x24")]
	public int lightmapped;

	// Token: 0x040009E5 RID: 2533
	[Token(Token = "0x40009E5")]
	[FieldOffset(Offset = "0x28")]
	public int trisTooMany;
}
