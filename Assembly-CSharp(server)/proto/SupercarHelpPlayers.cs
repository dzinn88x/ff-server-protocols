using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005F8 RID: 1528
	[Token(Token = "0x20005F8")]
	[ProtoContract]
	public class SupercarHelpPlayers
	{
		// Token: 0x06002378 RID: 9080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002378")]
		[Address(RVA = "0x24A0B6C", Offset = "0x24A0B6C", VA = "0x7BBCCA0B6C")]
		public SupercarHelpPlayers()
		{
		}

		// Token: 0x04001E82 RID: 7810
		[Token(Token = "0x4001E82")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106DB0", Offset = "0x1106DB0")]
		public List<SupercarHelpPlayer> players;
	}
}
