using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008E2 RID: 2274
	[Token(Token = "0x20008E2")]
	[ProtoContract]
	public class CSGetLiveTableNamesReq
	{
		// Token: 0x060025F0 RID: 9712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F0")]
		[Address(RVA = "0x21B4734", Offset = "0x21B4734", VA = "0x7BBC9B4734")]
		public CSGetLiveTableNamesReq()
		{
		}

		// Token: 0x04002A87 RID: 10887
		[Token(Token = "0x4002A87")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11172C8", Offset = "0x11172C8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11172C8", Offset = "0x11172C8")]
		public string language;
	}
}
