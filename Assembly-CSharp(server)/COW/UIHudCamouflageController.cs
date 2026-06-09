using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200188C RID: 6284
	[Token(Token = "0x200188C")]
	internal class UIHudCamouflageController : UIHudButtonBaseController
	{
		// Token: 0x06007C6C RID: 31852 RVA: 0x00022320 File Offset: 0x00020520
		[Token(Token = "0x6007C6C")]
		[Address(RVA = "0x19CFF3C", Offset = "0x19CFF3C", VA = "0x7BBC1CFF3C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007C6D RID: 31853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C6D")]
		[Address(RVA = "0x19CFF8C", Offset = "0x19CFF8C", VA = "0x7BBC1CFF8C", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06007C6E RID: 31854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C6E")]
		[Address(RVA = "0x19CFFD4", Offset = "0x19CFFD4", VA = "0x7BBC1CFFD4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007C6F RID: 31855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C6F")]
		[Address(RVA = "0x19D01E0", Offset = "0x19D01E0", VA = "0x7BBC1D01E0", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06007C70 RID: 31856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C70")]
		[Address(RVA = "0x19D03DC", Offset = "0x19D03DC", VA = "0x7BBC1D03DC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007C71 RID: 31857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C71")]
		[Address(RVA = "0x19D054C", Offset = "0x19D054C", VA = "0x7BBC1D054C")]
		private void OnEquipChange(params object[] data)
		{
		}

		// Token: 0x06007C72 RID: 31858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C72")]
		[Address(RVA = "0x19D05F4", Offset = "0x19D05F4", VA = "0x7BBC1D05F4")]
		private void OnSwitchObserver(params object[] param)
		{
		}

		// Token: 0x06007C73 RID: 31859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C73")]
		[Address(RVA = "0x19D05F8", Offset = "0x19D05F8", VA = "0x7BBC1D05F8")]
		private void OnPlayerStateChange(params object[] param)
		{
		}

		// Token: 0x06007C74 RID: 31860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C74")]
		[Address(RVA = "0x19D01E4", Offset = "0x19D01E4", VA = "0x7BBC1D01E4")]
		private void UpdateShowHide()
		{
		}

		// Token: 0x06007C75 RID: 31861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C75")]
		[Address(RVA = "0x19D05FC", Offset = "0x19D05FC", VA = "0x7BBC1D05FC")]
		private void UpdateOnOff(Player localPlayer)
		{
		}

		// Token: 0x06007C76 RID: 31862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C76")]
		[Address(RVA = "0x19D06CC", Offset = "0x19D06CC", VA = "0x7BBC1D06CC")]
		private void SetGetOn(bool getOn)
		{
		}

		// Token: 0x06007C77 RID: 31863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C77")]
		[Address(RVA = "0x19D0640", Offset = "0x19D0640", VA = "0x7BBC1D0640")]
		private void UpdateCdBar(Player localPlayer, W]MT\u0082aW type)
		{
		}

		// Token: 0x06007C78 RID: 31864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C78")]
		[Address(RVA = "0x19D0184", Offset = "0x19D0184", VA = "0x7BBC1D0184")]
		private void HideCdBar()
		{
		}

		// Token: 0x06007C79 RID: 31865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C79")]
		[Address(RVA = "0x19D07B0", Offset = "0x19D07B0", VA = "0x7BBC1D07B0")]
		private void ShowCdBar(float cd, float remain)
		{
		}

		// Token: 0x06007C7A RID: 31866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C7A")]
		[Address(RVA = "0x19D0954", Offset = "0x19D0954", VA = "0x7BBC1D0954")]
		public UIHudCamouflageController()
		{
		}

		// Token: 0x0400905F RID: 36959
		[Token(Token = "0x400905F")]
		[FieldOffset(Offset = "0x60")]
		private UIHudCamouflageView m_View;

		// Token: 0x04009060 RID: 36960
		[Token(Token = "0x4009060")]
		[FieldOffset(Offset = "0x68")]
		private bool m_GetOn;
	}
}
