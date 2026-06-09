using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200073B RID: 1851
	[Token(Token = "0x200073B")]
	[ProtoContract]
	public class CSGetAllCupConfigRes
	{
		// Token: 0x06002448 RID: 9288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002448")]
		[Address(RVA = "0x21B1DC4", Offset = "0x21B1DC4", VA = "0x7BBC9B1DC4")]
		public CSGetAllCupConfigRes()
		{
		}

		// Token: 0x0400249E RID: 9374
		[Token(Token = "0x400249E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C990", Offset = "0x110C990")]
		public List<CSGetCupConfigRes> settings;

		// Token: 0x0400249F RID: 9375
		[Token(Token = "0x400249F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C9A4", Offset = "0x110C9A4")]
		public CupTeamDesc team_setting;

		// Token: 0x040024A0 RID: 9376
		[Token(Token = "0x40024A0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C9B8", Offset = "0x110C9B8")]
		public CupRuleDesc rule;
	}
}
