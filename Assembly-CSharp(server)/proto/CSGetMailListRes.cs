using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007D4 RID: 2004
	[Token(Token = "0x20007D4")]
	[ProtoContract]
	public class CSGetMailListRes
	{
		// Token: 0x060024E3 RID: 9443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E3")]
		[Address(RVA = "0x21B4958", Offset = "0x21B4958", VA = "0x7BBC9B4958")]
		public CSGetMailListRes()
		{
		}

		// Token: 0x0400265C RID: 9820
		[Token(Token = "0x400265C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FAA0", Offset = "0x110FAA0")]
		public List<MailInfo> mails;
	}
}
