using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000581 RID: 1409
	[Token(Token = "0x2000581")]
	[ProtoContract]
	public class AbTestChoices
	{
		// Token: 0x06002340 RID: 9024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002340")]
		[Address(RVA = "0x21AE31C", Offset = "0x21AE31C", VA = "0x7BBC9AE31C")]
		public AbTestChoices()
		{
		}

		// Token: 0x04001B87 RID: 7047
		[Token(Token = "0x4001B87")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1104F4C", Offset = "0x1104F4C")]
		public List<AbTestChoice> choices;
	}
}
