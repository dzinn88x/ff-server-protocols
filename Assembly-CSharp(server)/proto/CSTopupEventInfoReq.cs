using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000789 RID: 1929
	[Token(Token = "0x2000789")]
	[ProtoContract]
	public class CSTopupEventInfoReq
	{
		// Token: 0x06002498 RID: 9368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002498")]
		[Address(RVA = "0x21B7A94", Offset = "0x21B7A94", VA = "0x7BBC9B7A94")]
		public CSTopupEventInfoReq()
		{
		}

		// Token: 0x04002587 RID: 9607
		[Token(Token = "0x4002587")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E13C", Offset = "0x110E13C")]
		public uint event_type;
	}
}
