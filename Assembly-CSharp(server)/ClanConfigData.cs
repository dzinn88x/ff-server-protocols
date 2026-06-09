using System;
using GCommon;
using Il2CppDummyDll;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
public class ClanConfigData : CSVBaseData
{
	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x23E04C8", Offset = "0x23E04C8", VA = "0x7BBCBE04C8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x23E0510", Offset = "0x23E0510", VA = "0x7BBCBE0510", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x23E0714", Offset = "0x23E0714", VA = "0x7BBCBE0714")]
	public ClanConfigData()
	{
	}

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	public const string PRIMARYKEY = "KEY";

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x10")]
	public int ClanMaxPendingApplications;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x14")]
	public int PlayerMaxRequestsPerDay;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x18")]
	public int MaxInviteNum;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x1C")]
	public int JoinDaysBeforeSignIn;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x20")]
	public int ClanLogTimeMax;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x24")]
	public int ClanLogCntMax;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x28")]
	public uint[] ClanPresetLevels;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x30")]
	public uint[] ClanPresetRanks;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x38")]
	public int CaptainOfflineDays;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x3C")]
	public int JoinDaysBeforeApplyForDeputy;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x40")]
	public int DeputyOfflineDays;
}
