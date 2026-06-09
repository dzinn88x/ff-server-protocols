using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A5F RID: 2655
	[Token(Token = "0x2000A5F")]
	[ProtoContract]
	public class AvatarHideDesc
	{
		// Token: 0x06002769 RID: 10089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002769")]
		[Address(RVA = "0x21AF4B0", Offset = "0x21AF4B0", VA = "0x7BBC9AF4B0")]
		public AvatarHideDesc()
		{
		}

		// Token: 0x0400308A RID: 12426
		[Token(Token = "0x400308A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121368", Offset = "0x1121368")]
		public List<AvatarHide> avatar_hide;
	}
}
