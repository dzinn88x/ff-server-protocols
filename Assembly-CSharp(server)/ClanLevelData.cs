using System;
using GCommon;
using Il2CppDummyDll;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
public class ClanLevelData : CSVBaseData
{
	// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x23E0914", Offset = "0x23E0914", VA = "0x7BBCBE0914", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x23E0920", Offset = "0x23E0920", VA = "0x7BBCBE0920", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x23E0BAC", Offset = "0x23E0BAC", VA = "0x7BBCBE0BAC")]
	public ClanLevelData()
	{
	}

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x10")]
	public int Level;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x14")]
	public int MinHonor;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x18")]
	public int ExpBuffFactor;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x1C")]
	public int GoldBuffFactor;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x20")]
	public int SizeImproved;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x24")]
	public int GoldLimitImproved;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x28")]
	public int AwardType1;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x2C")]
	public int AwardId1;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x30")]
	public int AwardNum1;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x34")]
	public int AwardMaxNum1;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x38")]
	public int AwardType2;

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x3C")]
	public int AwardId2;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x40")]
	public int AwardNum2;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x44")]
	public int AwardMaxNum2;

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x48")]
	public string LevelIcon;
}
