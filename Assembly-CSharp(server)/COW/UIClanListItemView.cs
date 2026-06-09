using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200216B RID: 8555
	[Token(Token = "0x200216B")]
	public class UIClanListItemView : UIBaseView
	{
		// Token: 0x0600BDE6 RID: 48614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDE6")]
		[Address(RVA = "0x1CFCC08", Offset = "0x1CFCC08", VA = "0x7BBC4FCC08", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDE7 RID: 48615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDE7")]
		[Address(RVA = "0x1CFCFD8", Offset = "0x1CFCFD8", VA = "0x7BBC4FCFD8")]
		public UIClanListItemView()
		{
		}

		// Token: 0x0400C60A RID: 50698
		[Token(Token = "0x400C60A")]
		[FieldOffset(Offset = "0x20")]
		public UILabel LV;

		// Token: 0x0400C60B RID: 50699
		[Token(Token = "0x400C60B")]
		[FieldOffset(Offset = "0x28")]
		public UILabel GuildName;

		// Token: 0x0400C60C RID: 50700
		[Token(Token = "0x400C60C")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Honor;

		// Token: 0x0400C60D RID: 50701
		[Token(Token = "0x400C60D")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Members;

		// Token: 0x0400C60E RID: 50702
		[Token(Token = "0x400C60E")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Slogan;

		// Token: 0x0400C60F RID: 50703
		[Token(Token = "0x400C60F")]
		[FieldOffset(Offset = "0x48")]
		public UIButton JoinBtn;

		// Token: 0x0400C610 RID: 50704
		[Token(Token = "0x400C610")]
		[FieldOffset(Offset = "0x50")]
		public UIButton AppliedBtn;

		// Token: 0x0400C611 RID: 50705
		[Token(Token = "0x400C611")]
		[FieldOffset(Offset = "0x58")]
		public GameObject AuditApproveLabel;

		// Token: 0x0400C612 RID: 50706
		[Token(Token = "0x400C612")]
		[FieldOffset(Offset = "0x60")]
		public GameObject AutoWithCond;

		// Token: 0x0400C613 RID: 50707
		[Token(Token = "0x400C613")]
		[FieldOffset(Offset = "0x68")]
		public UILabel AuditAutoLabelWithCond;

		// Token: 0x0400C614 RID: 50708
		[Token(Token = "0x400C614")]
		[FieldOffset(Offset = "0x70")]
		public UIGrid AutoCondContent;

		// Token: 0x0400C615 RID: 50709
		[Token(Token = "0x400C615")]
		[FieldOffset(Offset = "0x78")]
		public UILabel AutoLevel;

		// Token: 0x0400C616 RID: 50710
		[Token(Token = "0x400C616")]
		[FieldOffset(Offset = "0x80")]
		public UISprite Rank;

		// Token: 0x0400C617 RID: 50711
		[Token(Token = "0x400C617")]
		[FieldOffset(Offset = "0x88")]
		public GameObject AutoWithoutCond;

		// Token: 0x0400C618 RID: 50712
		[Token(Token = "0x400C618")]
		[FieldOffset(Offset = "0x90")]
		public GameObject AuditAutoLabel;
	}
}
