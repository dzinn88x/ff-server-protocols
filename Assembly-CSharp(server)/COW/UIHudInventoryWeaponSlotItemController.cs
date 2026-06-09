using System;
using System.Text;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018F0 RID: 6384
	[Token(Token = "0x20018F0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F536C", Offset = "0x10F536C")]
	internal class UIHudInventoryWeaponSlotItemController : UIInventoryItemControllerBase
	{
		// Token: 0x06007FEB RID: 32747 RVA: 0x00022E60 File Offset: 0x00021060
		[Token(Token = "0x6007FEB")]
		[Address(RVA = "0x1C464CC", Offset = "0x1C464CC", VA = "0x7BBC4464CC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007FEC RID: 32748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FEC")]
		[Address(RVA = "0x1C4651C", Offset = "0x1C4651C", VA = "0x7BBC44651C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007FED RID: 32749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FED")]
		[Address(RVA = "0x1C46E00", Offset = "0x1C46E00", VA = "0x7BBC446E00", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06007FEE RID: 32750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FEE")]
		[Address(RVA = "0x1C39828", Offset = "0x1C39828", VA = "0x7BBC439828")]
		public UIInventoryItemDragDropContainer GetDragContatiner()
		{
			return null;
		}

		// Token: 0x06007FEF RID: 32751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FEF")]
		[Address(RVA = "0x1C46E70", Offset = "0x1C46E70", VA = "0x7BBC446E70", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007FF0 RID: 32752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FF0")]
		[Address(RVA = "0x1C47044", Offset = "0x1C47044", VA = "0x7BBC447044")]
		private void RegisterEnergyWeaponEvents()
		{
		}

		// Token: 0x06007FF1 RID: 32753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FF1")]
		[Address(RVA = "0x1C46F68", Offset = "0x1C46F68", VA = "0x7BBC446F68")]
		private void UnRegisterEnergyWeaponEvents()
		{
		}

		// Token: 0x06007FF2 RID: 32754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FF2")]
		[Address(RVA = "0x1C47124", Offset = "0x1C47124", VA = "0x7BBC447124")]
		private void OnEnergyWeaponEnergyChange(params object[] ps)
		{
		}

		// Token: 0x06007FF3 RID: 32755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FF3")]
		[Address(RVA = "0x1C4130C", Offset = "0x1C4130C", VA = "0x7BBC44130C")]
		public void RefreshWeaponAmmo()
		{
		}

		// Token: 0x06007FF4 RID: 32756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FF4")]
		[Address(RVA = "0x1C3E660", Offset = "0x1C3E660", VA = "0x7BBC43E660")]
		public void RefreshAttachmentState()
		{
		}

		// Token: 0x06007FF5 RID: 32757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FF5")]
		[Address(RVA = "0x1C397D4", Offset = "0x1C397D4", VA = "0x7BBC4397D4")]
		public void SetDrapDropType(EInventoryDragDropContainerType type, GameObject emptyBG)
		{
		}

		// Token: 0x06007FF6 RID: 32758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FF6")]
		[Address(RVA = "0x1C3B3AC", Offset = "0x1C3B3AC", VA = "0x7BBC43B3AC")]
		public void RefreshWeaponSprite()
		{
		}

		// Token: 0x06007FF7 RID: 32759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FF7")]
		[Address(RVA = "0x1C47128", Offset = "0x1C47128", VA = "0x7BBC447128")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		// Token: 0x06007FF8 RID: 32760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FF8")]
		[Address(RVA = "0x1C472E4", Offset = "0x1C472E4", VA = "0x7BBC4472E4")]
		private void OnInventoryOpen(params object[] data)
		{
		}

		// Token: 0x06007FF9 RID: 32761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FF9")]
		[Address(RVA = "0x1C40148", Offset = "0x1C40148", VA = "0x7BBC440148")]
		public void SetUIData(UIItem item)
		{
		}

		// Token: 0x06007FFA RID: 32762 RVA: 0x00022E78 File Offset: 0x00021078
		[Token(Token = "0x6007FFA")]
		[Address(RVA = "0x1C47420", Offset = "0x1C47420", VA = "0x7BBC447420", Slot = "32")]
		protected override bool HandleReleaseEvent(UIInventoryItemDragDropContainer container)
		{
			return default(bool);
		}

		// Token: 0x06007FFB RID: 32763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FFB")]
		[Address(RVA = "0x1C47734", Offset = "0x1C47734", VA = "0x7BBC447734", Slot = "30")]
		public override void OnDrapStart()
		{
		}

		// Token: 0x06007FFC RID: 32764 RVA: 0x00022E90 File Offset: 0x00021090
		[Token(Token = "0x6007FFC")]
		[Address(RVA = "0x1C477E0", Offset = "0x1C477E0", VA = "0x7BBC4477E0", Slot = "31")]
		public override bool OnDrapRelease(UIInventoryItemDragDropContainer container)
		{
			return default(bool);
		}

		// Token: 0x06007FFD RID: 32765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FFD")]
		[Address(RVA = "0x1C47908", Offset = "0x1C47908", VA = "0x7BBC447908", Slot = "34")]
		public override UIToggle GetToggle()
		{
			return null;
		}

		// Token: 0x06007FFE RID: 32766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FFE")]
		[Address(RVA = "0x1C47934", Offset = "0x1C47934", VA = "0x7BBC447934", Slot = "35")]
		public override GameObject GetHighlightGO()
		{
			return null;
		}

		// Token: 0x06007FFF RID: 32767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FFF")]
		[Address(RVA = "0x1C47960", Offset = "0x1C47960", VA = "0x7BBC447960", Slot = "36")]
		public override GameObject GetDragGO()
		{
			return null;
		}

		// Token: 0x06008000 RID: 32768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008000")]
		[Address(RVA = "0x1C4798C", Offset = "0x1C4798C", VA = "0x7BBC44798C", Slot = "37")]
		public override GameObject GetNonDragGO()
		{
			return null;
		}

		// Token: 0x06008001 RID: 32769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008001")]
		[Address(RVA = "0x1C479B8", Offset = "0x1C479B8", VA = "0x7BBC4479B8", Slot = "38")]
		public override GameObject GetDragRedGo()
		{
			return null;
		}

		// Token: 0x06008002 RID: 32770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008002")]
		[Address(RVA = "0x1C479E4", Offset = "0x1C479E4", VA = "0x7BBC4479E4")]
		public UIHudInventoryWeaponSlotItemController()
		{
		}

		// Token: 0x06008003 RID: 32771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008003")]
		[Address(RVA = "0x1C47A44", Offset = "0x1C47A44", VA = "0x7BBC447A44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142EDC", Offset = "0x1142EDC")]
		private void <OnUIInit>b__7_0()
		{
		}

		// Token: 0x04009271 RID: 37489
		[Token(Token = "0x4009271")]
		[FieldOffset(Offset = "0x68")]
		private UIHudInventoryWeaponSlotItemView m_View;

		// Token: 0x04009272 RID: 37490
		[Token(Token = "0x4009272")]
		[FieldOffset(Offset = "0x70")]
		private GameObject m_EmptyBG;

		// Token: 0x04009273 RID: 37491
		[Token(Token = "0x4009273")]
		[FieldOffset(Offset = "0x78")]
		private UIHudInventoryAttachmentSlotItemController[] m_Attachments;

		// Token: 0x04009274 RID: 37492
		[Token(Token = "0x4009274")]
		[FieldOffset(Offset = "0x80")]
		private StringBuilder m_Sb;

		// Token: 0x04009275 RID: 37493
		[Token(Token = "0x4009275")]
		[FieldOffset(Offset = "0x88")]
		private bool m_EnergyWeaponEventsRegisterd;

		// Token: 0x04009276 RID: 37494
		[Token(Token = "0x4009276")]
		[FieldOffset(Offset = "0x8C")]
		private uint m_ShowingSpriteWeaponId;
	}
}
