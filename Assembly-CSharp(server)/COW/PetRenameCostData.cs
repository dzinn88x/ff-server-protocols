using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001163 RID: 4451
	[Token(Token = "0x2001163")]
	public class PetRenameCostData : CSVBaseData
	{
		// Token: 0x06004555 RID: 17749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004555")]
		[Address(RVA = "0x2051894", Offset = "0x2051894", VA = "0x7BBC851894", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004556")]
		[Address(RVA = "0x20518C8", Offset = "0x20518C8", VA = "0x7BBC8518C8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004557")]
		[Address(RVA = "0x2051988", Offset = "0x2051988", VA = "0x7BBC851988")]
		public PetRenameCostData()
		{
		}

		// Token: 0x0400562D RID: 22061
		[Token(Token = "0x400562D")]
		[FieldOffset(Offset = "0x10")]
		public string Region;

		// Token: 0x0400562E RID: 22062
		[Token(Token = "0x400562E")]
		[FieldOffset(Offset = "0x18")]
		public int DiamondCost;

		// Token: 0x0400562F RID: 22063
		[Token(Token = "0x400562F")]
		[FieldOffset(Offset = "0x1C")]
		public ResourceID PreviewModel;
	}
}
