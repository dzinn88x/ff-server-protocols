using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A09 RID: 2569
	[Token(Token = "0x2000A09")]
	[ProtoContract]
	public class GameModeNameList
	{
		// Token: 0x06002713 RID: 10003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002713")]
		[Address(RVA = "0x21BA78C", Offset = "0x21BA78C", VA = "0x7BBC9BA78C")]
		public GameModeNameList()
		{
		}

		// Token: 0x04002EF3 RID: 12019
		[Token(Token = "0x4002EF3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E5B4", Offset = "0x111E5B4")]
		public List<GameModeNameDesc> game_mode_names;
	}
}
