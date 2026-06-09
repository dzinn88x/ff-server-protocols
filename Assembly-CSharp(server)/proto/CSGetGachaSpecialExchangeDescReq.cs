using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000868 RID: 2152
	[Token(Token = "0x2000868")]
	[ProtoContract]
	public class CSGetGachaSpecialExchangeDescReq
	{
		// Token: 0x06002576 RID: 9590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002576")]
		[Address(RVA = "0x21B3E08", Offset = "0x21B3E08", VA = "0x7BBC9B3E08")]
		public CSGetGachaSpecialExchangeDescReq()
		{
		}

		// Token: 0x04002829 RID: 10281
		[Token(Token = "0x4002829")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11128A4", Offset = "0x11128A4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11128A4", Offset = "0x11128A4")]
		public string language;
	}
}
