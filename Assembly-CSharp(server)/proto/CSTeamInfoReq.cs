using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008F9 RID: 2297
	[Token(Token = "0x20008F9")]
	[ProtoContract]
	public class CSTeamInfoReq
	{
		// Token: 0x06002607 RID: 9735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002607")]
		[Address(RVA = "0x21B78AC", Offset = "0x21B78AC", VA = "0x7BBC9B78AC")]
		public CSTeamInfoReq()
		{
		}

		// Token: 0x04002AB9 RID: 10937
		[Token(Token = "0x4002AB9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117868", Offset = "0x1117868")]
		public ulong team_id;

		// Token: 0x04002ABA RID: 10938
		[Token(Token = "0x4002ABA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111787C", Offset = "0x111787C")]
		public bool ignore_region;
	}
}
