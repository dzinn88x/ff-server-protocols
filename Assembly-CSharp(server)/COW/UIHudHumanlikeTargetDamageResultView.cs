using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022E3 RID: 8931
	[Token(Token = "0x20022E3")]
	public class UIHudHumanlikeTargetDamageResultView : UIBaseView
	{
		// Token: 0x0600C0D6 RID: 49366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0D6")]
		[Address(RVA = "0x197E22C", Offset = "0x197E22C", VA = "0x7BBC17E22C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0D7 RID: 49367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0D7")]
		[Address(RVA = "0x197E524", Offset = "0x197E524", VA = "0x7BBC17E524")]
		public UIHudHumanlikeTargetDamageResultView()
		{
		}

		// Token: 0x0400D6F7 RID: 55031
		[Token(Token = "0x400D6F7")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnSwitch;

		// Token: 0x0400D6F8 RID: 55032
		[Token(Token = "0x400D6F8")]
		[FieldOffset(Offset = "0x28")]
		public UIButton FoldBtn;

		// Token: 0x0400D6F9 RID: 55033
		[Token(Token = "0x400D6F9")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Setting;

		// Token: 0x0400D6FA RID: 55034
		[Token(Token = "0x400D6FA")]
		[FieldOffset(Offset = "0x38")]
		public UIButton CleanDataBtn;

		// Token: 0x0400D6FB RID: 55035
		[Token(Token = "0x400D6FB")]
		[FieldOffset(Offset = "0x40")]
		public UILabel DPSVal;

		// Token: 0x0400D6FC RID: 55036
		[Token(Token = "0x400D6FC")]
		[FieldOffset(Offset = "0x48")]
		public UILabel RealDamageVal;

		// Token: 0x0400D6FD RID: 55037
		[Token(Token = "0x400D6FD")]
		[FieldOffset(Offset = "0x50")]
		public UILabel ShieldVal;

		// Token: 0x0400D6FE RID: 55038
		[Token(Token = "0x400D6FE")]
		[FieldOffset(Offset = "0x58")]
		public UILabel HeadShotVal;

		// Token: 0x0400D6FF RID: 55039
		[Token(Token = "0x400D6FF")]
		[FieldOffset(Offset = "0x60")]
		public UILabel BodyShotVal;

		// Token: 0x0400D700 RID: 55040
		[Token(Token = "0x400D700")]
		[FieldOffset(Offset = "0x68")]
		public UILabel LimbShotVal;

		// Token: 0x0400D701 RID: 55041
		[Token(Token = "0x400D701")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Config;
	}
}
