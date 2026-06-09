using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002352 RID: 9042
	[Token(Token = "0x2002352")]
	internal class UIHudReloadView : UIBaseView
	{
		// Token: 0x0600C1B4 RID: 49588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1B4")]
		[Address(RVA = "0x17F25E0", Offset = "0x17F25E0", VA = "0x7BBBFF25E0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1B5 RID: 49589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1B5")]
		[Address(RVA = "0x17F2700", Offset = "0x17F2700", VA = "0x7BBBFF2700")]
		public UIHudReloadView()
		{
		}

		// Token: 0x0400DAFA RID: 56058
		[Token(Token = "0x400DAFA")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnReload;

		// Token: 0x0400DAFB RID: 56059
		[Token(Token = "0x400DAFB")]
		[FieldOffset(Offset = "0x28")]
		public UILabel LabelNormal;

		// Token: 0x0400DAFC RID: 56060
		[Token(Token = "0x400DAFC")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ReloadWarning;
	}
}
