using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021FA RID: 8698
	[Token(Token = "0x20021FA")]
	public class UIFriendItemView : UIBaseView
	{
		// Token: 0x0600BF05 RID: 48901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF05")]
		[Address(RVA = "0x1592B18", Offset = "0x1592B18", VA = "0x7BBBD92B18", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF06 RID: 48902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF06")]
		[Address(RVA = "0x159360C", Offset = "0x159360C", VA = "0x7BBBD9360C")]
		public UIFriendItemView()
		{
		}

		// Token: 0x0400CD95 RID: 52629
		[Token(Token = "0x400CD95")]
		[FieldOffset(Offset = "0x20")]
		public BoxCollider UIFriendItem;

		// Token: 0x0400CD96 RID: 52630
		[Token(Token = "0x400CD96")]
		[FieldOffset(Offset = "0x28")]
		public GameObject FriendInfoContainer;

		// Token: 0x0400CD97 RID: 52631
		[Token(Token = "0x400CD97")]
		[FieldOffset(Offset = "0x30")]
		public UINetworkTexture FriendInfoIcon;

		// Token: 0x0400CD98 RID: 52632
		[Token(Token = "0x400CD98")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LevelNumLabel;

		// Token: 0x0400CD99 RID: 52633
		[Token(Token = "0x400CD99")]
		[FieldOffset(Offset = "0x40")]
		public UILabel FriendStatLabel;

		// Token: 0x0400CD9A RID: 52634
		[Token(Token = "0x400CD9A")]
		[FieldOffset(Offset = "0x48")]
		public UILabel NickNameLabel;

		// Token: 0x0400CD9B RID: 52635
		[Token(Token = "0x400CD9B")]
		[FieldOffset(Offset = "0x50")]
		public GameObject GameFriendProfileContainer;

		// Token: 0x0400CD9C RID: 52636
		[Token(Token = "0x400CD9C")]
		[FieldOffset(Offset = "0x58")]
		public UIButton ItemBtn;

		// Token: 0x0400CD9D RID: 52637
		[Token(Token = "0x400CD9D")]
		[FieldOffset(Offset = "0x60")]
		public GameObject AccountStatePivot_Right;

		// Token: 0x0400CD9E RID: 52638
		[Token(Token = "0x400CD9E")]
		[FieldOffset(Offset = "0x68")]
		public UILabel AccountState_InGame_Right;

		// Token: 0x0400CD9F RID: 52639
		[Token(Token = "0x400CD9F")]
		[FieldOffset(Offset = "0x70")]
		public UILabel AccountState_Offline_Right;

		// Token: 0x0400CDA0 RID: 52640
		[Token(Token = "0x400CDA0")]
		[FieldOffset(Offset = "0x78")]
		public UILabel AccountState_Online_Right;

		// Token: 0x0400CDA1 RID: 52641
		[Token(Token = "0x400CDA1")]
		[FieldOffset(Offset = "0x80")]
		public UIButton AddBtn;

		// Token: 0x0400CDA2 RID: 52642
		[Token(Token = "0x400CDA2")]
		[FieldOffset(Offset = "0x88")]
		public UIButton SendGiftBtn;

		// Token: 0x0400CDA3 RID: 52643
		[Token(Token = "0x400CDA3")]
		[FieldOffset(Offset = "0x90")]
		public UISprite GiftIcon;

		// Token: 0x0400CDA4 RID: 52644
		[Token(Token = "0x400CDA4")]
		[FieldOffset(Offset = "0x98")]
		public UIButton ChatBtn;

		// Token: 0x0400CDA5 RID: 52645
		[Token(Token = "0x400CDA5")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject AccountStatePivot;

		// Token: 0x0400CDA6 RID: 52646
		[Token(Token = "0x400CDA6")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel AccountState_InGame;

		// Token: 0x0400CDA7 RID: 52647
		[Token(Token = "0x400CDA7")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel AccountState_InGame_Time;

		// Token: 0x0400CDA8 RID: 52648
		[Token(Token = "0x400CDA8")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel AccountState_Offline;

		// Token: 0x0400CDA9 RID: 52649
		[Token(Token = "0x400CDA9")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel AccountState_Online;

		// Token: 0x0400CDAA RID: 52650
		[Token(Token = "0x400CDAA")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject Add_Tag;

		// Token: 0x0400CDAB RID: 52651
		[Token(Token = "0x400CDAB")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject TagTri;

		// Token: 0x0400CDAC RID: 52652
		[Token(Token = "0x400CDAC")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject TagTriPos_0;

		// Token: 0x0400CDAD RID: 52653
		[Token(Token = "0x400CDAD")]
		[FieldOffset(Offset = "0xE0")]
		public UISprite TagTri_BG_0;

		// Token: 0x0400CDAE RID: 52654
		[Token(Token = "0x400CDAE")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel TagTri_Label_0;

		// Token: 0x0400CDAF RID: 52655
		[Token(Token = "0x400CDAF")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject TagTriPos_1;

		// Token: 0x0400CDB0 RID: 52656
		[Token(Token = "0x400CDB0")]
		[FieldOffset(Offset = "0xF8")]
		public UISprite TagTri_BG_1;

		// Token: 0x0400CDB1 RID: 52657
		[Token(Token = "0x400CDB1")]
		[FieldOffset(Offset = "0x100")]
		public UILabel TagTri_Label_1;

		// Token: 0x0400CDB2 RID: 52658
		[Token(Token = "0x400CDB2")]
		[FieldOffset(Offset = "0x108")]
		public GameObject TagTriPos_2;

		// Token: 0x0400CDB3 RID: 52659
		[Token(Token = "0x400CDB3")]
		[FieldOffset(Offset = "0x110")]
		public UISprite TagTri_BG_2;

		// Token: 0x0400CDB4 RID: 52660
		[Token(Token = "0x400CDB4")]
		[FieldOffset(Offset = "0x118")]
		public UILabel TagTri_Label_2;

		// Token: 0x0400CDB5 RID: 52661
		[Token(Token = "0x400CDB5")]
		[FieldOffset(Offset = "0x120")]
		public GameObject TagDouble;

		// Token: 0x0400CDB6 RID: 52662
		[Token(Token = "0x400CDB6")]
		[FieldOffset(Offset = "0x128")]
		public GameObject TagDoublePos_0;

		// Token: 0x0400CDB7 RID: 52663
		[Token(Token = "0x400CDB7")]
		[FieldOffset(Offset = "0x130")]
		public UISprite TagDouble_BG_0;

		// Token: 0x0400CDB8 RID: 52664
		[Token(Token = "0x400CDB8")]
		[FieldOffset(Offset = "0x138")]
		public UILabel TagDouble_Label_0;

		// Token: 0x0400CDB9 RID: 52665
		[Token(Token = "0x400CDB9")]
		[FieldOffset(Offset = "0x140")]
		public GameObject TagDoublePos_1;

		// Token: 0x0400CDBA RID: 52666
		[Token(Token = "0x400CDBA")]
		[FieldOffset(Offset = "0x148")]
		public UISprite TagDouble_BG_1;

		// Token: 0x0400CDBB RID: 52667
		[Token(Token = "0x400CDBB")]
		[FieldOffset(Offset = "0x150")]
		public UILabel TagDouble_Label_1;

		// Token: 0x0400CDBC RID: 52668
		[Token(Token = "0x400CDBC")]
		[FieldOffset(Offset = "0x158")]
		public UISprite ItemBg;

		// Token: 0x0400CDBD RID: 52669
		[Token(Token = "0x400CDBD")]
		[FieldOffset(Offset = "0x160")]
		public GameObject PlatformInfoContainer;

		// Token: 0x0400CDBE RID: 52670
		[Token(Token = "0x400CDBE")]
		[FieldOffset(Offset = "0x168")]
		public GameObject PlatformIcon;

		// Token: 0x0400CDBF RID: 52671
		[Token(Token = "0x400CDBF")]
		[FieldOffset(Offset = "0x170")]
		public UILabel PlatformNickNameLabel;

		// Token: 0x0400CDC0 RID: 52672
		[Token(Token = "0x400CDC0")]
		[FieldOffset(Offset = "0x178")]
		public GameObject RecommendRoot;

		// Token: 0x0400CDC1 RID: 52673
		[Token(Token = "0x400CDC1")]
		[FieldOffset(Offset = "0x180")]
		public UISprite Gender;

		// Token: 0x0400CDC2 RID: 52674
		[Token(Token = "0x400CDC2")]
		[FieldOffset(Offset = "0x188")]
		public UISprite LanguageIcon;

		// Token: 0x0400CDC3 RID: 52675
		[Token(Token = "0x400CDC3")]
		[FieldOffset(Offset = "0x190")]
		public UILabel ModePreferLabel;

		// Token: 0x0400CDC4 RID: 52676
		[Token(Token = "0x400CDC4")]
		[FieldOffset(Offset = "0x198")]
		public UILabel TimeActiveLabel;
	}
}
