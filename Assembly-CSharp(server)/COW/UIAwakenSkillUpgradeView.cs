using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002114 RID: 8468
	[Token(Token = "0x2002114")]
	public class UIAwakenSkillUpgradeView : UIBaseView
	{
		// Token: 0x0600BD39 RID: 48441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD39")]
		[Address(RVA = "0x141D320", Offset = "0x141D320", VA = "0x7BBBC1D320", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD3A RID: 48442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD3A")]
		[Address(RVA = "0x141D5B4", Offset = "0x141D5B4", VA = "0x7BBBC1D5B4")]
		public UIAwakenSkillUpgradeView()
		{
		}

		// Token: 0x0400C1C4 RID: 49604
		[Token(Token = "0x400C1C4")]
		[FieldOffset(Offset = "0x20")]
		public UILabel SkillDesc;

		// Token: 0x0400C1C5 RID: 49605
		[Token(Token = "0x400C1C5")]
		[FieldOffset(Offset = "0x28")]
		public UILabel SkillName;

		// Token: 0x0400C1C6 RID: 49606
		[Token(Token = "0x400C1C6")]
		[FieldOffset(Offset = "0x30")]
		public Transform SkillSlotContainer;

		// Token: 0x0400C1C7 RID: 49607
		[Token(Token = "0x400C1C7")]
		[FieldOffset(Offset = "0x38")]
		public UILabel NextLvDesc;

		// Token: 0x0400C1C8 RID: 49608
		[Token(Token = "0x400C1C8")]
		[FieldOffset(Offset = "0x40")]
		public UISprite DebrisSpri;

		// Token: 0x0400C1C9 RID: 49609
		[Token(Token = "0x400C1C9")]
		[FieldOffset(Offset = "0x48")]
		public UILabel DebrisCnt;

		// Token: 0x0400C1CA RID: 49610
		[Token(Token = "0x400C1CA")]
		[FieldOffset(Offset = "0x50")]
		public UISprite ConsumeItemSpri;

		// Token: 0x0400C1CB RID: 49611
		[Token(Token = "0x400C1CB")]
		[FieldOffset(Offset = "0x58")]
		public UILabel ConsumeItemCnt;

		// Token: 0x0400C1CC RID: 49612
		[Token(Token = "0x400C1CC")]
		[FieldOffset(Offset = "0x60")]
		public UIButton UpgradeBtn;
	}
}
