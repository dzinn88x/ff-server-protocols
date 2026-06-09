using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002109 RID: 8457
	[Token(Token = "0x2002109")]
	public class UIAvatarSkillItemView : UIBaseView
	{
		// Token: 0x0600BD23 RID: 48419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD23")]
		[Address(RVA = "0x1E4BC40", Offset = "0x1E4BC40", VA = "0x7BBC64BC40", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD24 RID: 48420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD24")]
		[Address(RVA = "0x1E4BF9C", Offset = "0x1E4BF9C", VA = "0x7BBC64BF9C")]
		public UIAvatarSkillItemView()
		{
		}

		// Token: 0x0400C16C RID: 49516
		[Token(Token = "0x400C16C")]
		[FieldOffset(Offset = "0x20")]
		public UIButton SkillBtn;

		// Token: 0x0400C16D RID: 49517
		[Token(Token = "0x400C16D")]
		[FieldOffset(Offset = "0x28")]
		public Transform SkillIcon;

		// Token: 0x0400C16E RID: 49518
		[Token(Token = "0x400C16E")]
		[FieldOffset(Offset = "0x30")]
		public UILabel SkillName;

		// Token: 0x0400C16F RID: 49519
		[Token(Token = "0x400C16F")]
		[FieldOffset(Offset = "0x38")]
		public UILabel SkillDesc;

		// Token: 0x0400C170 RID: 49520
		[Token(Token = "0x400C170")]
		[FieldOffset(Offset = "0x40")]
		public GameObject SelectSprite;

		// Token: 0x0400C171 RID: 49521
		[Token(Token = "0x400C171")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Lock;

		// Token: 0x0400C172 RID: 49522
		[Token(Token = "0x400C172")]
		[FieldOffset(Offset = "0x50")]
		public UISprite AvatarIcon;

		// Token: 0x0400C173 RID: 49523
		[Token(Token = "0x400C173")]
		[FieldOffset(Offset = "0x58")]
		public UIButton TipButton;

		// Token: 0x0400C174 RID: 49524
		[Token(Token = "0x400C174")]
		[FieldOffset(Offset = "0x60")]
		public UIButton LevelBtn;

		// Token: 0x0400C175 RID: 49525
		[Token(Token = "0x400C175")]
		[FieldOffset(Offset = "0x68")]
		public GameObject LevelTips;

		// Token: 0x0400C176 RID: 49526
		[Token(Token = "0x400C176")]
		[FieldOffset(Offset = "0x70")]
		public UILabel SkillCd;

		// Token: 0x0400C177 RID: 49527
		[Token(Token = "0x400C177")]
		[FieldOffset(Offset = "0x78")]
		public Transform TipsRight;
	}
}
