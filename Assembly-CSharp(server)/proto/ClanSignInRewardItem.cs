using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007F0 RID: 2032
	[Token(Token = "0x20007F0")]
	[ProtoContract]
	public class ClanSignInRewardItem
	{
		// Token: 0x060024FF RID: 9471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FF")]
		[Address(RVA = "0x21B8B14", Offset = "0x21B8B14", VA = "0x7BBC9B8B14")]
		public ClanSignInRewardItem()
		{
		}

		// Token: 0x040026A2 RID: 9890
		[Token(Token = "0x40026A2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11101F8", Offset = "0x11101F8")]
		public ClanSignInRewardsDesc desc;

		// Token: 0x040026A3 RID: 9891
		[Token(Token = "0x40026A3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111020C", Offset = "0x111020C")]
		public uint status;
	}
}
