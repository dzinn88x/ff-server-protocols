using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020F6 RID: 8438
	[Token(Token = "0x20020F6")]
	public class UIAutoPickUpSettingView : UIBaseView
	{
		// Token: 0x0600BCFD RID: 48381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCFD")]
		[Address(RVA = "0x1B17190", Offset = "0x1B17190", VA = "0x7BBC317190", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCFE RID: 48382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCFE")]
		[Address(RVA = "0x1B172B0", Offset = "0x1B172B0", VA = "0x7BBC3172B0")]
		public UIAutoPickUpSettingView()
		{
		}

		// Token: 0x0400BFBF RID: 49087
		[Token(Token = "0x400BFBF")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView ScrollView;

		// Token: 0x0400BFC0 RID: 49088
		[Token(Token = "0x400BFC0")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid Grid;

		// Token: 0x0400BFC1 RID: 49089
		[Token(Token = "0x400BFC1")]
		[FieldOffset(Offset = "0x30")]
		public UISettingToggleGroup AutoPickupItem;
	}
}
