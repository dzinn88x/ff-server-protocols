using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000667 RID: 1639
	[Token(Token = "0x2000667")]
	[ProtoContract]
	public class ChoosedEmotes
	{
		// Token: 0x060023BA RID: 9146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BA")]
		[Address(RVA = "0x21B8520", Offset = "0x21B8520", VA = "0x7BBC9B8520")]
		public ChoosedEmotes()
		{
		}

		// Token: 0x04002059 RID: 8281
		[Token(Token = "0x4002059")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110873C", Offset = "0x110873C")]
		public List<ChoosedEmote> emotes;
	}
}
