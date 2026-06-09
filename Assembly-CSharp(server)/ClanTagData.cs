using System;
using GCommon;
using Il2CppDummyDll;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
public class ClanTagData : CSVBaseData
{
	// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x23E0C14", Offset = "0x23E0C14", VA = "0x7BBCBE0C14", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x23E0C20", Offset = "0x23E0C20", VA = "0x7BBCBE0C20", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x23E0CD8", Offset = "0x23E0CD8", VA = "0x7BBCBE0CD8")]
	public ClanTagData()
	{
	}

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x10")]
	public uint ID;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x18")]
	public string Tag;
}
