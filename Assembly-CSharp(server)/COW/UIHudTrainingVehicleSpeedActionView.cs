using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200238A RID: 9098
	[Token(Token = "0x200238A")]
	public class UIHudTrainingVehicleSpeedActionView : UIBaseView
	{
		// Token: 0x0600C224 RID: 49700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C224")]
		[Address(RVA = "0x15E8E10", Offset = "0x15E8E10", VA = "0x7BBBDE8E10", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C225 RID: 49701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C225")]
		[Address(RVA = "0x15E8F74", Offset = "0x15E8F74", VA = "0x7BBBDE8F74")]
		public UIHudTrainingVehicleSpeedActionView()
		{
		}

		// Token: 0x0400DCF4 RID: 56564
		[Token(Token = "0x400DCF4")]
		[FieldOffset(Offset = "0x20")]
		public UIButton btn;

		// Token: 0x0400DCF5 RID: 56565
		[Token(Token = "0x400DCF5")]
		[FieldOffset(Offset = "0x28")]
		public UISprite icon;

		// Token: 0x0400DCF6 RID: 56566
		[Token(Token = "0x400DCF6")]
		[FieldOffset(Offset = "0x30")]
		public UISprite normal;

		// Token: 0x0400DCF7 RID: 56567
		[Token(Token = "0x400DCF7")]
		[FieldOffset(Offset = "0x38")]
		public UILabel ActionNameTxt;
	}
}
