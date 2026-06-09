using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A3E RID: 2622
	[Token(Token = "0x2000A3E")]
	[ProtoContract]
	public class ClanSignInRewardsDesc
	{
		// Token: 0x06002748 RID: 10056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002748")]
		[Address(RVA = "0x21B8B1C", Offset = "0x21B8B1C", VA = "0x7BBC9B8B1C")]
		public ClanSignInRewardsDesc()
		{
		}

		// Token: 0x04002FD1 RID: 12241
		[Token(Token = "0x4002FD1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120170", Offset = "0x1120170")]
		public uint sign_in_group;

		// Token: 0x04002FD2 RID: 12242
		[Token(Token = "0x4002FD2")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120184", Offset = "0x1120184")]
		public uint clan_level;

		// Token: 0x04002FD3 RID: 12243
		[Token(Token = "0x4002FD3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120198", Offset = "0x1120198")]
		public uint weekday;

		// Token: 0x04002FD4 RID: 12244
		[Token(Token = "0x4002FD4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11201AC", Offset = "0x11201AC")]
		public AwardDesc award;
	}
}
