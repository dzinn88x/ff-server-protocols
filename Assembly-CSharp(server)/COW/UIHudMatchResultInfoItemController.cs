using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001913 RID: 6419
	[Token(Token = "0x2001913")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5784", Offset = "0x10F5784")]
	public class UIHudMatchResultInfoItemController : UIBaseController
	{
		// Token: 0x06008151 RID: 33105 RVA: 0x00023388 File Offset: 0x00021588
		[Token(Token = "0x6008151")]
		[Address(RVA = "0x17A6300", Offset = "0x17A6300", VA = "0x7BBBFA6300")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008152 RID: 33106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008152")]
		[Address(RVA = "0x17A6350", Offset = "0x17A6350", VA = "0x7BBBFA6350", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008153 RID: 33107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008153")]
		[Address(RVA = "0x17A6794", Offset = "0x17A6794", VA = "0x7BBBFA6794")]
		public void SetPlayerData(MatchStats statsData, MatchIncome incomeData, bool isShowScore)
		{
		}

		// Token: 0x06008154 RID: 33108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008154")]
		[Address(RVA = "0x17A74CC", Offset = "0x17A74CC", VA = "0x7BBBFA74CC")]
		public void SetCustomRoomPlayerData(MatchStats statsData, bool isShowScore)
		{
		}

		// Token: 0x06008155 RID: 33109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008155")]
		[Address(RVA = "0x17A7844", Offset = "0x17A7844", VA = "0x7BBBFA7844")]
		public void SetTeammateData(TeammateStats data, bool last, bool isShowScore)
		{
		}

		// Token: 0x06008156 RID: 33110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008156")]
		[Address(RVA = "0x17A70E4", Offset = "0x17A70E4", VA = "0x7BBBFA70E4")]
		private void HideItems(bool isTeammate, bool showPointsRaceStar = false)
		{
		}

		// Token: 0x06008157 RID: 33111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008157")]
		[Address(RVA = "0x17A7B38", Offset = "0x17A7B38", VA = "0x7BBBFA7B38")]
		private void OnAddBtnClick()
		{
		}

		// Token: 0x06008158 RID: 33112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008158")]
		[Address(RVA = "0x17A7CA8", Offset = "0x17A7CA8", VA = "0x7BBBFA7CA8")]
		private void OnExpBonusClick()
		{
		}

		// Token: 0x06008159 RID: 33113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008159")]
		[Address(RVA = "0x17A7EE0", Offset = "0x17A7EE0", VA = "0x7BBBFA7EE0")]
		private void OnGoldBonusClick()
		{
		}

		// Token: 0x0600815A RID: 33114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600815A")]
		[Address(RVA = "0x17A7320", Offset = "0x17A7320", VA = "0x7BBBFA7320")]
		private void ShowOwnerIcons(ulong id)
		{
		}

		// Token: 0x0600815B RID: 33115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600815B")]
		[Address(RVA = "0x17A8118", Offset = "0x17A8118", VA = "0x7BBBFA8118")]
		private void OnDetailClick()
		{
		}

		// Token: 0x0600815C RID: 33116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600815C")]
		[Address(RVA = "0x17A82B8", Offset = "0x17A82B8", VA = "0x7BBBFA82B8")]
		public UIHudMatchResultInfoItemController()
		{
		}

		// Token: 0x04009313 RID: 37651
		[Token(Token = "0x4009313")]
		[FieldOffset(Offset = "0x58")]
		private UIHudMatchResultInfoItemView m_View;

		// Token: 0x04009314 RID: 37652
		[Token(Token = "0x4009314")]
		[FieldOffset(Offset = "0x60")]
		private UIBaseProfileInfoController m_Profile;

		// Token: 0x04009315 RID: 37653
		[Token(Token = "0x4009315")]
		[FieldOffset(Offset = "0x68")]
		private UIBriefProfileInfoController m_BriefProfile;

		// Token: 0x04009316 RID: 37654
		[Token(Token = "0x4009316")]
		[FieldOffset(Offset = "0x70")]
		private int m_GoldBonus;

		// Token: 0x04009317 RID: 37655
		[Token(Token = "0x4009317")]
		[FieldOffset(Offset = "0x74")]
		private int m_ExpBonus;

		// Token: 0x04009318 RID: 37656
		[Token(Token = "0x4009318")]
		[FieldOffset(Offset = "0x78")]
		private ulong m_accountID;

		// Token: 0x04009319 RID: 37657
		[Token(Token = "0x4009319")]
		[FieldOffset(Offset = "0x80")]
		protected bool m_showScore;

		// Token: 0x0400931A RID: 37658
		[Token(Token = "0x400931A")]
		[FieldOffset(Offset = "0x88")]
		public Action<MatchResultDetailInfo, Vector3> onDetail;

		// Token: 0x0400931B RID: 37659
		[Token(Token = "0x400931B")]
		[FieldOffset(Offset = "0x90")]
		private MatchIncome m_IncomeData;
	}
}
