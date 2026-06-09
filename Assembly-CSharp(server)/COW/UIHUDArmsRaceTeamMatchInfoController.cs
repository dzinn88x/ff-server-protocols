using System;
using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001428 RID: 5160
	[Token(Token = "0x2001428")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC890", Offset = "0x10EC890")]
	public class UIHUDArmsRaceTeamMatchInfoController : UIBaseController
	{
		// Token: 0x06005548 RID: 21832 RVA: 0x000196E0 File Offset: 0x000178E0
		[Token(Token = "0x6005548")]
		[Address(RVA = "0x16B3B18", Offset = "0x16B3B18", VA = "0x7BBBEB3B18")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005549 RID: 21833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005549")]
		[Address(RVA = "0x16B3B68", Offset = "0x16B3B68", VA = "0x7BBBEB3B68", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600554A RID: 21834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600554A")]
		[Address(RVA = "0x16B3E20", Offset = "0x16B3E20", VA = "0x7BBBEB3E20", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600554B RID: 21835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600554B")]
		[Address(RVA = "0x16B4068", Offset = "0x16B4068", VA = "0x7BBBEB4068")]
		private void OnGameArmsListCome(params object[] param)
		{
		}

		// Token: 0x0600554C RID: 21836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600554C")]
		[Address(RVA = "0x16B454C", Offset = "0x16B454C", VA = "0x7BBBEB454C")]
		private void UpdateMaxLevel()
		{
		}

		// Token: 0x0600554D RID: 21837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600554D")]
		[Address(RVA = "0x16B4768", Offset = "0x16B4768", VA = "0x7BBBEB4768")]
		private void OnBattleTimeCome(params object[] parma)
		{
		}

		// Token: 0x0600554E RID: 21838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600554E")]
		[Address(RVA = "0x16B47F0", Offset = "0x16B47F0", VA = "0x7BBBEB47F0")]
		private void OnSelfArmLevelCome(params object[] param)
		{
		}

		// Token: 0x0600554F RID: 21839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600554F")]
		[Address(RVA = "0x16B4884", Offset = "0x16B4884", VA = "0x7BBBEB4884")]
		private void OnOpponentArmLevelCome(params object[] param)
		{
		}

		// Token: 0x06005550 RID: 21840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005550")]
		[Address(RVA = "0x16B4094", Offset = "0x16B4094", VA = "0x7BBBEB4094")]
		private void UpdateSelfArmInfo()
		{
		}

		// Token: 0x06005551 RID: 21841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005551")]
		[Address(RVA = "0x16B42F0", Offset = "0x16B42F0", VA = "0x7BBBEB42F0")]
		private void UpdateOpponentArmInfo()
		{
		}

		// Token: 0x06005552 RID: 21842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005552")]
		[Address(RVA = "0x16B4918", Offset = "0x16B4918", VA = "0x7BBBEB4918")]
		private void SetWeaponIcon(uint weaponID, UISprite uiSprite)
		{
		}

		// Token: 0x06005553 RID: 21843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005553")]
		[Address(RVA = "0x16B4A44", Offset = "0x16B4A44", VA = "0x7BBBEB4A44")]
		private void Update()
		{
		}

		// Token: 0x06005554 RID: 21844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005554")]
		[Address(RVA = "0x16B4C88", Offset = "0x16B4C88", VA = "0x7BBBEB4C88")]
		private void OpenScoreBoard()
		{
		}

		// Token: 0x06005555 RID: 21845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005555")]
		[Address(RVA = "0x16B4D48", Offset = "0x16B4D48", VA = "0x7BBBEB4D48")]
		public UIHUDArmsRaceTeamMatchInfoController()
		{
		}

		// Token: 0x04007A48 RID: 31304
		[Token(Token = "0x4007A48")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDArmsRaceTeamMatchInfoView m_View;

		// Token: 0x04007A49 RID: 31305
		[Token(Token = "0x4007A49")]
		[FieldOffset(Offset = "0x60")]
		private int m_SelfArmLevel;

		// Token: 0x04007A4A RID: 31306
		[Token(Token = "0x4007A4A")]
		[FieldOffset(Offset = "0x64")]
		private int m_OpponentArmLevel;

		// Token: 0x04007A4B RID: 31307
		[Token(Token = "0x4007A4B")]
		[FieldOffset(Offset = "0x68")]
		private uint m_GameEndTimeMS;

		// Token: 0x04007A4C RID: 31308
		[Token(Token = "0x4007A4C")]
		[FieldOffset(Offset = "0x6C")]
		private uint mSeconds;

		// Token: 0x04007A4D RID: 31309
		[Token(Token = "0x4007A4D")]
		[FieldOffset(Offset = "0x70")]
		private StringBuilder m_Timer;
	}
}
