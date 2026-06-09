using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000929 RID: 2345
	[Token(Token = "0x2000929")]
	[ProtoContract]
	public class BoxState
	{
		// Token: 0x06002637 RID: 9783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002637")]
		[Address(RVA = "0x21AFEF8", Offset = "0x21AFEF8", VA = "0x7BBC9AFEF8")]
		public BoxState()
		{
		}

		// Token: 0x04002B74 RID: 11124
		[Token(Token = "0x4002B74")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118A74", Offset = "0x1118A74")]
		public uint group_id;

		// Token: 0x04002B75 RID: 11125
		[Token(Token = "0x4002B75")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118A88", Offset = "0x1118A88")]
		public uint box_id;

		// Token: 0x04002B76 RID: 11126
		[Token(Token = "0x4002B76")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118A9C", Offset = "0x1118A9C")]
		public uint state;
	}
}
