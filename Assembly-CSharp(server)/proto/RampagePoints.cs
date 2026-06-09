using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200095B RID: 2395
	[Token(Token = "0x200095B")]
	[ProtoContract]
	public class RampagePoints
	{
		// Token: 0x06002669 RID: 9833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002669")]
		[Address(RVA = "0x249F7D0", Offset = "0x249F7D0", VA = "0x7BBCC9F7D0")]
		public RampagePoints()
		{
		}

		// Token: 0x04002BD9 RID: 11225
		[Token(Token = "0x4002BD9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11193FC", Offset = "0x11193FC")]
		public ELimitedEvent.RampageFaction faction;

		// Token: 0x04002BDA RID: 11226
		[Token(Token = "0x4002BDA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119410", Offset = "0x1119410")]
		public ulong points;
	}
}
