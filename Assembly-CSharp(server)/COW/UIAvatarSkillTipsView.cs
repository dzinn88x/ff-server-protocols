using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200210C RID: 8460
	[Token(Token = "0x200210C")]
	public class UIAvatarSkillTipsView : UIBaseView
	{
		// Token: 0x0600BD29 RID: 48425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD29")]
		[Address(RVA = "0x1E504DC", Offset = "0x1E504DC", VA = "0x7BBC6504DC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD2A RID: 48426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD2A")]
		[Address(RVA = "0x1E50874", Offset = "0x1E50874", VA = "0x7BBC650874")]
		public UIAvatarSkillTipsView()
		{
		}

		// Token: 0x0400C194 RID: 49556
		[Token(Token = "0x400C194")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel UIAvatarSkillTips;

		// Token: 0x0400C195 RID: 49557
		[Token(Token = "0x400C195")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Mask;

		// Token: 0x0400C196 RID: 49558
		[Token(Token = "0x400C196")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BG;

		// Token: 0x0400C197 RID: 49559
		[Token(Token = "0x400C197")]
		[FieldOffset(Offset = "0x38")]
		public UILabel SkillName;

		// Token: 0x0400C198 RID: 49560
		[Token(Token = "0x400C198")]
		[FieldOffset(Offset = "0x40")]
		public UILabel SkillDesc;

		// Token: 0x0400C199 RID: 49561
		[Token(Token = "0x400C199")]
		[FieldOffset(Offset = "0x48")]
		public UILabel SkillType;

		// Token: 0x0400C19A RID: 49562
		[Token(Token = "0x400C19A")]
		[FieldOffset(Offset = "0x50")]
		public GameObject BelowPanel;

		// Token: 0x0400C19B RID: 49563
		[Token(Token = "0x400C19B")]
		[FieldOffset(Offset = "0x58")]
		public UILabel SkillLevel1;

		// Token: 0x0400C19C RID: 49564
		[Token(Token = "0x400C19C")]
		[FieldOffset(Offset = "0x60")]
		public UILabel SkillLeve2;

		// Token: 0x0400C19D RID: 49565
		[Token(Token = "0x400C19D")]
		[FieldOffset(Offset = "0x68")]
		public UILabel SkillLevel3;

		// Token: 0x0400C19E RID: 49566
		[Token(Token = "0x400C19E")]
		[FieldOffset(Offset = "0x70")]
		public UILabel SkillLevel4;

		// Token: 0x0400C19F RID: 49567
		[Token(Token = "0x400C19F")]
		[FieldOffset(Offset = "0x78")]
		public UILabel SkillLevel5;

		// Token: 0x0400C1A0 RID: 49568
		[Token(Token = "0x400C1A0")]
		[FieldOffset(Offset = "0x80")]
		public UILabel SkillLevel6;

		// Token: 0x0400C1A1 RID: 49569
		[Token(Token = "0x400C1A1")]
		[FieldOffset(Offset = "0x88")]
		public UIGrid SkillGrid;
	}
}
