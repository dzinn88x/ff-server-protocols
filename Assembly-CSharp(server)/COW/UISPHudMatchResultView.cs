using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002518 RID: 9496
	[Token(Token = "0x2002518")]
	public class UISPHudMatchResultView : UIBaseView
	{
		// Token: 0x0600C540 RID: 50496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C540")]
		[Address(RVA = "0x1EE9D68", Offset = "0x1EE9D68", VA = "0x7BBC6E9D68", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C541 RID: 50497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C541")]
		[Address(RVA = "0x1EEA258", Offset = "0x1EEA258", VA = "0x7BBC6EA258")]
		public UISPHudMatchResultView()
		{
		}

		// Token: 0x0400F273 RID: 62067
		[Token(Token = "0x400F273")]
		[FieldOffset(Offset = "0x20")]
		public UIButton PrevBtn;

		// Token: 0x0400F274 RID: 62068
		[Token(Token = "0x400F274")]
		[FieldOffset(Offset = "0x28")]
		public UILabel MatchMapTxt;

		// Token: 0x0400F275 RID: 62069
		[Token(Token = "0x400F275")]
		[FieldOffset(Offset = "0x30")]
		public UILabel MatchModeTxt;

		// Token: 0x0400F276 RID: 62070
		[Token(Token = "0x400F276")]
		[FieldOffset(Offset = "0x38")]
		public UITexture bg;

		// Token: 0x0400F277 RID: 62071
		[Token(Token = "0x400F277")]
		[FieldOffset(Offset = "0x40")]
		public UITexture LocalBG;

		// Token: 0x0400F278 RID: 62072
		[Token(Token = "0x400F278")]
		[FieldOffset(Offset = "0x48")]
		public GameObject infoPanel;

		// Token: 0x0400F279 RID: 62073
		[Token(Token = "0x400F279")]
		[FieldOffset(Offset = "0x50")]
		public UITable LeftTable;

		// Token: 0x0400F27A RID: 62074
		[Token(Token = "0x400F27A")]
		[FieldOffset(Offset = "0x58")]
		public UIScrollView RightScrollView;

		// Token: 0x0400F27B RID: 62075
		[Token(Token = "0x400F27B")]
		[FieldOffset(Offset = "0x60")]
		public TweenPosition RightScrollViewTWPosition;

		// Token: 0x0400F27C RID: 62076
		[Token(Token = "0x400F27C")]
		[FieldOffset(Offset = "0x68")]
		public TweenAlpha RightScrollViewAlpha;

		// Token: 0x0400F27D RID: 62077
		[Token(Token = "0x400F27D")]
		[FieldOffset(Offset = "0x70")]
		public UIPanel RightScrollViewPanel;

		// Token: 0x0400F27E RID: 62078
		[Token(Token = "0x400F27E")]
		[FieldOffset(Offset = "0x78")]
		public UITable RightTable;

		// Token: 0x0400F27F RID: 62079
		[Token(Token = "0x400F27F")]
		[FieldOffset(Offset = "0x80")]
		public GameObject infoPanelQuad;

		// Token: 0x0400F280 RID: 62080
		[Token(Token = "0x400F280")]
		[FieldOffset(Offset = "0x88")]
		public UITable LeftTableQuad;

		// Token: 0x0400F281 RID: 62081
		[Token(Token = "0x400F281")]
		[FieldOffset(Offset = "0x90")]
		public UIScrollView RightScrollViewQuad;

		// Token: 0x0400F282 RID: 62082
		[Token(Token = "0x400F282")]
		[FieldOffset(Offset = "0x98")]
		public TweenAlpha RightScrollViewQuadTWAlpha;

		// Token: 0x0400F283 RID: 62083
		[Token(Token = "0x400F283")]
		[FieldOffset(Offset = "0xA0")]
		public TweenPosition RightScrollViewQuadTWPosition;

		// Token: 0x0400F284 RID: 62084
		[Token(Token = "0x400F284")]
		[FieldOffset(Offset = "0xA8")]
		public UIPanel RightScrollViewQuadPanel;

		// Token: 0x0400F285 RID: 62085
		[Token(Token = "0x400F285")]
		[FieldOffset(Offset = "0xB0")]
		public UITable RightTableQuad;
	}
}
