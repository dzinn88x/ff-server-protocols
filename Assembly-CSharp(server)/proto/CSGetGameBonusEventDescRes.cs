using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006F6 RID: 1782
	[Token(Token = "0x20006F6")]
	[ProtoContract]
	public class CSGetGameBonusEventDescRes
	{
		// Token: 0x06002404 RID: 9220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002404")]
		[Address(RVA = "0x21B3ED8", Offset = "0x21B3ED8", VA = "0x7BBC9B3ED8")]
		public CSGetGameBonusEventDescRes()
		{
		}

		// Token: 0x040022C3 RID: 8899
		[Token(Token = "0x40022C3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109EFC", Offset = "0x1109EFC")]
		public List<GameBonusEventDesc> game_bonus_events;
	}
}
