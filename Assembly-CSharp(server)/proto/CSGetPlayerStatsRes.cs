using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006EF RID: 1775
	[Token(Token = "0x20006EF")]
	[ProtoContract]
	public class CSGetPlayerStatsRes
	{
		// Token: 0x060023FD RID: 9213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FD")]
		[Address(RVA = "0x21B561C", Offset = "0x21B561C", VA = "0x7BBC9B561C")]
		public CSGetPlayerStatsRes()
		{
		}

		// Token: 0x040022AF RID: 8879
		[Token(Token = "0x40022AF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109D6C", Offset = "0x1109D6C")]
		public AccountInfoWithStatsToClient solo_stats;

		// Token: 0x040022B0 RID: 8880
		[Token(Token = "0x40022B0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109D80", Offset = "0x1109D80")]
		public AccountInfoWithStatsToClient duo_stats;

		// Token: 0x040022B1 RID: 8881
		[Token(Token = "0x40022B1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109D94", Offset = "0x1109D94")]
		public AccountInfoWithStatsToClient quad_stats;
	}
}
