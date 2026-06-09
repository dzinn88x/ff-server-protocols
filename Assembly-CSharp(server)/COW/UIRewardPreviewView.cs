using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024DA RID: 9434
	[Token(Token = "0x20024DA")]
	public class UIRewardPreviewView : UIBaseView
	{
		// Token: 0x0600C4C4 RID: 50372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4C4")]
		[Address(RVA = "0x1E20CEC", Offset = "0x1E20CEC", VA = "0x7BBC620CEC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4C5 RID: 50373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4C5")]
		[Address(RVA = "0x1E20E60", Offset = "0x1E20E60", VA = "0x7BBC620E60")]
		public UIRewardPreviewView()
		{
		}

		// Token: 0x0400EFE6 RID: 61414
		[Token(Token = "0x400EFE6")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid PreviewGrid;

		// Token: 0x0400EFE7 RID: 61415
		[Token(Token = "0x400EFE7")]
		[FieldOffset(Offset = "0x28")]
		public UIButton OKBtn;

		// Token: 0x0400EFE8 RID: 61416
		[Token(Token = "0x400EFE8")]
		[FieldOffset(Offset = "0x30")]
		public UILabel BtnLabel;

		// Token: 0x0400EFE9 RID: 61417
		[Token(Token = "0x400EFE9")]
		[FieldOffset(Offset = "0x38")]
		public UILabel DescLabel;
	}
}
