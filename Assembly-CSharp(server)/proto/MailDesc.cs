using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A22 RID: 2594
	[Token(Token = "0x2000A22")]
	[ProtoContract]
	public class MailDesc
	{
		// Token: 0x0600272C RID: 10028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272C")]
		[Address(RVA = "0x21BC220", Offset = "0x21BC220", VA = "0x7BBC9BC220")]
		public MailDesc()
		{
		}

		// Token: 0x04002F47 RID: 12103
		[Token(Token = "0x4002F47")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EFDC", Offset = "0x111EFDC")]
		public uint max_mail_num;

		// Token: 0x04002F48 RID: 12104
		[Token(Token = "0x4002F48")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EFF0", Offset = "0x111EFF0")]
		public uint expire_days;
	}
}
