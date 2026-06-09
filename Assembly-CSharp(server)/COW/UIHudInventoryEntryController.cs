using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018ED RID: 6381
	[Token(Token = "0x20018ED")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F52C4", Offset = "0x10F52C4")]
	internal class UIHudInventoryEntryController : UIBaseController
	{
		// Token: 0x06007FBD RID: 32701 RVA: 0x00022DD0 File Offset: 0x00020FD0
		[Token(Token = "0x6007FBD")]
		[Address(RVA = "0x1C42080", Offset = "0x1C42080", VA = "0x7BBC442080")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007FBE RID: 32702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FBE")]
		[Address(RVA = "0x1C420D0", Offset = "0x1C420D0", VA = "0x7BBC4420D0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007FBF RID: 32703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FBF")]
		[Address(RVA = "0x1C424C4", Offset = "0x1C424C4", VA = "0x7BBC4424C4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007FC0 RID: 32704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FC0")]
		[Address(RVA = "0x1C427DC", Offset = "0x1C427DC", VA = "0x7BBC4427DC")]
		private void OnBtnInventoryClick()
		{
		}

		// Token: 0x06007FC1 RID: 32705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FC1")]
		[Address(RVA = "0x1C42944", Offset = "0x1C42944", VA = "0x7BBC442944")]
		private void OnAddLocalPlayer(params object[] param)
		{
		}

		// Token: 0x06007FC2 RID: 32706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FC2")]
		[Address(RVA = "0x1C4299C", Offset = "0x1C4299C", VA = "0x7BBC44299C")]
		private void OnCapacityRefresh(params object[] param)
		{
		}

		// Token: 0x06007FC3 RID: 32707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FC3")]
		[Address(RVA = "0x1C42E58", Offset = "0x1C42E58", VA = "0x7BBC442E58")]
		private void OnInventoryPickup(params object[] param)
		{
		}

		// Token: 0x06007FC4 RID: 32708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FC4")]
		[Address(RVA = "0x1C42FDC", Offset = "0x1C42FDC", VA = "0x7BBC442FDC")]
		private void OnInventoryNoCapacityToPickup(params object[] param)
		{
		}

		// Token: 0x06007FC5 RID: 32709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FC5")]
		[Address(RVA = "0x1C4313C", Offset = "0x1C4313C", VA = "0x7BBC44313C")]
		private void ShowTutoDropCamouflageOpenBag(params object[] param)
		{
		}

		// Token: 0x06007FC6 RID: 32710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FC6")]
		[Address(RVA = "0x1C4329C", Offset = "0x1C4329C", VA = "0x7BBC44329C")]
		private void OnInventoryUpdateLevel(params object[] param)
		{
		}

		// Token: 0x06007FC7 RID: 32711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FC7")]
		[Address(RVA = "0x1C433E8", Offset = "0x1C433E8", VA = "0x7BBC4433E8")]
		private void OnEnableInventory(params object[] param)
		{
		}

		// Token: 0x06007FC8 RID: 32712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FC8")]
		[Address(RVA = "0x1C43498", Offset = "0x1C43498", VA = "0x7BBC443498")]
		private void OnTrainingZoneChanged(params object[] param)
		{
		}

		// Token: 0x06007FC9 RID: 32713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FC9")]
		[Address(RVA = "0x1C43544", Offset = "0x1C43544", VA = "0x7BBC443544")]
		public UIHudInventoryEntryController()
		{
		}

		// Token: 0x0400926A RID: 37482
		[Token(Token = "0x400926A")]
		[FieldOffset(Offset = "0x58")]
		private UIHudInventoryEntryView m_View;

		// Token: 0x0400926B RID: 37483
		[Token(Token = "0x400926B")]
		[FieldOffset(Offset = "0x60")]
		private Color32 m_CommonColor;

		// Token: 0x0400926C RID: 37484
		[Token(Token = "0x400926C")]
		[FieldOffset(Offset = "0x64")]
		private Color32 m_MaxColor;

		// Token: 0x0400926D RID: 37485
		[Token(Token = "0x400926D")]
		[FieldOffset(Offset = "0x68")]
		public bool InventoryDisabled;
	}
}
