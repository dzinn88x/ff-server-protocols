using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007FD RID: 2045
	[Token(Token = "0x20007FD")]
	[ProtoContract]
	public class CSRandomClanListReq
	{
		// Token: 0x0600250C RID: 9484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250C")]
		[Address(RVA = "0x21B7010", Offset = "0x21B7010", VA = "0x7BBC9B7010")]
		public CSRandomClanListReq()
		{
		}

		// Token: 0x040026DD RID: 9949
		[Token(Token = "0x40026DD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110874", Offset = "0x1110874")]
		public EClan.ClanMainType clan_list_type;

		// Token: 0x040026DE RID: 9950
		[Token(Token = "0x40026DE")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110888", Offset = "0x1110888")]
		public uint area_id;

		// Token: 0x040026DF RID: 9951
		[Token(Token = "0x40026DF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111089C", Offset = "0x111089C")]
		public uint play_style;
	}
}
