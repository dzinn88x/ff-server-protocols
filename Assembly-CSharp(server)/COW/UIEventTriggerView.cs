using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021DC RID: 8668
	[Token(Token = "0x20021DC")]
	public class UIEventTriggerView : UIBaseView
	{
		// Token: 0x0600BEC9 RID: 48841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEC9")]
		[Address(RVA = "0x1E7D880", Offset = "0x1E7D880", VA = "0x7BBC67D880", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BECA RID: 48842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BECA")]
		[Address(RVA = "0x1E7D9F4", Offset = "0x1E7D9F4", VA = "0x7BBC67D9F4")]
		public UIEventTriggerView()
		{
		}

		// Token: 0x0400CBDC RID: 52188
		[Token(Token = "0x400CBDC")]
		[FieldOffset(Offset = "0x20")]
		public UISprite triggerImg;

		// Token: 0x0400CBDD RID: 52189
		[Token(Token = "0x400CBDD")]
		[FieldOffset(Offset = "0x28")]
		public UISprite triggerBG;

		// Token: 0x0400CBDE RID: 52190
		[Token(Token = "0x400CBDE")]
		[FieldOffset(Offset = "0x30")]
		public TweenAlpha TweenAlphaBg;

		// Token: 0x0400CBDF RID: 52191
		[Token(Token = "0x400CBDF")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Distance;
	}
}
