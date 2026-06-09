using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000819 RID: 2073
	[Token(Token = "0x2000819")]
	[ProtoContract]
	public class CSGetDispatchInfoReq
	{
		// Token: 0x06002528 RID: 9512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002528")]
		[Address(RVA = "0x21B30C8", Offset = "0x21B30C8", VA = "0x7BBC9B30C8")]
		public CSGetDispatchInfoReq()
		{
		}

		// Token: 0x0400271C RID: 10012
		[Token(Token = "0x400271C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110DD8", Offset = "0x1110DD8")]
		public uint activity_id;
	}
}
