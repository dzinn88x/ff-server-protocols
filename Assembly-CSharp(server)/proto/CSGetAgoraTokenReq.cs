using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200087A RID: 2170
	[Token(Token = "0x200087A")]
	[ProtoContract]
	public class CSGetAgoraTokenReq
	{
		// Token: 0x06002588 RID: 9608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002588")]
		[Address(RVA = "0x21B1CB0", Offset = "0x21B1CB0", VA = "0x7BBC9B1CB0")]
		public CSGetAgoraTokenReq()
		{
		}

		// Token: 0x0400289D RID: 10397
		[Token(Token = "0x400289D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11134FC", Offset = "0x11134FC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11134FC", Offset = "0x11134FC")]
		public string channel_name;
	}
}
