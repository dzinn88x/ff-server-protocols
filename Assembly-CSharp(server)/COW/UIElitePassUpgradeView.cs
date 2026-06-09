using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021C2 RID: 8642
	[Token(Token = "0x20021C2")]
	public class UIElitePassUpgradeView : UIBaseView
	{
		// Token: 0x0600BE94 RID: 48788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE94")]
		[Address(RVA = "0x1E73224", Offset = "0x1E73224", VA = "0x7BBC673224", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE95 RID: 48789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE95")]
		[Address(RVA = "0x1E73680", Offset = "0x1E73680", VA = "0x7BBC673680")]
		public UIElitePassUpgradeView()
		{
		}

		// Token: 0x0400CAE0 RID: 51936
		[Token(Token = "0x400CAE0")]
		[FieldOffset(Offset = "0x20")]
		public UINetworkTexture CDNTexture_Left;

		// Token: 0x0400CAE1 RID: 51937
		[Token(Token = "0x400CAE1")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTexture CDNTexture_Right;

		// Token: 0x0400CAE2 RID: 51938
		[Token(Token = "0x400CAE2")]
		[FieldOffset(Offset = "0x30")]
		public BaseItemView UpgradeSprite;

		// Token: 0x0400CAE3 RID: 51939
		[Token(Token = "0x400CAE3")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Desc5;

		// Token: 0x0400CAE4 RID: 51940
		[Token(Token = "0x400CAE4")]
		[FieldOffset(Offset = "0x40")]
		public UILabel BadgeCount;

		// Token: 0x0400CAE5 RID: 51941
		[Token(Token = "0x400CAE5")]
		[FieldOffset(Offset = "0x48")]
		public UISprite Badge;

		// Token: 0x0400CAE6 RID: 51942
		[Token(Token = "0x400CAE6")]
		[FieldOffset(Offset = "0x50")]
		public UIScrollView RewardDisplay;

		// Token: 0x0400CAE7 RID: 51943
		[Token(Token = "0x400CAE7")]
		[FieldOffset(Offset = "0x58")]
		public UIGrid RewardGrid;

		// Token: 0x0400CAE8 RID: 51944
		[Token(Token = "0x400CAE8")]
		[FieldOffset(Offset = "0x60")]
		public UILabel RewardNum;

		// Token: 0x0400CAE9 RID: 51945
		[Token(Token = "0x400CAE9")]
		[FieldOffset(Offset = "0x68")]
		public UILabel Subtitle;

		// Token: 0x0400CAEA RID: 51946
		[Token(Token = "0x400CAEA")]
		[FieldOffset(Offset = "0x70")]
		public UIButton UpgradeBtn;

		// Token: 0x0400CAEB RID: 51947
		[Token(Token = "0x400CAEB")]
		[FieldOffset(Offset = "0x78")]
		public UILabel NormalPrice;

		// Token: 0x0400CAEC RID: 51948
		[Token(Token = "0x400CAEC")]
		[FieldOffset(Offset = "0x80")]
		public UILabel DiscountLabel;

		// Token: 0x0400CAED RID: 51949
		[Token(Token = "0x400CAED")]
		[FieldOffset(Offset = "0x88")]
		public UIButton BundleUpgradeBtn;

		// Token: 0x0400CAEE RID: 51950
		[Token(Token = "0x400CAEE")]
		[FieldOffset(Offset = "0x90")]
		public UILabel BundleOriginalPrice;

		// Token: 0x0400CAEF RID: 51951
		[Token(Token = "0x400CAEF")]
		[FieldOffset(Offset = "0x98")]
		public UILabel BundlePrice;
	}
}
