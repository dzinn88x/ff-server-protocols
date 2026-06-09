using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001112 RID: 4370
	[Token(Token = "0x2001112")]
	public class IntimacyRankInfoData : CSVBaseData
	{
		// Token: 0x0600446C RID: 17516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600446C")]
		[Address(RVA = "0x13F29DC", Offset = "0x13F29DC", VA = "0x7BBBBF29DC", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600446D RID: 17517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600446D")]
		[Address(RVA = "0x13F2A10", Offset = "0x13F2A10", VA = "0x7BBBBF2A10")]
		public static string GeneratePrimaryKey(uint relationType, uint IntimacyRank)
		{
			return null;
		}

		// Token: 0x0600446E RID: 17518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600446E")]
		[Address(RVA = "0x13F2A40", Offset = "0x13F2A40", VA = "0x7BBBBF2A40", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600446F RID: 17519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600446F")]
		[Address(RVA = "0x13F2BA0", Offset = "0x13F2BA0", VA = "0x7BBBBF2BA0")]
		public IntimacyRankInfoData()
		{
		}

		// Token: 0x04005465 RID: 21605
		[Token(Token = "0x4005465")]
		[FieldOffset(Offset = "0x10")]
		public uint RelationType;

		// Token: 0x04005466 RID: 21606
		[Token(Token = "0x4005466")]
		[FieldOffset(Offset = "0x14")]
		public uint IntimacyRank;

		// Token: 0x04005467 RID: 21607
		[Token(Token = "0x4005467")]
		[FieldOffset(Offset = "0x18")]
		public uint LowerBound;

		// Token: 0x04005468 RID: 21608
		[Token(Token = "0x4005468")]
		[FieldOffset(Offset = "0x1C")]
		public uint UpperBound;

		// Token: 0x04005469 RID: 21609
		[Token(Token = "0x4005469")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID RelationBadgeIcon;
	}
}
