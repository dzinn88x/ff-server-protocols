using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024C5 RID: 9413
	[Token(Token = "0x20024C5")]
	public class UIRankMapSelectItemView : UIBaseView
	{
		// Token: 0x0600C49A RID: 50330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C49A")]
		[Address(RVA = "0x1E10AE8", Offset = "0x1E10AE8", VA = "0x7BBC610AE8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C49B RID: 50331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C49B")]
		[Address(RVA = "0x1E10D84", Offset = "0x1E10D84", VA = "0x7BBC610D84")]
		public UIRankMapSelectItemView()
		{
		}

		// Token: 0x0400EF61 RID: 61281
		[Token(Token = "0x400EF61")]
		[FieldOffset(Offset = "0x20")]
		public UIButton DragItem;

		// Token: 0x0400EF62 RID: 61282
		[Token(Token = "0x400EF62")]
		[FieldOffset(Offset = "0x28")]
		public UISprite bg;

		// Token: 0x0400EF63 RID: 61283
		[Token(Token = "0x400EF63")]
		[FieldOffset(Offset = "0x30")]
		public UISprite ModeSprite;

		// Token: 0x0400EF64 RID: 61284
		[Token(Token = "0x400EF64")]
		[FieldOffset(Offset = "0x38")]
		public UINetworkTexture NetworkTexture;

		// Token: 0x0400EF65 RID: 61285
		[Token(Token = "0x400EF65")]
		[FieldOffset(Offset = "0x40")]
		public GameObject DownloadRoot;

		// Token: 0x0400EF66 RID: 61286
		[Token(Token = "0x400EF66")]
		[FieldOffset(Offset = "0x48")]
		public UICheckboxButton SelectButton;

		// Token: 0x0400EF67 RID: 61287
		[Token(Token = "0x400EF67")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Empty;

		// Token: 0x0400EF68 RID: 61288
		[Token(Token = "0x400EF68")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Selected;

		// Token: 0x0400EF69 RID: 61289
		[Token(Token = "0x400EF69")]
		[FieldOffset(Offset = "0x60")]
		public UILabel MapName;
	}
}
