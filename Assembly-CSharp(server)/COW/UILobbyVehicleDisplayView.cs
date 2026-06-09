using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002403 RID: 9219
	[Token(Token = "0x2002403")]
	public class UILobbyVehicleDisplayView : UIBaseView
	{
		// Token: 0x0600C316 RID: 49942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C316")]
		[Address(RVA = "0x19DC2DC", Offset = "0x19DC2DC", VA = "0x7BBC1DC2DC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C317 RID: 49943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C317")]
		[Address(RVA = "0x19DC5EC", Offset = "0x19DC5EC", VA = "0x7BBC1DC5EC")]
		public UILobbyVehicleDisplayView()
		{
		}

		// Token: 0x0400E32F RID: 58159
		[Token(Token = "0x400E32F")]
		[FieldOffset(Offset = "0x20")]
		public TweenPosition RightTween;

		// Token: 0x0400E330 RID: 58160
		[Token(Token = "0x400E330")]
		[FieldOffset(Offset = "0x28")]
		public Transform PopMenu;

		// Token: 0x0400E331 RID: 58161
		[Token(Token = "0x400E331")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView ScrollView;

		// Token: 0x0400E332 RID: 58162
		[Token(Token = "0x400E332")]
		[FieldOffset(Offset = "0x38")]
		public UIEasyList Grid;

		// Token: 0x0400E333 RID: 58163
		[Token(Token = "0x400E333")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Empty;

		// Token: 0x0400E334 RID: 58164
		[Token(Token = "0x400E334")]
		[FieldOffset(Offset = "0x48")]
		public UIButton GoShopButton;

		// Token: 0x0400E335 RID: 58165
		[Token(Token = "0x400E335")]
		[FieldOffset(Offset = "0x50")]
		public UIButton RemoveButton;

		// Token: 0x0400E336 RID: 58166
		[Token(Token = "0x400E336")]
		[FieldOffset(Offset = "0x58")]
		public UIWidget GuideRoot;

		// Token: 0x0400E337 RID: 58167
		[Token(Token = "0x400E337")]
		[FieldOffset(Offset = "0x60")]
		public GameObject NaviPage;

		// Token: 0x0400E338 RID: 58168
		[Token(Token = "0x400E338")]
		[FieldOffset(Offset = "0x68")]
		public UIButton HelpBtn;

		// Token: 0x0400E339 RID: 58169
		[Token(Token = "0x400E339")]
		[FieldOffset(Offset = "0x70")]
		public UIButton leaveBtn;
	}
}
