using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000968 RID: 2408
	[Token(Token = "0x2000968")]
	[ProtoContract]
	public class HelpPlayer
	{
		// Token: 0x06002676 RID: 9846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002676")]
		[Address(RVA = "0x21BB24C", Offset = "0x21BB24C", VA = "0x7BBC9BB24C")]
		public HelpPlayer()
		{
		}

		// Token: 0x04002BF8 RID: 11256
		[Token(Token = "0x4002BF8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11196B8", Offset = "0x11196B8")]
		public ulong account_id;

		// Token: 0x04002BF9 RID: 11257
		[Token(Token = "0x4002BF9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11196CC", Offset = "0x11196CC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11196CC", Offset = "0x11196CC")]
		public string nickname;
	}
}
