using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001125 RID: 4389
	[Token(Token = "0x2001125")]
	public class LinkActivityMapData : LinkActivityDetailData
	{
		// Token: 0x060044A1 RID: 17569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044A1")]
		[Address(RVA = "0x14046C4", Offset = "0x14046C4", VA = "0x7BBBC046C4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044A2 RID: 17570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A2")]
		[Address(RVA = "0x14046D0", Offset = "0x14046D0", VA = "0x7BBBC046D0", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044A3 RID: 17571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A3")]
		[Address(RVA = "0x14047AC", Offset = "0x14047AC", VA = "0x7BBBC047AC")]
		public LinkActivityMapData()
		{
		}

		// Token: 0x040054CB RID: 21707
		[Token(Token = "0x40054CB")]
		[FieldOffset(Offset = "0x10")]
		public uint Id;

		// Token: 0x040054CC RID: 21708
		[Token(Token = "0x40054CC")]
		[FieldOffset(Offset = "0x18")]
		public string ImageUrl;

		// Token: 0x040054CD RID: 21709
		[Token(Token = "0x40054CD")]
		[FieldOffset(Offset = "0x20")]
		public uint MapID;
	}
}
