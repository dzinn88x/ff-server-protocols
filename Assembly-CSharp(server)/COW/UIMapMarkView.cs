using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002431 RID: 9265
	[Token(Token = "0x2002431")]
	internal class UIMapMarkView : UIBaseView
	{
		// Token: 0x0600C372 RID: 50034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C372")]
		[Address(RVA = "0x146AD14", Offset = "0x146AD14", VA = "0x7BBBC6AD14", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C373 RID: 50035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C373")]
		[Address(RVA = "0x146ADB0", Offset = "0x146ADB0", VA = "0x7BBBC6ADB0")]
		public UIMapMarkView()
		{
		}

		// Token: 0x0400E6B0 RID: 59056
		[Token(Token = "0x400E6B0")]
		[FieldOffset(Offset = "0x20")]
		public UISprite Mark;
	}
}
