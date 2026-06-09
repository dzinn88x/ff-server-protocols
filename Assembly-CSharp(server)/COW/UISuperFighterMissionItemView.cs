using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200256C RID: 9580
	[Token(Token = "0x200256C")]
	public class UISuperFighterMissionItemView : UIBaseView
	{
		// Token: 0x0600C5E8 RID: 50664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5E8")]
		[Address(RVA = "0x1F4D690", Offset = "0x1F4D690", VA = "0x7BBC74D690", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5E9 RID: 50665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5E9")]
		[Address(RVA = "0x1F4D878", Offset = "0x1F4D878", VA = "0x7BBC74D878")]
		public UISuperFighterMissionItemView()
		{
		}

		// Token: 0x0400F603 RID: 62979
		[Token(Token = "0x400F603")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Desc;

		// Token: 0x0400F604 RID: 62980
		[Token(Token = "0x400F604")]
		[FieldOffset(Offset = "0x28")]
		public Transform AwardContainer;

		// Token: 0x0400F605 RID: 62981
		[Token(Token = "0x400F605")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Progress;

		// Token: 0x0400F606 RID: 62982
		[Token(Token = "0x400F606")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnClaim;

		// Token: 0x0400F607 RID: 62983
		[Token(Token = "0x400F607")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnClaimUnfinished;

		// Token: 0x0400F608 RID: 62984
		[Token(Token = "0x400F608")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Claimed;
	}
}
