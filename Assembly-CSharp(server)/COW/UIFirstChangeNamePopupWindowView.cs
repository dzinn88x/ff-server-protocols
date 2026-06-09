using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021F2 RID: 8690
	[Token(Token = "0x20021F2")]
	public class UIFirstChangeNamePopupWindowView : UIBaseView
	{
		// Token: 0x0600BEF5 RID: 48885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEF5")]
		[Address(RVA = "0x1DB7F6C", Offset = "0x1DB7F6C", VA = "0x7BBC5B7F6C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEF6 RID: 48886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEF6")]
		[Address(RVA = "0x1DB81E8", Offset = "0x1DB81E8", VA = "0x7BBC5B81E8")]
		public UIFirstChangeNamePopupWindowView()
		{
		}

		// Token: 0x0400CD45 RID: 52549
		[Token(Token = "0x400CD45")]
		[FieldOffset(Offset = "0x20")]
		public UILabel LabelDuplicateName;

		// Token: 0x0400CD46 RID: 52550
		[Token(Token = "0x400CD46")]
		[FieldOffset(Offset = "0x28")]
		public UIInput InputNewName;

		// Token: 0x0400CD47 RID: 52551
		[Token(Token = "0x400CD47")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnChange;

		// Token: 0x0400CD48 RID: 52552
		[Token(Token = "0x400CD48")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid BtnsContainer;

		// Token: 0x0400CD49 RID: 52553
		[Token(Token = "0x400CD49")]
		[FieldOffset(Offset = "0x40")]
		public GameObject BtnGroup;

		// Token: 0x0400CD4A RID: 52554
		[Token(Token = "0x400CD4A")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnConfirm;

		// Token: 0x0400CD4B RID: 52555
		[Token(Token = "0x400CD4B")]
		[FieldOffset(Offset = "0x50")]
		public UISprite ConfirmBtnBg;

		// Token: 0x0400CD4C RID: 52556
		[Token(Token = "0x400CD4C")]
		[FieldOffset(Offset = "0x58")]
		public UISprite SpriteMaster;
	}
}
