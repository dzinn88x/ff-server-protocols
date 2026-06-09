using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200193B RID: 6459
	[Token(Token = "0x200193B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5CF4", Offset = "0x10F5CF4")]
	internal class UIHudQuickUseMedkitController : UIBaseController
	{
		// Token: 0x060082E3 RID: 33507 RVA: 0x000238F8 File Offset: 0x00021AF8
		[Token(Token = "0x60082E3")]
		[Address(RVA = "0x17E11EC", Offset = "0x17E11EC", VA = "0x7BBBFE11EC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060082E4 RID: 33508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082E4")]
		[Address(RVA = "0x17E123C", Offset = "0x17E123C", VA = "0x7BBBFE123C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060082E5 RID: 33509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082E5")]
		[Address(RVA = "0x17E1780", Offset = "0x17E1780", VA = "0x7BBBFE1780", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x060082E6 RID: 33510 RVA: 0x00023910 File Offset: 0x00021B10
		[Token(Token = "0x170009AC")]
		private bool CanDriverUseMedkit
		{
			[Token(Token = "0x60082E6")]
			[Address(RVA = "0x17E1B94", Offset = "0x17E1B94", VA = "0x7BBBFE1B94")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060082E7 RID: 33511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082E7")]
		[Address(RVA = "0x17E1C18", Offset = "0x17E1C18", VA = "0x7BBBFE1C18")]
		private void OnBtnQuickUse()
		{
		}

		// Token: 0x060082E8 RID: 33512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082E8")]
		[Address(RVA = "0x17E20E4", Offset = "0x17E20E4", VA = "0x7BBBFE20E4")]
		private void OnShowedEffect(params object[] param)
		{
		}

		// Token: 0x060082E9 RID: 33513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082E9")]
		[Address(RVA = "0x17E2264", Offset = "0x17E2264", VA = "0x7BBBFE2264")]
		private void OnInventoryMedkitChanged(params object[] param)
		{
		}

		// Token: 0x060082EA RID: 33514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082EA")]
		[Address(RVA = "0x17E2878", Offset = "0x17E2878", VA = "0x7BBBFE2878")]
		private void OnInventoryInhalerChanged(params object[] param)
		{
		}

		// Token: 0x060082EB RID: 33515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082EB")]
		[Address(RVA = "0x17E291C", Offset = "0x17E291C", VA = "0x7BBBFE291C")]
		private void OnInventoryPickup(params object[] param)
		{
		}

		// Token: 0x060082EC RID: 33516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082EC")]
		[Address(RVA = "0x17E2BC4", Offset = "0x17E2BC4", VA = "0x7BBBFE2BC4", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060082ED RID: 33517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082ED")]
		[Address(RVA = "0x17E2DF0", Offset = "0x17E2DF0", VA = "0x7BBBFE2DF0")]
		private void Update()
		{
		}

		// Token: 0x060082EE RID: 33518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082EE")]
		[Address(RVA = "0x17E314C", Offset = "0x17E314C", VA = "0x7BBBFE314C")]
		private void OnLocalPlayerPhysicsStateChange(object[] data)
		{
		}

		// Token: 0x060082EF RID: 33519 RVA: 0x00023928 File Offset: 0x00021B28
		[Token(Token = "0x60082EF")]
		[Address(RVA = "0x17E3150", Offset = "0x17E3150", VA = "0x7BBBFE3150")]
		private bool CheckToShowUse({QAb\u0082~u pId)
		{
			return default(bool);
		}

		// Token: 0x060082F0 RID: 33520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082F0")]
		[Address(RVA = "0x17E33CC", Offset = "0x17E33CC", VA = "0x7BBBFE33CC")]
		private void OnPlayerTryUseItem(params object[] param)
		{
		}

		// Token: 0x060082F1 RID: 33521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082F1")]
		[Address(RVA = "0x17E3718", Offset = "0x17E3718", VA = "0x7BBBFE3718")]
		private void OnPlayerCancelUseItem(params object[] param)
		{
		}

		// Token: 0x060082F2 RID: 33522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082F2")]
		[Address(RVA = "0x17E38F4", Offset = "0x17E38F4", VA = "0x7BBBFE38F4")]
		private void OnHPChanged(params object[] data)
		{
		}

		// Token: 0x060082F3 RID: 33523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082F3")]
		[Address(RVA = "0x17E3B60", Offset = "0x17E3B60", VA = "0x7BBBFE3B60")]
		private void OnGetOnVehicle(params object[] param)
		{
		}

		// Token: 0x060082F4 RID: 33524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082F4")]
		[Address(RVA = "0x17E3CB8", Offset = "0x17E3CB8", VA = "0x7BBBFE3CB8")]
		private void OnGetOffVehicle(params object[] param)
		{
		}

		// Token: 0x060082F5 RID: 33525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082F5")]
		[Address(RVA = "0x17E2C98", Offset = "0x17E2C98", VA = "0x7BBBFE2C98")]
		private void UpdateIconStatus(Player p)
		{
		}

		// Token: 0x060082F6 RID: 33526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082F6")]
		[Address(RVA = "0x17E26E8", Offset = "0x17E26E8", VA = "0x7BBBFE26E8")]
		private void UpdateUrgencyEffect()
		{
		}

		// Token: 0x060082F7 RID: 33527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082F7")]
		[Address(RVA = "0x17E3E10", Offset = "0x17E3E10", VA = "0x7BBBFE3E10")]
		private void OnTrainingZoneChanged(params object[] param)
		{
		}

		// Token: 0x060082F8 RID: 33528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082F8")]
		[Address(RVA = "0x17E2310", Offset = "0x17E2310", VA = "0x7BBBFE2310")]
		private void RefreshQuickUseIconShow()
		{
		}

		// Token: 0x060082F9 RID: 33529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082F9")]
		[Address(RVA = "0x17E3EBC", Offset = "0x17E3EBC", VA = "0x7BBBFE3EBC")]
		public UIHudQuickUseMedkitController()
		{
		}

		// Token: 0x04009408 RID: 37896
		[Token(Token = "0x4009408")]
		[FieldOffset(Offset = "0x58")]
		private UIHudQuickUseMedkitView m_View;

		// Token: 0x04009409 RID: 37897
		[Token(Token = "0x4009409")]
		[FieldOffset(Offset = "0x60")]
		private float m_StartTime;

		// Token: 0x0400940A RID: 37898
		[Token(Token = "0x400940A")]
		[FieldOffset(Offset = "0x64")]
		private float m_TotalTime;

		// Token: 0x0400940B RID: 37899
		[Token(Token = "0x400940B")]
		[FieldOffset(Offset = "0x68")]
		private int m_MedkitCount;

		// Token: 0x0400940C RID: 37900
		[Token(Token = "0x400940C")]
		[FieldOffset(Offset = "0x6C")]
		private int m_InhalerCount;

		// Token: 0x0400940D RID: 37901
		[Token(Token = "0x400940D")]
		[FieldOffset(Offset = "0x70")]
		private Player m_LocalPlayer;

		// Token: 0x0400940E RID: 37902
		[Token(Token = "0x400940E")]
		[FieldOffset(Offset = "0x78")]
		private bool isPlayerWalking;

		// Token: 0x0400940F RID: 37903
		[Token(Token = "0x400940F")]
		[FieldOffset(Offset = "0x7C")]
		private UIHudQuickUseMedkitController.EQuickUseType showType;

		// Token: 0x04009410 RID: 37904
		[Token(Token = "0x4009410")]
		private const string MEDKIT_ICON_SPRITENAME = "UI_icon_FirstAidKit";

		// Token: 0x04009411 RID: 37905
		[Token(Token = "0x4009411")]
		private const string INHALER_ICON_SPRITENAME = "Icon_HUD_Gold_INHALER_Attachment";

		// Token: 0x0200193C RID: 6460
		[Token(Token = "0x200193C")]
		private enum EQuickUseType
		{
			// Token: 0x04009413 RID: 37907
			[Token(Token = "0x4009413")]
			Medkit,
			// Token: 0x04009414 RID: 37908
			[Token(Token = "0x4009414")]
			Inhaler
		}
	}
}
