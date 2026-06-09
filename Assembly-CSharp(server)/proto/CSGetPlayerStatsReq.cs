using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006EE RID: 1774
	[Token(Token = "0x20006EE")]
	[ProtoContract]
	public class CSGetPlayerStatsReq
	{
		// Token: 0x060023FC RID: 9212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FC")]
		[Address(RVA = "0x21B5614", Offset = "0x21B5614", VA = "0x7BBC9B5614")]
		public CSGetPlayerStatsReq()
		{
		}

		// Token: 0x040022AD RID: 8877
		[Token(Token = "0x40022AD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109D44", Offset = "0x1109D44")]
		public ulong account_id;

		// Token: 0x040022AE RID: 8878
		[Token(Token = "0x40022AE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109D58", Offset = "0x1109D58")]
		public uint match_mode;
	}
}
