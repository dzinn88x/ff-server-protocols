using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002538 RID: 9528
	[Token(Token = "0x2002538")]
	internal class UISPHudSideMapView : UIBaseView
	{
		// Token: 0x0600C580 RID: 50560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C580")]
		[Address(RVA = "0x1EF3C24", Offset = "0x1EF3C24", VA = "0x7BBC6F3C24", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C581 RID: 50561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C581")]
		[Address(RVA = "0x1EF3D44", Offset = "0x1EF3D44", VA = "0x7BBC6F3D44")]
		public UISPHudSideMapView()
		{
		}

		// Token: 0x0400F383 RID: 62339
		[Token(Token = "0x400F383")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400F384 RID: 62340
		[Token(Token = "0x400F384")]
		[FieldOffset(Offset = "0x28")]
		public TweenPosition TweenPostion;

		// Token: 0x0400F385 RID: 62341
		[Token(Token = "0x400F385")]
		[FieldOffset(Offset = "0x30")]
		public UIPanel MapContainer;
	}
}
