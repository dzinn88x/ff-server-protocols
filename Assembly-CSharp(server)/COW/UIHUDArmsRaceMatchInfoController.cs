using System;
using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001423 RID: 5155
	[Token(Token = "0x2001423")]
	public class UIHUDArmsRaceMatchInfoController : UIBaseController
	{
		// Token: 0x06005519 RID: 21785 RVA: 0x00019650 File Offset: 0x00017850
		[Token(Token = "0x6005519")]
		[Address(RVA = "0x16B2008", Offset = "0x16B2008", VA = "0x7BBBEB2008")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600551A RID: 21786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600551A")]
		[Address(RVA = "0x16B2058", Offset = "0x16B2058", VA = "0x7BBBEB2058", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600551B RID: 21787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600551B")]
		[Address(RVA = "0x16B22E0", Offset = "0x16B22E0", VA = "0x7BBBEB22E0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600551C RID: 21788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600551C")]
		[Address(RVA = "0x16B24FC", Offset = "0x16B24FC", VA = "0x7BBBEB24FC")]
		private void OnGameArmsListCome(params object[] param)
		{
		}

		// Token: 0x0600551D RID: 21789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600551D")]
		[Address(RVA = "0x16B2D78", Offset = "0x16B2D78", VA = "0x7BBBEB2D78")]
		private void OnBattleTimeCome(params object[] parma)
		{
		}

		// Token: 0x0600551E RID: 21790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600551E")]
		[Address(RVA = "0x16B2E00", Offset = "0x16B2E00", VA = "0x7BBBEB2E00")]
		private void OnSelfArmLevelCome(params object[] param)
		{
		}

		// Token: 0x0600551F RID: 21791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600551F")]
		[Address(RVA = "0x16B2E94", Offset = "0x16B2E94", VA = "0x7BBBEB2E94")]
		private void OnSelfRankCome(params object[] param)
		{
		}

		// Token: 0x06005520 RID: 21792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005520")]
		[Address(RVA = "0x16B2F28", Offset = "0x16B2F28", VA = "0x7BBBEB2F28")]
		private void OnTopPlayerArmLevelCome(params object[] param)
		{
		}

		// Token: 0x06005521 RID: 21793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005521")]
		[Address(RVA = "0x16B2B5C", Offset = "0x16B2B5C", VA = "0x7BBBEB2B5C")]
		private void UpdateMaxLevel()
		{
		}

		// Token: 0x06005522 RID: 21794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005522")]
		[Address(RVA = "0x16B2530", Offset = "0x16B2530", VA = "0x7BBBEB2530")]
		private void UpdateSelfArmInfo()
		{
		}

		// Token: 0x06005523 RID: 21795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005523")]
		[Address(RVA = "0x16B2900", Offset = "0x16B2900", VA = "0x7BBBEB2900")]
		private void UpdateTopArmInfo()
		{
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005524")]
		[Address(RVA = "0x16B278C", Offset = "0x16B278C", VA = "0x7BBBEB278C")]
		private void UpdateSelfRank()
		{
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005525")]
		[Address(RVA = "0x16B2FBC", Offset = "0x16B2FBC", VA = "0x7BBBEB2FBC")]
		private void SetWeaponIcon(uint weaponID, UISprite uiSprite)
		{
		}

		// Token: 0x06005526 RID: 21798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005526")]
		[Address(RVA = "0x16B30E8", Offset = "0x16B30E8", VA = "0x7BBBEB30E8")]
		private void Update()
		{
		}

		// Token: 0x06005527 RID: 21799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005527")]
		[Address(RVA = "0x16B332C", Offset = "0x16B332C", VA = "0x7BBBEB332C")]
		public UIHUDArmsRaceMatchInfoController()
		{
		}

		// Token: 0x04007A35 RID: 31285
		[Token(Token = "0x4007A35")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDArmsRaceMatchInfoView m_View;

		// Token: 0x04007A36 RID: 31286
		[Token(Token = "0x4007A36")]
		[FieldOffset(Offset = "0x60")]
		private int m_SelfRank;

		// Token: 0x04007A37 RID: 31287
		[Token(Token = "0x4007A37")]
		[FieldOffset(Offset = "0x64")]
		private int m_SelfArmLevel;

		// Token: 0x04007A38 RID: 31288
		[Token(Token = "0x4007A38")]
		[FieldOffset(Offset = "0x68")]
		private int m_TopArmLevel;

		// Token: 0x04007A39 RID: 31289
		[Token(Token = "0x4007A39")]
		[FieldOffset(Offset = "0x6C")]
		private uint m_GameEndTimeMS;

		// Token: 0x04007A3A RID: 31290
		[Token(Token = "0x4007A3A")]
		[FieldOffset(Offset = "0x70")]
		private uint mSeconds;

		// Token: 0x04007A3B RID: 31291
		[Token(Token = "0x4007A3B")]
		[FieldOffset(Offset = "0x78")]
		private StringBuilder m_Timer;
	}
}
