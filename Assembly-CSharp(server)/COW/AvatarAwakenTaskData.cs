using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200109B RID: 4251
	[Token(Token = "0x200109B")]
	public class AvatarAwakenTaskData : CSVBaseData
	{
		// Token: 0x0600419F RID: 16799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419F")]
		[Address(RVA = "0x155C494", Offset = "0x155C494", VA = "0x7BBBD5C494", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041A0")]
		[Address(RVA = "0x155C4A0", Offset = "0x155C4A0", VA = "0x7BBBD5C4A0", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060041A1 RID: 16801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A1")]
		[Address(RVA = "0x155C75C", Offset = "0x155C75C", VA = "0x7BBBD5C75C")]
		public List<BaseItemInfo> GetAwardList()
		{
			return null;
		}

		// Token: 0x060041A2 RID: 16802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041A2")]
		[Address(RVA = "0x155C8F4", Offset = "0x155C8F4", VA = "0x7BBBD5C8F4")]
		public AvatarAwakenTaskData()
		{
		}

		// Token: 0x040050E6 RID: 20710
		[Token(Token = "0x40050E6")]
		[FieldOffset(Offset = "0x10")]
		public uint IID;

		// Token: 0x040050E7 RID: 20711
		[Token(Token = "0x40050E7")]
		[FieldOffset(Offset = "0x14")]
		public uint AvatarId;

		// Token: 0x040050E8 RID: 20712
		[Token(Token = "0x40050E8")]
		[FieldOffset(Offset = "0x18")]
		public uint TaskType;

		// Token: 0x040050E9 RID: 20713
		[Token(Token = "0x40050E9")]
		[FieldOffset(Offset = "0x1C")]
		public uint TaskNeedValue;

		// Token: 0x040050EA RID: 20714
		[Token(Token = "0x40050EA")]
		[FieldOffset(Offset = "0x20")]
		public string TaskDesc;

		// Token: 0x040050EB RID: 20715
		[Token(Token = "0x40050EB")]
		[FieldOffset(Offset = "0x28")]
		public bool NeedChangeValType;

		// Token: 0x040050EC RID: 20716
		[Token(Token = "0x40050EC")]
		[FieldOffset(Offset = "0x2C")]
		public uint RewardType1;

		// Token: 0x040050ED RID: 20717
		[Token(Token = "0x40050ED")]
		[FieldOffset(Offset = "0x30")]
		public uint RewardId1;

		// Token: 0x040050EE RID: 20718
		[Token(Token = "0x40050EE")]
		[FieldOffset(Offset = "0x34")]
		public uint RewardCnt1;

		// Token: 0x040050EF RID: 20719
		[Token(Token = "0x40050EF")]
		[FieldOffset(Offset = "0x38")]
		public uint RewardType2;

		// Token: 0x040050F0 RID: 20720
		[Token(Token = "0x40050F0")]
		[FieldOffset(Offset = "0x3C")]
		public uint RewardId2;

		// Token: 0x040050F1 RID: 20721
		[Token(Token = "0x40050F1")]
		[FieldOffset(Offset = "0x40")]
		public uint RewardCnt2;

		// Token: 0x040050F2 RID: 20722
		[Token(Token = "0x40050F2")]
		[FieldOffset(Offset = "0x44")]
		public uint RewardType3;

		// Token: 0x040050F3 RID: 20723
		[Token(Token = "0x40050F3")]
		[FieldOffset(Offset = "0x48")]
		public uint RewardId3;

		// Token: 0x040050F4 RID: 20724
		[Token(Token = "0x40050F4")]
		[FieldOffset(Offset = "0x4C")]
		public uint RewardCnt3;

		// Token: 0x040050F5 RID: 20725
		[Token(Token = "0x40050F5")]
		[FieldOffset(Offset = "0x50")]
		public string ComicCDNLink;

		// Token: 0x040050F6 RID: 20726
		[Token(Token = "0x40050F6")]
		[FieldOffset(Offset = "0x58")]
		public string ComicDesc;

		// Token: 0x040050F7 RID: 20727
		[Token(Token = "0x40050F7")]
		[FieldOffset(Offset = "0x60")]
		public string ComicLockCDN;

		// Token: 0x040050F8 RID: 20728
		[Token(Token = "0x40050F8")]
		[FieldOffset(Offset = "0x68")]
		public string ComicUnLockCDN;
	}
}
