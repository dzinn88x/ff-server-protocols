using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007E0 RID: 2016
	[Token(Token = "0x20007E0")]
	[ProtoContract]
	public class CSInviteToClanReq
	{
		// Token: 0x060024EF RID: 9455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EF")]
		[Address(RVA = "0x21B65B8", Offset = "0x21B65B8", VA = "0x7BBC9B65B8")]
		public CSInviteToClanReq()
		{
		}

		// Token: 0x04002673 RID: 9843
		[Token(Token = "0x4002673")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FD5C", Offset = "0x110FD5C")]
		public ulong invitee_id;
	}
}
