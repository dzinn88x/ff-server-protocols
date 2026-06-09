using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000761 RID: 1889
	[Token(Token = "0x2000761")]
	[ProtoContract]
	public class CSVerifyAndLockCupTeamReq
	{
		// Token: 0x0600246E RID: 9326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600246E")]
		[Address(RVA = "0x21B7D54", Offset = "0x21B7D54", VA = "0x7BBC9B7D54")]
		public CSVerifyAndLockCupTeamReq()
		{
		}

		// Token: 0x04002511 RID: 9489
		[Token(Token = "0x4002511")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D4F8", Offset = "0x110D4F8")]
		public uint cup_type;

		// Token: 0x04002512 RID: 9490
		[Token(Token = "0x4002512")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D50C", Offset = "0x110D50C")]
		public uint cup_id;

		// Token: 0x04002513 RID: 9491
		[Token(Token = "0x4002513")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D520", Offset = "0x110D520")]
		public ulong[] member_account_ids;
	}
}
