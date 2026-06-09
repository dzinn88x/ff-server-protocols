using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021BB RID: 8635
	[Token(Token = "0x20021BB")]
	internal class UIElitePassPushToUpgradePopupView : UIBaseView
	{
		// Token: 0x0600BE86 RID: 48774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE86")]
		[Address(RVA = "0x1E6A340", Offset = "0x1E6A340", VA = "0x7BBC66A340", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE87 RID: 48775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE87")]
		[Address(RVA = "0x1E6A460", Offset = "0x1E6A460", VA = "0x7BBC66A460")]
		public UIElitePassPushToUpgradePopupView()
		{
		}

		// Token: 0x0400CA87 RID: 51847
		[Token(Token = "0x400CA87")]
		[FieldOffset(Offset = "0x20")]
		public UIButton OKBtn;

		// Token: 0x0400CA88 RID: 51848
		[Token(Token = "0x400CA88")]
		[FieldOffset(Offset = "0x28")]
		public UIButton UpgradeBtn;

		// Token: 0x0400CA89 RID: 51849
		[Token(Token = "0x400CA89")]
		[FieldOffset(Offset = "0x30")]
		public UIEasyList AwardList;
	}
}
