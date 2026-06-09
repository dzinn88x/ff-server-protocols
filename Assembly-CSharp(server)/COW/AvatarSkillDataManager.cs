using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CAE RID: 7342
	[Token(Token = "0x2001CAE")]
	internal class AvatarSkillDataManager : SingletonModule<AvatarSkillDataManager>
	{
		// Token: 0x0600A038 RID: 41016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A038")]
		[Address(RVA = "0x21C1104", Offset = "0x21C1104", VA = "0x7BBC9C1104", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A039 RID: 41017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A039")]
		[Address(RVA = "0x21C1474", Offset = "0x21C1474", VA = "0x7BBC9C1474", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A03A RID: 41018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A03A")]
		[Address(RVA = "0x21C14F8", Offset = "0x21C14F8", VA = "0x7BBC9C14F8")]
		public List<AvatarSkillData> GetAvatarSkillList(uint avatarID)
		{
			return null;
		}

		// Token: 0x0600A03B RID: 41019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A03B")]
		[Address(RVA = "0x21C159C", Offset = "0x21C159C", VA = "0x7BBC9C159C")]
		public List<AvatarSkillData> GetAvatarSkillListBySkillId(uint skillid)
		{
			return null;
		}

		// Token: 0x0600A03C RID: 41020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A03C")]
		[Address(RVA = "0x21BF9C4", Offset = "0x21BF9C4", VA = "0x7BBC9BF9C4")]
		public AvatarSkillData GetAvatarSkillDataByLevel(uint avatarID, uint level = 1U)
		{
			return null;
		}

		// Token: 0x0600A03D RID: 41021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A03D")]
		[Address(RVA = "0x21BE220", Offset = "0x21BE220", VA = "0x7BBC9BE220")]
		public AvatarSkillData GetAvatarSkillDataBySkillID(uint skillID)
		{
			return null;
		}

		// Token: 0x0600A03E RID: 41022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A03E")]
		[Address(RVA = "0x21C1638", Offset = "0x21C1638", VA = "0x7BBC9C1638")]
		public AvatarSkillDataManager()
		{
		}

		// Token: 0x0400A723 RID: 42787
		[Token(Token = "0x400A723")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, AvatarSkillData> m_SkillDict;

		// Token: 0x0400A724 RID: 42788
		[Token(Token = "0x400A724")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<uint, List<AvatarSkillData>> m_AvatarSkillDict;
	}
}
