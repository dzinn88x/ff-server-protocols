using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000911 RID: 2321
	[Token(Token = "0x2000911")]
	[ProtoContract]
	public class CSInitTeamChampionshipInfoReq
	{
		// Token: 0x0600261F RID: 9759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261F")]
		[Address(RVA = "0x21B65A0", Offset = "0x21B65A0", VA = "0x7BBC9B65A0")]
		public CSInitTeamChampionshipInfoReq()
		{
		}

		// Token: 0x04002B11 RID: 11025
		[Token(Token = "0x4002B11")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11181B4", Offset = "0x11181B4")]
		public uint championship_type;
	}
}
