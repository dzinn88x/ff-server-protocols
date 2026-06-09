using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000658 RID: 1624
	[Token(Token = "0x2000658")]
	[ProtoContract]
	public class EStore
	{
		// Token: 0x060023B7 RID: 9143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B7")]
		[Address(RVA = "0x21B9B54", Offset = "0x21B9B54", VA = "0x7BBC9B9B54")]
		public EStore()
		{
		}

		// Token: 0x02000659 RID: 1625
		[Token(Token = "0x2000659")]
		[ProtoContract]
		public enum GiftRankType
		{
			// Token: 0x0400201F RID: 8223
			[Token(Token = "0x400201F")]
			GiftRankType_NONE,
			// Token: 0x04002020 RID: 8224
			[Token(Token = "0x4002020")]
			GiftRankType_RECEIVER,
			// Token: 0x04002021 RID: 8225
			[Token(Token = "0x4002021")]
			GiftRankType_GIVER
		}

		// Token: 0x0200065A RID: 1626
		[Token(Token = "0x200065A")]
		[ProtoContract]
		public enum IapType
		{
			// Token: 0x04002023 RID: 8227
			[Token(Token = "0x4002023")]
			IapType_NORMAL,
			// Token: 0x04002024 RID: 8228
			[Token(Token = "0x4002024")]
			IapType_VETERAN
		}

		// Token: 0x0200065B RID: 1627
		[Token(Token = "0x200065B")]
		[ProtoContract]
		public enum IapConsumeType
		{
			// Token: 0x04002026 RID: 8230
			[Token(Token = "0x4002026")]
			IapConsumeType_CASH,
			// Token: 0x04002027 RID: 8231
			[Token(Token = "0x4002027")]
			IapConsumeType_DIAMOND
		}

		// Token: 0x0200065C RID: 1628
		[Token(Token = "0x200065C")]
		[ProtoContract]
		public enum IapSpecialDropType
		{
			// Token: 0x04002029 RID: 8233
			[Token(Token = "0x4002029")]
			IapSpecialDropType_NONE,
			// Token: 0x0400202A RID: 8234
			[Token(Token = "0x400202A")]
			IapSpecialDropType_HEAD_SHOT_KILLS,
			// Token: 0x0400202B RID: 8235
			[Token(Token = "0x400202B")]
			IapSpecialDropType_KILLS,
			// Token: 0x0400202C RID: 8236
			[Token(Token = "0x400202C")]
			IapSpecialDropType_HP_PKG_USED_CNT,
			// Token: 0x0400202D RID: 8237
			[Token(Token = "0x400202D")]
			IapSpecialDropType_DAMAGE
		}

		// Token: 0x0200065D RID: 1629
		[Token(Token = "0x200065D")]
		[ProtoContract]
		public enum IapStoreType
		{
			// Token: 0x0400202F RID: 8239
			[Token(Token = "0x400202F")]
			IapStoreType_NONE,
			// Token: 0x04002030 RID: 8240
			[Token(Token = "0x4002030")]
			IapStoreType_AFTER_FIGHT,
			// Token: 0x04002031 RID: 8241
			[Token(Token = "0x4002031")]
			IapStoreType_WEB_ACTIVITY,
			// Token: 0x04002032 RID: 8242
			[Token(Token = "0x4002032")]
			IapStoreType_OPTIONAL_BUNDLE
		}

		// Token: 0x0200065E RID: 1630
		[Token(Token = "0x200065E")]
		[ProtoContract]
		public enum IapDropSituation
		{
			// Token: 0x04002034 RID: 8244
			[Token(Token = "0x4002034")]
			IapDropSituation_NONE,
			// Token: 0x04002035 RID: 8245
			[Token(Token = "0x4002035")]
			IapDropSituation_AFTER_FIGHT,
			// Token: 0x04002036 RID: 8246
			[Token(Token = "0x4002036")]
			IapDropSituation_RECHARGE,
			// Token: 0x04002037 RID: 8247
			[Token(Token = "0x4002037")]
			IapDropSituation_EXCHANGE_ITEM
		}

		// Token: 0x0200065F RID: 1631
		[Token(Token = "0x200065F")]
		[ProtoContract]
		public enum RebateCardBillStatus
		{
			// Token: 0x04002039 RID: 8249
			[Token(Token = "0x4002039")]
			RebateCardBillStatus_NONE,
			// Token: 0x0400203A RID: 8250
			[Token(Token = "0x400203A")]
			RebateCardBillStatus_HITTING,
			// Token: 0x0400203B RID: 8251
			[Token(Token = "0x400203B")]
			RebateCardBillStatus_DONE,
			// Token: 0x0400203C RID: 8252
			[Token(Token = "0x400203C")]
			RebateCardBillStatus_TIMEOUT,
			// Token: 0x0400203D RID: 8253
			[Token(Token = "0x400203D")]
			RebateCardBillStatus_PENDING
		}

		// Token: 0x02000660 RID: 1632
		[Token(Token = "0x2000660")]
		[ProtoContract]
		public enum BundleRefreshType
		{
			// Token: 0x0400203F RID: 8255
			[Token(Token = "0x400203F")]
			BundleRefreshType_NEVER,
			// Token: 0x04002040 RID: 8256
			[Token(Token = "0x4002040")]
			BundleRefreshType_DAILY,
			// Token: 0x04002041 RID: 8257
			[Token(Token = "0x4002041")]
			BundleRefreshType_WEEKLY,
			// Token: 0x04002042 RID: 8258
			[Token(Token = "0x4002042")]
			BundleRefreshType_MONTHLY
		}

		// Token: 0x02000661 RID: 1633
		[Token(Token = "0x2000661")]
		[ProtoContract]
		public enum PbwConsumeType
		{
			// Token: 0x04002044 RID: 8260
			[Token(Token = "0x4002044")]
			PbwConsumeType_CASH,
			// Token: 0x04002045 RID: 8261
			[Token(Token = "0x4002045")]
			PbwConsumeType_DIAMOND,
			// Token: 0x04002046 RID: 8262
			[Token(Token = "0x4002046")]
			PbwConsumeType_FREE
		}

		// Token: 0x02000662 RID: 1634
		[Token(Token = "0x2000662")]
		[ProtoContract]
		public enum PbwActivityType
		{
			// Token: 0x04002048 RID: 8264
			[Token(Token = "0x4002048")]
			PbwActivityType_NONE,
			// Token: 0x04002049 RID: 8265
			[Token(Token = "0x4002049")]
			PbwActivityType_DISCOUNT_BUNDLE,
			// Token: 0x0400204A RID: 8266
			[Token(Token = "0x400204A")]
			PbwActivityType_NEWBIE_BUNDLE,
			// Token: 0x0400204B RID: 8267
			[Token(Token = "0x400204B")]
			PbwActivityType_GROWUP_BUNDLE
		}

		// Token: 0x02000663 RID: 1635
		[Token(Token = "0x2000663")]
		[ProtoContract]
		public enum PayLevelRewardHintType
		{
			// Token: 0x0400204D RID: 8269
			[Token(Token = "0x400204D")]
			PayLevelRewardHintType_NONE,
			// Token: 0x0400204E RID: 8270
			[Token(Token = "0x400204E")]
			PayLevelRewardHintType_NOPAY,
			// Token: 0x0400204F RID: 8271
			[Token(Token = "0x400204F")]
			PayLevelRewardHintType_PAY,
			// Token: 0x04002050 RID: 8272
			[Token(Token = "0x4002050")]
			PayLevelRewardHintType_ALL
		}

		// Token: 0x02000664 RID: 1636
		[Token(Token = "0x2000664")]
		[ProtoContract]
		public enum PayLevelInfoState
		{
			// Token: 0x04002052 RID: 8274
			[Token(Token = "0x4002052")]
			PayLevelInfoState_RECEIVED,
			// Token: 0x04002053 RID: 8275
			[Token(Token = "0x4002053")]
			PayLevelInfoState_FINISHED,
			// Token: 0x04002054 RID: 8276
			[Token(Token = "0x4002054")]
			PayLevelInfoState_AWARDED
		}
	}
}
