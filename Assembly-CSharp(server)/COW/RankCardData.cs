using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001178 RID: 4472
	[Token(Token = "0x2001178")]
	public class RankCardData : CSVBaseData
	{
		// Token: 0x06004599 RID: 17817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004599")]
		[Address(RVA = "0x1750004", Offset = "0x1750004", VA = "0x7BBBF50004", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459A")]
		[Address(RVA = "0x1750010", Offset = "0x1750010", VA = "0x7BBBF50010", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x00015288 File Offset: 0x00013488
		[Token(Token = "0x600459B")]
		[Address(RVA = "0x175013C", Offset = "0x175013C", VA = "0x7BBBF5013C")]
		private ERankCardType GetCardType()
		{
			return ERankCardType.NONE;
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459C")]
		[Address(RVA = "0x175016C", Offset = "0x175016C", VA = "0x7BBBF5016C")]
		public RankCardData()
		{
		}

		// Token: 0x04005689 RID: 22153
		[Token(Token = "0x4005689")]
		[FieldOffset(Offset = "0x10")]
		public int Id;

		// Token: 0x0400568A RID: 22154
		[Token(Token = "0x400568A")]
		[FieldOffset(Offset = "0x14")]
		public int RPTimes;

		// Token: 0x0400568B RID: 22155
		[Token(Token = "0x400568B")]
		[FieldOffset(Offset = "0x18")]
		public int TokenTimes;

		// Token: 0x0400568C RID: 22156
		[Token(Token = "0x400568C")]
		[FieldOffset(Offset = "0x1C")]
		public bool IsNoDeduct;

		// Token: 0x0400568D RID: 22157
		[Token(Token = "0x400568D")]
		[FieldOffset(Offset = "0x20")]
		public ERankCardType type;
	}
}
