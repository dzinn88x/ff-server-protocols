using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200250C RID: 9484
	[Token(Token = "0x200250C")]
	public class UISPHudCSTeammateInfoRightFullView : UIBaseView
	{
		// Token: 0x0600C528 RID: 50472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C528")]
		[Address(RVA = "0x1EE49DC", Offset = "0x1EE49DC", VA = "0x7BBC6E49DC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C529 RID: 50473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C529")]
		[Address(RVA = "0x1EE4B60", Offset = "0x1EE4B60", VA = "0x7BBC6E4B60")]
		public UISPHudCSTeammateInfoRightFullView()
		{
		}

		// Token: 0x0400F1DF RID: 61919
		[Token(Token = "0x400F1DF")]
		[FieldOffset(Offset = "0x20")]
		public UISPHudCSTeammateInfoDetailView DetailView;

		// Token: 0x0400F1E0 RID: 61920
		[Token(Token = "0x400F1E0")]
		[FieldOffset(Offset = "0x28")]
		public UILabel MedkitCount;

		// Token: 0x0400F1E1 RID: 61921
		[Token(Token = "0x400F1E1")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LandmineCount;

		// Token: 0x0400F1E2 RID: 61922
		[Token(Token = "0x400F1E2")]
		[FieldOffset(Offset = "0x38")]
		public UILabel GrenadeCount;

		// Token: 0x0400F1E3 RID: 61923
		[Token(Token = "0x400F1E3")]
		[FieldOffset(Offset = "0x40")]
		public UILabel IceWallCount;
	}
}
