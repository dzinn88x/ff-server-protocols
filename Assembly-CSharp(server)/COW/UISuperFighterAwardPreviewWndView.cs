using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002569 RID: 9577
	[Token(Token = "0x2002569")]
	public class UISuperFighterAwardPreviewWndView : UIBaseView
	{
		// Token: 0x0600C5E2 RID: 50658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5E2")]
		[Address(RVA = "0x1F43BFC", Offset = "0x1F43BFC", VA = "0x7BBC743BFC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5E3 RID: 50659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5E3")]
		[Address(RVA = "0x1F43DF4", Offset = "0x1F43DF4", VA = "0x7BBC743DF4")]
		public UISuperFighterAwardPreviewWndView()
		{
		}

		// Token: 0x0400F5B0 RID: 62896
		[Token(Token = "0x400F5B0")]
		[FieldOffset(Offset = "0x20")]
		public UIToggleButton BtnSmallAward;

		// Token: 0x0400F5B1 RID: 62897
		[Token(Token = "0x400F5B1")]
		[FieldOffset(Offset = "0x28")]
		public UIToggleButton BtnBigAward;

		// Token: 0x0400F5B2 RID: 62898
		[Token(Token = "0x400F5B2")]
		[FieldOffset(Offset = "0x30")]
		public GameObject SmallAwardPage;

		// Token: 0x0400F5B3 RID: 62899
		[Token(Token = "0x400F5B3")]
		[FieldOffset(Offset = "0x38")]
		public UIEasyList BoxList;

		// Token: 0x0400F5B4 RID: 62900
		[Token(Token = "0x400F5B4")]
		[FieldOffset(Offset = "0x40")]
		public GameObject BigAwardPage;

		// Token: 0x0400F5B5 RID: 62901
		[Token(Token = "0x400F5B5")]
		[FieldOffset(Offset = "0x48")]
		public UINetworkTexture BigRewardPreview;
	}
}
