using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200084B RID: 2123
	[Token(Token = "0x200084B")]
	[ProtoContract]
	public class CSGetBroadcastListRes
	{
		// Token: 0x06002560 RID: 9568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002560")]
		[Address(RVA = "0x21B29B8", Offset = "0x21B29B8", VA = "0x7BBC9B29B8")]
		public CSGetBroadcastListRes()
		{
		}

		// Token: 0x0400278A RID: 10122
		[Token(Token = "0x400278A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111188C", Offset = "0x111188C")]
		public List<BroadcastMessage> broadcast_messages;

		// Token: 0x0400278B RID: 10123
		[Token(Token = "0x400278B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11118A0", Offset = "0x11118A0")]
		public bool silence_show_switch;
	}
}
