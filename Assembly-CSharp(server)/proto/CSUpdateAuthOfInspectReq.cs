using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200083A RID: 2106
	[Token(Token = "0x200083A")]
	[ProtoContract]
	public class CSUpdateAuthOfInspectReq
	{
		// Token: 0x0600254F RID: 9551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254F")]
		[Address(RVA = "0x21B7BDC", Offset = "0x21B7BDC", VA = "0x7BBC9B7BDC")]
		public CSUpdateAuthOfInspectReq()
		{
		}

		// Token: 0x04002769 RID: 10089
		[Token(Token = "0x4002769")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111544", Offset = "0x1111544")]
		public bool is_visible;

		// Token: 0x0400276A RID: 10090
		[Token(Token = "0x400276A")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111558", Offset = "0x1111558")]
		public EFriend.RelationType relation_type;
	}
}
