using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A92 RID: 2706
	[Token(Token = "0x2000A92")]
	[ProtoContract]
	public class GetOppositeSexModelRes
	{
		// Token: 0x0600279C RID: 10140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279C")]
		[Address(RVA = "0x21BAA70", Offset = "0x21BAA70", VA = "0x7BBC9BAA70")]
		public GetOppositeSexModelRes()
		{
		}

		// Token: 0x040031F0 RID: 12784
		[Token(Token = "0x40031F0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123C58", Offset = "0x1123C58")]
		public List<OppositeSexModelDesc> opposite_sex_models;
	}
}
