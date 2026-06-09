using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200098E RID: 2446
	[Token(Token = "0x200098E")]
	[ProtoContract]
	public class CSSuperFighterAttackReq
	{
		// Token: 0x0600269C RID: 9884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269C")]
		[Address(RVA = "0x21B7710", Offset = "0x21B7710", VA = "0x7BBC9B7710")]
		public CSSuperFighterAttackReq()
		{
		}

		// Token: 0x04002C44 RID: 11332
		[Token(Token = "0x4002C44")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119DE8", Offset = "0x1119DE8")]
		public ELimitedEvent.SuperFighterManner manner;
	}
}
