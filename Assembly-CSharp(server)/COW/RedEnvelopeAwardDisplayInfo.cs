using System;
using Il2CppDummyDll;
using message;
using proto;

namespace COW
{
	// Token: 0x020025A7 RID: 9639
	[Token(Token = "0x20025A7")]
	internal class RedEnvelopeAwardDisplayInfo
	{
		// Token: 0x0600C661 RID: 50785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C661")]
		[Address(RVA = "0x1752434", Offset = "0x1752434", VA = "0x7BBBF52434")]
		public RedEnvelopeAwardDisplayInfo(r awardInfo)
		{
		}

		// Token: 0x0600C662 RID: 50786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C662")]
		[Address(RVA = "0x1752500", Offset = "0x1752500", VA = "0x7BBBF52500")]
		public RedEnvelopeAwardDisplayInfo(ReceivedRedEnvelope awardInfo)
		{
		}

		// Token: 0x0400F8EC RID: 63724
		[Token(Token = "0x400F8EC")]
		[FieldOffset(Offset = "0x10")]
		public string PlayerName;

		// Token: 0x0400F8ED RID: 63725
		[Token(Token = "0x400F8ED")]
		[FieldOffset(Offset = "0x18")]
		public uint ItemID;

		// Token: 0x0400F8EE RID: 63726
		[Token(Token = "0x400F8EE")]
		[FieldOffset(Offset = "0x1C")]
		public RedEnvelopeAwardType AwardType;

		// Token: 0x0400F8EF RID: 63727
		[Token(Token = "0x400F8EF")]
		[FieldOffset(Offset = "0x20")]
		public uint AwardNum;

		// Token: 0x0400F8F0 RID: 63728
		[Token(Token = "0x400F8F0")]
		[FieldOffset(Offset = "0x24")]
		public uint AwardTime;

		// Token: 0x0400F8F1 RID: 63729
		[Token(Token = "0x400F8F1")]
		[FieldOffset(Offset = "0x28")]
		public bool IsLucky;
	}
}
