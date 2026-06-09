using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002120 RID: 8480
	[Token(Token = "0x2002120")]
	public class UIBindAccountView : UIBaseView
	{
		// Token: 0x0600BD50 RID: 48464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD50")]
		[Address(RVA = "0x1431AF0", Offset = "0x1431AF0", VA = "0x7BBBC31AF0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD51 RID: 48465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD51")]
		[Address(RVA = "0x1431E1C", Offset = "0x1431E1C", VA = "0x7BBBC31E1C")]
		public UIBindAccountView()
		{
		}

		// Token: 0x0400C269 RID: 49769
		[Token(Token = "0x400C269")]
		[FieldOffset(Offset = "0x20")]
		public UINetworkTexture CDNEPWebSite;

		// Token: 0x0400C26A RID: 49770
		[Token(Token = "0x400C26A")]
		[FieldOffset(Offset = "0x28")]
		public UIButton CloseBtn;

		// Token: 0x0400C26B RID: 49771
		[Token(Token = "0x400C26B")]
		[FieldOffset(Offset = "0x30")]
		public Transform AwardGrid;

		// Token: 0x0400C26C RID: 49772
		[Token(Token = "0x400C26C")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid AccountBtnCenter;

		// Token: 0x0400C26D RID: 49773
		[Token(Token = "0x400C26D")]
		[FieldOffset(Offset = "0x40")]
		public UIButton HWBtn;

		// Token: 0x0400C26E RID: 49774
		[Token(Token = "0x400C26E")]
		[FieldOffset(Offset = "0x48")]
		public UIButton FBBtn;

		// Token: 0x0400C26F RID: 49775
		[Token(Token = "0x400C26F")]
		[FieldOffset(Offset = "0x50")]
		public UIButton VKBtn;

		// Token: 0x0400C270 RID: 49776
		[Token(Token = "0x400C270")]
		[FieldOffset(Offset = "0x58")]
		public UIButton GoogleBtn;

		// Token: 0x0400C271 RID: 49777
		[Token(Token = "0x400C271")]
		[FieldOffset(Offset = "0x60")]
		public UIButton AppleBtn;

		// Token: 0x0400C272 RID: 49778
		[Token(Token = "0x400C272")]
		[FieldOffset(Offset = "0x68")]
		public UIButton TwitterBtn;

		// Token: 0x0400C273 RID: 49779
		[Token(Token = "0x400C273")]
		[FieldOffset(Offset = "0x70")]
		public UIButton PlatformCombinedBtn;

		// Token: 0x0400C274 RID: 49780
		[Token(Token = "0x400C274")]
		[FieldOffset(Offset = "0x78")]
		public Transform MorePlatformPanel;
	}
}
