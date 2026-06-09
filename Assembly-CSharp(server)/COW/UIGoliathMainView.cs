using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002241 RID: 8769
	[Token(Token = "0x2002241")]
	public class UIGoliathMainView : UIBaseView
	{
		// Token: 0x0600BF93 RID: 49043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF93")]
		[Address(RVA = "0x1A7D98C", Offset = "0x1A7D98C", VA = "0x7BBC27D98C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF94 RID: 49044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF94")]
		[Address(RVA = "0x1A7E4A0", Offset = "0x1A7E4A0", VA = "0x7BBC27E4A0")]
		public UIGoliathMainView()
		{
		}

		// Token: 0x0400D1DE RID: 53726
		[Token(Token = "0x400D1DE")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400D1DF RID: 53727
		[Token(Token = "0x400D1DF")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Content;

		// Token: 0x0400D1E0 RID: 53728
		[Token(Token = "0x400D1E0")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnRule;

		// Token: 0x0400D1E1 RID: 53729
		[Token(Token = "0x400D1E1")]
		[FieldOffset(Offset = "0x38")]
		public UILabel TimeLabel;

		// Token: 0x0400D1E2 RID: 53730
		[Token(Token = "0x400D1E2")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnPeakDay;

		// Token: 0x0400D1E3 RID: 53731
		[Token(Token = "0x400D1E3")]
		[FieldOffset(Offset = "0x48")]
		public GameObject PeakDayTips;

		// Token: 0x0400D1E4 RID: 53732
		[Token(Token = "0x400D1E4")]
		[FieldOffset(Offset = "0x50")]
		public UILabel PeakDayBubble;

		// Token: 0x0400D1E5 RID: 53733
		[Token(Token = "0x400D1E5")]
		[FieldOffset(Offset = "0x58")]
		public UIButton BtnWeb;

		// Token: 0x0400D1E6 RID: 53734
		[Token(Token = "0x400D1E6")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnToken;

		// Token: 0x0400D1E7 RID: 53735
		[Token(Token = "0x400D1E7")]
		[FieldOffset(Offset = "0x68")]
		public UISprite TokenIcon;

		// Token: 0x0400D1E8 RID: 53736
		[Token(Token = "0x400D1E8")]
		[FieldOffset(Offset = "0x70")]
		public UILabel TokenNum;

		// Token: 0x0400D1E9 RID: 53737
		[Token(Token = "0x400D1E9")]
		[FieldOffset(Offset = "0x78")]
		public Transform TipsContainer;

		// Token: 0x0400D1EA RID: 53738
		[Token(Token = "0x400D1EA")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BtnAddFriend;

		// Token: 0x0400D1EB RID: 53739
		[Token(Token = "0x400D1EB")]
		[FieldOffset(Offset = "0x88")]
		public UIButton BtnInviteGroup;

		// Token: 0x0400D1EC RID: 53740
		[Token(Token = "0x400D1EC")]
		[FieldOffset(Offset = "0x90")]
		public UILabel MemberName;

		// Token: 0x0400D1ED RID: 53741
		[Token(Token = "0x400D1ED")]
		[FieldOffset(Offset = "0x98")]
		public UIButton BtnAddFriend1;

		// Token: 0x0400D1EE RID: 53742
		[Token(Token = "0x400D1EE")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton BtnInviteGroup1;

		// Token: 0x0400D1EF RID: 53743
		[Token(Token = "0x400D1EF")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel LabelInviteCaption;

		// Token: 0x0400D1F0 RID: 53744
		[Token(Token = "0x400D1F0")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel MemberName1;

		// Token: 0x0400D1F1 RID: 53745
		[Token(Token = "0x400D1F1")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton BtnAddFriend2;

		// Token: 0x0400D1F2 RID: 53746
		[Token(Token = "0x400D1F2")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton BtnInviteGroup2;

		// Token: 0x0400D1F3 RID: 53747
		[Token(Token = "0x400D1F3")]
		[FieldOffset(Offset = "0xC8")]
		public UIWidget InviteGuideRegion;

		// Token: 0x0400D1F4 RID: 53748
		[Token(Token = "0x400D1F4")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel MemberName2;

		// Token: 0x0400D1F5 RID: 53749
		[Token(Token = "0x400D1F5")]
		[FieldOffset(Offset = "0xD8")]
		public UIButton BtnAddFriend3;

		// Token: 0x0400D1F6 RID: 53750
		[Token(Token = "0x400D1F6")]
		[FieldOffset(Offset = "0xE0")]
		public UIButton BtnInviteGroup3;

		// Token: 0x0400D1F7 RID: 53751
		[Token(Token = "0x400D1F7")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel MemberName3;

		// Token: 0x0400D1F8 RID: 53752
		[Token(Token = "0x400D1F8")]
		[FieldOffset(Offset = "0xF0")]
		public UIWidget LeftGuideRegion;

		// Token: 0x0400D1F9 RID: 53753
		[Token(Token = "0x400D1F9")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel GroupName;

		// Token: 0x0400D1FA RID: 53754
		[Token(Token = "0x400D1FA")]
		[FieldOffset(Offset = "0x100")]
		public UIWidget Right;

		// Token: 0x0400D1FB RID: 53755
		[Token(Token = "0x400D1FB")]
		[FieldOffset(Offset = "0x108")]
		public UIButton BtnGroup;

		// Token: 0x0400D1FC RID: 53756
		[Token(Token = "0x400D1FC")]
		[FieldOffset(Offset = "0x110")]
		public GameObject GroupSelect;

		// Token: 0x0400D1FD RID: 53757
		[Token(Token = "0x400D1FD")]
		[FieldOffset(Offset = "0x118")]
		public GameObject GroupNormal;

		// Token: 0x0400D1FE RID: 53758
		[Token(Token = "0x400D1FE")]
		[FieldOffset(Offset = "0x120")]
		public UIButton BtnStore;

		// Token: 0x0400D1FF RID: 53759
		[Token(Token = "0x400D1FF")]
		[FieldOffset(Offset = "0x128")]
		public GameObject StoreSelect;

		// Token: 0x0400D200 RID: 53760
		[Token(Token = "0x400D200")]
		[FieldOffset(Offset = "0x130")]
		public GameObject StoreNormal;

		// Token: 0x0400D201 RID: 53761
		[Token(Token = "0x400D201")]
		[FieldOffset(Offset = "0x138")]
		public UIWidget StoreTabGuideRegion;

		// Token: 0x0400D202 RID: 53762
		[Token(Token = "0x400D202")]
		[FieldOffset(Offset = "0x140")]
		public GameObject GroupPage;

		// Token: 0x0400D203 RID: 53763
		[Token(Token = "0x400D203")]
		[FieldOffset(Offset = "0x148")]
		public Transform MainPos;

		// Token: 0x0400D204 RID: 53764
		[Token(Token = "0x400D204")]
		[FieldOffset(Offset = "0x150")]
		public Transform SecondPos;

		// Token: 0x0400D205 RID: 53765
		[Token(Token = "0x400D205")]
		[FieldOffset(Offset = "0x158")]
		public Transform ThirdPos;

		// Token: 0x0400D206 RID: 53766
		[Token(Token = "0x400D206")]
		[FieldOffset(Offset = "0x160")]
		public GameObject StorePage;

		// Token: 0x0400D207 RID: 53767
		[Token(Token = "0x400D207")]
		[FieldOffset(Offset = "0x168")]
		public UIEasyList StoreEasyList;

		// Token: 0x0400D208 RID: 53768
		[Token(Token = "0x400D208")]
		[FieldOffset(Offset = "0x170")]
		public UIWidget RightGuideGegion;

		// Token: 0x0400D209 RID: 53769
		[Token(Token = "0x400D209")]
		[FieldOffset(Offset = "0x178")]
		public UIWidget GuideMask;

		// Token: 0x0400D20A RID: 53770
		[Token(Token = "0x400D20A")]
		[FieldOffset(Offset = "0x180")]
		public UILabel GuideDesc;

		// Token: 0x0400D20B RID: 53771
		[Token(Token = "0x400D20B")]
		[FieldOffset(Offset = "0x188")]
		public Transform GuideDescFrame;

		// Token: 0x0400D20C RID: 53772
		[Token(Token = "0x400D20C")]
		[FieldOffset(Offset = "0x190")]
		public UITexture MaskBg;

		// Token: 0x0400D20D RID: 53773
		[Token(Token = "0x400D20D")]
		[FieldOffset(Offset = "0x198")]
		public GameObject Mask;
	}
}
