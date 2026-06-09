using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005A6 RID: 1446
	[Token(Token = "0x20005A6")]
	[ProtoContract]
	public class EStats
	{
		// Token: 0x0600234D RID: 9037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234D")]
		[Address(RVA = "0x21B9B4C", Offset = "0x21B9B4C", VA = "0x7BBC9B9B4C")]
		public EStats()
		{
		}

		// Token: 0x020005A7 RID: 1447
		[Token(Token = "0x20005A7")]
		[ProtoContract]
		public enum MissionType
		{
			// Token: 0x04001CAD RID: 7341
			[Token(Token = "0x4001CAD")]
			MissionType_NONE,
			// Token: 0x04001CAE RID: 7342
			[Token(Token = "0x4001CAE")]
			MissionType_UPGRADE_LEVEL
		}

		// Token: 0x020005A8 RID: 1448
		[Token(Token = "0x20005A8")]
		[ProtoContract]
		public enum DailyMatchRewardConfigID
		{
			// Token: 0x04001CB0 RID: 7344
			[Token(Token = "0x4001CB0")]
			DailyMatchRewardConfigID_NONE,
			// Token: 0x04001CB1 RID: 7345
			[Token(Token = "0x4001CB1")]
			DailyMatchRewardConfigID_SOLO_TOPN,
			// Token: 0x04001CB2 RID: 7346
			[Token(Token = "0x4001CB2")]
			DailyMatchRewardConfigID_DUO_TOPN,
			// Token: 0x04001CB3 RID: 7347
			[Token(Token = "0x4001CB3")]
			DailyMatchRewardConfigID_QUAD_TOPN,
			// Token: 0x04001CB4 RID: 7348
			[Token(Token = "0x4001CB4")]
			DailyMatchRewardConfigID_FIRST_MATCH
		}

		// Token: 0x020005A9 RID: 1449
		[Token(Token = "0x20005A9")]
		[ProtoContract]
		public enum DailyMatchRewardType
		{
			// Token: 0x04001CB6 RID: 7350
			[Token(Token = "0x4001CB6")]
			DailyMatchRewardType_NONE,
			// Token: 0x04001CB7 RID: 7351
			[Token(Token = "0x4001CB7")]
			DailyMatchRewardType_OUTSTANDING,
			// Token: 0x04001CB8 RID: 7352
			[Token(Token = "0x4001CB8")]
			DailyMatchRewardType_FIRST_MATCH
		}

		// Token: 0x020005AA RID: 1450
		[Token(Token = "0x20005AA")]
		[ProtoContract]
		public enum WinnerTakesAllCurrencyType
		{
			// Token: 0x04001CBA RID: 7354
			[Token(Token = "0x4001CBA")]
			WinnerTakesAllCurrencyType_NONE,
			// Token: 0x04001CBB RID: 7355
			[Token(Token = "0x4001CBB")]
			WinnerTakesAllCurrencyType_CHIP,
			// Token: 0x04001CBC RID: 7356
			[Token(Token = "0x4001CBC")]
			WinnerTakesAllCurrencyType_DIAMOND,
			// Token: 0x04001CBD RID: 7357
			[Token(Token = "0x4001CBD")]
			WinnerTakesAllCurrencyType_FREE
		}
	}
}
