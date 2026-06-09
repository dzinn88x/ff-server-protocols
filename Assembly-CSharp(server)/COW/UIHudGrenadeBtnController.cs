using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018D2 RID: 6354
	[Token(Token = "0x20018D2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4F2C", Offset = "0x10F4F2C")]
	internal class UIHudGrenadeBtnController : UIHudButtonBaseController
	{
		// Token: 0x06007EA2 RID: 32418 RVA: 0x000229E0 File Offset: 0x00020BE0
		[Token(Token = "0x6007EA2")]
		[Address(RVA = "0x19756AC", Offset = "0x19756AC", VA = "0x7BBC1756AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007EA3 RID: 32419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007EA3")]
		[Address(RVA = "0x19756FC", Offset = "0x19756FC", VA = "0x7BBC1756FC", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06007EA4 RID: 32420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EA4")]
		[Address(RVA = "0x1975744", Offset = "0x1975744", VA = "0x7BBC175744", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007EA5 RID: 32421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EA5")]
		[Address(RVA = "0x19767D4", Offset = "0x19767D4", VA = "0x7BBC1767D4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007EA6 RID: 32422 RVA: 0x000229F8 File Offset: 0x00020BF8
		[Token(Token = "0x6007EA6")]
		[Address(RVA = "0x1976D38", Offset = "0x1976D38", VA = "0x7BBC176D38")]
		public static ByGSUuj GetSlotType(UIHudGrenadeBtnController.ButtonType t)
		{
			return ByGSUuj.PrimaryWeapon1;
		}

		// Token: 0x06007EA7 RID: 32423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EA7")]
		[Address(RVA = "0x1976D5C", Offset = "0x1976D5C", VA = "0x7BBC176D5C")]
		private void OnSideWeaponChange(params object[] param)
		{
		}

		// Token: 0x06007EA8 RID: 32424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EA8")]
		[Address(RVA = "0x19771A0", Offset = "0x19771A0", VA = "0x7BBC1771A0")]
		private void GenerateSubDatas()
		{
		}

		// Token: 0x06007EA9 RID: 32425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EA9")]
		[Address(RVA = "0x1977330", Offset = "0x1977330", VA = "0x7BBC177330")]
		private void ShowSubButtons()
		{
		}

		// Token: 0x06007EAA RID: 32426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EAA")]
		[Address(RVA = "0x1976E98", Offset = "0x1976E98", VA = "0x7BBC176E98")]
		private void HideSubButtons()
		{
		}

		// Token: 0x06007EAB RID: 32427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EAB")]
		[Address(RVA = "0x1977CE8", Offset = "0x1977CE8", VA = "0x7BBC177CE8")]
		private void ToggleSubBtn()
		{
		}

		// Token: 0x06007EAC RID: 32428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EAC")]
		[Address(RVA = "0x1977CF8", Offset = "0x1977CF8", VA = "0x7BBC177CF8")]
		private new void OnBtnClick()
		{
		}

		// Token: 0x06007EAD RID: 32429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EAD")]
		[Address(RVA = "0x1977E7C", Offset = "0x1977E7C", VA = "0x7BBC177E7C")]
		private void OnArrowClick()
		{
		}

		// Token: 0x06007EAE RID: 32430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EAE")]
		[Address(RVA = "0x1977E80", Offset = "0x1977E80", VA = "0x7BBC177E80")]
		private void RefreshArrow()
		{
		}

		// Token: 0x06007EAF RID: 32431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EAF")]
		[Address(RVA = "0x19781FC", Offset = "0x19781FC", VA = "0x7BBC1781FC")]
		private void OnNewItemOnHand(params object[] param)
		{
		}

		// Token: 0x06007EB0 RID: 32432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EB0")]
		[Address(RVA = "0x19797CC", Offset = "0x19797CC", VA = "0x7BBC1797CC")]
		private void RefreshPrograssBar()
		{
		}

		// Token: 0x06007EB1 RID: 32433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EB1")]
		[Address(RVA = "0x1978860", Offset = "0x1978860", VA = "0x7BBC178860")]
		private void RefreshButton()
		{
		}

		// Token: 0x06007EB2 RID: 32434 RVA: 0x00022A10 File Offset: 0x00020C10
		[Token(Token = "0x6007EB2")]
		[Address(RVA = "0x19798AC", Offset = "0x19798AC", VA = "0x7BBC1798AC")]
		private UIHudGrenadeBtnController.ButtonType FindNextType(UIHudGrenadeBtnController.ButtonType typeidx)
		{
			return UIHudGrenadeBtnController.ButtonType.None;
		}

		// Token: 0x06007EB3 RID: 32435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EB3")]
		[Address(RVA = "0x1979950", Offset = "0x1979950", VA = "0x7BBC179950")]
		private void OnLandmineCountChange(params object[] param)
		{
		}

		// Token: 0x06007EB4 RID: 32436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EB4")]
		[Address(RVA = "0x1979A10", Offset = "0x1979A10", VA = "0x7BBC179A10")]
		private void OnFireworksCountChange(params object[] param)
		{
		}

		// Token: 0x06007EB5 RID: 32437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EB5")]
		[Address(RVA = "0x1979AD0", Offset = "0x1979AD0", VA = "0x7BBC179AD0")]
		private void OnPaintSprayerCountChange(params object[] param)
		{
		}

		// Token: 0x06007EB6 RID: 32438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EB6")]
		[Address(RVA = "0x1979C3C", Offset = "0x1979C3C", VA = "0x7BBC179C3C")]
		private void OnBuildingCountChange(params object[] param)
		{
		}

		// Token: 0x06007EB7 RID: 32439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EB7")]
		[Address(RVA = "0x1979D44", Offset = "0x1979D44", VA = "0x7BBC179D44")]
		private void OnMiniSentryCountChange(params object[] param)
		{
		}

		// Token: 0x06007EB8 RID: 32440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EB8")]
		[Address(RVA = "0x1979E04", Offset = "0x1979E04", VA = "0x7BBC179E04")]
		private void OnDummyCountChange(params object[] param)
		{
		}

		// Token: 0x06007EB9 RID: 32441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EB9")]
		[Address(RVA = "0x1979EC4", Offset = "0x1979EC4", VA = "0x7BBC179EC4")]
		private void OnMagneticFieldCountChange(params object[] param)
		{
		}

		// Token: 0x06007EBA RID: 32442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EBA")]
		[Address(RVA = "0x1979F84", Offset = "0x1979F84", VA = "0x7BBC179F84")]
		private void OnPersonalUAVCountChange(params object[] param)
		{
		}

		// Token: 0x06007EBB RID: 32443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EBB")]
		[Address(RVA = "0x197A044", Offset = "0x197A044", VA = "0x7BBC17A044")]
		private void OnLoadoutCountChange(params object[] param)
		{
		}

		// Token: 0x06007EBC RID: 32444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EBC")]
		[Address(RVA = "0x197A16C", Offset = "0x197A16C", VA = "0x7BBC17A16C")]
		private void OnGrenadeCountChange(params object[] param)
		{
		}

		// Token: 0x06007EBD RID: 32445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EBD")]
		[Address(RVA = "0x197A3B8", Offset = "0x197A3B8", VA = "0x7BBC17A3B8")]
		private void OnChargeChange(params object[] param)
		{
		}

		// Token: 0x06007EBE RID: 32446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EBE")]
		[Address(RVA = "0x1978140", Offset = "0x1978140", VA = "0x7BBC178140")]
		private void ShowTutorial()
		{
		}

		// Token: 0x06007EBF RID: 32447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EBF")]
		[Address(RVA = "0x1975F14", Offset = "0x1975F14", VA = "0x7BBC175F14")]
		private void OnDirectionChanged(params object[] param)
		{
		}

		// Token: 0x06007EC0 RID: 32448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EC0")]
		[Address(RVA = "0x197A478", Offset = "0x197A478", VA = "0x7BBC17A478")]
		public UIHudGrenadeBtnController()
		{
		}

		// Token: 0x040091D8 RID: 37336
		[Token(Token = "0x40091D8")]
		[FieldOffset(Offset = "0x60")]
		private UIHudGrenadeBtnView m_View;

		// Token: 0x040091D9 RID: 37337
		[Token(Token = "0x40091D9")]
		[FieldOffset(Offset = "0x68")]
		private UIHudGrenadeBtnController.ButtonType curType;

		// Token: 0x040091DA RID: 37338
		[Token(Token = "0x40091DA")]
		[FieldOffset(Offset = "0x70")]
		private int[] itemCount;

		// Token: 0x040091DB RID: 37339
		[Token(Token = "0x40091DB")]
		[FieldOffset(Offset = "0x78")]
		private int[] itemType;

		// Token: 0x040091DC RID: 37340
		[Token(Token = "0x40091DC")]
		[FieldOffset(Offset = "0x80")]
		private int curcharge;

		// Token: 0x040091DD RID: 37341
		[Token(Token = "0x40091DD")]
		[FieldOffset(Offset = "0x84")]
		private int maxcharge;

		// Token: 0x040091DE RID: 37342
		[Token(Token = "0x40091DE")]
		[FieldOffset(Offset = "0x88")]
		private bool HasShownTutorial;

		// Token: 0x040091DF RID: 37343
		[Token(Token = "0x40091DF")]
		[FieldOffset(Offset = "0x90")]
		private List<UIHudGrenadeSubBtnController> m_SubBtns;

		// Token: 0x040091E0 RID: 37344
		[Token(Token = "0x40091E0")]
		[FieldOffset(Offset = "0x98")]
		private List<UIHudGrenadeBtnController.GrenadeButtonData> m_SubData;

		// Token: 0x040091E1 RID: 37345
		[Token(Token = "0x40091E1")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_ShowSub;

		// Token: 0x040091E2 RID: 37346
		[Token(Token = "0x40091E2")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 m_DefaultPos;

		// Token: 0x040091E3 RID: 37347
		[Token(Token = "0x40091E3")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 m_SpPos;

		// Token: 0x020018D3 RID: 6355
		[Token(Token = "0x20018D3")]
		public enum ButtonType
		{
			// Token: 0x040091E5 RID: 37349
			[Token(Token = "0x40091E5")]
			None,
			// Token: 0x040091E6 RID: 37350
			[Token(Token = "0x40091E6")]
			Grenade,
			// Token: 0x040091E7 RID: 37351
			[Token(Token = "0x40091E7")]
			Loadout,
			// Token: 0x040091E8 RID: 37352
			[Token(Token = "0x40091E8")]
			BuildingIceWall,
			// Token: 0x040091E9 RID: 37353
			[Token(Token = "0x40091E9")]
			Landmine,
			// Token: 0x040091EA RID: 37354
			[Token(Token = "0x40091EA")]
			FlashBomb,
			// Token: 0x040091EB RID: 37355
			[Token(Token = "0x40091EB")]
			MiniSentry,
			// Token: 0x040091EC RID: 37356
			[Token(Token = "0x40091EC")]
			BuildingBrickBlock,
			// Token: 0x040091ED RID: 37357
			[Token(Token = "0x40091ED")]
			WaterBall,
			// Token: 0x040091EE RID: 37358
			[Token(Token = "0x40091EE")]
			PaintSprayer,
			// Token: 0x040091EF RID: 37359
			[Token(Token = "0x40091EF")]
			Dummy,
			// Token: 0x040091F0 RID: 37360
			[Token(Token = "0x40091F0")]
			SmokeGrenade,
			// Token: 0x040091F1 RID: 37361
			[Token(Token = "0x40091F1")]
			Fireworks,
			// Token: 0x040091F2 RID: 37362
			[Token(Token = "0x40091F2")]
			BigToyGrenade,
			// Token: 0x040091F3 RID: 37363
			[Token(Token = "0x40091F3")]
			MagneticField,
			// Token: 0x040091F4 RID: 37364
			[Token(Token = "0x40091F4")]
			PersonalUAV,
			// Token: 0x040091F5 RID: 37365
			[Token(Token = "0x40091F5")]
			MAX
		}

		// Token: 0x020018D4 RID: 6356
		[Token(Token = "0x20018D4")]
		private struct GrenadeButtonData
		{
			// Token: 0x06007EC1 RID: 32449 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EC1")]
			[Address(RVA = "0x11F06A0", Offset = "0x11F06A0", VA = "0x7BBB9F06A0")]
			public GrenadeButtonData(UIHudGrenadeBtnController.ButtonType t, int c, int it)
			{
			}

			// Token: 0x040091F6 RID: 37366
			[Token(Token = "0x40091F6")]
			[FieldOffset(Offset = "0x0")]
			public UIHudGrenadeBtnController.ButtonType type;

			// Token: 0x040091F7 RID: 37367
			[Token(Token = "0x40091F7")]
			[FieldOffset(Offset = "0x4")]
			public int count;

			// Token: 0x040091F8 RID: 37368
			[Token(Token = "0x40091F8")]
			[FieldOffset(Offset = "0x8")]
			public int itemtype;
		}
	}
}
