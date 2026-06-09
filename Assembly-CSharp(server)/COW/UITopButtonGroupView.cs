using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002577 RID: 9591
	[Token(Token = "0x2002577")]
	public class UITopButtonGroupView : UIBaseView
	{
		// Token: 0x0600C5FE RID: 50686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5FE")]
		[Address(RVA = "0x1F5A718", Offset = "0x1F5A718", VA = "0x7BBC75A718", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5FF RID: 50687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5FF")]
		[Address(RVA = "0x1F5B1A4", Offset = "0x1F5B1A4", VA = "0x7BBC75B1A4")]
		public UITopButtonGroupView()
		{
		}

		// Token: 0x0400F642 RID: 63042
		[Token(Token = "0x400F642")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget Root;

		// Token: 0x0400F643 RID: 63043
		[Token(Token = "0x400F643")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Lobby;

		// Token: 0x0400F644 RID: 63044
		[Token(Token = "0x400F644")]
		[FieldOffset(Offset = "0x30")]
		public UIButton btnfriend;

		// Token: 0x0400F645 RID: 63045
		[Token(Token = "0x400F645")]
		[FieldOffset(Offset = "0x38")]
		public GameObject FriendNewsHint;

		// Token: 0x0400F646 RID: 63046
		[Token(Token = "0x400F646")]
		[FieldOffset(Offset = "0x40")]
		public UIButton btnmail;

		// Token: 0x0400F647 RID: 63047
		[Token(Token = "0x400F647")]
		[FieldOffset(Offset = "0x48")]
		public GameObject MailNewsHint;

		// Token: 0x0400F648 RID: 63048
		[Token(Token = "0x400F648")]
		[FieldOffset(Offset = "0x50")]
		public UIButton btnsetting;

		// Token: 0x0400F649 RID: 63049
		[Token(Token = "0x400F649")]
		[FieldOffset(Offset = "0x58")]
		public GameObject settingTips;

		// Token: 0x0400F64A RID: 63050
		[Token(Token = "0x400F64A")]
		[FieldOffset(Offset = "0x60")]
		public UIWidget MaxSettingGuide;

		// Token: 0x0400F64B RID: 63051
		[Token(Token = "0x400F64B")]
		[FieldOffset(Offset = "0x68")]
		public GameObject LobbySettingTips;

		// Token: 0x0400F64C RID: 63052
		[Token(Token = "0x400F64C")]
		[FieldOffset(Offset = "0x70")]
		public UISprite Battery;

		// Token: 0x0400F64D RID: 63053
		[Token(Token = "0x400F64D")]
		[FieldOffset(Offset = "0x78")]
		public UISprite BatteryLevelSprite;

		// Token: 0x0400F64E RID: 63054
		[Token(Token = "0x400F64E")]
		[FieldOffset(Offset = "0x80")]
		public UISprite BatteryChargingSprite;

		// Token: 0x0400F64F RID: 63055
		[Token(Token = "0x400F64F")]
		[FieldOffset(Offset = "0x88")]
		public UISprite BGSprite;

		// Token: 0x0400F650 RID: 63056
		[Token(Token = "0x400F650")]
		[FieldOffset(Offset = "0x90")]
		public UISprite BGSpriteUnder;

		// Token: 0x0400F651 RID: 63057
		[Token(Token = "0x400F651")]
		[FieldOffset(Offset = "0x98")]
		public UITable NaviPage;

		// Token: 0x0400F652 RID: 63058
		[Token(Token = "0x400F652")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton HelpBtn;

		// Token: 0x0400F653 RID: 63059
		[Token(Token = "0x400F653")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject VoiceBtnGroup;

		// Token: 0x0400F654 RID: 63060
		[Token(Token = "0x400F654")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton MicToggle;

		// Token: 0x0400F655 RID: 63061
		[Token(Token = "0x400F655")]
		[FieldOffset(Offset = "0xB8")]
		public UISprite MicSprite;

		// Token: 0x0400F656 RID: 63062
		[Token(Token = "0x400F656")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite MicMask;

		// Token: 0x0400F657 RID: 63063
		[Token(Token = "0x400F657")]
		[FieldOffset(Offset = "0xC8")]
		public UIButton SpeakerToggle;

		// Token: 0x0400F658 RID: 63064
		[Token(Token = "0x400F658")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite SpeakerSprite;

		// Token: 0x0400F659 RID: 63065
		[Token(Token = "0x400F659")]
		[FieldOffset(Offset = "0xD8")]
		public UISprite SpeakerMask;

		// Token: 0x0400F65A RID: 63066
		[Token(Token = "0x400F65A")]
		[FieldOffset(Offset = "0xE0")]
		public Transform CustomizedCtrlTrans;

		// Token: 0x0400F65B RID: 63067
		[Token(Token = "0x400F65B")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel title;

		// Token: 0x0400F65C RID: 63068
		[Token(Token = "0x400F65C")]
		[FieldOffset(Offset = "0xF0")]
		public UIButton leaveBtn;

		// Token: 0x0400F65D RID: 63069
		[Token(Token = "0x400F65D")]
		[FieldOffset(Offset = "0xF8")]
		public UISprite ButtonBgSprite;

		// Token: 0x0400F65E RID: 63070
		[Token(Token = "0x400F65E")]
		[FieldOffset(Offset = "0x100")]
		public UISprite ButtonClose;

		// Token: 0x0400F65F RID: 63071
		[Token(Token = "0x400F65F")]
		[FieldOffset(Offset = "0x108")]
		public Transform TitleLeft;

		// Token: 0x0400F660 RID: 63072
		[Token(Token = "0x400F660")]
		[FieldOffset(Offset = "0x110")]
		public UITable ItemTable;

		// Token: 0x0400F661 RID: 63073
		[Token(Token = "0x400F661")]
		[FieldOffset(Offset = "0x118")]
		public UISprite NormalExchangeSprite;

		// Token: 0x0400F662 RID: 63074
		[Token(Token = "0x400F662")]
		[FieldOffset(Offset = "0x120")]
		public UISprite ExchangeTokenSprite;

		// Token: 0x0400F663 RID: 63075
		[Token(Token = "0x400F663")]
		[FieldOffset(Offset = "0x128")]
		public UIButton ExchangeStoreBtn;

		// Token: 0x0400F664 RID: 63076
		[Token(Token = "0x400F664")]
		[FieldOffset(Offset = "0x130")]
		public UILabel ExchangeStoreLabel;

		// Token: 0x0400F665 RID: 63077
		[Token(Token = "0x400F665")]
		[FieldOffset(Offset = "0x138")]
		public UIWidget arrow;

		// Token: 0x0400F666 RID: 63078
		[Token(Token = "0x400F666")]
		[FieldOffset(Offset = "0x140")]
		public UISprite Token1;

		// Token: 0x0400F667 RID: 63079
		[Token(Token = "0x400F667")]
		[FieldOffset(Offset = "0x148")]
		public UILabel Token1Label;

		// Token: 0x0400F668 RID: 63080
		[Token(Token = "0x400F668")]
		[FieldOffset(Offset = "0x150")]
		public GameObject Token1TimeIcon;

		// Token: 0x0400F669 RID: 63081
		[Token(Token = "0x400F669")]
		[FieldOffset(Offset = "0x158")]
		public UIButton Token1Btn;

		// Token: 0x0400F66A RID: 63082
		[Token(Token = "0x400F66A")]
		[FieldOffset(Offset = "0x160")]
		public UISprite Token2;

		// Token: 0x0400F66B RID: 63083
		[Token(Token = "0x400F66B")]
		[FieldOffset(Offset = "0x168")]
		public UILabel Token2Label;

		// Token: 0x0400F66C RID: 63084
		[Token(Token = "0x400F66C")]
		[FieldOffset(Offset = "0x170")]
		public GameObject Token2TimeIcon;

		// Token: 0x0400F66D RID: 63085
		[Token(Token = "0x400F66D")]
		[FieldOffset(Offset = "0x178")]
		public UIButton Token2Btn;
	}
}
