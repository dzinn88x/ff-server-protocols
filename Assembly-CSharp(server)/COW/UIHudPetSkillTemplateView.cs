using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002327 RID: 8999
	[Token(Token = "0x2002327")]
	public class UIHudPetSkillTemplateView : UIBaseView
	{
		// Token: 0x0600C15E RID: 49502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C15E")]
		[Address(RVA = "0x1D700F4", Offset = "0x1D700F4", VA = "0x7BBC5700F4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C15F RID: 49503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C15F")]
		[Address(RVA = "0x1D70214", Offset = "0x1D70214", VA = "0x7BBC570214")]
		public UIHudPetSkillTemplateView()
		{
		}

		// Token: 0x0400DA23 RID: 55843
		[Token(Token = "0x400DA23")]
		[FieldOffset(Offset = "0x20")]
		public UISprite UIHudPetSkillTemplate;

		// Token: 0x0400DA24 RID: 55844
		[Token(Token = "0x400DA24")]
		[FieldOffset(Offset = "0x28")]
		public UIButton SkillBtn;

		// Token: 0x0400DA25 RID: 55845
		[Token(Token = "0x400DA25")]
		[FieldOffset(Offset = "0x30")]
		public UILabel SkillLabel;
	}
}
