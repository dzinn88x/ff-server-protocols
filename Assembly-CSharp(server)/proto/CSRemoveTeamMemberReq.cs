using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000904 RID: 2308
	[Token(Token = "0x2000904")]
	[ProtoContract]
	public class CSRemoveTeamMemberReq
	{
		// Token: 0x06002612 RID: 9746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002612")]
		[Address(RVA = "0x21B7430", Offset = "0x21B7430", VA = "0x7BBC9B7430")]
		public CSRemoveTeamMemberReq()
		{
		}

		// Token: 0x04002AD2 RID: 10962
		[Token(Token = "0x4002AD2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117B9C", Offset = "0x1117B9C")]
		public ulong team_id;

		// Token: 0x04002AD3 RID: 10963
		[Token(Token = "0x4002AD3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117BB0", Offset = "0x1117BB0")]
		public ulong removee_id;
	}
}
