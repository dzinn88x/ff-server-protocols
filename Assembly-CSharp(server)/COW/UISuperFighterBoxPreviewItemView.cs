using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200256A RID: 9578
	[Token(Token = "0x200256A")]
	public class UISuperFighterBoxPreviewItemView : UIBaseView
	{
		// Token: 0x0600C5E4 RID: 50660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5E4")]
		[Address(RVA = "0x1F444C8", Offset = "0x1F444C8", VA = "0x7BBC7444C8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5E5 RID: 50661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5E5")]
		[Address(RVA = "0x1F4463C", Offset = "0x1F4463C", VA = "0x7BBC74463C")]
		public UISuperFighterBoxPreviewItemView()
		{
		}

		// Token: 0x0400F5B6 RID: 62902
		[Token(Token = "0x400F5B6")]
		[FieldOffset(Offset = "0x20")]
		public UILabel BoxName;

		// Token: 0x0400F5B7 RID: 62903
		[Token(Token = "0x400F5B7")]
		[FieldOffset(Offset = "0x28")]
		public UISprite BoxIcon;

		// Token: 0x0400F5B8 RID: 62904
		[Token(Token = "0x400F5B8")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView ScrollView;

		// Token: 0x0400F5B9 RID: 62905
		[Token(Token = "0x400F5B9")]
		[FieldOffset(Offset = "0x38")]
		public UIEasyList Awards;
	}
}
