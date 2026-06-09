using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001D19 RID: 7449
	[Token(Token = "0x2001D19")]
	public class GachaResultInfo
	{
		// Token: 0x0600A21D RID: 41501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A21D")]
		[Address(RVA = "0x186B588", Offset = "0x186B588", VA = "0x7BBC06B588")]
		public void ProcessGachaResultInfo(uint chestID, UIModelGacha.GachaDrawType drawType, CSLotteryRes gachaResult)
		{
		}

		// Token: 0x0600A21E RID: 41502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A21E")]
		[Address(RVA = "0x186B69C", Offset = "0x186B69C", VA = "0x7BBC06B69C")]
		public GachaResultInfo()
		{
		}

		// Token: 0x0400A88C RID: 43148
		[Token(Token = "0x400A88C")]
		[FieldOffset(Offset = "0x10")]
		public uint gachaId;

		// Token: 0x0400A88D RID: 43149
		[Token(Token = "0x400A88D")]
		[FieldOffset(Offset = "0x14")]
		public UIModelGacha.GachaDrawType gachaType;

		// Token: 0x0400A88E RID: 43150
		[Token(Token = "0x400A88E")]
		[FieldOffset(Offset = "0x18")]
		public List<ExchangedAward> lotteries;

		// Token: 0x0400A88F RID: 43151
		[Token(Token = "0x400A88F")]
		[FieldOffset(Offset = "0x20")]
		public List<ExchangedAward> rewards;

		// Token: 0x0400A890 RID: 43152
		[Token(Token = "0x400A890")]
		[FieldOffset(Offset = "0x28")]
		public List<ExchangedAward> extraRewards;

		// Token: 0x0400A891 RID: 43153
		[Token(Token = "0x400A891")]
		[FieldOffset(Offset = "0x30")]
		public List<uint> rewardIDs;

		// Token: 0x0400A892 RID: 43154
		[Token(Token = "0x400A892")]
		[FieldOffset(Offset = "0x38")]
		public uint act_progress;
	}
}
