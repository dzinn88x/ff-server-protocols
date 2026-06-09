using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B2F RID: 2863
	[Token(Token = "0x2000B2F")]
	[ProtoContract]
	public class ModeRecord
	{
		// Token: 0x06002837 RID: 10295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002837")]
		[Address(RVA = "0x21BCBF4", Offset = "0x21BCBF4", VA = "0x7BBC9BCBF4")]
		public ModeRecord()
		{
		}

		// Token: 0x04003655 RID: 13909
		[Token(Token = "0x4003655")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C808", Offset = "0x112C808")]
		public uint match_mode;

		// Token: 0x04003656 RID: 13910
		[Token(Token = "0x4003656")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C81C", Offset = "0x112C81C")]
		public uint game_mode;
	}
}
