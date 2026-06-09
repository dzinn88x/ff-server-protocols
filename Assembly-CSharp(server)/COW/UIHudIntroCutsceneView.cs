using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022EA RID: 8938
	[Token(Token = "0x20022EA")]
	public class UIHudIntroCutsceneView : UIBaseView
	{
		// Token: 0x0600C0E4 RID: 49380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0E4")]
		[Address(RVA = "0x198F680", Offset = "0x198F680", VA = "0x7BBC18F680", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0E5 RID: 49381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0E5")]
		[Address(RVA = "0x198F8CC", Offset = "0x198F8CC", VA = "0x7BBC18F8CC")]
		public UIHudIntroCutsceneView()
		{
		}

		// Token: 0x0400D74B RID: 55115
		[Token(Token = "0x400D74B")]
		[FieldOffset(Offset = "0x20")]
		public UILabel myTeamName;

		// Token: 0x0400D74C RID: 55116
		[Token(Token = "0x400D74C")]
		[FieldOffset(Offset = "0x28")]
		public UILabel myTeamDesc;

		// Token: 0x0400D74D RID: 55117
		[Token(Token = "0x400D74D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject myTeamIcon_1;

		// Token: 0x0400D74E RID: 55118
		[Token(Token = "0x400D74E")]
		[FieldOffset(Offset = "0x38")]
		public GameObject myTeamIcon_2;

		// Token: 0x0400D74F RID: 55119
		[Token(Token = "0x400D74F")]
		[FieldOffset(Offset = "0x40")]
		public UILabel LocalPlayerName;

		// Token: 0x0400D750 RID: 55120
		[Token(Token = "0x400D750")]
		[FieldOffset(Offset = "0x48")]
		public UILabel TeammateName_1;

		// Token: 0x0400D751 RID: 55121
		[Token(Token = "0x400D751")]
		[FieldOffset(Offset = "0x50")]
		public UILabel TeammateName_2;

		// Token: 0x0400D752 RID: 55122
		[Token(Token = "0x400D752")]
		[FieldOffset(Offset = "0x58")]
		public UILabel TeammateName_3;
	}
}
