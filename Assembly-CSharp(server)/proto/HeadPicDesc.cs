using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009D1 RID: 2513
	[Token(Token = "0x20009D1")]
	[ProtoContract]
	public class HeadPicDesc
	{
		// Token: 0x060026DB RID: 9947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DB")]
		[Address(RVA = "0x21BB244", Offset = "0x21BB244", VA = "0x7BBC9BB244")]
		public HeadPicDesc()
		{
		}

		// Token: 0x04002D7F RID: 11647
		[Token(Token = "0x4002D7F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B648", Offset = "0x111B648")]
		public uint Item_id;

		// Token: 0x04002D80 RID: 11648
		[Token(Token = "0x4002D80")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B65C", Offset = "0x111B65C")]
		public uint avatar_id;
	}
}
