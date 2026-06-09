using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020B5 RID: 8373
	[Token(Token = "0x20020B5")]
	public class AvatarSelectionSkillSlot : MonoBehaviour
	{
		// Token: 0x0600BC74 RID: 48244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC74")]
		[Address(RVA = "0x21BDF04", Offset = "0x21BDF04", VA = "0x7BBC9BDF04")]
		public void SetSkillIcon(uint skillID, bool isLock = false, bool semiAlphaView = false)
		{
		}

		// Token: 0x0600BC75 RID: 48245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC75")]
		[Address(RVA = "0x21BE2A8", Offset = "0x21BE2A8", VA = "0x7BBC9BE2A8")]
		public AvatarSelectionSkillSlot()
		{
		}

		// Token: 0x0400BD0A RID: 48394
		[Token(Token = "0x400BD0A")]
		[FieldOffset(Offset = "0x18")]
		public GameObject m_SlotContainer;

		// Token: 0x0400BD0B RID: 48395
		[Token(Token = "0x400BD0B")]
		[FieldOffset(Offset = "0x20")]
		public UISprite m_EquippedSkillIcon;

		// Token: 0x0400BD0C RID: 48396
		[Token(Token = "0x400BD0C")]
		[FieldOffset(Offset = "0x28")]
		public UISprite m_UnEquippedIcon;

		// Token: 0x0400BD0D RID: 48397
		[Token(Token = "0x400BD0D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject m_LockSkillIcon;

		// Token: 0x0400BD0E RID: 48398
		[Token(Token = "0x400BD0E")]
		[FieldOffset(Offset = "0x38")]
		private Color semiColor;
	}
}
