using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001991 RID: 6545
	[Token(Token = "0x2001991")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F698C", Offset = "0x10F698C")]
	internal class UIHudVehicleWeaponSwitchInfoController : UIBaseController
	{
		// Token: 0x06008596 RID: 34198 RVA: 0x00024378 File Offset: 0x00022578
		[Token(Token = "0x6008596")]
		[Address(RVA = "0x15F3324", Offset = "0x15F3324", VA = "0x7BBBDF3324")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008597 RID: 34199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008597")]
		[Address(RVA = "0x15F3374", Offset = "0x15F3374", VA = "0x7BBBDF3374", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008598 RID: 34200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008598")]
		[Address(RVA = "0x15F3458", Offset = "0x15F3458", VA = "0x7BBBDF3458", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008599 RID: 34201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008599")]
		[Address(RVA = "0x15F362C", Offset = "0x15F362C", VA = "0x7BBBDF362C")]
		private void OnBtnClick()
		{
		}

		// Token: 0x0600859A RID: 34202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600859A")]
		[Address(RVA = "0x15F375C", Offset = "0x15F375C", VA = "0x7BBBDF375C")]
		private void Update()
		{
		}

		// Token: 0x0600859B RID: 34203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600859B")]
		[Address(RVA = "0x15F3490", Offset = "0x15F3490", VA = "0x7BBBDF3490")]
		private void ClearWeaponDisplay()
		{
		}

		// Token: 0x0600859C RID: 34204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600859C")]
		[Address(RVA = "0x15F3AE0", Offset = "0x15F3AE0", VA = "0x7BBBDF3AE0")]
		private void SetIcon(string s)
		{
		}

		// Token: 0x0600859D RID: 34205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600859D")]
		[Address(RVA = "0x15F3BCC", Offset = "0x15F3BCC", VA = "0x7BBBDF3BCC")]
		private void SetIcon(ResourceID id)
		{
		}

		// Token: 0x0600859E RID: 34206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600859E")]
		[Address(RVA = "0x15F3C94", Offset = "0x15F3C94", VA = "0x7BBBDF3C94")]
		private void SetWeaponIcon(ytMNhlw currentWeapon)
		{
		}

		// Token: 0x0600859F RID: 34207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600859F")]
		[Address(RVA = "0x15F3CE8", Offset = "0x15F3CE8", VA = "0x7BBBDF3CE8")]
		private void SetWeaponIcon(hZRsEYY vWeapon)
		{
		}

		// Token: 0x060085A0 RID: 34208 RVA: 0x00024390 File Offset: 0x00022590
		[Token(Token = "0x60085A0")]
		[Address(RVA = "0x15F3D2C", Offset = "0x15F3D2C", VA = "0x7BBBDF3D2C")]
		private bool HasIcon(hZRsEYY vWeapon)
		{
			return default(bool);
		}

		// Token: 0x060085A1 RID: 34209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085A1")]
		[Address(RVA = "0x15F38A8", Offset = "0x15F38A8", VA = "0x7BBBDF38A8")]
		private void UpdateWeaponIcon(hZRsEYY vehWeapon)
		{
		}

		// Token: 0x060085A2 RID: 34210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085A2")]
		[Address(RVA = "0x15F39D0", Offset = "0x15F39D0", VA = "0x7BBBDF39D0")]
		private void UpdateAmmoDisplay(hZRsEYY vehWeapon)
		{
		}

		// Token: 0x060085A3 RID: 34211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085A3")]
		[Address(RVA = "0x15F3E20", Offset = "0x15F3E20", VA = "0x7BBBDF3E20")]
		private void UpdateAmmoDisplay(bool infinityAmmo)
		{
		}

		// Token: 0x060085A4 RID: 34212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085A4")]
		[Address(RVA = "0x15F36BC", Offset = "0x15F36BC", VA = "0x7BBBDF36BC")]
		private void UpdateAutoIcon(hZRsEYY vehWeapon)
		{
		}

		// Token: 0x060085A5 RID: 34213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085A5")]
		[Address(RVA = "0x15F35F0", Offset = "0x15F35F0", VA = "0x7BBBDF35F0")]
		private void ShowAutoIcon(bool b)
		{
		}

		// Token: 0x060085A6 RID: 34214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085A6")]
		[Address(RVA = "0x15F41D8", Offset = "0x15F41D8", VA = "0x7BBBDF41D8")]
		public UIHudVehicleWeaponSwitchInfoController()
		{
		}

		// Token: 0x060085A7 RID: 34215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085A7")]
		[Address(RVA = "0x15F4230", Offset = "0x15F4230", VA = "0x7BBBDF4230")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143468", Offset = "0x1143468")]
		private void <OnUIInit>b__11_0()
		{
		}

		// Token: 0x04009517 RID: 38167
		[Token(Token = "0x4009517")]
		[FieldOffset(Offset = "0x58")]
		public UIHudVehicleWeaponSwitchInfoView m_View;

		// Token: 0x04009518 RID: 38168
		[Token(Token = "0x4009518")]
		[FieldOffset(Offset = "0x60")]
		private string EmptyWeaponSpriteIcon;

		// Token: 0x04009519 RID: 38169
		[Token(Token = "0x4009519")]
		[FieldOffset(Offset = "0x68")]
		private string EmptyAmmoSpriteIcon;

		// Token: 0x0400951A RID: 38170
		[Token(Token = "0x400951A")]
		[FieldOffset(Offset = "0x70")]
		private bool m_EmptyAmmo;

		// Token: 0x0400951B RID: 38171
		[Token(Token = "0x400951B")]
		[FieldOffset(Offset = "0x71")]
		private bool m_DisplayCleared;

		// Token: 0x0400951C RID: 38172
		[Token(Token = "0x400951C")]
		[FieldOffset(Offset = "0x78")]
		private ytMNhlw m_LastWeapon;

		// Token: 0x0400951D RID: 38173
		[Token(Token = "0x400951D")]
		[FieldOffset(Offset = "0x80")]
		private hZRsEYY m_LastVehicleWeapon;

		// Token: 0x0400951E RID: 38174
		[Token(Token = "0x400951E")]
		[FieldOffset(Offset = "0x88")]
		private int m_LastAmmoCapacity;

		// Token: 0x0400951F RID: 38175
		[Token(Token = "0x400951F")]
		[FieldOffset(Offset = "0x8C")]
		private int m_LastAmmoLeft;

		// Token: 0x04009520 RID: 38176
		[Token(Token = "0x4009520")]
		[FieldOffset(Offset = "0x90")]
		private int m_LastAmmoLeftInClip;
	}
}
