using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021D3 RID: 8659
	[Token(Token = "0x20021D3")]
	public class UIEPTaskMainView : UIBaseView
	{
		// Token: 0x0600BEB7 RID: 48823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEB7")]
		[Address(RVA = "0x1AD132C", Offset = "0x1AD132C", VA = "0x7BBC2D132C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEB8 RID: 48824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEB8")]
		[Address(RVA = "0x1AD144C", Offset = "0x1AD144C", VA = "0x7BBC2D144C")]
		public UIEPTaskMainView()
		{
		}

		// Token: 0x0400CB79 RID: 52089
		[Token(Token = "0x400CB79")]
		[FieldOffset(Offset = "0x20")]
		public Transform TopTabContainer;

		// Token: 0x0400CB7A RID: 52090
		[Token(Token = "0x400CB7A")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Content;

		// Token: 0x0400CB7B RID: 52091
		[Token(Token = "0x400CB7B")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BG;
	}
}
