using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002519 RID: 9497
	[Token(Token = "0x2002519")]
	internal class UISPHudMoveDownView : UIBaseView
	{
		// Token: 0x0600C542 RID: 50498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C542")]
		[Address(RVA = "0x1EEA2B8", Offset = "0x1EEA2B8", VA = "0x7BBC6EA2B8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C543 RID: 50499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C543")]
		[Address(RVA = "0x1EEA3D0", Offset = "0x1EEA3D0", VA = "0x7BBC6EA3D0")]
		public UISPHudMoveDownView()
		{
		}

		// Token: 0x0400F286 RID: 62086
		[Token(Token = "0x400F286")]
		[FieldOffset(Offset = "0x20")]
		public UIButton btnSpeedup;

		// Token: 0x0400F287 RID: 62087
		[Token(Token = "0x400F287")]
		[FieldOffset(Offset = "0x28")]
		public UISprite normal;

		// Token: 0x0400F288 RID: 62088
		[Token(Token = "0x400F288")]
		[FieldOffset(Offset = "0x30")]
		public UISprite icon;
	}
}
