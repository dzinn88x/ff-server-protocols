using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001151 RID: 4433
	[Token(Token = "0x2001151")]
	public class PayItemDisplay_iOS_Data : CSVBaseData
	{
		// Token: 0x06004528 RID: 17704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004528")]
		[Address(RVA = "0x203E3A8", Offset = "0x203E3A8", VA = "0x7BBC83E3A8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004529 RID: 17705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004529")]
		[Address(RVA = "0x203E3DC", Offset = "0x203E3DC", VA = "0x7BBC83E3DC", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600452A RID: 17706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600452A")]
		[Address(RVA = "0x203E664", Offset = "0x203E664", VA = "0x7BBC83E664")]
		public PayItemDisplay_iOS_Data()
		{
		}

		// Token: 0x040055CC RID: 21964
		[Token(Token = "0x40055CC")]
		[FieldOffset(Offset = "0x10")]
		public string ItemIdentifier;

		// Token: 0x040055CD RID: 21965
		[Token(Token = "0x40055CD")]
		[FieldOffset(Offset = "0x18")]
		public string CostString;

		// Token: 0x040055CE RID: 21966
		[Token(Token = "0x40055CE")]
		[FieldOffset(Offset = "0x20")]
		public string CostCurrency;

		// Token: 0x040055CF RID: 21967
		[Token(Token = "0x40055CF")]
		[FieldOffset(Offset = "0x28")]
		public float CostAmount;

		// Token: 0x040055D0 RID: 21968
		[Token(Token = "0x40055D0")]
		[FieldOffset(Offset = "0x2C")]
		public int VirtualCurrencyAmount;

		// Token: 0x040055D1 RID: 21969
		[Token(Token = "0x40055D1")]
		[FieldOffset(Offset = "0x30")]
		public int BonusVirtualCurrencyAmount;

		// Token: 0x040055D2 RID: 21970
		[Token(Token = "0x40055D2")]
		[FieldOffset(Offset = "0x34")]
		public int FirstTimeBonusVirtualCurrencyAmount;

		// Token: 0x040055D3 RID: 21971
		[Token(Token = "0x40055D3")]
		[FieldOffset(Offset = "0x38")]
		public string CdnUrlKey;

		// Token: 0x040055D4 RID: 21972
		[Token(Token = "0x40055D4")]
		[FieldOffset(Offset = "0x40")]
		public string ResourceName;

		// Token: 0x040055D5 RID: 21973
		[Token(Token = "0x40055D5")]
		[FieldOffset(Offset = "0x48")]
		public ResourceID ResourceId;
	}
}
