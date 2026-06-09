using System;
using GCommon;
using Il2CppDummyDll;

// Token: 0x0200000B RID: 11
[Token(Token = "0x200000B")]
public class NotifyData : CSVBaseData
{
	// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2291404", Offset = "0x2291404", VA = "0x7BBCA91404", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x229140C", Offset = "0x229140C", VA = "0x7BBCA9140C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x229150C", Offset = "0x229150C", VA = "0x7BBCA9150C")]
	public NotifyData()
	{
	}

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x10")]
	public string ID;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x18")]
	public string NotifyType;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x20")]
	public string NotifyContentString;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x28")]
	public string NotifyTypePic;
}
