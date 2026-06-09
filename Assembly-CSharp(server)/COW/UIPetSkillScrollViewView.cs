using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200248E RID: 9358
	[Token(Token = "0x200248E")]
	public class UIPetSkillScrollViewView : UIBaseView
	{
		// Token: 0x0600C42C RID: 50220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C42C")]
		[Address(RVA = "0x20E3948", Offset = "0x20E3948", VA = "0x7BBC8E3948", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C42D RID: 50221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C42D")]
		[Address(RVA = "0x20E3AEC", Offset = "0x20E3AEC", VA = "0x7BBC8E3AEC")]
		public UIPetSkillScrollViewView()
		{
		}

		// Token: 0x0400EB39 RID: 60217
		[Token(Token = "0x400EB39")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SelectSkillView;

		// Token: 0x0400EB3A RID: 60218
		[Token(Token = "0x400EB3A")]
		[FieldOffset(Offset = "0x28")]
		public UIButton UIMarkClick;

		// Token: 0x0400EB3B RID: 60219
		[Token(Token = "0x400EB3B")]
		[FieldOffset(Offset = "0x30")]
		public GameObject NoItemChoose;

		// Token: 0x0400EB3C RID: 60220
		[Token(Token = "0x400EB3C")]
		[FieldOffset(Offset = "0x38")]
		public UIEasyList UIPetSkillGrid;

		// Token: 0x0400EB3D RID: 60221
		[Token(Token = "0x400EB3D")]
		[FieldOffset(Offset = "0x40")]
		public GameObject CurrentSkill;
	}
}
