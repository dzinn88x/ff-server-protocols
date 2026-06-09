using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002368 RID: 9064
	[Token(Token = "0x2002368")]
	public class UIHudSkillTemplateView : UIBaseView
	{
		// Token: 0x0600C1E0 RID: 49632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1E0")]
		[Address(RVA = "0x166B4B0", Offset = "0x166B4B0", VA = "0x7BBBE6B4B0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1E1 RID: 49633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1E1")]
		[Address(RVA = "0x166B6C8", Offset = "0x166B6C8", VA = "0x7BBBE6B6C8")]
		public UIHudSkillTemplateView()
		{
		}

		// Token: 0x0400DBCC RID: 56268
		[Token(Token = "0x400DBCC")]
		[FieldOffset(Offset = "0x20")]
		public UISprite UIHudSkillTemplate;

		// Token: 0x0400DBCD RID: 56269
		[Token(Token = "0x400DBCD")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Cooldown;

		// Token: 0x0400DBCE RID: 56270
		[Token(Token = "0x400DBCE")]
		[FieldOffset(Offset = "0x30")]
		public TweenAlpha SkillFlashAnim;

		// Token: 0x0400DBCF RID: 56271
		[Token(Token = "0x400DBCF")]
		[FieldOffset(Offset = "0x38")]
		public UIButton SkillBtn;

		// Token: 0x0400DBD0 RID: 56272
		[Token(Token = "0x400DBD0")]
		[FieldOffset(Offset = "0x40")]
		public UISprite SkillBG;

		// Token: 0x0400DBD1 RID: 56273
		[Token(Token = "0x400DBD1")]
		[FieldOffset(Offset = "0x48")]
		public UILabel SkillLabel;

		// Token: 0x0400DBD2 RID: 56274
		[Token(Token = "0x400DBD2")]
		[FieldOffset(Offset = "0x50")]
		public TweenAlpha SkillBrightAnim;
	}
}
