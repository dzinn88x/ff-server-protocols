using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023A4 RID: 9124
	[Token(Token = "0x20023A4")]
	public class UIHUDWereWolvesHumanKilledView : UIBaseView
	{
		// Token: 0x0600C258 RID: 49752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C258")]
		[Address(RVA = "0x1D57D2C", Offset = "0x1D57D2C", VA = "0x7BBC557D2C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C259 RID: 49753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C259")]
		[Address(RVA = "0x1D57E98", Offset = "0x1D57E98", VA = "0x7BBC557E98")]
		public UIHUDWereWolvesHumanKilledView()
		{
		}

		// Token: 0x0400DDAA RID: 56746
		[Token(Token = "0x400DDAA")]
		[FieldOffset(Offset = "0x20")]
		public UISprite WolfIcon;

		// Token: 0x0400DDAB RID: 56747
		[Token(Token = "0x400DDAB")]
		[FieldOffset(Offset = "0x28")]
		public UILabel WolfNum;

		// Token: 0x0400DDAC RID: 56748
		[Token(Token = "0x400DDAC")]
		[FieldOffset(Offset = "0x30")]
		public UISprite HumanIcon;

		// Token: 0x0400DDAD RID: 56749
		[Token(Token = "0x400DDAD")]
		[FieldOffset(Offset = "0x38")]
		public UILabel HumanNum;
	}
}
