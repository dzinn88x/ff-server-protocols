using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200255F RID: 9567
	[Token(Token = "0x200255F")]
	public class UISuperCarHelpWndView : UIBaseView
	{
		// Token: 0x0600C5CE RID: 50638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5CE")]
		[Address(RVA = "0x2145AB8", Offset = "0x2145AB8", VA = "0x7BBC945AB8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5CF RID: 50639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5CF")]
		[Address(RVA = "0x2145C2C", Offset = "0x2145C2C", VA = "0x7BBC945C2C")]
		public UISuperCarHelpWndView()
		{
		}

		// Token: 0x0400F53B RID: 62779
		[Token(Token = "0x400F53B")]
		[FieldOffset(Offset = "0x20")]
		public UITable HelperTable;

		// Token: 0x0400F53C RID: 62780
		[Token(Token = "0x400F53C")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Desc;

		// Token: 0x0400F53D RID: 62781
		[Token(Token = "0x400F53D")]
		[FieldOffset(Offset = "0x30")]
		public UIButton HelpOtherBtn;

		// Token: 0x0400F53E RID: 62782
		[Token(Token = "0x400F53E")]
		[FieldOffset(Offset = "0x38")]
		public UIButton RightMask;
	}
}
