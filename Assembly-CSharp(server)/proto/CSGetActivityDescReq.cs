using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007BF RID: 1983
	[Token(Token = "0x20007BF")]
	[ProtoContract]
	public class CSGetActivityDescReq
	{
		// Token: 0x060024CE RID: 9422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CE")]
		[Address(RVA = "0x21B1970", Offset = "0x21B1970", VA = "0x7BBC9B1970")]
		public CSGetActivityDescReq()
		{
		}

		// Token: 0x04002605 RID: 9733
		[Token(Token = "0x4002605")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110EE5C", Offset = "0x110EE5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EE5C", Offset = "0x110EE5C")]
		public string language;

		// Token: 0x04002606 RID: 9734
		[Token(Token = "0x4002606")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EEAC", Offset = "0x110EEAC")]
		public uint platform;
	}
}
