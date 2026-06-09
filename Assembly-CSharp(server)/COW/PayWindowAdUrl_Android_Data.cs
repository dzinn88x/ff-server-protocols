using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001154 RID: 4436
	[Token(Token = "0x2001154")]
	public class PayWindowAdUrl_Android_Data : CSVBaseData
	{
		// Token: 0x06004533 RID: 17715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004533")]
		[Address(RVA = "0x204ABD8", Offset = "0x204ABD8", VA = "0x7BBC84ABD8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004534")]
		[Address(RVA = "0x204ABE0", Offset = "0x204ABE0", VA = "0x7BBC84ABE0", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004535 RID: 17717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004535")]
		[Address(RVA = "0x204ACB4", Offset = "0x204ACB4", VA = "0x7BBC84ACB4")]
		public PayWindowAdUrl_Android_Data()
		{
		}

		// Token: 0x040055D9 RID: 21977
		[Token(Token = "0x40055D9")]
		[FieldOffset(Offset = "0x10")]
		public string RegionName;

		// Token: 0x040055DA RID: 21978
		[Token(Token = "0x40055DA")]
		[FieldOffset(Offset = "0x18")]
		public string Url;
	}
}
