using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020010ED RID: 4333
	[Token(Token = "0x20010ED")]
	public class EPPreorderData : CSVBaseData
	{
		// Token: 0x060043A1 RID: 17313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A1")]
		[Address(RVA = "0x16115B4", Offset = "0x16115B4", VA = "0x7BBBE115B4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A2")]
		[Address(RVA = "0x16115E4", Offset = "0x16115E4", VA = "0x7BBBE115E4", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x00014BF8 File Offset: 0x00012DF8
		[Token(Token = "0x60043A3")]
		[Address(RVA = "0x1611964", Offset = "0x1611964", VA = "0x7BBBE11964")]
		public static bool IsNextEPPreorder(uint curEPID)
		{
			return default(bool);
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A4")]
		[Address(RVA = "0x1611A14", Offset = "0x1611A14", VA = "0x7BBBE11A14")]
		public static EPPreorderData GetPreorderData(uint epid)
		{
			return null;
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A5")]
		[Address(RVA = "0x1611B74", Offset = "0x1611B74", VA = "0x7BBBE11B74")]
		public List<BaseItemInfo> GetPreviewItem()
		{
			return null;
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A6")]
		[Address(RVA = "0x1611CA8", Offset = "0x1611CA8", VA = "0x7BBBE11CA8")]
		public EPPreorderData()
		{
		}

		// Token: 0x04005388 RID: 21384
		[Token(Token = "0x4005388")]
		[FieldOffset(Offset = "0x10")]
		public DateTime StartTime;

		// Token: 0x04005389 RID: 21385
		[Token(Token = "0x4005389")]
		[FieldOffset(Offset = "0x18")]
		public DateTime EndTime;

		// Token: 0x0400538A RID: 21386
		[Token(Token = "0x400538A")]
		[FieldOffset(Offset = "0x20")]
		public string Region;

		// Token: 0x0400538B RID: 21387
		[Token(Token = "0x400538B")]
		[FieldOffset(Offset = "0x28")]
		public uint[] PreviewItem;

		// Token: 0x0400538C RID: 21388
		[Token(Token = "0x400538C")]
		[FieldOffset(Offset = "0x30")]
		public uint EPID;

		// Token: 0x0400538D RID: 21389
		[Token(Token = "0x400538D")]
		[FieldOffset(Offset = "0x34")]
		public EInventory.AwardType ExAwardType1;

		// Token: 0x0400538E RID: 21390
		[Token(Token = "0x400538E")]
		[FieldOffset(Offset = "0x38")]
		public uint ExAwardID1;

		// Token: 0x0400538F RID: 21391
		[Token(Token = "0x400538F")]
		[FieldOffset(Offset = "0x3C")]
		public uint ExAwardCnt1;

		// Token: 0x04005390 RID: 21392
		[Token(Token = "0x4005390")]
		[FieldOffset(Offset = "0x40")]
		public uint ExAwardTime1;

		// Token: 0x04005391 RID: 21393
		[Token(Token = "0x4005391")]
		[FieldOffset(Offset = "0x44")]
		public EInventory.AwardType ExAwardType2;

		// Token: 0x04005392 RID: 21394
		[Token(Token = "0x4005392")]
		[FieldOffset(Offset = "0x48")]
		public uint ExAwardID2;

		// Token: 0x04005393 RID: 21395
		[Token(Token = "0x4005393")]
		[FieldOffset(Offset = "0x4C")]
		public uint ExAwardCnt2;

		// Token: 0x04005394 RID: 21396
		[Token(Token = "0x4005394")]
		[FieldOffset(Offset = "0x50")]
		public uint ExAwardTime2;

		// Token: 0x04005395 RID: 21397
		[Token(Token = "0x4005395")]
		[FieldOffset(Offset = "0x54")]
		public ResourceID PreorderIcon;
	}
}
