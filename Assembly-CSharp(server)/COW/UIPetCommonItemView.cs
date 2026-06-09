using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002489 RID: 9353
	[Token(Token = "0x2002489")]
	internal class UIPetCommonItemView : UIBaseView
	{
		// Token: 0x0600C422 RID: 50210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C422")]
		[Address(RVA = "0x20D4CCC", Offset = "0x20D4CCC", VA = "0x7BBC8D4CCC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C423 RID: 50211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C423")]
		[Address(RVA = "0x20D4EE4", Offset = "0x20D4EE4", VA = "0x7BBC8D4EE4")]
		public UIPetCommonItemView()
		{
		}

		// Token: 0x0400EB13 RID: 60179
		[Token(Token = "0x400EB13")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400EB14 RID: 60180
		[Token(Token = "0x400EB14")]
		[FieldOffset(Offset = "0x28")]
		public BaseItemView BaseItemInfo;

		// Token: 0x0400EB15 RID: 60181
		[Token(Token = "0x400EB15")]
		[FieldOffset(Offset = "0x30")]
		public GameObject HighLightBG;

		// Token: 0x0400EB16 RID: 60182
		[Token(Token = "0x400EB16")]
		[FieldOffset(Offset = "0x38")]
		public GameObject BG;

		// Token: 0x0400EB17 RID: 60183
		[Token(Token = "0x400EB17")]
		[FieldOffset(Offset = "0x40")]
		public UISprite UnlockIcon;

		// Token: 0x0400EB18 RID: 60184
		[Token(Token = "0x400EB18")]
		[FieldOffset(Offset = "0x48")]
		public GameObject SelectedFlag;

		// Token: 0x0400EB19 RID: 60185
		[Token(Token = "0x400EB19")]
		[FieldOffset(Offset = "0x50")]
		public GameObject NewTag;
	}
}
