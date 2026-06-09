using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001A67 RID: 6759
	[Token(Token = "0x2001A67")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8174", Offset = "0x10F8174")]
	public class UIMatchCSResultInfoItemController : UIBaseController
	{
		// Token: 0x06008E4A RID: 36426 RVA: 0x00025F98 File Offset: 0x00024198
		[Token(Token = "0x6008E4A")]
		[Address(RVA = "0x1477618", Offset = "0x1477618", VA = "0x7BBBC77618")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008E4B RID: 36427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E4B")]
		[Address(RVA = "0x1477668", Offset = "0x1477668", VA = "0x7BBBC77668", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008E4C RID: 36428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E4C")]
		[Address(RVA = "0x1477884", Offset = "0x1477884", VA = "0x7BBBC77884")]
		public void SetPlayerData(MatchStats statsData, MatchIncome incomeData, bool isMVP)
		{
		}

		// Token: 0x06008E4D RID: 36429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E4D")]
		[Address(RVA = "0x1477D84", Offset = "0x1477D84", VA = "0x7BBBC77D84")]
		public void SetRoomPlayerData(MatchStats statsData, bool isMVP)
		{
		}

		// Token: 0x06008E4E RID: 36430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E4E")]
		[Address(RVA = "0x147802C", Offset = "0x147802C", VA = "0x7BBBC7802C")]
		public void SetTeammateData(TeammateStats data, bool last, bool isMVP)
		{
		}

		// Token: 0x06008E4F RID: 36431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E4F")]
		[Address(RVA = "0x1477D34", Offset = "0x1477D34", VA = "0x7BBBC77D34")]
		private void ShowMVPIcon()
		{
		}

		// Token: 0x06008E50 RID: 36432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E50")]
		[Address(RVA = "0x1477C34", Offset = "0x1477C34", VA = "0x7BBBC77C34")]
		private void HideItems(bool isTeammate, bool showPointsRaceStar = false)
		{
		}

		// Token: 0x06008E51 RID: 36433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E51")]
		[Address(RVA = "0x147831C", Offset = "0x147831C", VA = "0x7BBBC7831C")]
		private void OnAddBtnClick()
		{
		}

		// Token: 0x06008E52 RID: 36434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E52")]
		[Address(RVA = "0x147848C", Offset = "0x147848C", VA = "0x7BBBC7848C")]
		public UIMatchCSResultInfoItemController()
		{
		}

		// Token: 0x040099F7 RID: 39415
		[Token(Token = "0x40099F7")]
		[FieldOffset(Offset = "0x58")]
		private UIMatchCSResultInfoItemView m_View;

		// Token: 0x040099F8 RID: 39416
		[Token(Token = "0x40099F8")]
		[FieldOffset(Offset = "0x60")]
		private UIBaseProfileInfoController m_Profile;

		// Token: 0x040099F9 RID: 39417
		[Token(Token = "0x40099F9")]
		[FieldOffset(Offset = "0x68")]
		private UIBriefProfileInfoController m_BriefProfile;

		// Token: 0x040099FA RID: 39418
		[Token(Token = "0x40099FA")]
		[FieldOffset(Offset = "0x70")]
		private ulong m_accountID;

		// Token: 0x040099FB RID: 39419
		[Token(Token = "0x40099FB")]
		[FieldOffset(Offset = "0x78")]
		protected bool m_isMVP;
	}
}
