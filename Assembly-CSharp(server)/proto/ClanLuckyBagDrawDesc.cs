using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A46 RID: 2630
	[Token(Token = "0x2000A46")]
	[ProtoContract]
	public class ClanLuckyBagDrawDesc
	{
		// Token: 0x06002750 RID: 10064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002750")]
		[Address(RVA = "0x21B8868", Offset = "0x21B8868", VA = "0x7BBC9B8868")]
		public ClanLuckyBagDrawDesc()
		{
		}

		// Token: 0x04002FF2 RID: 12274
		[Token(Token = "0x4002FF2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11205A8", Offset = "0x11205A8")]
		public uint guild_token_num;

		// Token: 0x04002FF3 RID: 12275
		[Token(Token = "0x4002FF3")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11205BC", Offset = "0x11205BC")]
		public uint weight;
	}
}
