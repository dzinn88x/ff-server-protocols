using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020F7 RID: 8439
	[Token(Token = "0x20020F7")]
	public class UIAvatarAwakenNavigationView : UIBaseView
	{
		// Token: 0x0600BCFF RID: 48383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCFF")]
		[Address(RVA = "0x1B1F608", Offset = "0x1B1F608", VA = "0x7BBC31F608", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD00 RID: 48384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD00")]
		[Address(RVA = "0x1B1F94C", Offset = "0x1B1F94C", VA = "0x7BBC31F94C")]
		public UIAvatarAwakenNavigationView()
		{
		}

		// Token: 0x0400BFC2 RID: 49090
		[Token(Token = "0x400BFC2")]
		[FieldOffset(Offset = "0x20")]
		public UILabel AwakenNameLabel;

		// Token: 0x0400BFC3 RID: 49091
		[Token(Token = "0x400BFC3")]
		[FieldOffset(Offset = "0x28")]
		public UILabel AwakenTitle;

		// Token: 0x0400BFC4 RID: 49092
		[Token(Token = "0x400BFC4")]
		[FieldOffset(Offset = "0x30")]
		public UILabel AwakenTitle_2;

		// Token: 0x0400BFC5 RID: 49093
		[Token(Token = "0x400BFC5")]
		[FieldOffset(Offset = "0x38")]
		public GameObject CDNImgContainer;

		// Token: 0x0400BFC6 RID: 49094
		[Token(Token = "0x400BFC6")]
		[FieldOffset(Offset = "0x40")]
		public UIButton CDNBtnClose;

		// Token: 0x0400BFC7 RID: 49095
		[Token(Token = "0x400BFC7")]
		[FieldOffset(Offset = "0x48")]
		public UINetworkTextureExt CDNImage;

		// Token: 0x0400BFC8 RID: 49096
		[Token(Token = "0x400BFC8")]
		[FieldOffset(Offset = "0x50")]
		public UIButton LeftClickArea;

		// Token: 0x0400BFC9 RID: 49097
		[Token(Token = "0x400BFC9")]
		[FieldOffset(Offset = "0x58")]
		public UIButton RightClickArea;

		// Token: 0x0400BFCA RID: 49098
		[Token(Token = "0x400BFCA")]
		[FieldOffset(Offset = "0x60")]
		public GameObject LeftShowDisable;

		// Token: 0x0400BFCB RID: 49099
		[Token(Token = "0x400BFCB")]
		[FieldOffset(Offset = "0x68")]
		public GameObject LeftShow;

		// Token: 0x0400BFCC RID: 49100
		[Token(Token = "0x400BFCC")]
		[FieldOffset(Offset = "0x70")]
		public GameObject RightShowDisable;

		// Token: 0x0400BFCD RID: 49101
		[Token(Token = "0x400BFCD")]
		[FieldOffset(Offset = "0x78")]
		public GameObject RightShow;
	}
}
