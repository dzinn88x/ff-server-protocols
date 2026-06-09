using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018BC RID: 6332
	[Token(Token = "0x20018BC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4B8C", Offset = "0x10F4B8C")]
	internal class UIHudEscortVehicleProgressController : UIBaseController
	{
		// Token: 0x06007E06 RID: 32262 RVA: 0x00022830 File Offset: 0x00020A30
		[Token(Token = "0x6007E06")]
		[Address(RVA = "0x1C093D4", Offset = "0x1C093D4", VA = "0x7BBC4093D4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007E07 RID: 32263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E07")]
		[Address(RVA = "0x1C09424", Offset = "0x1C09424", VA = "0x7BBC409424", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007E08 RID: 32264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E08")]
		[Address(RVA = "0x1C09C44", Offset = "0x1C09C44", VA = "0x7BBC409C44", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007E09 RID: 32265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E09")]
		[Address(RVA = "0x1C09EB4", Offset = "0x1C09EB4", VA = "0x7BBC409EB4")]
		private void OnCurrentMileStoneChanged(params object[] data)
		{
		}

		// Token: 0x06007E0A RID: 32266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E0A")]
		[Address(RVA = "0x1C098B8", Offset = "0x1C098B8", VA = "0x7BBC4098B8")]
		private void UpdateMileStoneUI()
		{
		}

		// Token: 0x06007E0B RID: 32267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E0B")]
		[Address(RVA = "0x1C09EB8", Offset = "0x1C09EB8", VA = "0x7BBC409EB8")]
		private void OnNewPhaseEnter(params object[] data)
		{
		}

		// Token: 0x06007E0C RID: 32268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E0C")]
		[Address(RVA = "0x1C0A218", Offset = "0x1C0A218", VA = "0x7BBC40A218")]
		private void OnVehiclePositionChanged(params object[] data)
		{
		}

		// Token: 0x06007E0D RID: 32269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E0D")]
		[Address(RVA = "0x1C0A4F8", Offset = "0x1C0A4F8", VA = "0x7BBC40A4F8")]
		private void OnEffectiveAttackerChanged(params object[] data)
		{
		}

		// Token: 0x06007E0E RID: 32270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E0E")]
		[Address(RVA = "0x1C09BB0", Offset = "0x1C09BB0", VA = "0x7BBC409BB0")]
		private void RefreshEffectiveAttacker()
		{
		}

		// Token: 0x06007E0F RID: 32271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E0F")]
		[Address(RVA = "0x1C0A4FC", Offset = "0x1C0A4FC", VA = "0x7BBC40A4FC")]
		private void OnEffectiveDefenderChanged(params object[] data)
		{
		}

		// Token: 0x06007E10 RID: 32272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E10")]
		[Address(RVA = "0x1C09B1C", Offset = "0x1C09B1C", VA = "0x7BBC409B1C")]
		private void RefreshEffectiveDefender()
		{
		}

		// Token: 0x06007E11 RID: 32273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E11")]
		[Address(RVA = "0x1C0A500", Offset = "0x1C0A500", VA = "0x7BBC40A500")]
		private void OnEquipmentConfirmed(params object[] data)
		{
		}

		// Token: 0x06007E12 RID: 32274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E12")]
		[Address(RVA = "0x1C0A7D4", Offset = "0x1C0A7D4", VA = "0x7BBC40A7D4")]
		protected void WaitAndHide()
		{
		}

		// Token: 0x06007E13 RID: 32275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E13")]
		[Address(RVA = "0x1C0A81C", Offset = "0x1C0A81C", VA = "0x7BBC40A81C")]
		public UIHudEscortVehicleProgressController()
		{
		}

		// Token: 0x0400915D RID: 37213
		[Token(Token = "0x400915D")]
		[FieldOffset(Offset = "0x58")]
		private UIHudEscortVehicleProgressView m_View;

		// Token: 0x0400915E RID: 37214
		[Token(Token = "0x400915E")]
		[FieldOffset(Offset = "0x60")]
		private rwKefBm mGame;

		// Token: 0x0400915F RID: 37215
		[Token(Token = "0x400915F")]
		[FieldOffset(Offset = "0x68")]
		private UIHudEscortVehicleProgressController.MileStoneInfo[] m_MileStoneInfos;

		// Token: 0x04009160 RID: 37216
		[Token(Token = "0x4009160")]
		private const int TOTAL_MILESTONE_COUNT = 4;

		// Token: 0x04009161 RID: 37217
		[Token(Token = "0x4009161")]
		private const float TOTAL_PROGRESS_BAR_LENGHTH = 331.75f;

		// Token: 0x04009162 RID: 37218
		[Token(Token = "0x4009162")]
		[FieldOffset(Offset = "0x70")]
		private Color FLAG_FINISH_COLOR;

		// Token: 0x04009163 RID: 37219
		[Token(Token = "0x4009163")]
		[FieldOffset(Offset = "0x80")]
		private Color FLAG_UNFINISH_COLOR;

		// Token: 0x04009164 RID: 37220
		[Token(Token = "0x4009164")]
		[FieldOffset(Offset = "0x90")]
		private uint m_DelayCallID;

		// Token: 0x020018BD RID: 6333
		[Token(Token = "0x20018BD")]
		private struct MileStoneInfo
		{
			// Token: 0x06007E14 RID: 32276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E14")]
			[Address(RVA = "0x11F0D4C", Offset = "0x11F0D4C", VA = "0x7BBB9F0D4C")]
			public MileStoneInfo(UISprite progressBar, UISprite flag)
			{
			}

			// Token: 0x04009165 RID: 37221
			[Token(Token = "0x4009165")]
			[FieldOffset(Offset = "0x0")]
			public UISprite ProgressBar;

			// Token: 0x04009166 RID: 37222
			[Token(Token = "0x4009166")]
			[FieldOffset(Offset = "0x8")]
			public UISprite FlagIcon;
		}
	}
}
