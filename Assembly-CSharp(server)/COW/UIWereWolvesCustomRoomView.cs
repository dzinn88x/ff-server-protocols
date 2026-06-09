using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025A3 RID: 9635
	[Token(Token = "0x20025A3")]
	public class UIWereWolvesCustomRoomView : UIBaseView
	{
		// Token: 0x0600C656 RID: 50774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C656")]
		[Address(RVA = "0x178CCDC", Offset = "0x178CCDC", VA = "0x7BBBF8CCDC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C657 RID: 50775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C657")]
		[Address(RVA = "0x178D6F4", Offset = "0x178D6F4", VA = "0x7BBBF8D6F4")]
		public UIWereWolvesCustomRoomView()
		{
		}

		// Token: 0x0400F8A3 RID: 63651
		[Token(Token = "0x400F8A3")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget LeftContainer;

		// Token: 0x0400F8A4 RID: 63652
		[Token(Token = "0x400F8A4")]
		[FieldOffset(Offset = "0x28")]
		public UILabel RoomId;

		// Token: 0x0400F8A5 RID: 63653
		[Token(Token = "0x400F8A5")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid Flags;

		// Token: 0x0400F8A6 RID: 63654
		[Token(Token = "0x400F8A6")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Lock;

		// Token: 0x0400F8A7 RID: 63655
		[Token(Token = "0x400F8A7")]
		[FieldOffset(Offset = "0x40")]
		public UISprite Map;

		// Token: 0x0400F8A8 RID: 63656
		[Token(Token = "0x400F8A8")]
		[FieldOffset(Offset = "0x48")]
		public UISprite weatherBg;

		// Token: 0x0400F8A9 RID: 63657
		[Token(Token = "0x400F8A9")]
		[FieldOffset(Offset = "0x50")]
		public UISprite WeatherIcon;

		// Token: 0x0400F8AA RID: 63658
		[Token(Token = "0x400F8AA")]
		[FieldOffset(Offset = "0x58")]
		public UILabel MapName;

		// Token: 0x0400F8AB RID: 63659
		[Token(Token = "0x400F8AB")]
		[FieldOffset(Offset = "0x60")]
		public UILabel GameModeLabel;

		// Token: 0x0400F8AC RID: 63660
		[Token(Token = "0x400F8AC")]
		[FieldOffset(Offset = "0x68")]
		public UILabel PlayerCountLabel;

		// Token: 0x0400F8AD RID: 63661
		[Token(Token = "0x400F8AD")]
		[FieldOffset(Offset = "0x70")]
		public UILabel GameTimeLabel;

		// Token: 0x0400F8AE RID: 63662
		[Token(Token = "0x400F8AE")]
		[FieldOffset(Offset = "0x78")]
		public UILabel HuamanCountLabel;

		// Token: 0x0400F8AF RID: 63663
		[Token(Token = "0x400F8AF")]
		[FieldOffset(Offset = "0x80")]
		public UILabel WolfCountLabel;

		// Token: 0x0400F8B0 RID: 63664
		[Token(Token = "0x400F8B0")]
		[FieldOffset(Offset = "0x88")]
		public UIButton CustomizeBtn;

		// Token: 0x0400F8B1 RID: 63665
		[Token(Token = "0x400F8B1")]
		[FieldOffset(Offset = "0x90")]
		public UILabel CustomizeTxt;

		// Token: 0x0400F8B2 RID: 63666
		[Token(Token = "0x400F8B2")]
		[FieldOffset(Offset = "0x98")]
		public UIButton BtnShare;

		// Token: 0x0400F8B3 RID: 63667
		[Token(Token = "0x400F8B3")]
		[FieldOffset(Offset = "0xA0")]
		public UIScrollView roomSettingtScrollView;

		// Token: 0x0400F8B4 RID: 63668
		[Token(Token = "0x400F8B4")]
		[FieldOffset(Offset = "0xA8")]
		public UIGrid SettingGrid;

		// Token: 0x0400F8B5 RID: 63669
		[Token(Token = "0x400F8B5")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel HumanTaskLabel;

		// Token: 0x0400F8B6 RID: 63670
		[Token(Token = "0x400F8B6")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel WolfKillCDLabel;

		// Token: 0x0400F8B7 RID: 63671
		[Token(Token = "0x400F8B7")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel WolfTaskCD;

		// Token: 0x0400F8B8 RID: 63672
		[Token(Token = "0x400F8B8")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel WolfTaskDurationLabel;

		// Token: 0x0400F8B9 RID: 63673
		[Token(Token = "0x400F8B9")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel VoteCenterCDLabel;

		// Token: 0x0400F8BA RID: 63674
		[Token(Token = "0x400F8BA")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject InvitationGO;

		// Token: 0x0400F8BB RID: 63675
		[Token(Token = "0x400F8BB")]
		[FieldOffset(Offset = "0xE0")]
		public UIWidget RightContainer;

		// Token: 0x0400F8BC RID: 63676
		[Token(Token = "0x400F8BC")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel RoomName;

		// Token: 0x0400F8BD RID: 63677
		[Token(Token = "0x400F8BD")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject Effect_Glow;

		// Token: 0x0400F8BE RID: 63678
		[Token(Token = "0x400F8BE")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel RoomStatus;

		// Token: 0x0400F8BF RID: 63679
		[Token(Token = "0x400F8BF")]
		[FieldOffset(Offset = "0x100")]
		public UIButton ToggleDisplayTypeBtn;

		// Token: 0x0400F8C0 RID: 63680
		[Token(Token = "0x400F8C0")]
		[FieldOffset(Offset = "0x108")]
		public UILabel DisplayTypeLabel;

		// Token: 0x0400F8C1 RID: 63681
		[Token(Token = "0x400F8C1")]
		[FieldOffset(Offset = "0x110")]
		public UIButton InviteBtn;

		// Token: 0x0400F8C2 RID: 63682
		[Token(Token = "0x400F8C2")]
		[FieldOffset(Offset = "0x118")]
		public UIButton Start;

		// Token: 0x0400F8C3 RID: 63683
		[Token(Token = "0x400F8C3")]
		[FieldOffset(Offset = "0x120")]
		public UICountDownLabel CountDownTxt;

		// Token: 0x0400F8C4 RID: 63684
		[Token(Token = "0x400F8C4")]
		[FieldOffset(Offset = "0x128")]
		public GameObject Waiting;

		// Token: 0x0400F8C5 RID: 63685
		[Token(Token = "0x400F8C5")]
		[FieldOffset(Offset = "0x130")]
		public UILabel WatingLabel;

		// Token: 0x0400F8C6 RID: 63686
		[Token(Token = "0x400F8C6")]
		[FieldOffset(Offset = "0x138")]
		public GameObject RoomCardTips;

		// Token: 0x0400F8C7 RID: 63687
		[Token(Token = "0x400F8C7")]
		[FieldOffset(Offset = "0x140")]
		public GameObject RoomCard;

		// Token: 0x0400F8C8 RID: 63688
		[Token(Token = "0x400F8C8")]
		[FieldOffset(Offset = "0x148")]
		public UIButton RoomCardBtn;

		// Token: 0x0400F8C9 RID: 63689
		[Token(Token = "0x400F8C9")]
		[FieldOffset(Offset = "0x150")]
		public UILabel Remain;

		// Token: 0x0400F8CA RID: 63690
		[Token(Token = "0x400F8CA")]
		[FieldOffset(Offset = "0x158")]
		public UILabel RoomCardCount;

		// Token: 0x0400F8CB RID: 63691
		[Token(Token = "0x400F8CB")]
		[FieldOffset(Offset = "0x160")]
		public UIScrollView PlayerListScrollView;

		// Token: 0x0400F8CC RID: 63692
		[Token(Token = "0x400F8CC")]
		[FieldOffset(Offset = "0x168")]
		public UIEasyList PlayerListGrid;

		// Token: 0x0400F8CD RID: 63693
		[Token(Token = "0x400F8CD")]
		[FieldOffset(Offset = "0x170")]
		public UIButton BackBtn;
	}
}
