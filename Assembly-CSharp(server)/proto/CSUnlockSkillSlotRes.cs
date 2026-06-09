using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200080A RID: 2058
	[Token(Token = "0x200080A")]
	[ProtoContract]
	public class CSUnlockSkillSlotRes
	{
		// Token: 0x06002519 RID: 9497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002519")]
		[Address(RVA = "0x21B7B60", Offset = "0x21B7B60", VA = "0x7BBC9B7B60")]
		public CSUnlockSkillSlotRes()
		{
		}

		// Token: 0x040026FD RID: 9981
		[Token(Token = "0x40026FD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110B44", Offset = "0x1110B44")]
		public ExchangeChangeData change_data;

		// Token: 0x040026FE RID: 9982
		[Token(Token = "0x40026FE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110B58", Offset = "0x1110B58")]
		public List<AvatarProfile> profiles;
	}
}
