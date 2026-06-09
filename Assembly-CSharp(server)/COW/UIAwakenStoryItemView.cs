using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002115 RID: 8469
	[Token(Token = "0x2002115")]
	public class UIAwakenStoryItemView : UIBaseView
	{
		// Token: 0x0600BD3B RID: 48443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD3B")]
		[Address(RVA = "0x141D5BC", Offset = "0x141D5BC", VA = "0x7BBBC1D5BC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD3C RID: 48444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD3C")]
		[Address(RVA = "0x141D6AC", Offset = "0x141D6AC", VA = "0x7BBBC1D6AC")]
		public UIAwakenStoryItemView()
		{
		}

		// Token: 0x0400C1CD RID: 49613
		[Token(Token = "0x400C1CD")]
		[FieldOffset(Offset = "0x20")]
		public UIAvatarAwakenStoryItemController UIAwakenStoryItem;

		// Token: 0x0400C1CE RID: 49614
		[Token(Token = "0x400C1CE")]
		[FieldOffset(Offset = "0x28")]
		public Animation itemAnim;
	}
}
