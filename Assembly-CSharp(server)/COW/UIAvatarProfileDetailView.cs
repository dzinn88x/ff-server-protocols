using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002104 RID: 8452
	[Token(Token = "0x2002104")]
	public class UIAvatarProfileDetailView : UIBaseView
	{
		// Token: 0x0600BD19 RID: 48409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD19")]
		[Address(RVA = "0x208AF8C", Offset = "0x208AF8C", VA = "0x7BBC88AF8C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD1A RID: 48410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD1A")]
		[Address(RVA = "0x208B1AC", Offset = "0x208B1AC", VA = "0x7BBC88B1AC")]
		public UIAvatarProfileDetailView()
		{
		}

		// Token: 0x0400C090 RID: 49296
		[Token(Token = "0x400C090")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel MainWidget;

		// Token: 0x0400C091 RID: 49297
		[Token(Token = "0x400C091")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList EasyList;

		// Token: 0x0400C092 RID: 49298
		[Token(Token = "0x400C092")]
		[FieldOffset(Offset = "0x30")]
		public UIButton TipBtn;

		// Token: 0x0400C093 RID: 49299
		[Token(Token = "0x400C093")]
		[FieldOffset(Offset = "0x38")]
		public UIButton UseUpgradeCardBtn;

		// Token: 0x0400C094 RID: 49300
		[Token(Token = "0x400C094")]
		[FieldOffset(Offset = "0x40")]
		public UILabel AvatarInfo;

		// Token: 0x0400C095 RID: 49301
		[Token(Token = "0x400C095")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ExpireInfo;

		// Token: 0x0400C096 RID: 49302
		[Token(Token = "0x400C096")]
		[FieldOffset(Offset = "0x50")]
		public UILabel MaxLvlLabel;
	}
}
