using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002107 RID: 8455
	[Token(Token = "0x2002107")]
	public class UIAvatarProfileNavigationView : UIBaseView
	{
		// Token: 0x0600BD1F RID: 48415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD1F")]
		[Address(RVA = "0x1E45B40", Offset = "0x1E45B40", VA = "0x7BBC645B40", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD20 RID: 48416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD20")]
		[Address(RVA = "0x1E45FE0", Offset = "0x1E45FE0", VA = "0x7BBC645FE0")]
		public UIAvatarProfileNavigationView()
		{
		}

		// Token: 0x0400C0BE RID: 49342
		[Token(Token = "0x400C0BE")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel AvatarPanel;

		// Token: 0x0400C0BF RID: 49343
		[Token(Token = "0x400C0BF")]
		[FieldOffset(Offset = "0x28")]
		public GameObject tweenNodeBtn;

		// Token: 0x0400C0C0 RID: 49344
		[Token(Token = "0x400C0C0")]
		[FieldOffset(Offset = "0x30")]
		public UITable AvatarTableGroup;

		// Token: 0x0400C0C1 RID: 49345
		[Token(Token = "0x400C0C1")]
		[FieldOffset(Offset = "0x38")]
		public GameObject GainAvatar;

		// Token: 0x0400C0C2 RID: 49346
		[Token(Token = "0x400C0C2")]
		[FieldOffset(Offset = "0x40")]
		public UIButton GainAvatarBtn;

		// Token: 0x0400C0C3 RID: 49347
		[Token(Token = "0x400C0C3")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ExpireInfo;

		// Token: 0x0400C0C4 RID: 49348
		[Token(Token = "0x400C0C4")]
		[FieldOffset(Offset = "0x50")]
		public UILabel ExpireTime;

		// Token: 0x0400C0C5 RID: 49349
		[Token(Token = "0x400C0C5")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ExpireState1;

		// Token: 0x0400C0C6 RID: 49350
		[Token(Token = "0x400C0C6")]
		[FieldOffset(Offset = "0x60")]
		public GameObject ExpireState2;

		// Token: 0x0400C0C7 RID: 49351
		[Token(Token = "0x400C0C7")]
		[FieldOffset(Offset = "0x68")]
		public UIButton InUseSelectBtn1;

		// Token: 0x0400C0C8 RID: 49352
		[Token(Token = "0x400C0C8")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Inuse;

		// Token: 0x0400C0C9 RID: 49353
		[Token(Token = "0x400C0C9")]
		[FieldOffset(Offset = "0x78")]
		public GameObject InuseState1;

		// Token: 0x0400C0CA RID: 49354
		[Token(Token = "0x400C0CA")]
		[FieldOffset(Offset = "0x80")]
		public GameObject InuseState2;

		// Token: 0x0400C0CB RID: 49355
		[Token(Token = "0x400C0CB")]
		[FieldOffset(Offset = "0x88")]
		public UIButton InUseSelectBtn;

		// Token: 0x0400C0CC RID: 49356
		[Token(Token = "0x400C0CC")]
		[FieldOffset(Offset = "0x90")]
		public GameObject TopContainer;

		// Token: 0x0400C0CD RID: 49357
		[Token(Token = "0x400C0CD")]
		[FieldOffset(Offset = "0x98")]
		public UIButton VaultBtn;

		// Token: 0x0400C0CE RID: 49358
		[Token(Token = "0x400C0CE")]
		[FieldOffset(Offset = "0xA0")]
		public Transform RecommendTr;

		// Token: 0x0400C0CF RID: 49359
		[Token(Token = "0x400C0CF")]
		[FieldOffset(Offset = "0xA8")]
		public Transform LeftContainer;
	}
}
