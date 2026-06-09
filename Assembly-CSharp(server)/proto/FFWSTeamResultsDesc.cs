using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B49 RID: 2889
	[Token(Token = "0x2000B49")]
	[ProtoContract]
	public class FFWSTeamResultsDesc
	{
		// Token: 0x06002851 RID: 10321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002851")]
		[Address(RVA = "0x21BA2C4", Offset = "0x21BA2C4", VA = "0x7BBC9BA2C4")]
		public FFWSTeamResultsDesc()
		{
		}

		// Token: 0x040036E8 RID: 14056
		[Token(Token = "0x40036E8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DA14", Offset = "0x112DA14")]
		public uint team_id;

		// Token: 0x040036E9 RID: 14057
		[Token(Token = "0x40036E9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DA28", Offset = "0x112DA28")]
		public uint[] scores;
	}
}
