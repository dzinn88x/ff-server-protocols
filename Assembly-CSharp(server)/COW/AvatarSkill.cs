using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CA8 RID: 7336
	[Token(Token = "0x2001CA8")]
	public class AvatarSkill
	{
		// Token: 0x0600A02D RID: 41005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A02D")]
		[Address(RVA = "0x21BE61C", Offset = "0x21BE61C", VA = "0x7BBC9BE61C")]
		public AvatarSkill()
		{
		}

		// Token: 0x0400A6F9 RID: 42745
		[Token(Token = "0x400A6F9")]
		[FieldOffset(Offset = "0x10")]
		public uint AvatarID;

		// Token: 0x0400A6FA RID: 42746
		[Token(Token = "0x400A6FA")]
		[FieldOffset(Offset = "0x14")]
		public uint SkillID;

		// Token: 0x0400A6FB RID: 42747
		[Token(Token = "0x400A6FB")]
		[FieldOffset(Offset = "0x18")]
		public AvatarSkillData SkillData;
	}
}
