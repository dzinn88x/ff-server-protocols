using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200226D RID: 8813
	[Token(Token = "0x200226D")]
	public class UIHUDArmsRaceTopLevelWarningView : UIBaseView
	{
		// Token: 0x0600BFEB RID: 49131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFEB")]
		[Address(RVA = "0x16B5CA8", Offset = "0x16B5CA8", VA = "0x7BBBEB5CA8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFEC RID: 49132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFEC")]
		[Address(RVA = "0x16B5D98", Offset = "0x16B5D98", VA = "0x7BBBEB5D98")]
		public UIHUDArmsRaceTopLevelWarningView()
		{
		}

		// Token: 0x0400D3A8 RID: 54184
		[Token(Token = "0x400D3A8")]
		[FieldOffset(Offset = "0x20")]
		public GameObject InfoContainer;

		// Token: 0x0400D3A9 RID: 54185
		[Token(Token = "0x400D3A9")]
		[FieldOffset(Offset = "0x28")]
		public UILabel WarningText;
	}
}
