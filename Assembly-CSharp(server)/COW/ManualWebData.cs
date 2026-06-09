using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001146 RID: 4422
	[Token(Token = "0x2001146")]
	public class ManualWebData : CSVBaseData
	{
		// Token: 0x06004503 RID: 17667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004503")]
		[Address(RVA = "0x1A56D50", Offset = "0x1A56D50", VA = "0x7BBC256D50", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004504")]
		[Address(RVA = "0x1A56D58", Offset = "0x1A56D58", VA = "0x7BBC256D58", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004505")]
		[Address(RVA = "0x1A56E18", Offset = "0x1A56E18", VA = "0x7BBC256E18")]
		public ManualWebData()
		{
		}

		// Token: 0x0400555C RID: 21852
		[Token(Token = "0x400555C")]
		[FieldOffset(Offset = "0x10")]
		public string Region;

		// Token: 0x0400555D RID: 21853
		[Token(Token = "0x400555D")]
		[FieldOffset(Offset = "0x18")]
		public string WebLink;
	}
}
