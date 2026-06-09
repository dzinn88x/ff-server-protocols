using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CE7 RID: 7399
	[Token(Token = "0x2001CE7")]
	public class NationFlagData : CSVBaseData
	{
		// Token: 0x0600A16D RID: 41325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A16D")]
		[Address(RVA = "0x1A5DB4C", Offset = "0x1A5DB4C", VA = "0x7BBC25DB4C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600A16E RID: 41326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A16E")]
		[Address(RVA = "0x1A5DB54", Offset = "0x1A5DB54", VA = "0x7BBC25DB54", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600A16F RID: 41327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A16F")]
		[Address(RVA = "0x1A5DE28", Offset = "0x1A5DE28", VA = "0x7BBC25DE28")]
		public NationFlagData()
		{
		}

		// Token: 0x0400A7EC RID: 42988
		[Token(Token = "0x400A7EC")]
		[FieldOffset(Offset = "0x10")]
		public string countryOrArea;

		// Token: 0x0400A7ED RID: 42989
		[Token(Token = "0x400A7ED")]
		[FieldOffset(Offset = "0x18")]
		public string region;

		// Token: 0x0400A7EE RID: 42990
		[Token(Token = "0x400A7EE")]
		[FieldOffset(Offset = "0x20")]
		public string key;

		// Token: 0x0400A7EF RID: 42991
		[Token(Token = "0x400A7EF")]
		[FieldOffset(Offset = "0x28")]
		public string icon;

		// Token: 0x0400A7F0 RID: 42992
		[Token(Token = "0x400A7F0")]
		[FieldOffset(Offset = "0x30")]
		public bool switchFlag;

		// Token: 0x0400A7F1 RID: 42993
		[Token(Token = "0x400A7F1")]
		[FieldOffset(Offset = "0x31")]
		public bool isOpen;
	}
}
