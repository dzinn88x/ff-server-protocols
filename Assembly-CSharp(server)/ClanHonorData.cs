using System;
using GCommon;
using Il2CppDummyDll;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
public class ClanHonorData : CSVBaseData
{
	// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x23E077C", Offset = "0x23E077C", VA = "0x7BBCBE077C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x23E0788", Offset = "0x23E0788", VA = "0x7BBCBE0788", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x23E08AC", Offset = "0x23E08AC", VA = "0x7BBCBE08AC")]
	public ClanHonorData()
	{
	}

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x10")]
	public int ID;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x14")]
	public int Type;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x18")]
	public int Upperlimit;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x1C")]
	public int Division;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x20")]
	public float Honor;
}
