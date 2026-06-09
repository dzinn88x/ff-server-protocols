using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009AD RID: 2477
	[Token(Token = "0x20009AD")]
	[ProtoContract]
	public class CSGetBigEventTokenTipsDescReq
	{
		// Token: 0x060026BB RID: 9915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BB")]
		[Address(RVA = "0x21B25C0", Offset = "0x21B25C0", VA = "0x7BBC9B25C0")]
		public CSGetBigEventTokenTipsDescReq()
		{
		}

		// Token: 0x04002C9D RID: 11421
		[Token(Token = "0x4002C9D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A590", Offset = "0x111A590")]
		public ELimitedEvent.EventID event_id;
	}
}
