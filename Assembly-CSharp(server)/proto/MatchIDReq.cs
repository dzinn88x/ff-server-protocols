using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005E2 RID: 1506
	[Token(Token = "0x20005E2")]
	[ProtoContract]
	public class MatchIDReq
	{
		// Token: 0x06002362 RID: 9058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002362")]
		[Address(RVA = "0x21BC504", Offset = "0x21BC504", VA = "0x7BBC9BC504")]
		public MatchIDReq()
		{
		}

		// Token: 0x04001DCC RID: 7628
		[Token(Token = "0x4001DCC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11055F0", Offset = "0x11055F0")]
		public ulong match_id;
	}
}
