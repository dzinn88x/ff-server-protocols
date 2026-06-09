using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200092A RID: 2346
	[Token(Token = "0x200092A")]
	[ProtoContract]
	public class BoxInfo
	{
		// Token: 0x06002638 RID: 9784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002638")]
		[Address(RVA = "0x21AFEF0", Offset = "0x21AFEF0", VA = "0x7BBC9AFEF0")]
		public BoxInfo()
		{
		}

		// Token: 0x04002B77 RID: 11127
		[Token(Token = "0x4002B77")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118AB0", Offset = "0x1118AB0")]
		public uint group_id;

		// Token: 0x04002B78 RID: 11128
		[Token(Token = "0x4002B78")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118AC4", Offset = "0x1118AC4")]
		public uint box_id;
	}
}
