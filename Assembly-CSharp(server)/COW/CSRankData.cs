using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010D8 RID: 4312
	[Token(Token = "0x20010D8")]
	public class CSRankData : CSVBaseData
	{
		// Token: 0x06004349 RID: 17225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004349")]
		[Address(RVA = "0x14EE428", Offset = "0x14EE428", VA = "0x7BBBCEE428", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434A")]
		[Address(RVA = "0x14EE434", Offset = "0x14EE434", VA = "0x7BBBCEE434", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600434B RID: 17227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434B")]
		[Address(RVA = "0x14EE824", Offset = "0x14EE824", VA = "0x7BBBCEE824")]
		public CSRankData()
		{
		}

		// Token: 0x040052D7 RID: 21207
		[Token(Token = "0x40052D7")]
		[FieldOffset(Offset = "0x10")]
		public int Rank;

		// Token: 0x040052D8 RID: 21208
		[Token(Token = "0x40052D8")]
		[FieldOffset(Offset = "0x18")]
		public string RankName;

		// Token: 0x040052D9 RID: 21209
		[Token(Token = "0x40052D9")]
		[FieldOffset(Offset = "0x20")]
		public uint RankUpStar;

		// Token: 0x040052DA RID: 21210
		[Token(Token = "0x40052DA")]
		[FieldOffset(Offset = "0x24")]
		public uint LowerBound;

		// Token: 0x040052DB RID: 21211
		[Token(Token = "0x40052DB")]
		[FieldOffset(Offset = "0x28")]
		public uint UpperBound;

		// Token: 0x040052DC RID: 21212
		[Token(Token = "0x40052DC")]
		[FieldOffset(Offset = "0x2C")]
		public bool IsRankProtect;

		// Token: 0x040052DD RID: 21213
		[Token(Token = "0x40052DD")]
		[FieldOffset(Offset = "0x30")]
		public ResourceID IconRes;

		// Token: 0x040052DE RID: 21214
		[Token(Token = "0x40052DE")]
		[FieldOffset(Offset = "0x34")]
		public ResourceID BigIconRes;

		// Token: 0x040052DF RID: 21215
		[Token(Token = "0x40052DF")]
		[FieldOffset(Offset = "0x38")]
		public ResourceID LobbyIconRes;
	}
}
