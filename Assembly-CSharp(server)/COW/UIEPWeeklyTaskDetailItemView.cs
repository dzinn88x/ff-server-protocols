using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021D5 RID: 8661
	[Token(Token = "0x20021D5")]
	public class UIEPWeeklyTaskDetailItemView : UIBaseView
	{
		// Token: 0x0600BEBB RID: 48827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEBB")]
		[Address(RVA = "0x1AD579C", Offset = "0x1AD579C", VA = "0x7BBC2D579C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEBC RID: 48828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEBC")]
		[Address(RVA = "0x1AD59F8", Offset = "0x1AD59F8", VA = "0x7BBC2D59F8")]
		public UIEPWeeklyTaskDetailItemView()
		{
		}

		// Token: 0x0400CB83 RID: 52099
		[Token(Token = "0x400CB83")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Title;

		// Token: 0x0400CB84 RID: 52100
		[Token(Token = "0x400CB84")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Desc;

		// Token: 0x0400CB85 RID: 52101
		[Token(Token = "0x400CB85")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Process;

		// Token: 0x0400CB86 RID: 52102
		[Token(Token = "0x400CB86")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid AwardList;

		// Token: 0x0400CB87 RID: 52103
		[Token(Token = "0x400CB87")]
		[FieldOffset(Offset = "0x40")]
		public UIButton Operation;

		// Token: 0x0400CB88 RID: 52104
		[Token(Token = "0x400CB88")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BGReceived;

		// Token: 0x0400CB89 RID: 52105
		[Token(Token = "0x400CB89")]
		[FieldOffset(Offset = "0x50")]
		public GameObject BGAwarded;

		// Token: 0x0400CB8A RID: 52106
		[Token(Token = "0x400CB8A")]
		[FieldOffset(Offset = "0x58")]
		public UISprite BGFnished;
	}
}
