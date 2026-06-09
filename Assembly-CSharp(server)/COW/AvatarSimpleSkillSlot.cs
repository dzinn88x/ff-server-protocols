using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020B6 RID: 8374
	[Token(Token = "0x20020B6")]
	public class AvatarSimpleSkillSlot : MonoBehaviour
	{
		// Token: 0x0600BC76 RID: 48246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC76")]
		[Address(RVA = "0x21BE310", Offset = "0x21BE310", VA = "0x7BBC9BE310")]
		public void SetSkillIcon(uint skillID, bool isLock = false, bool isSelected = false)
		{
		}

		// Token: 0x0600BC77 RID: 48247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC77")]
		[Address(RVA = "0x21BE614", Offset = "0x21BE614", VA = "0x7BBC9BE614")]
		public AvatarSimpleSkillSlot()
		{
		}

		// Token: 0x0400BD0F RID: 48399
		[Token(Token = "0x400BD0F")]
		[FieldOffset(Offset = "0x18")]
		public GameObject SelectedHL;

		// Token: 0x0400BD10 RID: 48400
		[Token(Token = "0x400BD10")]
		[FieldOffset(Offset = "0x20")]
		public UISprite SkillSprite;

		// Token: 0x0400BD11 RID: 48401
		[Token(Token = "0x400BD11")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Empty;

		// Token: 0x0400BD12 RID: 48402
		[Token(Token = "0x400BD12")]
		[FieldOffset(Offset = "0x30")]
		public GameObject LockGo;
	}
}
