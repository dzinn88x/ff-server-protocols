using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000640 RID: 1600
	[Token(Token = "0x2000640")]
	[ProtoContract]
	public class MatchPlayer
	{
		// Token: 0x060023AA RID: 9130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AA")]
		[Address(RVA = "0x21BC5D0", Offset = "0x21BC5D0", VA = "0x7BBC9BC5D0")]
		public MatchPlayer()
		{
		}

		// Token: 0x04001FAD RID: 8109
		[Token(Token = "0x4001FAD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11082F0", Offset = "0x11082F0")]
		public ulong account_id;

		// Token: 0x04001FAE RID: 8110
		[Token(Token = "0x4001FAE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108304", Offset = "0x1108304")]
		public int ranking_points;

		// Token: 0x04001FAF RID: 8111
		[Token(Token = "0x4001FAF")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108318", Offset = "0x1108318")]
		public uint dead_order;
	}
}
