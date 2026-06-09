using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000ABA RID: 2746
	[Token(Token = "0x2000ABA")]
	[ProtoContract]
	public class IntimacyAwardDesc
	{
		// Token: 0x060027C4 RID: 10180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C4")]
		[Address(RVA = "0x21BB544", Offset = "0x21BB544", VA = "0x7BBC9BB544")]
		public IntimacyAwardDesc()
		{
		}

		// Token: 0x040033A4 RID: 13220
		[Token(Token = "0x40033A4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127178", Offset = "0x1127178")]
		public EFriend.RelationType relation_type;

		// Token: 0x040033A5 RID: 13221
		[Token(Token = "0x40033A5")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112718C", Offset = "0x112718C")]
		public uint rank;

		// Token: 0x040033A6 RID: 13222
		[Token(Token = "0x40033A6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11271A0", Offset = "0x11271A0")]
		public List<AwardDesc> awards;
	}
}
