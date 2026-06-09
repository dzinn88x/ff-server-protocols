using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002291 RID: 8849
	[Token(Token = "0x2002291")]
	internal class UIHudCatapultLaunchView : UIBaseView
	{
		// Token: 0x0600C033 RID: 49203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C033")]
		[Address(RVA = "0x19D1964", Offset = "0x19D1964", VA = "0x7BBC1D1964", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C034 RID: 49204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C034")]
		[Address(RVA = "0x19D1A84", Offset = "0x19D1A84", VA = "0x7BBC1D1A84")]
		public UIHudCatapultLaunchView()
		{
		}

		// Token: 0x0400D475 RID: 54389
		[Token(Token = "0x400D475")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnLaunch;

		// Token: 0x0400D476 RID: 54390
		[Token(Token = "0x400D476")]
		[FieldOffset(Offset = "0x28")]
		public UISprite BtnSprite;

		// Token: 0x0400D477 RID: 54391
		[Token(Token = "0x400D477")]
		[FieldOffset(Offset = "0x30")]
		public UILabel BtnName;
	}
}
