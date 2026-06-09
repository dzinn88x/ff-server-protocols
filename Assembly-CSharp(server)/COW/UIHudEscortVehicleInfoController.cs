using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018BB RID: 6331
	[Token(Token = "0x20018BB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4B54", Offset = "0x10F4B54")]
	internal class UIHudEscortVehicleInfoController : UIBaseController
	{
		// Token: 0x06007DF8 RID: 32248 RVA: 0x00022818 File Offset: 0x00020A18
		[Token(Token = "0x6007DF8")]
		[Address(RVA = "0x1C08154", Offset = "0x1C08154", VA = "0x7BBC408154")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007DF9 RID: 32249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DF9")]
		[Address(RVA = "0x1C081A4", Offset = "0x1C081A4", VA = "0x7BBC4081A4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007DFA RID: 32250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DFA")]
		[Address(RVA = "0x1C08B00", Offset = "0x1C08B00", VA = "0x7BBC408B00", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007DFB RID: 32251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DFB")]
		[Address(RVA = "0x1C08C74", Offset = "0x1C08C74", VA = "0x7BBC408C74")]
		private void OnBtnBodyTipClick()
		{
		}

		// Token: 0x06007DFC RID: 32252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DFC")]
		[Address(RVA = "0x1C08DF8", Offset = "0x1C08DF8", VA = "0x7BBC408DF8")]
		private void OnBtnWheelTipClick()
		{
		}

		// Token: 0x06007DFD RID: 32253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DFD")]
		[Address(RVA = "0x1C08F7C", Offset = "0x1C08F7C", VA = "0x7BBC408F7C")]
		private void OnBtnStatusTipClick()
		{
		}

		// Token: 0x06007DFE RID: 32254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DFE")]
		[Address(RVA = "0x1C09100", Offset = "0x1C09100", VA = "0x7BBC409100")]
		private void OnWheelHPChanged(params object[] data)
		{
		}

		// Token: 0x06007DFF RID: 32255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DFF")]
		[Address(RVA = "0x1C09104", Offset = "0x1C09104", VA = "0x7BBC409104")]
		private void OnBodyHPChanged(params object[] data)
		{
		}

		// Token: 0x06007E00 RID: 32256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E00")]
		[Address(RVA = "0x1C09108", Offset = "0x1C09108", VA = "0x7BBC409108")]
		private void OnStatusChanged(params object[] data)
		{
		}

		// Token: 0x06007E01 RID: 32257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E01")]
		[Address(RVA = "0x1C084C8", Offset = "0x1C084C8", VA = "0x7BBC4084C8")]
		private void UpdateWheelHPUI()
		{
		}

		// Token: 0x06007E02 RID: 32258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E02")]
		[Address(RVA = "0x1C0862C", Offset = "0x1C0862C", VA = "0x7BBC40862C")]
		private void UpdateBodyHPUI()
		{
		}

		// Token: 0x06007E03 RID: 32259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E03")]
		[Address(RVA = "0x1C08790", Offset = "0x1C08790", VA = "0x7BBC408790")]
		private void UpdateStatusUI()
		{
		}

		// Token: 0x06007E04 RID: 32260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E04")]
		[Address(RVA = "0x1C0910C", Offset = "0x1C0910C", VA = "0x7BBC40910C")]
		public UIHudEscortVehicleInfoController()
		{
		}

		// Token: 0x04009156 RID: 37206
		[Token(Token = "0x4009156")]
		[FieldOffset(Offset = "0x58")]
		private UIHudEscortVehicleInfoView m_View;

		// Token: 0x04009157 RID: 37207
		[Token(Token = "0x4009157")]
		[FieldOffset(Offset = "0x60")]
		private rwKefBm mGame;

		// Token: 0x04009158 RID: 37208
		[Token(Token = "0x4009158")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color HP_COLOR_YELLOW;

		// Token: 0x04009159 RID: 37209
		[Token(Token = "0x4009159")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color HP_COLOR_GREEN;

		// Token: 0x0400915A RID: 37210
		[Token(Token = "0x400915A")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Color HP_COLOR_RED;

		// Token: 0x0400915B RID: 37211
		[Token(Token = "0x400915B")]
		[FieldOffset(Offset = "0x68")]
		private UIGuideTipsController m_GuideTipsCtrl;

		// Token: 0x0400915C RID: 37212
		[Token(Token = "0x400915C")]
		[FieldOffset(Offset = "0x70")]
		private UIHudCommonlTipsController m_CurrentTips;
	}
}
