using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200085F RID: 2143
	[Token(Token = "0x200085F")]
	[ProtoContract]
	public class CSExchangeGachaExtraRewardRes
	{
		// Token: 0x0600256D RID: 9581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256D")]
		[Address(RVA = "0x21B11FC", Offset = "0x21B11FC", VA = "0x7BBC9B11FC")]
		public CSExchangeGachaExtraRewardRes()
		{
		}

		// Token: 0x04002818 RID: 10264
		[Token(Token = "0x4002818")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11126B0", Offset = "0x11126B0")]
		public uint[] exchanged_reward_list;

		// Token: 0x04002819 RID: 10265
		[Token(Token = "0x4002819")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11126EC", Offset = "0x11126EC")]
		public List<ExchangedAward> extra_rewards;
	}
}
