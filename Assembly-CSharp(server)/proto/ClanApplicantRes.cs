using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007EF RID: 2031
	[Token(Token = "0x20007EF")]
	[ProtoContract]
	public class ClanApplicantRes
	{
		// Token: 0x060024FE RID: 9470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FE")]
		[Address(RVA = "0x21B859C", Offset = "0x21B859C", VA = "0x7BBC9B859C")]
		public ClanApplicantRes()
		{
		}

		// Token: 0x0400269F RID: 9887
		[Token(Token = "0x400269F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11101BC", Offset = "0x11101BC")]
		public ulong applicant_id;

		// Token: 0x040026A0 RID: 9888
		[Token(Token = "0x40026A0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11101D0", Offset = "0x11101D0")]
		public ulong clan_id;

		// Token: 0x040026A1 RID: 9889
		[Token(Token = "0x40026A1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11101E4", Offset = "0x11101E4")]
		public ulong create_at;
	}
}
