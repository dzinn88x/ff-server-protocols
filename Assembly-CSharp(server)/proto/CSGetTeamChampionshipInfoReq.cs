using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000912 RID: 2322
	[Token(Token = "0x2000912")]
	[ProtoContract]
	public class CSGetTeamChampionshipInfoReq
	{
		// Token: 0x06002620 RID: 9760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002620")]
		[Address(RVA = "0x21B5F80", Offset = "0x21B5F80", VA = "0x7BBC9B5F80")]
		public CSGetTeamChampionshipInfoReq()
		{
		}

		// Token: 0x04002B12 RID: 11026
		[Token(Token = "0x4002B12")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11181C8", Offset = "0x11181C8")]
		public uint championship_type;

		// Token: 0x04002B13 RID: 11027
		[Token(Token = "0x4002B13")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11181DC", Offset = "0x11181DC")]
		public uint championship_id;
	}
}
