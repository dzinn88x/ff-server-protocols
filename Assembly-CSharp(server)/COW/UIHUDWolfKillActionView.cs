using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023BA RID: 9146
	[Token(Token = "0x20023BA")]
	public class UIHUDWolfKillActionView : UIBaseView
	{
		// Token: 0x0600C284 RID: 49796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C284")]
		[Address(RVA = "0x1D5C608", Offset = "0x1D5C608", VA = "0x7BBC55C608", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C285 RID: 49797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C285")]
		[Address(RVA = "0x1D5C79C", Offset = "0x1D5C79C", VA = "0x7BBC55C79C")]
		public UIHUDWolfKillActionView()
		{
		}

		// Token: 0x0400DE3C RID: 56892
		[Token(Token = "0x400DE3C")]
		[FieldOffset(Offset = "0x20")]
		public Transform root;

		// Token: 0x0400DE3D RID: 56893
		[Token(Token = "0x400DE3D")]
		[FieldOffset(Offset = "0x28")]
		public GameObject NoTargetRoot;

		// Token: 0x0400DE3E RID: 56894
		[Token(Token = "0x400DE3E")]
		[FieldOffset(Offset = "0x30")]
		public GameObject CDRoot;

		// Token: 0x0400DE3F RID: 56895
		[Token(Token = "0x400DE3F")]
		[FieldOffset(Offset = "0x38")]
		public UILabel CDLabel;

		// Token: 0x0400DE40 RID: 56896
		[Token(Token = "0x400DE40")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnFire;
	}
}
