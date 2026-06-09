using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021D4 RID: 8660
	[Token(Token = "0x20021D4")]
	public class UIEPWeeklyTaskContentListView : UIBaseView
	{
		// Token: 0x0600BEB9 RID: 48825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEB9")]
		[Address(RVA = "0x1AD38E0", Offset = "0x1AD38E0", VA = "0x7BBC2D38E0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEBA RID: 48826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEBA")]
		[Address(RVA = "0x1AD3B00", Offset = "0x1AD3B00", VA = "0x7BBC2D3B00")]
		public UIEPWeeklyTaskContentListView()
		{
		}

		// Token: 0x0400CB7C RID: 52092
		[Token(Token = "0x400CB7C")]
		[FieldOffset(Offset = "0x20")]
		public UISprite BG;

		// Token: 0x0400CB7D RID: 52093
		[Token(Token = "0x400CB7D")]
		[FieldOffset(Offset = "0x28")]
		public UICenterOnChild CenterChild;

		// Token: 0x0400CB7E RID: 52094
		[Token(Token = "0x400CB7E")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView ScrollView;

		// Token: 0x0400CB7F RID: 52095
		[Token(Token = "0x400CB7F")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid Grid;

		// Token: 0x0400CB80 RID: 52096
		[Token(Token = "0x400CB80")]
		[FieldOffset(Offset = "0x40")]
		public UIButton LeftBtn;

		// Token: 0x0400CB81 RID: 52097
		[Token(Token = "0x400CB81")]
		[FieldOffset(Offset = "0x48")]
		public UIButton RightBtn;

		// Token: 0x0400CB82 RID: 52098
		[Token(Token = "0x400CB82")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnClose;
	}
}
