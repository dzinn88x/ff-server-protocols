using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002583 RID: 9603
	[Token(Token = "0x2002583")]
	internal class UIVersionView : UIBaseView
	{
		// Token: 0x0600C616 RID: 50710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C616")]
		[Address(RVA = "0x1A09E18", Offset = "0x1A09E18", VA = "0x7BBC209E18", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C617 RID: 50711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C617")]
		[Address(RVA = "0x1A09EB4", Offset = "0x1A09EB4", VA = "0x7BBC209EB4")]
		public UIVersionView()
		{
		}

		// Token: 0x0400F6E3 RID: 63203
		[Token(Token = "0x400F6E3")]
		[FieldOffset(Offset = "0x20")]
		public UILabel VersionInfo;
	}
}
