using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C25 RID: 7205
	[Token(Token = "0x2001C25")]
	public class BaseChatMessageView : MonoBehaviour
	{
		// Token: 0x06009CCF RID: 40143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CCF")]
		[Address(RVA = "0x21CDF94", Offset = "0x21CDF94", VA = "0x7BBC9CDF94")]
		public void SetUIData(MessageInfo info)
		{
		}

		// Token: 0x06009CD0 RID: 40144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CD0")]
		[Address(RVA = "0x21CFD50", Offset = "0x21CFD50", VA = "0x7BBC9CFD50")]
		public void UpdateJoinBtn(bool isShowJoinBtn)
		{
		}

		// Token: 0x06009CD1 RID: 40145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CD1")]
		[Address(RVA = "0x21CFBF8", Offset = "0x21CFBF8", VA = "0x7BBC9CFBF8")]
		public void UpdatePin(uint pinId)
		{
		}

		// Token: 0x06009CD2 RID: 40146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CD2")]
		[Address(RVA = "0x21CFD54", Offset = "0x21CFD54", VA = "0x7BBC9CFD54")]
		public BaseChatMessageView()
		{
		}

		// Token: 0x0400A2B4 RID: 41652
		[Token(Token = "0x400A2B4")]
		[FieldOffset(Offset = "0x18")]
		public UIEffectSprite m_HeadPic;

		// Token: 0x0400A2B5 RID: 41653
		[Token(Token = "0x400A2B5")]
		[FieldOffset(Offset = "0x20")]
		public UILabel m_NameLabel;

		// Token: 0x0400A2B6 RID: 41654
		[Token(Token = "0x400A2B6")]
		[FieldOffset(Offset = "0x28")]
		public UILabel m_SendTimeLabel;

		// Token: 0x0400A2B7 RID: 41655
		[Token(Token = "0x400A2B7")]
		[FieldOffset(Offset = "0x30")]
		public UISprite m_BannerBG;

		// Token: 0x0400A2B8 RID: 41656
		[Token(Token = "0x400A2B8")]
		[FieldOffset(Offset = "0x38")]
		public bool m_BriefBanner;

		// Token: 0x0400A2B9 RID: 41657
		[Token(Token = "0x400A2B9")]
		[FieldOffset(Offset = "0x40")]
		public UILabel m_Content;

		// Token: 0x0400A2BA RID: 41658
		[Token(Token = "0x400A2BA")]
		[FieldOffset(Offset = "0x48")]
		public UIButton m_ResendBtn;

		// Token: 0x0400A2BB RID: 41659
		[Token(Token = "0x400A2BB")]
		[FieldOffset(Offset = "0x50")]
		public UIButton m_JoinBtn;

		// Token: 0x0400A2BC RID: 41660
		[Token(Token = "0x400A2BC")]
		[FieldOffset(Offset = "0x58")]
		public UISprite m_StickerSprite;

		// Token: 0x0400A2BD RID: 41661
		[Token(Token = "0x400A2BD")]
		[FieldOffset(Offset = "0x60")]
		public UISprite m_LadderIcon;

		// Token: 0x0400A2BE RID: 41662
		[Token(Token = "0x400A2BE")]
		[FieldOffset(Offset = "0x68")]
		public GameObject m_GroupInvite;

		// Token: 0x0400A2BF RID: 41663
		[Token(Token = "0x400A2BF")]
		[FieldOffset(Offset = "0x70")]
		public GameObject m_ClanInvite;

		// Token: 0x0400A2C0 RID: 41664
		[Token(Token = "0x400A2C0")]
		[FieldOffset(Offset = "0x78")]
		public GameObject m_ChampionshipTeamInvite;

		// Token: 0x0400A2C1 RID: 41665
		[Token(Token = "0x400A2C1")]
		[FieldOffset(Offset = "0x80")]
		public UIWidget m_LiftTopMessage;

		// Token: 0x0400A2C2 RID: 41666
		[Token(Token = "0x400A2C2")]
		[FieldOffset(Offset = "0x88")]
		public UISprite m_PinIcon;

		// Token: 0x0400A2C3 RID: 41667
		[Token(Token = "0x400A2C3")]
		[FieldOffset(Offset = "0x90")]
		public UILabel m_ContentSystem;

		// Token: 0x0400A2C4 RID: 41668
		[Token(Token = "0x400A2C4")]
		[FieldOffset(Offset = "0x98")]
		public UISprite m_ContentSystemIcon;

		// Token: 0x0400A2C5 RID: 41669
		[Token(Token = "0x400A2C5")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject Icon_Celebrity;

		// Token: 0x0400A2C6 RID: 41670
		[Token(Token = "0x400A2C6")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel m_ModeName;

		// Token: 0x0400A2C7 RID: 41671
		[Token(Token = "0x400A2C7")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel m_MapName;

		// Token: 0x0400A2C8 RID: 41672
		[Token(Token = "0x400A2C8")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel m_GroupModeName;

		// Token: 0x0400A2C9 RID: 41673
		[Token(Token = "0x400A2C9")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite m_ReqRankSprite;

		// Token: 0x0400A2CA RID: 41674
		[Token(Token = "0x400A2CA")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel m_ClanName;

		// Token: 0x0400A2CB RID: 41675
		[Token(Token = "0x400A2CB")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel m_ClanLevel;

		// Token: 0x0400A2CC RID: 41676
		[Token(Token = "0x400A2CC")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel m_ClanDeclaration;

		// Token: 0x0400A2CD RID: 41677
		[Token(Token = "0x400A2CD")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel m_ClanMemberNum;

		// Token: 0x0400A2CE RID: 41678
		[Token(Token = "0x400A2CE")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel m_ClanApplyMethod;

		// Token: 0x0400A2CF RID: 41679
		[Token(Token = "0x400A2CF")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel m_ChampionshipName;

		// Token: 0x0400A2D0 RID: 41680
		[Token(Token = "0x400A2D0")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel m_ChampionshipMember;

		// Token: 0x0400A2D1 RID: 41681
		[Token(Token = "0x400A2D1")]
		[FieldOffset(Offset = "0x100")]
		public UISprite m_ChampionshipSprite;

		// Token: 0x0400A2D2 RID: 41682
		[Token(Token = "0x400A2D2")]
		[FieldOffset(Offset = "0x108")]
		public GameObject m_ActivityMsgOB;

		// Token: 0x0400A2D3 RID: 41683
		[Token(Token = "0x400A2D3")]
		private const uint DEFAULT_HEAD_ID = 902000003U;

		// Token: 0x0400A2D4 RID: 41684
		[Token(Token = "0x400A2D4")]
		[FieldOffset(Offset = "0x110")]
		private Vector3 m_Pos;

		// Token: 0x0400A2D5 RID: 41685
		[Token(Token = "0x400A2D5")]
		[FieldOffset(Offset = "0x120")]
		private MessageInfo m_Message;
	}
}
