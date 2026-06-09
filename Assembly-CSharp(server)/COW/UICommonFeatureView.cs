using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200217D RID: 8573
	[Token(Token = "0x200217D")]
	public class UICommonFeatureView : UIBaseView
	{
		// Token: 0x0600BE0A RID: 48650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE0A")]
		[Address(RVA = "0x17FFEAC", Offset = "0x17FFEAC", VA = "0x7BBBFFFEAC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE0B RID: 48651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE0B")]
		[Address(RVA = "0x1800050", Offset = "0x1800050", VA = "0x7BBC000050")]
		public UICommonFeatureView()
		{
		}

		// Token: 0x0400C781 RID: 51073
		[Token(Token = "0x400C781")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIContent;

		// Token: 0x0400C782 RID: 51074
		[Token(Token = "0x400C782")]
		[FieldOffset(Offset = "0x28")]
		public UISprite BGSprite;

		// Token: 0x0400C783 RID: 51075
		[Token(Token = "0x400C783")]
		[FieldOffset(Offset = "0x30")]
		public UIButton DownLoadBtn;

		// Token: 0x0400C784 RID: 51076
		[Token(Token = "0x400C784")]
		[FieldOffset(Offset = "0x38")]
		public UILabel DownloadText;

		// Token: 0x0400C785 RID: 51077
		[Token(Token = "0x400C785")]
		[FieldOffset(Offset = "0x40")]
		public UIButton OkBtn;
	}
}
