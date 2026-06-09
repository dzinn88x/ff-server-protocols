using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B4D RID: 2893
	[Token(Token = "0x2000B4D")]
	[ProtoContract]
	public class CupTierDesc
	{
		// Token: 0x06002855 RID: 10325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002855")]
		[Address(RVA = "0x21B93C4", Offset = "0x21B93C4", VA = "0x7BBC9B93C4")]
		public CupTierDesc()
		{
		}

		// Token: 0x040036FB RID: 14075
		[Token(Token = "0x40036FB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DE10", Offset = "0x112DE10")]
		public uint cup_type;

		// Token: 0x040036FC RID: 14076
		[Token(Token = "0x40036FC")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DE24", Offset = "0x112DE24")]
		public uint tier;

		// Token: 0x040036FD RID: 14077
		[Token(Token = "0x40036FD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DE38", Offset = "0x112DE38")]
		public uint tier_lower_bound;

		// Token: 0x040036FE RID: 14078
		[Token(Token = "0x40036FE")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DE4C", Offset = "0x112DE4C")]
		public bool is_pure_tier;
	}
}
