using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A49 RID: 2633
	[Token(Token = "0x2000A49")]
	[ProtoContract]
	public class ClanTagDesc
	{
		// Token: 0x06002753 RID: 10067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002753")]
		[Address(RVA = "0x21B8B24", Offset = "0x21B8B24", VA = "0x7BBC9B8B24")]
		public ClanTagDesc()
		{
		}

		// Token: 0x04002FF7 RID: 12279
		[Token(Token = "0x4002FF7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112060C", Offset = "0x112060C")]
		public uint play_style;
	}
}
