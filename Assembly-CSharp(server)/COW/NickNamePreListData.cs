using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200114F RID: 4431
	[Token(Token = "0x200114F")]
	public class NickNamePreListData : CSVBaseData
	{
		// Token: 0x06004521 RID: 17697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004521")]
		[Address(RVA = "0x1A66618", Offset = "0x1A66618", VA = "0x7BBC266618", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004522 RID: 17698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004522")]
		[Address(RVA = "0x1A66624", Offset = "0x1A66624", VA = "0x7BBC266624", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004523")]
		[Address(RVA = "0x1A667E4", Offset = "0x1A667E4", VA = "0x7BBC2667E4")]
		public NickNamePreListData()
		{
		}

		// Token: 0x040055BB RID: 21947
		[Token(Token = "0x40055BB")]
		[FieldOffset(Offset = "0x10")]
		public uint ID;

		// Token: 0x040055BC RID: 21948
		[Token(Token = "0x40055BC")]
		[FieldOffset(Offset = "0x18")]
		public List<string> left;

		// Token: 0x040055BD RID: 21949
		[Token(Token = "0x40055BD")]
		[FieldOffset(Offset = "0x20")]
		public List<string> right;
	}
}
