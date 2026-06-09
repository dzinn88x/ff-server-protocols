using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020011A8 RID: 4520
	[Token(Token = "0x20011A8")]
	public class WebTutorialData : CsvDataIndexedReading
	{
		// Token: 0x0600464F RID: 17999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600464F")]
		[Address(RVA = "0x17A0974", Offset = "0x17A0974", VA = "0x7BBBFA0974", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004650 RID: 18000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004650")]
		[Address(RVA = "0x17A09BC", Offset = "0x17A09BC", VA = "0x7BBBFA09BC", Slot = "7")]
		public override string[] GetHeadColNames()
		{
			return null;
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004651")]
		[Address(RVA = "0x17A0BBC", Offset = "0x17A0BBC", VA = "0x7BBBFA0BBC", Slot = "8")]
		public override void ParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004652")]
		[Address(RVA = "0x17A0F90", Offset = "0x17A0F90", VA = "0x7BBBFA0F90")]
		public WebTutorialData()
		{
		}

		// Token: 0x0400579E RID: 22430
		[Token(Token = "0x400579E")]
		[FieldOffset(Offset = "0x10")]
		public string Region;

		// Token: 0x0400579F RID: 22431
		[Token(Token = "0x400579F")]
		[FieldOffset(Offset = "0x18")]
		public string WebLink;

		// Token: 0x040057A0 RID: 22432
		[Token(Token = "0x40057A0")]
		[FieldOffset(Offset = "0x20")]
		public int Type;

		// Token: 0x040057A1 RID: 22433
		[Token(Token = "0x40057A1")]
		[FieldOffset(Offset = "0x24")]
		public int SubType;

		// Token: 0x040057A2 RID: 22434
		[Token(Token = "0x40057A2")]
		[FieldOffset(Offset = "0x28")]
		public int MatchType;
	}
}
