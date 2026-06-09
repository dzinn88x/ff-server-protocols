using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007E4 RID: 2020
	[Token(Token = "0x20007E4")]
	[ProtoContract]
	public class CSRemoveClanMemberReq
	{
		// Token: 0x060024F3 RID: 9459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F3")]
		[Address(RVA = "0x21B73B4", Offset = "0x21B73B4", VA = "0x7BBC9B73B4")]
		public CSRemoveClanMemberReq()
		{
		}

		// Token: 0x04002679 RID: 9849
		[Token(Token = "0x4002679")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FDD4", Offset = "0x110FDD4")]
		public ulong clan_id;

		// Token: 0x0400267A RID: 9850
		[Token(Token = "0x400267A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FDE8", Offset = "0x110FDE8")]
		public ulong removee_id;
	}
}
