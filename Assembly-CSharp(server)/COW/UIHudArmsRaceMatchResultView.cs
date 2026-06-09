using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002269 RID: 8809
	[Token(Token = "0x2002269")]
	public class UIHudArmsRaceMatchResultView : UIBaseView
	{
		// Token: 0x0600BFE3 RID: 49123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFE3")]
		[Address(RVA = "0x1886A28", Offset = "0x1886A28", VA = "0x7BBC086A28", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFE4 RID: 49124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFE4")]
		[Address(RVA = "0x1886B8C", Offset = "0x1886B8C", VA = "0x7BBC086B8C")]
		public UIHudArmsRaceMatchResultView()
		{
		}

		// Token: 0x0400D388 RID: 54152
		[Token(Token = "0x400D388")]
		[FieldOffset(Offset = "0x20")]
		public GameObject CallSignContainer;

		// Token: 0x0400D389 RID: 54153
		[Token(Token = "0x400D389")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnShare;

		// Token: 0x0400D38A RID: 54154
		[Token(Token = "0x400D38A")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnNext;

		// Token: 0x0400D38B RID: 54155
		[Token(Token = "0x400D38B")]
		[FieldOffset(Offset = "0x38")]
		public UIEasyList EasyList;
	}
}
