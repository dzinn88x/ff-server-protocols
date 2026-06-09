using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008FF RID: 2303
	[Token(Token = "0x20008FF")]
	[ProtoContract]
	public class CSApproveJoinApplicationReq
	{
		// Token: 0x0600260D RID: 9741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260D")]
		[Address(RVA = "0x21B0428", Offset = "0x21B0428", VA = "0x7BBC9B0428")]
		public CSApproveJoinApplicationReq()
		{
		}

		// Token: 0x04002AC9 RID: 10953
		[Token(Token = "0x4002AC9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117A98", Offset = "0x1117A98")]
		public ulong applicant_id;

		// Token: 0x04002ACA RID: 10954
		[Token(Token = "0x4002ACA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117AAC", Offset = "0x1117AAC")]
		public ulong team_id;
	}
}
