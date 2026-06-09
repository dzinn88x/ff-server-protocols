using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000812 RID: 2066
	[Token(Token = "0x2000812")]
	[ProtoContract]
	public class LoginProfileRes
	{
		// Token: 0x06002521 RID: 9505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002521")]
		[Address(RVA = "0x21BBE20", Offset = "0x21BBE20", VA = "0x7BBC9BBE20")]
		public LoginProfileRes()
		{
		}

		// Token: 0x0400270D RID: 9997
		[Token(Token = "0x400270D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110CAC", Offset = "0x1110CAC")]
		public CSGetProfileListRes profile_res;

		// Token: 0x0400270E RID: 9998
		[Token(Token = "0x400270E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110CC0", Offset = "0x1110CC0")]
		public CSGetSkillListRes skill_res;

		// Token: 0x0400270F RID: 9999
		[Token(Token = "0x400270F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110CD4", Offset = "0x1110CD4")]
		public PetInfo pet_info;
	}
}
