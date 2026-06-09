using System;
using GCommon;
using Il2CppDummyDll;

// Token: 0x0200000A RID: 10
[Token(Token = "0x200000A")]
public class GeoIpCountryData : CSVBaseData
{
	// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2748A24", Offset = "0x2748A24", VA = "0x7BBCF48A24", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2748A2C", Offset = "0x2748A2C", VA = "0x7BBCF48A2C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2748B88", Offset = "0x2748B88", VA = "0x7BBCF48B88")]
	public GeoIpCountryData()
	{
	}

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x10")]
	public string CountryCode;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x18")]
	public bool IsBlackBlood;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x19")]
	public bool IsNoBlood;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x1A")]
	public bool IsNoGacha;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x1B")]
	public bool Is18AgeShow;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x1C")]
	public bool IsNotPPTOP;
}
