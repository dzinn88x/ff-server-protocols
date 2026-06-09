using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200075F RID: 1887
	[Token(Token = "0x200075F")]
	[ProtoContract]
	public class CupTeamMemberWithAccountInfo
	{
		// Token: 0x0600246C RID: 9324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600246C")]
		[Address(RVA = "0x21B93BC", Offset = "0x21B93BC", VA = "0x7BBC9B93BC")]
		public CupTeamMemberWithAccountInfo()
		{
		}

		// Token: 0x04002501 RID: 9473
		[Token(Token = "0x4002501")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D318", Offset = "0x110D318")]
		public AccountInfoBasic basic_info;

		// Token: 0x04002502 RID: 9474
		[Token(Token = "0x4002502")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D32C", Offset = "0x110D32C")]
		public CSAccountCupInfoRes cup_info;
	}
}
