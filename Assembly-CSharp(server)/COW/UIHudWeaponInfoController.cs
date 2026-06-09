using System;
using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001992 RID: 6546
	[Token(Token = "0x2001992")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F69C4", Offset = "0x10F69C4")]
	internal class UIHudWeaponInfoController : UIBaseController
	{
		// Token: 0x060085A8 RID: 34216 RVA: 0x000243A8 File Offset: 0x000225A8
		[Token(Token = "0x60085A8")]
		[Address(RVA = "0x15F44FC", Offset = "0x15F44FC", VA = "0x7BBBDF44FC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060085A9 RID: 34217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085A9")]
		[Address(RVA = "0x15F454C", Offset = "0x15F454C", VA = "0x7BBBDF454C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060085AA RID: 34218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085AA")]
		[Address(RVA = "0x15F5184", Offset = "0x15F5184", VA = "0x7BBBDF5184")]
		private void ShowLevelUpGoldFX(bool show)
		{
		}

		// Token: 0x060085AB RID: 34219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085AB")]
		[Address(RVA = "0x15F532C", Offset = "0x15F532C", VA = "0x7BBBDF532C")]
		private void OnEquipAttachment(object[] data)
		{
		}

		// Token: 0x060085AC RID: 34220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085AC")]
		[Address(RVA = "0x15F5870", Offset = "0x15F5870", VA = "0x7BBBDF5870")]
		protected void OnBuffIconChange(object[] data)
		{
		}

		// Token: 0x060085AD RID: 34221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085AD")]
		[Address(RVA = "0x15F59D4", Offset = "0x15F59D4", VA = "0x7BBBDF59D4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060085AE RID: 34222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085AE")]
		[Address(RVA = "0x15F5E48", Offset = "0x15F5E48", VA = "0x7BBBDF5E48")]
		private void OnObserverInfoListVisibleChanged(object[] data)
		{
		}

		// Token: 0x060085AF RID: 34223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085AF")]
		[Address(RVA = "0x15F5EF0", Offset = "0x15F5EF0", VA = "0x7BBBDF5EF0")]
		private void OnGrenadeSwitchClick()
		{
		}

		// Token: 0x060085B0 RID: 34224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085B0")]
		[Address(RVA = "0x15F6070", Offset = "0x15F6070", VA = "0x7BBBDF6070")]
		private void OnCanCombineChanged(object[] param)
		{
		}

		// Token: 0x060085B1 RID: 34225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085B1")]
		[Address(RVA = "0x15F62E0", Offset = "0x15F62E0", VA = "0x7BBBDF62E0")]
		private void OnSecondWeaponDataEffectiveChanged(object[] param)
		{
		}

		// Token: 0x060085B2 RID: 34226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085B2")]
		[Address(RVA = "0x15F6450", Offset = "0x15F6450", VA = "0x7BBBDF6450")]
		private void OnHeavyWeaponDrop()
		{
		}

		// Token: 0x060085B3 RID: 34227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085B3")]
		[Address(RVA = "0x15F65C4", Offset = "0x15F65C4", VA = "0x7BBBDF65C4")]
		private void Update()
		{
		}

		// Token: 0x060085B4 RID: 34228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085B4")]
		[Address(RVA = "0x15F9458", Offset = "0x15F9458", VA = "0x7BBBDF9458")]
		private void UpdateWeaponShowTxt(int currentweapon, int maxweapon)
		{
		}

		// Token: 0x060085B5 RID: 34229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085B5")]
		[Address(RVA = "0x15F9A1C", Offset = "0x15F9A1C", VA = "0x7BBBDF9A1C")]
		private void RefreshBuildingInfo(AHtazwI item)
		{
		}

		// Token: 0x060085B6 RID: 34230 RVA: 0x000243C0 File Offset: 0x000225C0
		[Token(Token = "0x60085B6")]
		[Address(RVA = "0x15F9D9C", Offset = "0x15F9D9C", VA = "0x7BBBDF9D9C")]
		private bool IsSideWeapon(AHtazwI item)
		{
			return default(bool);
		}

		// Token: 0x060085B7 RID: 34231 RVA: 0x000243D8 File Offset: 0x000225D8
		[Token(Token = "0x60085B7")]
		[Address(RVA = "0x15F9E34", Offset = "0x15F9E34", VA = "0x7BBBDF9E34")]
		private bool IsHeavyWeapon(AHtazwI item)
		{
			return default(bool);
		}

		// Token: 0x060085B8 RID: 34232 RVA: 0x000243F0 File Offset: 0x000225F0
		[Token(Token = "0x60085B8")]
		[Address(RVA = "0x15F8BD8", Offset = "0x15F8BD8", VA = "0x7BBBDF8BD8")]
		private bool ShouldUpdateVehicleWeapon()
		{
			return default(bool);
		}

		// Token: 0x060085B9 RID: 34233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085B9")]
		[Address(RVA = "0x15F8CC4", Offset = "0x15F8CC4", VA = "0x7BBBDF8CC4")]
		private void UpdateVehicleWeapon(bool wasUpdating)
		{
		}

		// Token: 0x060085BA RID: 34234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085BA")]
		[Address(RVA = "0x15F9EE0", Offset = "0x15F9EE0", VA = "0x7BBBDF9EE0")]
		private void OnLastWeaponInit(params object[] param)
		{
		}

		// Token: 0x060085BB RID: 34235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085BB")]
		[Address(RVA = "0x15FA038", Offset = "0x15FA038", VA = "0x7BBBDFA038")]
		private void OnInventoryItemChanged(params object[] param)
		{
		}

		// Token: 0x060085BC RID: 34236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085BC")]
		[Address(RVA = "0x15FA114", Offset = "0x15FA114", VA = "0x7BBBDFA114")]
		private void OnObserverInventoryItemChanged(params object[] data)
		{
		}

		// Token: 0x060085BD RID: 34237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085BD")]
		[Address(RVA = "0x15FA1A8", Offset = "0x15FA1A8", VA = "0x7BBBDFA1A8", Slot = "28")]
		protected virtual void OnPlayerGetOnVehicle(params object[] ps)
		{
		}

		// Token: 0x060085BE RID: 34238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085BE")]
		[Address(RVA = "0x15F9820", Offset = "0x15F9820", VA = "0x7BBBDF9820")]
		private void RefreshUIByWeaponOnHand(ByGSUuj WeaponEquipSlot)
		{
		}

		// Token: 0x060085BF RID: 34239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085BF")]
		[Address(RVA = "0x15FA1AC", Offset = "0x15FA1AC", VA = "0x7BBBDFA1AC")]
		private void TweakUIForHyakkiMode()
		{
		}

		// Token: 0x060085C0 RID: 34240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085C0")]
		[Address(RVA = "0x15FA320", Offset = "0x15FA320", VA = "0x7BBBDFA320")]
		private void OnEnterGameLanding(params object[] data)
		{
		}

		// Token: 0x060085C1 RID: 34241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085C1")]
		[Address(RVA = "0x15FA32C", Offset = "0x15FA32C", VA = "0x7BBBDFA32C")]
		private void OnPlayerDead(params object[] data)
		{
		}

		// Token: 0x060085C2 RID: 34242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085C2")]
		[Address(RVA = "0x15FA3DC", Offset = "0x15FA3DC", VA = "0x7BBBDFA3DC")]
		private void ShowSwitchWeaponTutorial(params object[] data)
		{
		}

		// Token: 0x060085C3 RID: 34243 RVA: 0x00024408 File Offset: 0x00022608
		[Token(Token = "0x60085C3")]
		[Address(RVA = "0x15FA574", Offset = "0x15FA574", VA = "0x7BBBDFA574", Slot = "29")]
		protected virtual bool IsOnlyShowOneWeapon()
		{
			return default(bool);
		}

		// Token: 0x060085C4 RID: 34244 RVA: 0x00024420 File Offset: 0x00022620
		[Token(Token = "0x60085C4")]
		[Address(RVA = "0x15F93D0", Offset = "0x15F93D0", VA = "0x7BBBDF93D0")]
		private bool CheckSilderWeapon(AHtazwI item)
		{
			return default(bool);
		}

		// Token: 0x060085C5 RID: 34245 RVA: 0x00024438 File Offset: 0x00022638
		[Token(Token = "0x60085C5")]
		[Address(RVA = "0x15F9414", Offset = "0x15F9414", VA = "0x7BBBDF9414")]
		private bool CheckHeaveyWeapon(AHtazwI item)
		{
			return default(bool);
		}

		// Token: 0x060085C6 RID: 34246 RVA: 0x00024450 File Offset: 0x00022650
		[Token(Token = "0x60085C6")]
		[Address(RVA = "0x15FA62C", Offset = "0x15FA62C", VA = "0x7BBBDFA62C", Slot = "30")]
		protected virtual bool IsCheckSilderWeapon()
		{
			return default(bool);
		}

		// Token: 0x060085C7 RID: 34247 RVA: 0x00024468 File Offset: 0x00022668
		[Token(Token = "0x60085C7")]
		[Address(RVA = "0x15FA634", Offset = "0x15FA634", VA = "0x7BBBDFA634", Slot = "31")]
		protected virtual bool IsCheckHeaveyWeapon()
		{
			return default(bool);
		}

		// Token: 0x060085C8 RID: 34248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085C8")]
		[Address(RVA = "0x15FA63C", Offset = "0x15FA63C", VA = "0x7BBBDFA63C")]
		public UIHudWeaponInfoController()
		{
		}

		// Token: 0x04009521 RID: 38177
		[Token(Token = "0x4009521")]
		[FieldOffset(Offset = "0x58")]
		protected UIHudWeaponInfoView m_View;

		// Token: 0x04009522 RID: 38178
		[Token(Token = "0x4009522")]
		[FieldOffset(Offset = "0x60")]
		private ytMNhlw m_LastWeaponInHand;

		// Token: 0x04009523 RID: 38179
		[Token(Token = "0x4009523")]
		[FieldOffset(Offset = "0x68")]
		private ByGSUuj m_LastEquipSlot;

		// Token: 0x04009524 RID: 38180
		[Token(Token = "0x4009524")]
		[FieldOffset(Offset = "0x6C")]
		private int m_LastAmmoLeft;

		// Token: 0x04009525 RID: 38181
		[Token(Token = "0x4009525")]
		[FieldOffset(Offset = "0x70")]
		private int m_LastAmmoCapacity;

		// Token: 0x04009526 RID: 38182
		[Token(Token = "0x4009526")]
		[FieldOffset(Offset = "0x74")]
		private int m_LastAmmoLeftInBag;

		// Token: 0x04009527 RID: 38183
		[Token(Token = "0x4009527")]
		[FieldOffset(Offset = "0x78")]
		private bool m_LastCombined;

		// Token: 0x04009528 RID: 38184
		[Token(Token = "0x4009528")]
		[FieldOffset(Offset = "0x79")]
		private bool m_LastSecondWeaponDataEffective;

		// Token: 0x04009529 RID: 38185
		[Token(Token = "0x4009529")]
		[FieldOffset(Offset = "0x7A")]
		private bool m_LastHasGoldAttachment;

		// Token: 0x0400952A RID: 38186
		[Token(Token = "0x400952A")]
		[FieldOffset(Offset = "0x7B")]
		private bool m_weaponChanged;

		// Token: 0x0400952B RID: 38187
		[Token(Token = "0x400952B")]
		[FieldOffset(Offset = "0x7C")]
		private bool m_UpdateingVehicleWeapon;

		// Token: 0x0400952C RID: 38188
		[Token(Token = "0x400952C")]
		[FieldOffset(Offset = "0x7D")]
		private bool m_ModeDriverCanFire;

		// Token: 0x0400952D RID: 38189
		[Token(Token = "0x400952D")]
		[FieldOffset(Offset = "0x80")]
		private StringBuilder m_Sb;

		// Token: 0x0400952E RID: 38190
		[Token(Token = "0x400952E")]
		[FieldOffset(Offset = "0x88")]
		private bool canCheckWeaponAmmo;

		// Token: 0x0400952F RID: 38191
		[Token(Token = "0x400952F")]
		[FieldOffset(Offset = "0x89")]
		private bool m_LastComine;

		// Token: 0x04009530 RID: 38192
		[Token(Token = "0x4009530")]
		[FieldOffset(Offset = "0x90")]
		private UIHudWeaponSwitchInfoController m_Primary1WeaponController;

		// Token: 0x04009531 RID: 38193
		[Token(Token = "0x4009531")]
		[FieldOffset(Offset = "0x98")]
		private UIHudWeaponSwitchInfoController m_Primary2WeaponController;

		// Token: 0x04009532 RID: 38194
		[Token(Token = "0x4009532")]
		[FieldOffset(Offset = "0xA0")]
		private UIHudWeaponSwitchInfoController m_SecondaryWeaponController;

		// Token: 0x04009533 RID: 38195
		[Token(Token = "0x4009533")]
		[FieldOffset(Offset = "0xA8")]
		private UIHudWeaponSwitchInfoController m_MeleeWeaponController;

		// Token: 0x04009534 RID: 38196
		[Token(Token = "0x4009534")]
		[FieldOffset(Offset = "0x0")]
		public static Color AmmoColorHigh;

		// Token: 0x04009535 RID: 38197
		[Token(Token = "0x4009535")]
		[FieldOffset(Offset = "0x10")]
		public static Color AmmoColorMid;

		// Token: 0x04009536 RID: 38198
		[Token(Token = "0x4009536")]
		[FieldOffset(Offset = "0x20")]
		public static Color AmmoColorLow;

		// Token: 0x04009537 RID: 38199
		[Token(Token = "0x4009537")]
		[FieldOffset(Offset = "0x30")]
		public static Color HeatGunNormal;

		// Token: 0x04009538 RID: 38200
		[Token(Token = "0x4009538")]
		[FieldOffset(Offset = "0x40")]
		public static Color HeatGunCooling;

		// Token: 0x04009539 RID: 38201
		[Token(Token = "0x4009539")]
		[FieldOffset(Offset = "0xB0")]
		private bool needReposition;

		// Token: 0x0400953A RID: 38202
		[Token(Token = "0x400953A")]
		[FieldOffset(Offset = "0xB8")]
		private List<UIHudBuildingSwitchInfoController> m_BuildingSwitchBtns;

		// Token: 0x0400953B RID: 38203
		[Token(Token = "0x400953B")]
		[FieldOffset(Offset = "0xC0")]
		private GameObject m_FXLevelUpGold;
	}
}
