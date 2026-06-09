using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021B2 RID: 8626
	[Token(Token = "0x20021B2")]
	public class UIElitePassChallengeItemView : UIBaseView
	{
		// Token: 0x0600BE74 RID: 48756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE74")]
		[Address(RVA = "0x1AE5BB4", Offset = "0x1AE5BB4", VA = "0x7BBC2E5BB4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE75 RID: 48757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE75")]
		[Address(RVA = "0x1AE609C", Offset = "0x1AE609C", VA = "0x7BBC2E609C")]
		public UIElitePassChallengeItemView()
		{
		}

		// Token: 0x0400C9E6 RID: 51686
		[Token(Token = "0x400C9E6")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BG_Light;

		// Token: 0x0400C9E7 RID: 51687
		[Token(Token = "0x400C9E7")]
		[FieldOffset(Offset = "0x28")]
		public UISprite ItemBg1;

		// Token: 0x0400C9E8 RID: 51688
		[Token(Token = "0x400C9E8")]
		[FieldOffset(Offset = "0x30")]
		public GameObject BG_Dark;

		// Token: 0x0400C9E9 RID: 51689
		[Token(Token = "0x400C9E9")]
		[FieldOffset(Offset = "0x38")]
		public UISprite ItemBg2;

		// Token: 0x0400C9EA RID: 51690
		[Token(Token = "0x400C9EA")]
		[FieldOffset(Offset = "0x40")]
		public GameObject BgSpeical;

		// Token: 0x0400C9EB RID: 51691
		[Token(Token = "0x400C9EB")]
		[FieldOffset(Offset = "0x48")]
		public UIButton TeamWorkBtn;

		// Token: 0x0400C9EC RID: 51692
		[Token(Token = "0x400C9EC")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Desc;

		// Token: 0x0400C9ED RID: 51693
		[Token(Token = "0x400C9ED")]
		[FieldOffset(Offset = "0x58")]
		public UIProgressBar ProgressBar;

		// Token: 0x0400C9EE RID: 51694
		[Token(Token = "0x400C9EE")]
		[FieldOffset(Offset = "0x60")]
		public UILabel ProcessLabel;

		// Token: 0x0400C9EF RID: 51695
		[Token(Token = "0x400C9EF")]
		[FieldOffset(Offset = "0x68")]
		public UIButton ClaimBtn;

		// Token: 0x0400C9F0 RID: 51696
		[Token(Token = "0x400C9F0")]
		[FieldOffset(Offset = "0x70")]
		public GameObject CanClaimNotEP;

		// Token: 0x0400C9F1 RID: 51697
		[Token(Token = "0x400C9F1")]
		[FieldOffset(Offset = "0x78")]
		public GameObject CanClaim;

		// Token: 0x0400C9F2 RID: 51698
		[Token(Token = "0x400C9F2")]
		[FieldOffset(Offset = "0x80")]
		public GameObject ClaimNormalBg;

		// Token: 0x0400C9F3 RID: 51699
		[Token(Token = "0x400C9F3")]
		[FieldOffset(Offset = "0x88")]
		public GameObject ClaimGreyBg;

		// Token: 0x0400C9F4 RID: 51700
		[Token(Token = "0x400C9F4")]
		[FieldOffset(Offset = "0x90")]
		public GameObject PurchaseEP;

		// Token: 0x0400C9F5 RID: 51701
		[Token(Token = "0x400C9F5")]
		[FieldOffset(Offset = "0x98")]
		public UIButton GotoEpBtn;

		// Token: 0x0400C9F6 RID: 51702
		[Token(Token = "0x400C9F6")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject LockLabel;

		// Token: 0x0400C9F7 RID: 51703
		[Token(Token = "0x400C9F7")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject ClaimedLabel;

		// Token: 0x0400C9F8 RID: 51704
		[Token(Token = "0x400C9F8")]
		[FieldOffset(Offset = "0xB0")]
		public UIGrid RewardList;
	}
}
