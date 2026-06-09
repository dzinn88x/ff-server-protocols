using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200117C RID: 4476
	[Token(Token = "0x200117C")]
	public class RebateCardData : CSVBaseData
	{
		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060045A3 RID: 17827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000816")]
		public string SubscriptionProductIdentifier
		{
			[Token(Token = "0x60045A3")]
			[Address(RVA = "0x1750A5C", Offset = "0x1750A5C", VA = "0x7BBBF50A5C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x060045A4 RID: 17828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000817")]
		public static Dictionary<int, RebateCardData> Data
		{
			[Token(Token = "0x60045A4")]
			[Address(RVA = "0x1750A64", Offset = "0x1750A64", VA = "0x7BBBF50A64")]
			get
			{
				return null;
			}
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A5")]
		[Address(RVA = "0x1750ACC", Offset = "0x1750ACC", VA = "0x7BBBF50ACC", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A6")]
		[Address(RVA = "0x1750AD8", Offset = "0x1750AD8", VA = "0x7BBBF50AD8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x000152A0 File Offset: 0x000134A0
		[Token(Token = "0x60045A7")]
		[Address(RVA = "0x1750DD0", Offset = "0x1750DD0", VA = "0x7BBBF50DD0")]
		public bool SupportSubscription()
		{
			return default(bool);
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A8")]
		[Address(RVA = "0x1750E18", Offset = "0x1750E18", VA = "0x7BBBF50E18")]
		public RebateCardData()
		{
		}

		// Token: 0x04005699 RID: 22169
		[Token(Token = "0x4005699")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x0400569A RID: 22170
		[Token(Token = "0x400569A")]
		[FieldOffset(Offset = "0x14")]
		public int RebateID;

		// Token: 0x0400569B RID: 22171
		[Token(Token = "0x400569B")]
		[FieldOffset(Offset = "0x18")]
		public string Price;

		// Token: 0x0400569C RID: 22172
		[Token(Token = "0x400569C")]
		[FieldOffset(Offset = "0x20")]
		public int RebateDays;

		// Token: 0x0400569D RID: 22173
		[Token(Token = "0x400569D")]
		[FieldOffset(Offset = "0x24")]
		public RebateCardType RebateCardType;

		// Token: 0x0400569E RID: 22174
		[Token(Token = "0x400569E")]
		[FieldOffset(Offset = "0x28")]
		public int RebateAmount;

		// Token: 0x0400569F RID: 22175
		[Token(Token = "0x400569F")]
		[FieldOffset(Offset = "0x2C")]
		public int FirstRebateAmount;

		// Token: 0x040056A0 RID: 22176
		[Token(Token = "0x40056A0")]
		[FieldOffset(Offset = "0x30")]
		public string ProductIdentifier;

		// Token: 0x040056A1 RID: 22177
		[Token(Token = "0x40056A1")]
		[FieldOffset(Offset = "0x38")]
		public int EarningRatePercentage;

		// Token: 0x040056A2 RID: 22178
		[Token(Token = "0x40056A2")]
		[FieldOffset(Offset = "0x40")]
		public string NameKey;

		// Token: 0x040056A3 RID: 22179
		[Token(Token = "0x40056A3")]
		[FieldOffset(Offset = "0x48")]
		public int DaysAheadForRenewalReminding;

		// Token: 0x040056A4 RID: 22180
		[Token(Token = "0x40056A4")]
		[FieldOffset(Offset = "0x50")]
		public string SubscriptionProductIdentifier_iOS;

		// Token: 0x040056A5 RID: 22181
		[Token(Token = "0x40056A5")]
		[FieldOffset(Offset = "0x58")]
		public string SubscriptionProductIdentifier_Android;

		// Token: 0x040056A6 RID: 22182
		[Token(Token = "0x40056A6")]
		[FieldOffset(Offset = "0x60")]
		public string SubscribePrice;

		// Token: 0x040056A7 RID: 22183
		[Token(Token = "0x40056A7")]
		[FieldOffset(Offset = "0x68")]
		public int SubscribeBonus;

		// Token: 0x040056A8 RID: 22184
		[Token(Token = "0x40056A8")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, RebateCardData> _Data;
	}
}
