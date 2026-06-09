using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200248D RID: 9357
	[Token(Token = "0x200248D")]
	public class UIpetSkillItemView : UIBaseView
	{
		// Token: 0x0600C42A RID: 50218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C42A")]
		[Address(RVA = "0x1793918", Offset = "0x1793918", VA = "0x7BBBF93918", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C42B RID: 50219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C42B")]
		[Address(RVA = "0x1793D74", Offset = "0x1793D74", VA = "0x7BBBF93D74")]
		public UIpetSkillItemView()
		{
		}

		// Token: 0x0400EB28 RID: 60200
		[Token(Token = "0x400EB28")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SkillInfo;

		// Token: 0x0400EB29 RID: 60201
		[Token(Token = "0x400EB29")]
		[FieldOffset(Offset = "0x28")]
		public UIScrollView UIPetskilltextScroll;

		// Token: 0x0400EB2A RID: 60202
		[Token(Token = "0x400EB2A")]
		[FieldOffset(Offset = "0x30")]
		public UITable skilltextTable;

		// Token: 0x0400EB2B RID: 60203
		[Token(Token = "0x400EB2B")]
		[FieldOffset(Offset = "0x38")]
		public UILabel SkillDesc;

		// Token: 0x0400EB2C RID: 60204
		[Token(Token = "0x400EB2C")]
		[FieldOffset(Offset = "0x40")]
		public UILabel NextLevelDes;

		// Token: 0x0400EB2D RID: 60205
		[Token(Token = "0x400EB2D")]
		[FieldOffset(Offset = "0x48")]
		public GameObject NewTips;

		// Token: 0x0400EB2E RID: 60206
		[Token(Token = "0x400EB2E")]
		[FieldOffset(Offset = "0x50")]
		public GameObject UnlockMask;

		// Token: 0x0400EB2F RID: 60207
		[Token(Token = "0x400EB2F")]
		[FieldOffset(Offset = "0x58")]
		public UISprite SkillIcon;

		// Token: 0x0400EB30 RID: 60208
		[Token(Token = "0x400EB30")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Skilltitle;

		// Token: 0x0400EB31 RID: 60209
		[Token(Token = "0x400EB31")]
		[FieldOffset(Offset = "0x68")]
		public UILabel levelLabel;

		// Token: 0x0400EB32 RID: 60210
		[Token(Token = "0x400EB32")]
		[FieldOffset(Offset = "0x70")]
		public UIButton ChangeBtn;

		// Token: 0x0400EB33 RID: 60211
		[Token(Token = "0x400EB33")]
		[FieldOffset(Offset = "0x78")]
		public GameObject NoItemTips;

		// Token: 0x0400EB34 RID: 60212
		[Token(Token = "0x400EB34")]
		[FieldOffset(Offset = "0x80")]
		public GameObject SelectSkillGuide;

		// Token: 0x0400EB35 RID: 60213
		[Token(Token = "0x400EB35")]
		[FieldOffset(Offset = "0x88")]
		public GameObject Effect_Circle;

		// Token: 0x0400EB36 RID: 60214
		[Token(Token = "0x400EB36")]
		[FieldOffset(Offset = "0x90")]
		public UIButton LeftBtn;

		// Token: 0x0400EB37 RID: 60215
		[Token(Token = "0x400EB37")]
		[FieldOffset(Offset = "0x98")]
		public UIButton RightBtn;

		// Token: 0x0400EB38 RID: 60216
		[Token(Token = "0x400EB38")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton UpgradeBtn;
	}
}
