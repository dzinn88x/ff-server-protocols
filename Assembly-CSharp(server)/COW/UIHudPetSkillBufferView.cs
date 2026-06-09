using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002326 RID: 8998
	[Token(Token = "0x2002326")]
	public class UIHudPetSkillBufferView : UIBaseView
	{
		// Token: 0x0600C15C RID: 49500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C15C")]
		[Address(RVA = "0x1D6F46C", Offset = "0x1D6F46C", VA = "0x7BBC56F46C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C15D RID: 49501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C15D")]
		[Address(RVA = "0x1D6F600", Offset = "0x1D6F600", VA = "0x7BBC56F600")]
		public UIHudPetSkillBufferView()
		{
		}

		// Token: 0x0400DA1E RID: 55838
		[Token(Token = "0x400DA1E")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Btn;

		// Token: 0x0400DA1F RID: 55839
		[Token(Token = "0x400DA1F")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Icon;

		// Token: 0x0400DA20 RID: 55840
		[Token(Token = "0x400DA20")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Mask;

		// Token: 0x0400DA21 RID: 55841
		[Token(Token = "0x400DA21")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Effect;

		// Token: 0x0400DA22 RID: 55842
		[Token(Token = "0x400DA22")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Tips;
	}
}
