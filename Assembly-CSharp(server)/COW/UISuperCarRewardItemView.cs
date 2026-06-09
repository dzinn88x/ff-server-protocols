using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002565 RID: 9573
	[Token(Token = "0x2002565")]
	public class UISuperCarRewardItemView : UIBaseView
	{
		// Token: 0x0600C5DA RID: 50650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5DA")]
		[Address(RVA = "0x214AE64", Offset = "0x214AE64", VA = "0x7BBC94AE64", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5DB RID: 50651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5DB")]
		[Address(RVA = "0x214AF7C", Offset = "0x214AF7C", VA = "0x7BBC94AF7C")]
		public UISuperCarRewardItemView()
		{
		}

		// Token: 0x0400F570 RID: 62832
		[Token(Token = "0x400F570")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Label;

		// Token: 0x0400F571 RID: 62833
		[Token(Token = "0x400F571")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Reward;

		// Token: 0x0400F572 RID: 62834
		[Token(Token = "0x400F572")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ProcessingLabel;
	}
}
