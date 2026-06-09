using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022A7 RID: 8871
	[Token(Token = "0x20022A7")]
	public class UIHudCSFactionView : UIBaseView
	{
		// Token: 0x0600C05F RID: 49247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C05F")]
		[Address(RVA = "0x19BA7C4", Offset = "0x19BA7C4", VA = "0x7BBC1BA7C4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C060 RID: 49248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C060")]
		[Address(RVA = "0x19BA9BC", Offset = "0x19BA9BC", VA = "0x7BBC1BA9BC")]
		public UIHudCSFactionView()
		{
		}

		// Token: 0x0400D505 RID: 54533
		[Token(Token = "0x400D505")]
		[FieldOffset(Offset = "0x20")]
		public UILabel taskDesc;

		// Token: 0x0400D506 RID: 54534
		[Token(Token = "0x400D506")]
		[FieldOffset(Offset = "0x28")]
		public UILabel myTeamName;

		// Token: 0x0400D507 RID: 54535
		[Token(Token = "0x400D507")]
		[FieldOffset(Offset = "0x30")]
		public UILabel myTeamDesc;

		// Token: 0x0400D508 RID: 54536
		[Token(Token = "0x400D508")]
		[FieldOffset(Offset = "0x38")]
		public UISprite myTeamIcon;

		// Token: 0x0400D509 RID: 54537
		[Token(Token = "0x400D509")]
		[FieldOffset(Offset = "0x40")]
		public UILabel oppoTeamName;

		// Token: 0x0400D50A RID: 54538
		[Token(Token = "0x400D50A")]
		[FieldOffset(Offset = "0x48")]
		public UILabel oppoTeamDesc;

		// Token: 0x0400D50B RID: 54539
		[Token(Token = "0x400D50B")]
		[FieldOffset(Offset = "0x50")]
		public UISprite oppoTeamIcon;
	}
}
