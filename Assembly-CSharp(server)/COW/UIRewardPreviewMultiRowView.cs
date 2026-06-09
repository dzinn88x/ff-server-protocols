using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024D9 RID: 9433
	[Token(Token = "0x20024D9")]
	public class UIRewardPreviewMultiRowView : UIBaseView
	{
		// Token: 0x0600C4C2 RID: 50370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4C2")]
		[Address(RVA = "0x1E20BC4", Offset = "0x1E20BC4", VA = "0x7BBC620BC4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4C3 RID: 50371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4C3")]
		[Address(RVA = "0x1E20CE4", Offset = "0x1E20CE4", VA = "0x7BBC620CE4")]
		public UIRewardPreviewMultiRowView()
		{
		}

		// Token: 0x0400EFE3 RID: 61411
		[Token(Token = "0x400EFE3")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid RowGrid;

		// Token: 0x0400EFE4 RID: 61412
		[Token(Token = "0x400EFE4")]
		[FieldOffset(Offset = "0x28")]
		public UIButton OKBtn;

		// Token: 0x0400EFE5 RID: 61413
		[Token(Token = "0x400EFE5")]
		[FieldOffset(Offset = "0x30")]
		public UILabel BtnLabel;
	}
}
