using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200096A RID: 2410
	[Token(Token = "0x200096A")]
	[ProtoContract]
	public class MoneyHeistAward
	{
		// Token: 0x06002678 RID: 9848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002678")]
		[Address(RVA = "0x21BCC60", Offset = "0x21BCC60", VA = "0x7BBC9BCC60")]
		public MoneyHeistAward()
		{
		}

		// Token: 0x04002BFB RID: 11259
		[Token(Token = "0x4002BFB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119730", Offset = "0x1119730")]
		public uint money;

		// Token: 0x04002BFC RID: 11260
		[Token(Token = "0x4002BFC")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119744", Offset = "0x1119744")]
		public bool big_one;

		// Token: 0x04002BFD RID: 11261
		[Token(Token = "0x4002BFD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119758", Offset = "0x1119758")]
		public List<AwardDesc> awards;
	}
}
