using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002556 RID: 9558
	[Token(Token = "0x2002556")]
	public class UIStandardTopTabView : UIBaseView
	{
		// Token: 0x0600C5BC RID: 50620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5BC")]
		[Address(RVA = "0x2135440", Offset = "0x2135440", VA = "0x7BBC935440", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5BD RID: 50621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5BD")]
		[Address(RVA = "0x2135638", Offset = "0x2135638", VA = "0x7BBC935638")]
		public UIStandardTopTabView()
		{
		}

		// Token: 0x0400F4F2 RID: 62706
		[Token(Token = "0x400F4F2")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel TabPanel;

		// Token: 0x0400F4F3 RID: 62707
		[Token(Token = "0x400F4F3")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnClose;

		// Token: 0x0400F4F4 RID: 62708
		[Token(Token = "0x400F4F4")]
		[FieldOffset(Offset = "0x30")]
		public GameObject TopTab;

		// Token: 0x0400F4F5 RID: 62709
		[Token(Token = "0x400F4F5")]
		[FieldOffset(Offset = "0x38")]
		public UISprite BG;

		// Token: 0x0400F4F6 RID: 62710
		[Token(Token = "0x400F4F6")]
		[FieldOffset(Offset = "0x40")]
		public UIScrollView ScrollView;

		// Token: 0x0400F4F7 RID: 62711
		[Token(Token = "0x400F4F7")]
		[FieldOffset(Offset = "0x48")]
		public UIEasyList EasyList;
	}
}
