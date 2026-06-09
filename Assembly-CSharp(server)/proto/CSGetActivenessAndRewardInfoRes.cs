using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200092E RID: 2350
	[Token(Token = "0x200092E")]
	[ProtoContract]
	public class CSGetActivenessAndRewardInfoRes
	{
		// Token: 0x0600263C RID: 9788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263C")]
		[Address(RVA = "0x21B18E4", Offset = "0x21B18E4", VA = "0x7BBC9B18E4")]
		public CSGetActivenessAndRewardInfoRes()
		{
		}

		// Token: 0x04002B7E RID: 11134
		[Token(Token = "0x4002B7E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118B3C", Offset = "0x1118B3C")]
		public ActivenessInfo activeness_info;

		// Token: 0x04002B7F RID: 11135
		[Token(Token = "0x4002B7F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118B50", Offset = "0x1118B50")]
		public ActivenessRewardInfo activeness_reward_info;
	}
}
