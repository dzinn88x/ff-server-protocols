using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200239B RID: 9115
	[Token(Token = "0x200239B")]
	internal class UIHudVehiclePosView : UIBaseView
	{
		// Token: 0x0600C246 RID: 49734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C246")]
		[Address(RVA = "0x15F0B20", Offset = "0x15F0B20", VA = "0x7BBBDF0B20", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C247 RID: 49735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C247")]
		[Address(RVA = "0x15F0D28", Offset = "0x15F0D28", VA = "0x7BBBDF0D28")]
		public UIHudVehiclePosView()
		{
		}

		// Token: 0x0400DD2D RID: 56621
		[Token(Token = "0x400DD2D")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400DD2E RID: 56622
		[Token(Token = "0x400DD2E")]
		[FieldOffset(Offset = "0x28")]
		public GameObject icon;

		// Token: 0x0400DD2F RID: 56623
		[Token(Token = "0x400DD2F")]
		[FieldOffset(Offset = "0x30")]
		public UILabel DistanceLabel;

		// Token: 0x0400DD30 RID: 56624
		[Token(Token = "0x400DD30")]
		[FieldOffset(Offset = "0x38")]
		public UISprite ArrowUp;

		// Token: 0x0400DD31 RID: 56625
		[Token(Token = "0x400DD31")]
		[FieldOffset(Offset = "0x40")]
		public UISprite ArrowLeft;

		// Token: 0x0400DD32 RID: 56626
		[Token(Token = "0x400DD32")]
		[FieldOffset(Offset = "0x48")]
		public UISprite ArrowRight;

		// Token: 0x0400DD33 RID: 56627
		[Token(Token = "0x400DD33")]
		[FieldOffset(Offset = "0x50")]
		public UISprite ArrowDown;
	}
}
