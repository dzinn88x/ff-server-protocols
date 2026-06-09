using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200237A RID: 9082
	[Token(Token = "0x200237A")]
	internal class UIHudTeammatesInfoView : UIBaseView
	{
		// Token: 0x0600C204 RID: 49668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C204")]
		[Address(RVA = "0x15E5774", Offset = "0x15E5774", VA = "0x7BBBDE5774", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C205 RID: 49669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C205")]
		[Address(RVA = "0x15E5864", Offset = "0x15E5864", VA = "0x7BBBDE5864")]
		public UIHudTeammatesInfoView()
		{
		}

		// Token: 0x0400DC5B RID: 56411
		[Token(Token = "0x400DC5B")]
		[FieldOffset(Offset = "0x20")]
		public Transform Grid;

		// Token: 0x0400DC5C RID: 56412
		[Token(Token = "0x400DC5C")]
		[FieldOffset(Offset = "0x28")]
		public UIHudTeammateItem TeammateTemplate;
	}
}
