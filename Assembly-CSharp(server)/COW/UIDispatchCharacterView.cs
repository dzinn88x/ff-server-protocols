using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021A9 RID: 8617
	[Token(Token = "0x20021A9")]
	public class UIDispatchCharacterView : UIBaseView
	{
		// Token: 0x0600BE62 RID: 48738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE62")]
		[Address(RVA = "0x220664C", Offset = "0x220664C", VA = "0x7BBCA0664C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE63 RID: 48739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE63")]
		[Address(RVA = "0x22068B8", Offset = "0x22068B8", VA = "0x7BBCA068B8")]
		public UIDispatchCharacterView()
		{
		}

		// Token: 0x0400C974 RID: 51572
		[Token(Token = "0x400C974")]
		[FieldOffset(Offset = "0x20")]
		public UINetworkTexture TitleCDN;

		// Token: 0x0400C975 RID: 51573
		[Token(Token = "0x400C975")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnClose;

		// Token: 0x0400C976 RID: 51574
		[Token(Token = "0x400C976")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView CharacterScrollView;

		// Token: 0x0400C977 RID: 51575
		[Token(Token = "0x400C977")]
		[FieldOffset(Offset = "0x38")]
		public UIEasyList EasyList;

		// Token: 0x0400C978 RID: 51576
		[Token(Token = "0x400C978")]
		[FieldOffset(Offset = "0x40")]
		public GameObject CharacterDragArea;

		// Token: 0x0400C979 RID: 51577
		[Token(Token = "0x400C979")]
		[FieldOffset(Offset = "0x48")]
		public UILabel Quota;

		// Token: 0x0400C97A RID: 51578
		[Token(Token = "0x400C97A")]
		[FieldOffset(Offset = "0x50")]
		public UIButton StartBtn;

		// Token: 0x0400C97B RID: 51579
		[Token(Token = "0x400C97B")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ArrowPanel;
	}
}
