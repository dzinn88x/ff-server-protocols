using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CF7 RID: 7415
	[Token(Token = "0x2001CF7")]
	public struct PetSkillConfigInfo
	{
		// Token: 0x0600A1A8 RID: 41384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1A8")]
		[Address(RVA = "0x11F1234", Offset = "0x11F1234", VA = "0x7BBB9F1234")]
		public PetSkillConfigInfo(uint skill_id, uint pet_level, uint pet_id)
		{
		}

		// Token: 0x0400A818 RID: 43032
		[Token(Token = "0x400A818")]
		[FieldOffset(Offset = "0x0")]
		public uint SkillID;

		// Token: 0x0400A819 RID: 43033
		[Token(Token = "0x400A819")]
		[FieldOffset(Offset = "0x4")]
		public int Level;

		// Token: 0x0400A81A RID: 43034
		[Token(Token = "0x400A81A")]
		[FieldOffset(Offset = "0x8")]
		public uint PetID;

		// Token: 0x0400A81B RID: 43035
		[Token(Token = "0x400A81B")]
		[FieldOffset(Offset = "0xC")]
		public bool IsLock;

		// Token: 0x0400A81C RID: 43036
		[Token(Token = "0x400A81C")]
		[FieldOffset(Offset = "0x10")]
		public PetSkillLevelData CurrentLevelData;

		// Token: 0x0400A81D RID: 43037
		[Token(Token = "0x400A81D")]
		[FieldOffset(Offset = "0x18")]
		public PetSkillLevelData NextLevelData;
	}
}
