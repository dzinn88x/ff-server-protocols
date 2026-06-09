using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A21 RID: 2593
	[Token(Token = "0x2000A21")]
	[ProtoContract]
	public class BillboardDesc
	{
		// Token: 0x0600272B RID: 10027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272B")]
		[Address(RVA = "0x21AFA08", Offset = "0x21AFA08", VA = "0x7BBC9AFA08")]
		public BillboardDesc()
		{
		}

		// Token: 0x04002F44 RID: 12100
		[Token(Token = "0x4002F44")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EF64", Offset = "0x111EF64")]
		public uint id;

		// Token: 0x04002F45 RID: 12101
		[Token(Token = "0x4002F45")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EF78", Offset = "0x111EF78")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111EF78", Offset = "0x111EF78")]
		public string desc;

		// Token: 0x04002F46 RID: 12102
		[Token(Token = "0x4002F46")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EFC8", Offset = "0x111EFC8")]
		public uint enabled;
	}
}
