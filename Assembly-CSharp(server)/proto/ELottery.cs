using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200064A RID: 1610
	[Token(Token = "0x200064A")]
	[ProtoContract]
	public class ELottery
	{
		// Token: 0x060023B4 RID: 9140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B4")]
		[Address(RVA = "0x21B9858", Offset = "0x21B9858", VA = "0x7BBC9B9858")]
		public ELottery()
		{
		}

		// Token: 0x0200064B RID: 1611
		[Token(Token = "0x200064B")]
		[ProtoContract]
		public enum LotteryType
		{
			// Token: 0x04001FCD RID: 8141
			[Token(Token = "0x4001FCD")]
			LotteryType_NONE,
			// Token: 0x04001FCE RID: 8142
			[Token(Token = "0x4001FCE")]
			LotteryType_ONE,
			// Token: 0x04001FCF RID: 8143
			[Token(Token = "0x4001FCF")]
			LotteryType_SOME,
			// Token: 0x04001FD0 RID: 8144
			[Token(Token = "0x4001FD0")]
			LotteryType_DROPUP_BUFF,
			// Token: 0x04001FD1 RID: 8145
			[Token(Token = "0x4001FD1")]
			LotteryType_RERANDOM
		}

		// Token: 0x0200064C RID: 1612
		[Token(Token = "0x200064C")]
		[ProtoContract]
		public enum PoolType
		{
			// Token: 0x04001FD3 RID: 8147
			[Token(Token = "0x4001FD3")]
			PoolType_ALL,
			// Token: 0x04001FD4 RID: 8148
			[Token(Token = "0x4001FD4")]
			PoolType_FR,
			// Token: 0x04001FD5 RID: 8149
			[Token(Token = "0x4001FD5")]
			PoolType_R,
			// Token: 0x04001FD6 RID: 8150
			[Token(Token = "0x4001FD6")]
			PoolType_SR,
			// Token: 0x04001FD7 RID: 8151
			[Token(Token = "0x4001FD7")]
			PoolType_NO_R,
			// Token: 0x04001FD8 RID: 8152
			[Token(Token = "0x4001FD8")]
			PoolType_NO_SR,
			// Token: 0x04001FD9 RID: 8153
			[Token(Token = "0x4001FD9")]
			PoolType_NO_R_SR,
			// Token: 0x04001FDA RID: 8154
			[Token(Token = "0x4001FDA")]
			PoolType_NO_FR,
			// Token: 0x04001FDB RID: 8155
			[Token(Token = "0x4001FDB")]
			PoolType_NO_FR_R,
			// Token: 0x04001FDC RID: 8156
			[Token(Token = "0x4001FDC")]
			PoolType_NO_FR_SR,
			// Token: 0x04001FDD RID: 8157
			[Token(Token = "0x4001FDD")]
			PoolType_NO_FR_R_SR,
			// Token: 0x04001FDE RID: 8158
			[Token(Token = "0x4001FDE")]
			PoolType_MUST_DROP,
			// Token: 0x04001FDF RID: 8159
			[Token(Token = "0x4001FDF")]
			PoolType_VETERAN
		}

		// Token: 0x0200064D RID: 1613
		[Token(Token = "0x200064D")]
		[ProtoContract]
		public enum CoinType
		{
			// Token: 0x04001FE1 RID: 8161
			[Token(Token = "0x4001FE1")]
			CoinType_NONE,
			// Token: 0x04001FE2 RID: 8162
			[Token(Token = "0x4001FE2")]
			CoinType_COINS,
			// Token: 0x04001FE3 RID: 8163
			[Token(Token = "0x4001FE3")]
			CoinType_GEMS
		}

		// Token: 0x0200064E RID: 1614
		[Token(Token = "0x200064E")]
		[ProtoContract]
		public enum WeightType
		{
			// Token: 0x04001FE5 RID: 8165
			[Token(Token = "0x4001FE5")]
			WeightType_NONE,
			// Token: 0x04001FE6 RID: 8166
			[Token(Token = "0x4001FE6")]
			WeightType_FIRST_REWARD,
			// Token: 0x04001FE7 RID: 8167
			[Token(Token = "0x4001FE7")]
			WeightType_BASE,
			// Token: 0x04001FE8 RID: 8168
			[Token(Token = "0x4001FE8")]
			WeightType_SECOND_LEVEL,
			// Token: 0x04001FE9 RID: 8169
			[Token(Token = "0x4001FE9")]
			WeightType_THIRD_LEVEL,
			// Token: 0x04001FEA RID: 8170
			[Token(Token = "0x4001FEA")]
			WeightType_VETERAN,
			// Token: 0x04001FEB RID: 8171
			[Token(Token = "0x4001FEB")]
			WeightType_FOURTH_LEVEL,
			// Token: 0x04001FEC RID: 8172
			[Token(Token = "0x4001FEC")]
			WeightType_FIFTH_LEVEL
		}

		// Token: 0x0200064F RID: 1615
		[Token(Token = "0x200064F")]
		[ProtoContract]
		public enum ConsumeType
		{
			// Token: 0x04001FEE RID: 8174
			[Token(Token = "0x4001FEE")]
			ConsumeType_NONE,
			// Token: 0x04001FEF RID: 8175
			[Token(Token = "0x4001FEF")]
			ConsumeType_FREE,
			// Token: 0x04001FF0 RID: 8176
			[Token(Token = "0x4001FF0")]
			ConsumeType_EXCHANGE_ITEM,
			// Token: 0x04001FF1 RID: 8177
			[Token(Token = "0x4001FF1")]
			ConsumeType_MONEY
		}

		// Token: 0x02000650 RID: 1616
		[Token(Token = "0x2000650")]
		[ProtoContract]
		public enum ExtraRewardState
		{
			// Token: 0x04001FF3 RID: 8179
			[Token(Token = "0x4001FF3")]
			ExtraRewardState_NONE,
			// Token: 0x04001FF4 RID: 8180
			[Token(Token = "0x4001FF4")]
			ExtraRewardState_RECEIVED
		}

		// Token: 0x02000651 RID: 1617
		[Token(Token = "0x2000651")]
		[ProtoContract]
		public enum Type
		{
			// Token: 0x04001FF6 RID: 8182
			[Token(Token = "0x4001FF6")]
			Type_NORMAL,
			// Token: 0x04001FF7 RID: 8183
			[Token(Token = "0x4001FF7")]
			Type_TURNTABLE,
			// Token: 0x04001FF8 RID: 8184
			[Token(Token = "0x4001FF8")]
			Type_ULTRAMATE,
			// Token: 0x04001FF9 RID: 8185
			[Token(Token = "0x4001FF9")]
			Type_LEGENDARY,
			// Token: 0x04001FFA RID: 8186
			[Token(Token = "0x4001FFA")]
			Type_LIMIT_POOL,
			// Token: 0x04001FFB RID: 8187
			[Token(Token = "0x4001FFB")]
			Type_TOKEN_GACHA,
			// Token: 0x04001FFC RID: 8188
			[Token(Token = "0x4001FFC")]
			Type_ENERGY_GACHA,
			// Token: 0x04001FFD RID: 8189
			[Token(Token = "0x4001FFD")]
			Type_COMPLETION,
			// Token: 0x04001FFE RID: 8190
			[Token(Token = "0x4001FFE")]
			Type_ACT_LIMIT_POOL = 101,
			// Token: 0x04001FFF RID: 8191
			[Token(Token = "0x4001FFF")]
			Type_ACT_REAPER,
			// Token: 0x04002000 RID: 8192
			[Token(Token = "0x4002000")]
			Type_ACT_ANN_POOL,
			// Token: 0x04002001 RID: 8193
			[Token(Token = "0x4002001")]
			Type_ACT_ANN_LIMIT_POOL,
			// Token: 0x04002002 RID: 8194
			[Token(Token = "0x4002002")]
			Type_ACT_COMPETITION,
			// Token: 0x04002003 RID: 8195
			[Token(Token = "0x4002003")]
			Type_ACT_MEGAPUNCH
		}

		// Token: 0x02000652 RID: 1618
		[Token(Token = "0x2000652")]
		[ProtoContract]
		public enum RareType
		{
			// Token: 0x04002005 RID: 8197
			[Token(Token = "0x4002005")]
			RareType_NORMAL,
			// Token: 0x04002006 RID: 8198
			[Token(Token = "0x4002006")]
			RareType_RARE,
			// Token: 0x04002007 RID: 8199
			[Token(Token = "0x4002007")]
			RareType_SUPER_RARE
		}

		// Token: 0x02000653 RID: 1619
		[Token(Token = "0x2000653")]
		[ProtoContract]
		public enum LimitPurchaseType
		{
			// Token: 0x04002009 RID: 8201
			[Token(Token = "0x4002009")]
			LimitPurchaseType_NONE,
			// Token: 0x0400200A RID: 8202
			[Token(Token = "0x400200A")]
			LimitPurchaseType_DAILY,
			// Token: 0x0400200B RID: 8203
			[Token(Token = "0x400200B")]
			LimitPurchaseType_SUBID
		}

		// Token: 0x02000654 RID: 1620
		[Token(Token = "0x2000654")]
		[ProtoContract]
		public enum ExtraRewardCdtType
		{
			// Token: 0x0400200D RID: 8205
			[Token(Token = "0x400200D")]
			ExtraRewardCdtType_NONE,
			// Token: 0x0400200E RID: 8206
			[Token(Token = "0x400200E")]
			ExtraRewardCdtType_LOTTERY_COUNT,
			// Token: 0x0400200F RID: 8207
			[Token(Token = "0x400200F")]
			ExtraRewardCdtType_PROGRESS
		}

		// Token: 0x02000655 RID: 1621
		[Token(Token = "0x2000655")]
		[ProtoContract]
		public enum BuffUpDisplayLevel
		{
			// Token: 0x04002011 RID: 8209
			[Token(Token = "0x4002011")]
			BuffUpDisplayLevel_LOW,
			// Token: 0x04002012 RID: 8210
			[Token(Token = "0x4002012")]
			BuffUpDisplayLevel_MEDIUM,
			// Token: 0x04002013 RID: 8211
			[Token(Token = "0x4002013")]
			BuffUpDisplayLevel_HIGH
		}
	}
}
