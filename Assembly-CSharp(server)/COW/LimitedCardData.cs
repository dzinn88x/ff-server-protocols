using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001122 RID: 4386
	[Token(Token = "0x2001122")]
	public class LimitedCardData : CsvDataIndexedReading, IGetId
	{
		// Token: 0x06004497 RID: 17559 RVA: 0x00015060 File Offset: 0x00013260
		[Token(Token = "0x6004497")]
		[Address(RVA = "0x1403680", Offset = "0x1403680", VA = "0x7BBBC03680", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x06004498 RID: 17560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004498")]
		[Address(RVA = "0x1403688", Offset = "0x1403688", VA = "0x7BBBC03688", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004499")]
		[Address(RVA = "0x1403694", Offset = "0x1403694", VA = "0x7BBBC03694", Slot = "7")]
		public override string[] GetHeadColNames()
		{
			return null;
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600449A")]
		[Address(RVA = "0x140393C", Offset = "0x140393C", VA = "0x7BBBC0393C", Slot = "8")]
		public override void ParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600449B")]
		[Address(RVA = "0x1403E5C", Offset = "0x1403E5C", VA = "0x7BBBC03E5C")]
		public LimitedCardData()
		{
		}

		// Token: 0x040054B8 RID: 21688
		[Token(Token = "0x40054B8")]
		[FieldOffset(Offset = "0x10")]
		public uint iID;

		// Token: 0x040054B9 RID: 21689
		[Token(Token = "0x40054B9")]
		[FieldOffset(Offset = "0x14")]
		public uint CardType;

		// Token: 0x040054BA RID: 21690
		[Token(Token = "0x40054BA")]
		[FieldOffset(Offset = "0x18")]
		public uint EffectedId;

		// Token: 0x040054BB RID: 21691
		[Token(Token = "0x40054BB")]
		[FieldOffset(Offset = "0x1C")]
		public uint ExpireMins;

		// Token: 0x040054BC RID: 21692
		[Token(Token = "0x40054BC")]
		[FieldOffset(Offset = "0x20")]
		public uint LeftUseTimes;

		// Token: 0x040054BD RID: 21693
		[Token(Token = "0x40054BD")]
		[FieldOffset(Offset = "0x24")]
		public uint DisCount;

		// Token: 0x040054BE RID: 21694
		[Token(Token = "0x40054BE")]
		[FieldOffset(Offset = "0x28")]
		public uint TakeGiftCount;
	}
}
