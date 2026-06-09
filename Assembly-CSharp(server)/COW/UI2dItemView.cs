using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020D2 RID: 8402
	[Token(Token = "0x20020D2")]
	internal class UI2dItemView : UIBaseView
	{
		// Token: 0x0600BCB5 RID: 48309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCB5")]
		[Address(RVA = "0x1A37DF0", Offset = "0x1A37DF0", VA = "0x7BBC237DF0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCB6 RID: 48310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCB6")]
		[Address(RVA = "0x1A3806C", Offset = "0x1A3806C", VA = "0x7BBC23806C")]
		public UI2dItemView()
		{
		}

		// Token: 0x0400BE64 RID: 48740
		[Token(Token = "0x400BE64")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ui2dparent;

		// Token: 0x0400BE65 RID: 48741
		[Token(Token = "0x400BE65")]
		[FieldOffset(Offset = "0x28")]
		public UIPanel ui2dparentpanel;

		// Token: 0x0400BE66 RID: 48742
		[Token(Token = "0x400BE66")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget ItemViewContainer;

		// Token: 0x0400BE67 RID: 48743
		[Token(Token = "0x400BE67")]
		[FieldOffset(Offset = "0x38")]
		public BaseItemView BaseItemInfo;

		// Token: 0x0400BE68 RID: 48744
		[Token(Token = "0x400BE68")]
		[FieldOffset(Offset = "0x40")]
		public Transform stone;

		// Token: 0x0400BE69 RID: 48745
		[Token(Token = "0x400BE69")]
		[FieldOffset(Offset = "0x48")]
		public UISprite ItemViewIcon;

		// Token: 0x0400BE6A RID: 48746
		[Token(Token = "0x400BE6A")]
		[FieldOffset(Offset = "0x50")]
		public Transform BannerItemView;

		// Token: 0x0400BE6B RID: 48747
		[Token(Token = "0x400BE6B")]
		[FieldOffset(Offset = "0x58")]
		public Transform HeadPicItemView;
	}
}
