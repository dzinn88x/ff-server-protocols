using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002463 RID: 9315
	[Token(Token = "0x2002463")]
	public class UINotificationsSettingView : UIBaseView
	{
		// Token: 0x0600C3D6 RID: 50134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3D6")]
		[Address(RVA = "0x1B0A51C", Offset = "0x1B0A51C", VA = "0x7BBC30A51C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3D7 RID: 50135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3D7")]
		[Address(RVA = "0x1B0B024", Offset = "0x1B0B024", VA = "0x7BBC30B024")]
		public UINotificationsSettingView()
		{
		}

		// Token: 0x0400E920 RID: 59680
		[Token(Token = "0x400E920")]
		[FieldOffset(Offset = "0x20")]
		public UIButton CommonGuideMask;

		// Token: 0x0400E921 RID: 59681
		[Token(Token = "0x400E921")]
		[FieldOffset(Offset = "0x28")]
		public GameObject GuidePos;

		// Token: 0x0400E922 RID: 59682
		[Token(Token = "0x400E922")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget GuidePosWidget;

		// Token: 0x0400E923 RID: 59683
		[Token(Token = "0x400E923")]
		[FieldOffset(Offset = "0x38")]
		public UIScrollView NotificationScrollView;

		// Token: 0x0400E924 RID: 59684
		[Token(Token = "0x400E924")]
		[FieldOffset(Offset = "0x40")]
		public UITable Table;

		// Token: 0x0400E925 RID: 59685
		[Token(Token = "0x400E925")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Cell001;

		// Token: 0x0400E926 RID: 59686
		[Token(Token = "0x400E926")]
		[FieldOffset(Offset = "0x50")]
		public GameObject LabelWidget;

		// Token: 0x0400E927 RID: 59687
		[Token(Token = "0x400E927")]
		[FieldOffset(Offset = "0x58")]
		public GameObject NotifyRebateCardsWidget;

		// Token: 0x0400E928 RID: 59688
		[Token(Token = "0x400E928")]
		[FieldOffset(Offset = "0x60")]
		public UIToggleButtonGroup NotifyRebateCards;

		// Token: 0x0400E929 RID: 59689
		[Token(Token = "0x400E929")]
		[FieldOffset(Offset = "0x68")]
		public UIToggleButton RebateCardsOn;

		// Token: 0x0400E92A RID: 59690
		[Token(Token = "0x400E92A")]
		[FieldOffset(Offset = "0x70")]
		public UIToggleButton RebateCardsOff;

		// Token: 0x0400E92B RID: 59691
		[Token(Token = "0x400E92B")]
		[FieldOffset(Offset = "0x78")]
		public GameObject NotifyFreeGachaWidget;

		// Token: 0x0400E92C RID: 59692
		[Token(Token = "0x400E92C")]
		[FieldOffset(Offset = "0x80")]
		public UIToggleButtonGroup NotifyFreeGacha;

		// Token: 0x0400E92D RID: 59693
		[Token(Token = "0x400E92D")]
		[FieldOffset(Offset = "0x88")]
		public UIToggleButton GachaOn;

		// Token: 0x0400E92E RID: 59694
		[Token(Token = "0x400E92E")]
		[FieldOffset(Offset = "0x90")]
		public UIToggleButton GachaOff;

		// Token: 0x0400E92F RID: 59695
		[Token(Token = "0x400E92F")]
		[FieldOffset(Offset = "0x98")]
		public GameObject WebViewWidget;

		// Token: 0x0400E930 RID: 59696
		[Token(Token = "0x400E930")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton BtnWebViewClearCache;

		// Token: 0x0400E931 RID: 59697
		[Token(Token = "0x400E931")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject UnknowRoot;

		// Token: 0x0400E932 RID: 59698
		[Token(Token = "0x400E932")]
		[FieldOffset(Offset = "0xB0")]
		public UIToggleButtonGroup UnknowToggleGroup;

		// Token: 0x0400E933 RID: 59699
		[Token(Token = "0x400E933")]
		[FieldOffset(Offset = "0xB8")]
		public UIToggleButton UnknowAccept;

		// Token: 0x0400E934 RID: 59700
		[Token(Token = "0x400E934")]
		[FieldOffset(Offset = "0xC0")]
		public UIToggleButton UnknowRefuse;

		// Token: 0x0400E935 RID: 59701
		[Token(Token = "0x400E935")]
		[FieldOffset(Offset = "0xC8")]
		public UIToggleButtonGroup ReserveToggleGroup;

		// Token: 0x0400E936 RID: 59702
		[Token(Token = "0x400E936")]
		[FieldOffset(Offset = "0xD0")]
		public UIToggleButton ReserveAccept;

		// Token: 0x0400E937 RID: 59703
		[Token(Token = "0x400E937")]
		[FieldOffset(Offset = "0xD8")]
		public UIToggleButton ReserveRefuse;

		// Token: 0x0400E938 RID: 59704
		[Token(Token = "0x400E938")]
		[FieldOffset(Offset = "0xE0")]
		public UIToggleButtonGroup AcceptInviteToggleGroup;

		// Token: 0x0400E939 RID: 59705
		[Token(Token = "0x400E939")]
		[FieldOffset(Offset = "0xE8")]
		public UIToggleButton AcceptInviteAccept;

		// Token: 0x0400E93A RID: 59706
		[Token(Token = "0x400E93A")]
		[FieldOffset(Offset = "0xF0")]
		public UIToggleButton AcceptInviteRefuse;

		// Token: 0x0400E93B RID: 59707
		[Token(Token = "0x400E93B")]
		[FieldOffset(Offset = "0xF8")]
		public UIToggleButtonGroup FriendRecommendToggleGroup;

		// Token: 0x0400E93C RID: 59708
		[Token(Token = "0x400E93C")]
		[FieldOffset(Offset = "0x100")]
		public UIToggleButton FriendRecommendAccept;

		// Token: 0x0400E93D RID: 59709
		[Token(Token = "0x400E93D")]
		[FieldOffset(Offset = "0x108")]
		public UIToggleButton FriendRecommendRefuse;

		// Token: 0x0400E93E RID: 59710
		[Token(Token = "0x400E93E")]
		[FieldOffset(Offset = "0x110")]
		public GameObject QuickChatRoot;

		// Token: 0x0400E93F RID: 59711
		[Token(Token = "0x400E93F")]
		[FieldOffset(Offset = "0x118")]
		public UISettingToggleBtnGroup QuickChatToggleGroup;

		// Token: 0x0400E940 RID: 59712
		[Token(Token = "0x400E940")]
		[FieldOffset(Offset = "0x120")]
		public UISettingToggleBtnGroup QuickChatSoundToggleGroup;

		// Token: 0x0400E941 RID: 59713
		[Token(Token = "0x400E941")]
		[FieldOffset(Offset = "0x128")]
		public GameObject SyncSettingWidget;

		// Token: 0x0400E942 RID: 59714
		[Token(Token = "0x400E942")]
		[FieldOffset(Offset = "0x130")]
		public GameObject SyncSettingLabel;

		// Token: 0x0400E943 RID: 59715
		[Token(Token = "0x400E943")]
		[FieldOffset(Offset = "0x138")]
		public UIWidget SyncSettingLabelWidget;

		// Token: 0x0400E944 RID: 59716
		[Token(Token = "0x400E944")]
		[FieldOffset(Offset = "0x140")]
		public UIButton SyncSettingTip;

		// Token: 0x0400E945 RID: 59717
		[Token(Token = "0x400E945")]
		[FieldOffset(Offset = "0x148")]
		public UIButton BtnUpload;

		// Token: 0x0400E946 RID: 59718
		[Token(Token = "0x400E946")]
		[FieldOffset(Offset = "0x150")]
		public UIButton BtnDownload;

		// Token: 0x0400E947 RID: 59719
		[Token(Token = "0x400E947")]
		[FieldOffset(Offset = "0x158")]
		public GameObject ChatBlockWidget;

		// Token: 0x0400E948 RID: 59720
		[Token(Token = "0x400E948")]
		[FieldOffset(Offset = "0x160")]
		public UIButton BtnChatBlock;

		// Token: 0x0400E949 RID: 59721
		[Token(Token = "0x400E949")]
		[FieldOffset(Offset = "0x168")]
		public GameObject OptionalDownloadCenterWidget;

		// Token: 0x0400E94A RID: 59722
		[Token(Token = "0x400E94A")]
		[FieldOffset(Offset = "0x170")]
		public UIToggleButtonGroup OptionalDownloadCentre;

		// Token: 0x0400E94B RID: 59723
		[Token(Token = "0x400E94B")]
		[FieldOffset(Offset = "0x178")]
		public UIToggleButton CentreShow;

		// Token: 0x0400E94C RID: 59724
		[Token(Token = "0x400E94C")]
		[FieldOffset(Offset = "0x180")]
		public UIToggleButton CentreHide;

		// Token: 0x0400E94D RID: 59725
		[Token(Token = "0x400E94D")]
		[FieldOffset(Offset = "0x188")]
		public GameObject NetworkReportWidget;

		// Token: 0x0400E94E RID: 59726
		[Token(Token = "0x400E94E")]
		[FieldOffset(Offset = "0x190")]
		public UIButton BtnSendReport;
	}
}
