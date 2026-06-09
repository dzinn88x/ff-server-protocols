using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007FB RID: 2043
	[Token(Token = "0x20007FB")]
	[ProtoContract]
	public class CSDrawClanLuckyBagReq
	{
		// Token: 0x0600250A RID: 9482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250A")]
		[Address(RVA = "0x21B0FDC", Offset = "0x21B0FDC", VA = "0x7BBC9B0FDC")]
		public CSDrawClanLuckyBagReq()
		{
		}

		// Token: 0x040026D8 RID: 9944
		[Token(Token = "0x40026D8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110810", Offset = "0x1110810")]
		public ulong clan_id;

		// Token: 0x040026D9 RID: 9945
		[Token(Token = "0x40026D9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110824", Offset = "0x1110824")]
		public ulong bag_id;
	}
}
