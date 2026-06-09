using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200192D RID: 6445
	[Token(Token = "0x200192D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5B24", Offset = "0x10F5B24")]
	public class UIHudPlayerArmorStatsController : UIBaseController
	{
		// Token: 0x0600824E RID: 33358 RVA: 0x00023778 File Offset: 0x00021978
		[Token(Token = "0x600824E")]
		[Address(RVA = "0x1D787E8", Offset = "0x1D787E8", VA = "0x7BBC5787E8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600824F RID: 33359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600824F")]
		[Address(RVA = "0x1D78838", Offset = "0x1D78838", VA = "0x7BBC578838", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008250 RID: 33360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008250")]
		[Address(RVA = "0x1D78A54", Offset = "0x1D78A54", VA = "0x7BBC578A54", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008251 RID: 33361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008251")]
		[Address(RVA = "0x1D78DE4", Offset = "0x1D78DE4", VA = "0x7BBC578DE4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06008252 RID: 33362 RVA: 0x00023790 File Offset: 0x00021990
		[Token(Token = "0x170009AB")]
		private bool CanDriverUse
		{
			[Token(Token = "0x6008252")]
			[Address(RVA = "0x1D790FC", Offset = "0x1D790FC", VA = "0x7BBC5790FC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06008253 RID: 33363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008253")]
		[Address(RVA = "0x1D79180", Offset = "0x1D79180", VA = "0x7BBC579180")]
		private void OnBtnQuickUse()
		{
		}

		// Token: 0x06008254 RID: 33364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008254")]
		[Address(RVA = "0x1D79470", Offset = "0x1D79470", VA = "0x7BBC579470")]
		private void OnInventoryRepairArmorChanged(params object[] param)
		{
		}

		// Token: 0x06008255 RID: 33365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008255")]
		[Address(RVA = "0x1D7974C", Offset = "0x1D7974C", VA = "0x7BBC57974C")]
		private void OnPlayerDead(params object[] data)
		{
		}

		// Token: 0x06008256 RID: 33366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008256")]
		[Address(RVA = "0x1D79508", Offset = "0x1D79508", VA = "0x7BBC579508")]
		private void UpdatetVisibility()
		{
		}

		// Token: 0x06008257 RID: 33367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008257")]
		[Address(RVA = "0x1D798D8", Offset = "0x1D798D8", VA = "0x7BBC5798D8")]
		private void OnReadyToGlide(params object[] data)
		{
		}

		// Token: 0x06008258 RID: 33368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008258")]
		[Address(RVA = "0x1D79968", Offset = "0x1D79968", VA = "0x7BBC579968")]
		private void OnGetOnOffSkateboard(params object[] data)
		{
		}

		// Token: 0x06008259 RID: 33369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008259")]
		[Address(RVA = "0x1D79AEC", Offset = "0x1D79AEC", VA = "0x7BBC579AEC")]
		private void UpdateUseBtnStatust(params object[] InParams)
		{
		}

		// Token: 0x0600825A RID: 33370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600825A")]
		[Address(RVA = "0x1D79CC4", Offset = "0x1D79CC4", VA = "0x7BBC579CC4")]
		private void BindPlayer(Player p)
		{
		}

		// Token: 0x0600825B RID: 33371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600825B")]
		[Address(RVA = "0x1D79CCC", Offset = "0x1D79CCC", VA = "0x7BBC579CCC")]
		private void OnAddPlayer(params object[] data)
		{
		}

		// Token: 0x0600825C RID: 33372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600825C")]
		[Address(RVA = "0x1D79D74", Offset = "0x1D79D74", VA = "0x7BBC579D74")]
		private void OnObservePlayer(object[] data)
		{
		}

		// Token: 0x0600825D RID: 33373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600825D")]
		[Address(RVA = "0x1D7AB30", Offset = "0x1D7AB30", VA = "0x7BBC57AB30")]
		private void OnPlayerPostInit(params object[] data)
		{
		}

		// Token: 0x0600825E RID: 33374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600825E")]
		[Address(RVA = "0x1D79EA4", Offset = "0x1D79EA4", VA = "0x7BBC579EA4")]
		private void RefreshEquipmentStats(ByGSUuj InSlot = ByGSUuj.Unknown)
		{
		}

		// Token: 0x0600825F RID: 33375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600825F")]
		[Address(RVA = "0x1D7AB38", Offset = "0x1D7AB38", VA = "0x7BBC57AB38")]
		private void OnRecoverArmorDurability(params object[] parms)
		{
		}

		// Token: 0x06008260 RID: 33376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008260")]
		[Address(RVA = "0x1D7ACA8", Offset = "0x1D7ACA8", VA = "0x7BBC57ACA8")]
		private void RecoverArmorDurability()
		{
		}

		// Token: 0x06008261 RID: 33377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008261")]
		[Address(RVA = "0x1D7AF24", Offset = "0x1D7AF24", VA = "0x7BBC57AF24")]
		private void OnEnquipmentEquipStateChanged(params object[] InParams)
		{
		}

		// Token: 0x06008262 RID: 33378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008262")]
		[Address(RVA = "0x1D7B0B8", Offset = "0x1D7B0B8", VA = "0x7BBC57B0B8")]
		public void RefreshStrengthenArmorUI()
		{
		}

		// Token: 0x06008263 RID: 33379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008263")]
		[Address(RVA = "0x1D7B374", Offset = "0x1D7B374", VA = "0x7BBC57B374")]
		public UIHudPlayerArmorStatsController()
		{
		}

		// Token: 0x04009398 RID: 37784
		[Token(Token = "0x4009398")]
		[FieldOffset(Offset = "0x58")]
		private UIHudPlayerArmorStatsView m_View;

		// Token: 0x04009399 RID: 37785
		[Token(Token = "0x4009399")]
		[FieldOffset(Offset = "0x60")]
		private Player m_Player;

		// Token: 0x0400939A RID: 37786
		[Token(Token = "0x400939A")]
		[FieldOffset(Offset = "0x68")]
		private Player.\u0081HFicwE m_FoldingWingStatus;

		// Token: 0x0400939B RID: 37787
		[Token(Token = "0x400939B")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_IsSkateboarding;

		// Token: 0x0400939C RID: 37788
		[Token(Token = "0x400939C")]
		[FieldOffset(Offset = "0x70")]
		private int curHelmetLevel;

		// Token: 0x0400939D RID: 37789
		[Token(Token = "0x400939D")]
		[FieldOffset(Offset = "0x74")]
		private int curArmorLevel;

		// Token: 0x0400939E RID: 37790
		[Token(Token = "0x400939E")]
		[FieldOffset(Offset = "0x78")]
		private string FilledArmorIcon;

		// Token: 0x0400939F RID: 37791
		[Token(Token = "0x400939F")]
		[FieldOffset(Offset = "0x80")]
		private string FilledArmorIconBG;

		// Token: 0x040093A0 RID: 37792
		[Token(Token = "0x40093A0")]
		[FieldOffset(Offset = "0x88")]
		private string FilledArmorIconExplode;

		// Token: 0x040093A1 RID: 37793
		[Token(Token = "0x40093A1")]
		[FieldOffset(Offset = "0x90")]
		private string FilledArmorIconExplodeBG;

		// Token: 0x040093A2 RID: 37794
		[Token(Token = "0x40093A2")]
		[FieldOffset(Offset = "0x98")]
		private string FilledHeadIcon;

		// Token: 0x040093A3 RID: 37795
		[Token(Token = "0x40093A3")]
		[FieldOffset(Offset = "0xA0")]
		private string FilledHeadIconBG;

		// Token: 0x040093A4 RID: 37796
		[Token(Token = "0x40093A4")]
		[FieldOffset(Offset = "0xA8")]
		private string FilledHeadIconProtect;

		// Token: 0x040093A5 RID: 37797
		[Token(Token = "0x40093A5")]
		[FieldOffset(Offset = "0xB0")]
		private string FilledHeadIconProtectBG;

		// Token: 0x040093A6 RID: 37798
		[Token(Token = "0x40093A6")]
		[FieldOffset(Offset = "0xB8")]
		private Color NormalColor;

		// Token: 0x040093A7 RID: 37799
		[Token(Token = "0x40093A7")]
		[FieldOffset(Offset = "0xC8")]
		private Color InRecoverColor;
	}
}
