using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A23 RID: 2595
	[Token(Token = "0x2000A23")]
	[ProtoContract]
	public class MailContentDesc
	{
		// Token: 0x0600272D RID: 10029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272D")]
		[Address(RVA = "0x21BC1C4", Offset = "0x21BC1C4", VA = "0x7BBC9BC1C4")]
		public MailContentDesc()
		{
		}

		// Token: 0x04002F49 RID: 12105
		[Token(Token = "0x4002F49")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F004", Offset = "0x111F004")]
		public uint type;

		// Token: 0x04002F4A RID: 12106
		[Token(Token = "0x4002F4A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F018", Offset = "0x111F018")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F018", Offset = "0x111F018")]
		public string title;

		// Token: 0x04002F4B RID: 12107
		[Token(Token = "0x4002F4B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F068", Offset = "0x111F068")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F068", Offset = "0x111F068")]
		public string content;
	}
}
