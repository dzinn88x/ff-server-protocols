using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A3C RID: 2620
	[Token(Token = "0x2000A3C")]
	[ProtoContract]
	public class ClanRenameDesc
	{
		// Token: 0x06002746 RID: 10054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002746")]
		[Address(RVA = "0x21B8B04", Offset = "0x21B8B04", VA = "0x7BBC9B8B04")]
		public ClanRenameDesc()
		{
		}

		// Token: 0x04002FC9 RID: 12233
		[Token(Token = "0x4002FC9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11200D0", Offset = "0x11200D0")]
		public uint diamond_cost;
	}
}
