using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020F2 RID: 8434
	[Token(Token = "0x20020F2")]
	public class UIAnniversaryLobbyEnterWndView : UIBaseView
	{
		// Token: 0x0600BCF5 RID: 48373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF5")]
		[Address(RVA = "0x1B11684", Offset = "0x1B11684", VA = "0x7BBC311684", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCF6 RID: 48374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF6")]
		[Address(RVA = "0x1B118A4", Offset = "0x1B118A4", VA = "0x7BBC3118A4")]
		public UIAnniversaryLobbyEnterWndView()
		{
		}

		// Token: 0x0400BFA3 RID: 49059
		[Token(Token = "0x400BFA3")]
		[FieldOffset(Offset = "0x20")]
		public GameObject OpenEffect;

		// Token: 0x0400BFA4 RID: 49060
		[Token(Token = "0x400BFA4")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTexture CDNTitle;

		// Token: 0x0400BFA5 RID: 49061
		[Token(Token = "0x400BFA5")]
		[FieldOffset(Offset = "0x30")]
		public UIButton CloseBtn;

		// Token: 0x0400BFA6 RID: 49062
		[Token(Token = "0x400BFA6")]
		[FieldOffset(Offset = "0x38")]
		public UIEasyList Grid;

		// Token: 0x0400BFA7 RID: 49063
		[Token(Token = "0x400BFA7")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Title;

		// Token: 0x0400BFA8 RID: 49064
		[Token(Token = "0x400BFA8")]
		[FieldOffset(Offset = "0x48")]
		public UICountDownLabel GachaCountDownLabel;

		// Token: 0x0400BFA9 RID: 49065
		[Token(Token = "0x400BFA9")]
		[FieldOffset(Offset = "0x50")]
		public UINetworkTexture CDNBg;
	}
}
