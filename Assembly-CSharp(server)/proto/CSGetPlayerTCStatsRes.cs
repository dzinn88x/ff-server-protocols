using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006F1 RID: 1777
	[Token(Token = "0x20006F1")]
	[ProtoContract]
	public class CSGetPlayerTCStatsRes
	{
		// Token: 0x060023FF RID: 9215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FF")]
		[Address(RVA = "0x21B562C", Offset = "0x21B562C", VA = "0x7BBC9B562C")]
		public CSGetPlayerTCStatsRes()
		{
		}

		// Token: 0x040022B6 RID: 8886
		[Token(Token = "0x40022B6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109DF8", Offset = "0x1109DF8")]
		public AccountInfoWithTCStats cs_stats;
	}
}
