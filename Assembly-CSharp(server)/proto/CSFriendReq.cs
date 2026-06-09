using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000825 RID: 2085
	[Token(Token = "0x2000825")]
	[ProtoContract]
	public class CSFriendReq
	{
		// Token: 0x06002534 RID: 9524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002534")]
		[Address(RVA = "0x21B15A8", Offset = "0x21B15A8", VA = "0x7BBC9B15A8")]
		public CSFriendReq()
		{
		}

		// Token: 0x0400272F RID: 10031
		[Token(Token = "0x400272F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110F7C", Offset = "0x1110F7C")]
		public ulong adder;

		// Token: 0x04002730 RID: 10032
		[Token(Token = "0x4002730")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110F90", Offset = "0x1110F90")]
		public ulong addee;

		// Token: 0x04002731 RID: 10033
		[Token(Token = "0x4002731")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110FA4", Offset = "0x1110FA4")]
		public uint add_from;

		// Token: 0x04002732 RID: 10034
		[Token(Token = "0x4002732")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110FB8", Offset = "0x1110FB8")]
		public uint friend_tag;
	}
}
