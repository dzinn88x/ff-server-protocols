using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200239A RID: 9114
	[Token(Token = "0x200239A")]
	public class UIHudVehiclePassengerSkillView : UIBaseView
	{
		// Token: 0x0600C244 RID: 49732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C244")]
		[Address(RVA = "0x15F09B4", Offset = "0x15F09B4", VA = "0x7BBBDF09B4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C245 RID: 49733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C245")]
		[Address(RVA = "0x15F0B18", Offset = "0x15F0B18", VA = "0x7BBBDF0B18")]
		public UIHudVehiclePassengerSkillView()
		{
		}

		// Token: 0x0400DD29 RID: 56617
		[Token(Token = "0x400DD29")]
		[FieldOffset(Offset = "0x20")]
		public UIButton btn;

		// Token: 0x0400DD2A RID: 56618
		[Token(Token = "0x400DD2A")]
		[FieldOffset(Offset = "0x28")]
		public UISprite normal;

		// Token: 0x0400DD2B RID: 56619
		[Token(Token = "0x400DD2B")]
		[FieldOffset(Offset = "0x30")]
		public UISprite icon;

		// Token: 0x0400DD2C RID: 56620
		[Token(Token = "0x400DD2C")]
		[FieldOffset(Offset = "0x38")]
		public TweenFill cooldown;
	}
}
