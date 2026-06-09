using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024C4 RID: 9412
	[Token(Token = "0x20024C4")]
	internal class UIRankGuideView : UIBaseView
	{
		// Token: 0x0600C498 RID: 50328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C498")]
		[Address(RVA = "0x1E0C5CC", Offset = "0x1E0C5CC", VA = "0x7BBC60C5CC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C499 RID: 50329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C499")]
		[Address(RVA = "0x1E0C750", Offset = "0x1E0C750", VA = "0x7BBC60C750")]
		public UIRankGuideView()
		{
		}

		// Token: 0x0400EF5C RID: 61276
		[Token(Token = "0x400EF5C")]
		[FieldOffset(Offset = "0x20")]
		public UILabel GuideText;

		// Token: 0x0400EF5D RID: 61277
		[Token(Token = "0x400EF5D")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Guide_MapBtn_Anim;

		// Token: 0x0400EF5E RID: 61278
		[Token(Token = "0x400EF5E")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Guide_MapBtn_Anim_In;

		// Token: 0x0400EF5F RID: 61279
		[Token(Token = "0x400EF5F")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Guide_Unlock_Anim;

		// Token: 0x0400EF60 RID: 61280
		[Token(Token = "0x400EF60")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Guide_MapBtn_Anim_Small;
	}
}
