using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C7D RID: 7293
	[Token(Token = "0x2001C7D")]
	public class LocStyleConfigData : CSVBaseData
	{
		// Token: 0x06009F08 RID: 40712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F08")]
		[Address(RVA = "0x1A4E45C", Offset = "0x1A4E45C", VA = "0x7BBC24E45C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06009F09 RID: 40713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F09")]
		[Address(RVA = "0x1A4E468", Offset = "0x1A4E468", VA = "0x7BBC24E468", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06009F0A RID: 40714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F0A")]
		[Address(RVA = "0x1A4E568", Offset = "0x1A4E568", VA = "0x7BBC24E568")]
		public LocStyleConfigData()
		{
		}

		// Token: 0x0400A5F0 RID: 42480
		[Token(Token = "0x400A5F0")]
		[FieldOffset(Offset = "0x10")]
		public int LanguageID;

		// Token: 0x0400A5F1 RID: 42481
		[Token(Token = "0x400A5F1")]
		[FieldOffset(Offset = "0x14")]
		public float FontSize;

		// Token: 0x0400A5F2 RID: 42482
		[Token(Token = "0x400A5F2")]
		[FieldOffset(Offset = "0x18")]
		public float SpacingX;

		// Token: 0x0400A5F3 RID: 42483
		[Token(Token = "0x400A5F3")]
		[FieldOffset(Offset = "0x1C")]
		public float SpacingY;
	}
}
