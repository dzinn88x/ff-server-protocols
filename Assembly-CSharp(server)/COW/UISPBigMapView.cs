using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024FA RID: 9466
	[Token(Token = "0x20024FA")]
	public class UISPBigMapView : UIBaseView
	{
		// Token: 0x0600C504 RID: 50436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C504")]
		[Address(RVA = "0x1A266E4", Offset = "0x1A266E4", VA = "0x7BBC2266E4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C505 RID: 50437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C505")]
		[Address(RVA = "0x1A26AC4", Offset = "0x1A26AC4", VA = "0x7BBC226AC4")]
		public UISPBigMapView()
		{
		}

		// Token: 0x0400F13D RID: 61757
		[Token(Token = "0x400F13D")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400F13E RID: 61758
		[Token(Token = "0x400F13E")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Bg;

		// Token: 0x0400F13F RID: 61759
		[Token(Token = "0x400F13F")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Border;

		// Token: 0x0400F140 RID: 61760
		[Token(Token = "0x400F140")]
		[FieldOffset(Offset = "0x38")]
		public UIPanel MapContainer;

		// Token: 0x0400F141 RID: 61761
		[Token(Token = "0x400F141")]
		[FieldOffset(Offset = "0x40")]
		public GameObject DebugCatapultContainer;

		// Token: 0x0400F142 RID: 61762
		[Token(Token = "0x400F142")]
		[FieldOffset(Offset = "0x48")]
		public UILabel CatapultMarkLabel;

		// Token: 0x0400F143 RID: 61763
		[Token(Token = "0x400F143")]
		[FieldOffset(Offset = "0x50")]
		public SetRelativeDepth MapEffectDepth;

		// Token: 0x0400F144 RID: 61764
		[Token(Token = "0x400F144")]
		[FieldOffset(Offset = "0x58")]
		public GameObject LeftWidget;

		// Token: 0x0400F145 RID: 61765
		[Token(Token = "0x400F145")]
		[FieldOffset(Offset = "0x60")]
		public UILabel SPSafeZoneTxt;

		// Token: 0x0400F146 RID: 61766
		[Token(Token = "0x400F146")]
		[FieldOffset(Offset = "0x68")]
		public GameObject rankingContainer;

		// Token: 0x0400F147 RID: 61767
		[Token(Token = "0x400F147")]
		[FieldOffset(Offset = "0x70")]
		public GameObject DropAttachmentLabel;

		// Token: 0x0400F148 RID: 61768
		[Token(Token = "0x400F148")]
		[FieldOffset(Offset = "0x78")]
		public UIGrid AttachmentGrid;

		// Token: 0x0400F149 RID: 61769
		[Token(Token = "0x400F149")]
		[FieldOffset(Offset = "0x80")]
		public GameObject TeamInfoPanel;

		// Token: 0x0400F14A RID: 61770
		[Token(Token = "0x400F14A")]
		[FieldOffset(Offset = "0x88")]
		public UIGrid TeamListLeft;

		// Token: 0x0400F14B RID: 61771
		[Token(Token = "0x400F14B")]
		[FieldOffset(Offset = "0x90")]
		public UIGrid TeamListRight;
	}
}
