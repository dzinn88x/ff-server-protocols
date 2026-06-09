using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001155 RID: 4437
	[Token(Token = "0x2001155")]
	public class PayWindowMainImageData : CSVBaseData
	{
		// Token: 0x06004536 RID: 17718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004536")]
		[Address(RVA = "0x204AD1C", Offset = "0x204AD1C", VA = "0x7BBC84AD1C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004537")]
		[Address(RVA = "0x204AD28", Offset = "0x204AD28", VA = "0x7BBC84AD28", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004538")]
		[Address(RVA = "0x204AFB8", Offset = "0x204AFB8", VA = "0x7BBC84AFB8")]
		public PayWindowMainImageData()
		{
		}

		// Token: 0x040055DB RID: 21979
		[Token(Token = "0x40055DB")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x040055DC RID: 21980
		[Token(Token = "0x40055DC")]
		[FieldOffset(Offset = "0x18")]
		public string PaidCdnUrlKey;

		// Token: 0x040055DD RID: 21981
		[Token(Token = "0x40055DD")]
		[FieldOffset(Offset = "0x20")]
		public string UnpaidCdnUrlKey;

		// Token: 0x040055DE RID: 21982
		[Token(Token = "0x40055DE")]
		[FieldOffset(Offset = "0x28")]
		public string PaidResourceName;

		// Token: 0x040055DF RID: 21983
		[Token(Token = "0x40055DF")]
		[FieldOffset(Offset = "0x30")]
		public string UnpaidResourceName;

		// Token: 0x040055E0 RID: 21984
		[Token(Token = "0x40055E0")]
		[FieldOffset(Offset = "0x38")]
		public ResourceID PaidResourceId;

		// Token: 0x040055E1 RID: 21985
		[Token(Token = "0x40055E1")]
		[FieldOffset(Offset = "0x3C")]
		public ResourceID UnpaidResourceId;
	}
}
