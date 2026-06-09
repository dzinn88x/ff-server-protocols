using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001123 RID: 4387
	[Token(Token = "0x2001123")]
	public class LinkActivityData : CSVBaseData
	{
		// Token: 0x0600449C RID: 17564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600449C")]
		[Address(RVA = "0x1404290", Offset = "0x1404290", VA = "0x7BBBC04290", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600449D")]
		[Address(RVA = "0x140429C", Offset = "0x140429C", VA = "0x7BBBC0429C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x00015078 File Offset: 0x00013278
		[Token(Token = "0x600449E")]
		[Address(RVA = "0x140454C", Offset = "0x140454C", VA = "0x7BBBC0454C")]
		public int GetTotalDays()
		{
			return 0;
		}

		// Token: 0x0600449F RID: 17567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600449F")]
		[Address(RVA = "0x14045F4", Offset = "0x14045F4", VA = "0x7BBBC045F4")]
		public LinkActivityData()
		{
		}

		// Token: 0x040054BF RID: 21695
		[Token(Token = "0x40054BF")]
		[FieldOffset(Offset = "0x10")]
		public uint Id;

		// Token: 0x040054C0 RID: 21696
		[Token(Token = "0x40054C0")]
		[FieldOffset(Offset = "0x14")]
		public uint Type;

		// Token: 0x040054C1 RID: 21697
		[Token(Token = "0x40054C1")]
		[FieldOffset(Offset = "0x18")]
		public DateTime StartTime;

		// Token: 0x040054C2 RID: 21698
		[Token(Token = "0x40054C2")]
		[FieldOffset(Offset = "0x20")]
		public DateTime EndTime;

		// Token: 0x040054C3 RID: 21699
		[Token(Token = "0x40054C3")]
		[FieldOffset(Offset = "0x28")]
		public uint[] ExchangeIds;

		// Token: 0x040054C4 RID: 21700
		[Token(Token = "0x40054C4")]
		[FieldOffset(Offset = "0x30")]
		public uint[] ExchangeAwardTimes;

		// Token: 0x040054C5 RID: 21701
		[Token(Token = "0x40054C5")]
		[FieldOffset(Offset = "0x38")]
		public int ProcessNum;

		// Token: 0x040054C6 RID: 21702
		[Token(Token = "0x40054C6")]
		[FieldOffset(Offset = "0x3C")]
		public int CircleType;

		// Token: 0x040054C7 RID: 21703
		[Token(Token = "0x40054C7")]
		[FieldOffset(Offset = "0x40")]
		public uint AwardId;

		// Token: 0x040054C8 RID: 21704
		[Token(Token = "0x40054C8")]
		[FieldOffset(Offset = "0x48")]
		public string UrlGoPos;

		// Token: 0x040054C9 RID: 21705
		[Token(Token = "0x40054C9")]
		[FieldOffset(Offset = "0x50")]
		public string CdnUrl;

		// Token: 0x040054CA RID: 21706
		[Token(Token = "0x40054CA")]
		[FieldOffset(Offset = "0x58")]
		public ResourceID EntrySprite;
	}
}
