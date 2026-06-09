using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000712 RID: 1810
	[Token(Token = "0x2000712")]
	[ProtoContract]
	public class CSSetShowRankReq
	{
		// Token: 0x0600241F RID: 9247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241F")]
		[Address(RVA = "0x21B7674", Offset = "0x21B7674", VA = "0x7BBC9B7674")]
		public CSSetShowRankReq()
		{
		}

		// Token: 0x04002429 RID: 9257
		[Token(Token = "0x4002429")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BE14", Offset = "0x110BE14")]
		public uint season_id;

		// Token: 0x0400242A RID: 9258
		[Token(Token = "0x400242A")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BE28", Offset = "0x110BE28")]
		public bool show_rank;
	}
}
