using System;
using COW;
using GCommon;
using Il2CppDummyDll;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
public class CollectionTabData : CSVBaseData
{
	// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x23E0D40", Offset = "0x23E0D40", VA = "0x7BBCBE0D40", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x23E0DE0", Offset = "0x23E0DE0", VA = "0x7BBCBE0DE0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x23E0EBC", Offset = "0x23E0EBC", VA = "0x7BBCBE0EBC")]
	public CollectionTabData()
	{
	}

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x10")]
	public CSSharedItemDataManager.CollectionSubType TabID;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x18")]
	public string TabName;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x20")]
	public int Priority;
}
