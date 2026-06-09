using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008F4 RID: 2292
	[Token(Token = "0x20008F4")]
	[ProtoContract]
	public class TeamApplicantRes
	{
		// Token: 0x06002602 RID: 9730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002602")]
		[Address(RVA = "0x24A0D08", Offset = "0x24A0D08", VA = "0x7BBCCA0D08")]
		public TeamApplicantRes()
		{
		}

		// Token: 0x04002AA0 RID: 10912
		[Token(Token = "0x4002AA0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111755C", Offset = "0x111755C")]
		public ulong applicant_id;

		// Token: 0x04002AA1 RID: 10913
		[Token(Token = "0x4002AA1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117570", Offset = "0x1117570")]
		public ulong team_id;

		// Token: 0x04002AA2 RID: 10914
		[Token(Token = "0x4002AA2")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117584", Offset = "0x1117584")]
		public ulong create_at;
	}
}
