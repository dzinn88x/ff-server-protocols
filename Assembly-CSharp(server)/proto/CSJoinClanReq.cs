using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007DD RID: 2013
	[Token(Token = "0x20007DD")]
	[ProtoContract]
	public class CSJoinClanReq
	{
		// Token: 0x060024EC RID: 9452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EC")]
		[Address(RVA = "0x21B65D0", Offset = "0x21B65D0", VA = "0x7BBC9B65D0")]
		public CSJoinClanReq()
		{
		}

		// Token: 0x0400266F RID: 9839
		[Token(Token = "0x400266F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FD0C", Offset = "0x110FD0C")]
		public ulong clan_id;
	}
}
