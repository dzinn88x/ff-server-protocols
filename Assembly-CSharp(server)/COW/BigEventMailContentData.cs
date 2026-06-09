using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200113C RID: 4412
	[Token(Token = "0x200113C")]
	public class BigEventMailContentData : CSVBaseData
	{
		// Token: 0x060044E8 RID: 17640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044E8")]
		[Address(RVA = "0x21D7EC4", Offset = "0x21D7EC4", VA = "0x7BBC9D7EC4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E9")]
		[Address(RVA = "0x21D7ED0", Offset = "0x21D7ED0", VA = "0x7BBC9D7ED0", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044EA RID: 17642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044EA")]
		[Address(RVA = "0x21D7FE8", Offset = "0x21D7FE8", VA = "0x7BBC9D7FE8")]
		public BigEventMailContentData()
		{
		}

		// Token: 0x04005509 RID: 21769
		[Token(Token = "0x4005509")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x0400550A RID: 21770
		[Token(Token = "0x400550A")]
		[FieldOffset(Offset = "0x14")]
		public int RankType;

		// Token: 0x0400550B RID: 21771
		[Token(Token = "0x400550B")]
		[FieldOffset(Offset = "0x18")]
		public string BigEventName;

		// Token: 0x0400550C RID: 21772
		[Token(Token = "0x400550C")]
		[FieldOffset(Offset = "0x20")]
		public string RankDesc;
	}
}
