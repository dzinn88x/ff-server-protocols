using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002509 RID: 9481
	[Token(Token = "0x2002509")]
	public class UISPHudCSTeamInfoView : UIBaseView
	{
		// Token: 0x0600C523 RID: 50467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C523")]
		[Address(RVA = "0x1EE3A50", Offset = "0x1EE3A50", VA = "0x7BBC6E3A50", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C524 RID: 50468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C524")]
		[Address(RVA = "0x1EE3A48", Offset = "0x1EE3A48", VA = "0x7BBC6E3A48")]
		public UISPHudCSTeamInfoView()
		{
		}

		// Token: 0x0400F1D4 RID: 61908
		[Token(Token = "0x400F1D4")]
		[FieldOffset(Offset = "0x20")]
		public TweenPosition TWPosition;

		// Token: 0x0400F1D5 RID: 61909
		[Token(Token = "0x400F1D5")]
		[FieldOffset(Offset = "0x28")]
		public UILabel GrenadeNum;

		// Token: 0x0400F1D6 RID: 61910
		[Token(Token = "0x400F1D6")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LandmineNum;

		// Token: 0x0400F1D7 RID: 61911
		[Token(Token = "0x400F1D7")]
		[FieldOffset(Offset = "0x38")]
		public UILabel BuildingNum;

		// Token: 0x0400F1D8 RID: 61912
		[Token(Token = "0x400F1D8")]
		[FieldOffset(Offset = "0x40")]
		public UILabel MedkitNum;

		// Token: 0x0400F1D9 RID: 61913
		[Token(Token = "0x400F1D9")]
		[FieldOffset(Offset = "0x48")]
		public UIGrid TeammateGrid;
	}
}
