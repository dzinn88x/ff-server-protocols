using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000035 RID: 53
[Token(Token = "0x2000035")]
[Serializable]
public class PVEHyakkiMatchDifficultyRelatedConfig
{
	// Token: 0x060000A9 RID: 169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x23C0CB4", Offset = "0x23C0CB4", VA = "0x7BBCBC0CB4")]
	public PVEHyakkiMatchDifficultyRelatedConfig()
	{
	}

	// Token: 0x040000D4 RID: 212
	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0x10")]
	public int Difficulty;

	// Token: 0x040000D5 RID: 213
	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x14")]
	public int RoundCount;

	// Token: 0x040000D6 RID: 214
	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x18")]
	public int GameTotalTime_S;

	// Token: 0x040000D7 RID: 215
	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FF94C", Offset = "0x10FF94C")]
	public List<RoundInfo> RoundInfos;
}
