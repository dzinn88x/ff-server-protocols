using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200060B RID: 1547
	[Token(Token = "0x200060B")]
	[ProtoContract]
	public class EPet
	{
		// Token: 0x06002387 RID: 9095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002387")]
		[Address(RVA = "0x21B9B0C", Offset = "0x21B9B0C", VA = "0x7BBC9B9B0C")]
		public EPet()
		{
		}

		// Token: 0x0200060C RID: 1548
		[Token(Token = "0x200060C")]
		[ProtoContract]
		public enum SkillSourceType
		{
			// Token: 0x04001ED9 RID: 7897
			[Token(Token = "0x4001ED9")]
			SkillSourceType_NONE,
			// Token: 0x04001EDA RID: 7898
			[Token(Token = "0x4001EDA")]
			SkillSourceType_ALONG_WITH_PET,
			// Token: 0x04001EDB RID: 7899
			[Token(Token = "0x4001EDB")]
			SkillSourceType_ITEM
		}
	}
}
