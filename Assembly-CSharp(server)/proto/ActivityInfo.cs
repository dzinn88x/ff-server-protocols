using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007CC RID: 1996
	[Token(Token = "0x20007CC")]
	[ProtoContract]
	public class ActivityInfo
	{
		// Token: 0x060024DB RID: 9435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DB")]
		[Address(RVA = "0x21AEDAC", Offset = "0x21AEDAC", VA = "0x7BBC9AEDAC")]
		public ActivityInfo()
		{
		}

		// Token: 0x04002621 RID: 9761
		[Token(Token = "0x4002621")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F244", Offset = "0x110F244")]
		public uint id;

		// Token: 0x04002622 RID: 9762
		[Token(Token = "0x4002622")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F258", Offset = "0x110F258")]
		public uint data;

		// Token: 0x04002623 RID: 9763
		[Token(Token = "0x4002623")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F26C", Offset = "0x110F26C")]
		public EActivity.State state;
	}
}
