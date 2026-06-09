using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000806 RID: 2054
	[Token(Token = "0x2000806")]
	[ProtoContract]
	public class CSEquipSkillRes
	{
		// Token: 0x06002515 RID: 9493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002515")]
		[Address(RVA = "0x21B1180", Offset = "0x21B1180", VA = "0x7BBC9B1180")]
		public CSEquipSkillRes()
		{
		}

		// Token: 0x040026F3 RID: 9971
		[Token(Token = "0x40026F3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110A54", Offset = "0x1110A54")]
		public List<AvatarProfile> profiles;
	}
}
