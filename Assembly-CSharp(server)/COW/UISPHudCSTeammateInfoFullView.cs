using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200250B RID: 9483
	[Token(Token = "0x200250B")]
	public class UISPHudCSTeammateInfoFullView : UIBaseView
	{
		// Token: 0x0600C526 RID: 50470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C526")]
		[Address(RVA = "0x1EE4858", Offset = "0x1EE4858", VA = "0x7BBC6E4858", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C527 RID: 50471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C527")]
		[Address(RVA = "0x1EE4850", Offset = "0x1EE4850", VA = "0x7BBC6E4850")]
		public UISPHudCSTeammateInfoFullView()
		{
		}

		// Token: 0x0400F1DA RID: 61914
		[Token(Token = "0x400F1DA")]
		[FieldOffset(Offset = "0x20")]
		public UISPHudCSTeammateInfoDetailView DetailView;

		// Token: 0x0400F1DB RID: 61915
		[Token(Token = "0x400F1DB")]
		[FieldOffset(Offset = "0x28")]
		public UILabel MedkitCount;

		// Token: 0x0400F1DC RID: 61916
		[Token(Token = "0x400F1DC")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LandmineCount;

		// Token: 0x0400F1DD RID: 61917
		[Token(Token = "0x400F1DD")]
		[FieldOffset(Offset = "0x38")]
		public UILabel GrenadeCount;

		// Token: 0x0400F1DE RID: 61918
		[Token(Token = "0x400F1DE")]
		[FieldOffset(Offset = "0x40")]
		public UILabel IceWallCount;
	}
}
