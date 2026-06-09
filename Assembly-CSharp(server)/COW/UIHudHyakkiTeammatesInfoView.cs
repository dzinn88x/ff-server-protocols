using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022E5 RID: 8933
	[Token(Token = "0x20022E5")]
	internal class UIHudHyakkiTeammatesInfoView : UIBaseView
	{
		// Token: 0x0600C0DA RID: 49370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0DA")]
		[Address(RVA = "0x19843C8", Offset = "0x19843C8", VA = "0x7BBC1843C8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0DB RID: 49371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0DB")]
		[Address(RVA = "0x19844B8", Offset = "0x19844B8", VA = "0x7BBC1844B8")]
		public UIHudHyakkiTeammatesInfoView()
		{
		}

		// Token: 0x0400D706 RID: 55046
		[Token(Token = "0x400D706")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid Grid;

		// Token: 0x0400D707 RID: 55047
		[Token(Token = "0x400D707")]
		[FieldOffset(Offset = "0x28")]
		public UIHudHyakkiTeammateItem TeammateTemplate;
	}
}
