using System;
using GCommon;
using Il2CppDummyDll;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
public class ClanAreaData : CSVBaseData
{
	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x23E0378", Offset = "0x23E0378", VA = "0x7BBCBE0378", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x23E0384", Offset = "0x23E0384", VA = "0x7BBCBE0384", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x23E0460", Offset = "0x23E0460", VA = "0x7BBCBE0460")]
	public ClanAreaData()
	{
	}

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x10")]
	public uint ID;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x18")]
	public string FirstGrade;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x20")]
	public string SecondGrade;
}
