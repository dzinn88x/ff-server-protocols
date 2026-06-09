using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200190B RID: 6411
	[Token(Token = "0x200190B")]
	public class UIHudMatchResult2TeamsGridItemController : UIBaseController
	{
		// Token: 0x060080D7 RID: 32983 RVA: 0x00023280 File Offset: 0x00021480
		[Token(Token = "0x60080D7")]
		[Address(RVA = "0x15C3BB0", Offset = "0x15C3BB0", VA = "0x7BBBDC3BB0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060080D8 RID: 32984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080D8")]
		[Address(RVA = "0x15C3C00", Offset = "0x15C3C00", VA = "0x7BBBDC3C00", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060080D9 RID: 32985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080D9")]
		[Address(RVA = "0x15C3C70", Offset = "0x15C3C70", VA = "0x7BBBDC3C70", Slot = "28")]
		protected virtual void InitComponents()
		{
		}

		// Token: 0x060080DA RID: 32986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080DA")]
		[Address(RVA = "0x15C2168", Offset = "0x15C2168", VA = "0x7BBBDC2168")]
		protected void SetDefaultActive()
		{
		}

		// Token: 0x060080DB RID: 32987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080DB")]
		[Address(RVA = "0x15C1DC0", Offset = "0x15C1DC0", VA = "0x7BBBDC1DC0")]
		public void SetUIData(TeammateStats p, bool localPlayer, bool isFriend, bool hideScore = false, bool hideFriend = false)
		{
		}

		// Token: 0x060080DC RID: 32988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080DC")]
		[Address(RVA = "0x15C4220", Offset = "0x15C4220", VA = "0x7BBBDC4220")]
		public void SetUIData(string nickname, string teamname, uint headicon, uint kill, uint dead, uint assist, uint damage, uint banner)
		{
		}

		// Token: 0x060080DD RID: 32989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080DD")]
		[Address(RVA = "0x15C3EA4", Offset = "0x15C3EA4", VA = "0x7BBBDC3EA4")]
		private void SetNameIcon(TeammateStats p)
		{
		}

		// Token: 0x060080DE RID: 32990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080DE")]
		[Address(RVA = "0x15C2688", Offset = "0x15C2688", VA = "0x7BBBDC2688", Slot = "29")]
		protected virtual void SetScores(TeammateStats p)
		{
		}

		// Token: 0x060080DF RID: 32991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080DF")]
		[Address(RVA = "0x15C3F78", Offset = "0x15C3F78", VA = "0x7BBBDC3F78")]
		private void SetLocalPlayer()
		{
		}

		// Token: 0x060080E0 RID: 32992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080E0")]
		[Address(RVA = "0x15C4478", Offset = "0x15C4478", VA = "0x7BBBDC4478")]
		private void Highlight(UILabel label)
		{
		}

		// Token: 0x060080E1 RID: 32993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080E1")]
		[Address(RVA = "0x15C1F84", Offset = "0x15C1F84", VA = "0x7BBBDC1F84")]
		public void SetMvp()
		{
		}

		// Token: 0x060080E2 RID: 32994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080E2")]
		[Address(RVA = "0x15C4554", Offset = "0x15C4554", VA = "0x7BBBDC4554")]
		private void OnAddFriend()
		{
		}

		// Token: 0x060080E3 RID: 32995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080E3")]
		[Address(RVA = "0x15C3FE8", Offset = "0x15C3FE8", VA = "0x7BBBDC3FE8")]
		private void UpdateBannerData(uint bannerID)
		{
		}

		// Token: 0x060080E4 RID: 32996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080E4")]
		[Address(RVA = "0x15C27E0", Offset = "0x15C27E0", VA = "0x7BBBDC27E0")]
		public UIHudMatchResult2TeamsGridItemController()
		{
		}

		// Token: 0x040092CE RID: 37582
		[Token(Token = "0x40092CE")]
		[FieldOffset(Offset = "0x58")]
		private UIHudMatchResult2TeamsGridItemView m_View;

		// Token: 0x040092CF RID: 37583
		[Token(Token = "0x40092CF")]
		[FieldOffset(Offset = "0x60")]
		private ulong m_UserAccountId;

		// Token: 0x040092D0 RID: 37584
		[Token(Token = "0x40092D0")]
		[FieldOffset(Offset = "0x68")]
		protected GameObject m_Self;

		// Token: 0x040092D1 RID: 37585
		[Token(Token = "0x40092D1")]
		[FieldOffset(Offset = "0x70")]
		protected UIButton m_SimpleProfileInfo;

		// Token: 0x040092D2 RID: 37586
		[Token(Token = "0x40092D2")]
		[FieldOffset(Offset = "0x78")]
		protected UISprite m_HeadIcon;

		// Token: 0x040092D3 RID: 37587
		[Token(Token = "0x40092D3")]
		[FieldOffset(Offset = "0x80")]
		protected GameObject m_InfoContainer;

		// Token: 0x040092D4 RID: 37588
		[Token(Token = "0x40092D4")]
		[FieldOffset(Offset = "0x88")]
		protected UILabel m_Nickname;

		// Token: 0x040092D5 RID: 37589
		[Token(Token = "0x40092D5")]
		[FieldOffset(Offset = "0x90")]
		protected UILabel m_ClanName;

		// Token: 0x040092D6 RID: 37590
		[Token(Token = "0x40092D6")]
		[FieldOffset(Offset = "0x98")]
		protected UILabel m_Kill;

		// Token: 0x040092D7 RID: 37591
		[Token(Token = "0x40092D7")]
		[FieldOffset(Offset = "0xA0")]
		protected UILabel m_Death;

		// Token: 0x040092D8 RID: 37592
		[Token(Token = "0x40092D8")]
		[FieldOffset(Offset = "0xA8")]
		protected UILabel m_Assist;

		// Token: 0x040092D9 RID: 37593
		[Token(Token = "0x40092D9")]
		[FieldOffset(Offset = "0xB0")]
		protected UILabel m_Damage;

		// Token: 0x040092DA RID: 37594
		[Token(Token = "0x40092DA")]
		[FieldOffset(Offset = "0xB8")]
		protected UILabel m_Evaluation;

		// Token: 0x040092DB RID: 37595
		[Token(Token = "0x40092DB")]
		[FieldOffset(Offset = "0xC0")]
		protected GameObject m_Mvp;

		// Token: 0x040092DC RID: 37596
		[Token(Token = "0x40092DC")]
		[FieldOffset(Offset = "0xC8")]
		protected UIButton m_AddFriendBtn;

		// Token: 0x040092DD RID: 37597
		[Token(Token = "0x40092DD")]
		[FieldOffset(Offset = "0xD0")]
		protected UILabel m_BDLabel;

		// Token: 0x040092DE RID: 37598
		[Token(Token = "0x40092DE")]
		[FieldOffset(Offset = "0xD8")]
		protected UILabel m_BPLabel;

		// Token: 0x040092DF RID: 37599
		[Token(Token = "0x40092DF")]
		[FieldOffset(Offset = "0xE0")]
		protected UIEffectSprite m_BannerBG;

		// Token: 0x040092E0 RID: 37600
		[Token(Token = "0x40092E0")]
		[FieldOffset(Offset = "0xE8")]
		protected GameObject m_FakeBannerBG;
	}
}
