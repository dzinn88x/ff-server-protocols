using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008F2 RID: 2290
	[Token(Token = "0x20008F2")]
	[ProtoContract]
	public class CSTeamIDRes
	{
		// Token: 0x06002600 RID: 9728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002600")]
		[Address(RVA = "0x21B7830", Offset = "0x21B7830", VA = "0x7BBC9B7830")]
		public CSTeamIDRes()
		{
		}

		// Token: 0x04002A9E RID: 10910
		[Token(Token = "0x4002A9E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117534", Offset = "0x1117534")]
		public ulong team_id;
	}
}
